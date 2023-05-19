using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Punto_de_Venta.Clases;

namespace Punto_de_Venta
{
    public partial class DiscountsScreen : Form
    {
        EnlaceCassandra cass = new EnlaceCassandra();
        string codigoReString;
        Cancelaciones cancel = new Cancelaciones();
        
        public DiscountsScreen()
        {
            InitializeComponent();
            btnConfirmCancel.Enabled = false;

        }

        private void addDiscountBtton_Click(object sender, EventArgs e)
        {
            if (txtCodeReservCancel.TextLength == 0)
            {
                MessageBox.Show("Falta de escribir el codigo de reservación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cass.incrementarContadorCancelacion();

            string fechaReal = dtpDateCancel.Text;
            String.Format("{0:yyyy-MM-dd}", fechaReal);
            cancel.idCancelaciones = cass.obtenerContadorCancelacion();
            cancel.codigoRe = codigoReString;
            cancel.fechaCancelacion = fechaReal;
            cancel.horaCancelacion = DateTime.Now.ToString("HH:mm:ss"); ;
            cancel.usuarioCancelacion = "Kevin";
            var success = cass.InsertarCancelacion(cancel);
            var success2 = cass.Delete_Reservacion(codigoReString);
            List<Reservaciones> habitacionesRe = cass.Obtener_reservacionesDetalle(codigoReString);

            foreach (Reservaciones habitacionObt in habitacionesRe)
            {
                var success3 = cass.Delete_ReservacionDetalle(codigoReString, habitacionObt.habitacion);
            }

            if (success && success2)
                MessageBox.Show("Se cancelo la reservacion.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);


            dataGridCancel.DataSource = cass.Obtener_reservaciones("0");
            txtCodeReservCancel.Text = "";
            btnConfirmCancel.Enabled = false;
            //if (dateValidFuture(dtpDateCancel.Value.Date) == false)
            //{
            //    MessageBox.Show("Fecha no valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
        }

        private void onlyNumbers(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCodeReservCancel_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(e); 
        }

        private bool dateValidFuture(DateTime fecha)
        {
            DateTime hoy = DateTime.Today;
            if (fecha > hoy)
            {
                return false;
            }
            return true;
        }

        private void dataGridCancel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridCancel.AllowUserToAddRows = false;
                if (dataGridCancel.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridCancel.CurrentRow.Selected = true;
                    codigoReString = dataGridCancel.Rows[e.RowIndex].Cells["codigo"].Value.ToString();
                    btnConfirmCancel.Enabled = true;
                }
            }
            catch (Exception ArgumentOutOfRangeException)
            {
                MessageBox.Show("Seleccione una celda valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelectCodeCancel_Click(object sender, EventArgs e)
        {
            dataGridCancel.DataSource = cass.Obtener_reservaciones(txtCodeReservCancel.Text);
        }
    }
}
