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

namespace Punto_de_Venta.Pantallas
{
    public partial class checkOutScreen : Form
    {
        bool bandera;
        bool check1 = false;
        bool check2 = false;
        EnlaceCassandra cass = new EnlaceCassandra();
        ReservacionesDetalle reservationDetalle = new ReservacionesDetalle();
        Servicios serv = new Servicios();
        string personas;
        string precios;
        string serviciosS;
        float totalHospedaje = 0;
        float totalServicios = 0;
        float anticipo = 0;
        float total = 0;
        float aux = 0;
        public checkOutScreen()
        {
            InitializeComponent();
            txtCreditCardCheckOut.Enabled = false;
            txtDebitCardCheckOut.Enabled = false;
            btnConfirmCheckOut.Enabled = false;
            dataGridServicesCheckOut.DataSource = cass.Obtener_servicios();
            btnSelectServicesCheckOut.Enabled = false;
        }

        private void btnEditDepartament_Click(object sender, EventArgs e)
        {
            //POR MIENTRAS
            //TODO: Esta cosa
            //WaytoPayScreen TheOtherForm = new WaytoPayScreen();
            //TheOtherForm.ShowDialog();
            MessageBox.Show("En proceso...", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSearchCheckOut_Click(object sender, EventArgs e)
        {
            if (txtCodeCheckOut.TextLength == 0)
            {
                MessageBox.Show("Falta de escribir el codigo de reservación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dataGridRoomsCheckOut.DataSource = cass.Obtener_reservacionesDetalle(txtCodeCheckOut.Text);

            foreach (DataGridViewRow row in dataGridRoomsCheckOut.Rows)
            {
                if (!row.IsNewRow)
                {
                    personas = row.Cells[2].Value.ToString();
                    precios = row.Cells[3].Value.ToString();
                    float personaf = float.Parse(personas);
                    float preciof = float.Parse(precios);
                    aux = personaf * preciof;
                    totalHospedaje = totalHospedaje + aux;
                }
            }
            List<Reservaciones> anticipoRe = cass.Obtener_reservaciones(txtCodeCheckOut.Text);
            foreach (Reservaciones habitacionObt in anticipoRe)
            {
                string anticipoString = habitacionObt.anticipo.ToString();
                anticipo = float.Parse(anticipoString);
            }

            total = totalHospedaje - anticipo;

            labelTotal.Text = total.ToString();
            labelAnticipo.Text = anticipo.ToString();
            labelHospedaje.Text = totalHospedaje.ToString();

        }

        private void onlyNumbers(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCodeCheckOut_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(e);
        }

        private void onePoint(KeyPressEventArgs e, String cadena)
        {
            int cont = 0;
            String caracter = "";
            for (int i = 0; i < cadena.Length; i++)
            {
                caracter = cadena.Substring(i, 1);
                if (caracter == ".")
                {
                    cont++;
                }
            }
            if (cont == 0)
            {
                bandera = true;
                if (e.KeyChar.ToString().Equals(".") && bandera)
                {
                    bandera = false;
                    e.Handled = false;
                }
                else if (Char.IsDigit(e.KeyChar))
                    e.Handled = false;
                else if (Char.IsControl(e.KeyChar))
                    e.Handled = false;
                else
                    e.Handled = true;
            }
            else
            {
                bandera = false;
                e.Handled = true;
                if (Char.IsDigit(e.KeyChar))
                    e.Handled = false;
                else if (Char.IsControl(e.KeyChar))
                    e.Handled = false;
                else
                    e.Handled = true;
            }
        }

        private void txtCreditCardCheckOut_KeyPress(object sender, KeyPressEventArgs e)
        {
            onePoint(e, txtCreditCardCheckOut.Text);
        }

        private void txtDebitCardCheckOut_KeyPress(object sender, KeyPressEventArgs e)
        {
            onePoint(e, txtDebitCardCheckOut.Text);
        }

        private void rbCreditCardCheckOut_Click(object sender, EventArgs e)
        {
            if (txtCreditCardCheckOut.Enabled == false)
            {
                txtCreditCardCheckOut.Enabled = true;
                check1 = true;
            }
            else if (txtCreditCardCheckOut.Enabled == true)
            {
                txtCreditCardCheckOut.Enabled = false;
                txtCreditCardCheckOut.Text = "";
                check1 = false;
            }
            checkButton();
        }

        private void rbDebitCardCheckOut_Click(object sender, EventArgs e)
        {
            if (txtDebitCardCheckOut.Enabled == false)
            {
                txtDebitCardCheckOut.Enabled = true;
                check2 = true;
            }
            else if (txtDebitCardCheckOut.Enabled == true)
            {
                txtDebitCardCheckOut.Enabled = false;
                txtDebitCardCheckOut.Text = "";
                check2 = false;
            }
            checkButton();
        }

        private void checkButton()
        {
            if(check1 == true || check2 == true)
                btnConfirmCheckOut.Enabled = true;
            else
                btnConfirmCheckOut.Enabled = false; 
        }

        private void btnConfirmCheckOut_Click(object sender, EventArgs e)
        {

        }

        private void dataGridServicesCheckOut_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridServicesCheckOut.AllowUserToAddRows = false;
                if (dataGridServicesCheckOut.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridServicesCheckOut.CurrentRow.Selected = true;
                    
                    btnSelectServicesCheckOut.Enabled = true;
                }
            }
            catch (Exception ArgumentOutOfRangeException)
            {
                MessageBox.Show("Seleccione una celda valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelectServicesCheckOut_Click(object sender, EventArgs e)
        {
            serv.Servicio = dataGridServicesCheckOut.CurrentRow.Cells[0].Value.ToString();
            serv.PrecioDeServicio = dataGridServicesCheckOut.CurrentRow.Cells[1].Value.ToString();

            var success = cass.InsertarServiciosTemporales(serv);
            if (success)
            {
                MessageBox.Show("Se agrego el servicio adicional.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dataGridServices2CheckOut.DataSource = cass.Obtener_serviciosTemp();

            dataGridServicesCheckOut.ClearSelection();
            btnSelectServicesCheckOut.Enabled = false;
        }

        private void btnConfirmServicesCheckOut_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridServices2CheckOut.Rows)
            {
                if (!row.IsNewRow)
                {
                    serviciosS = row.Cells[1].Value.ToString();
                    aux = float.Parse(serviciosS);
                    totalServicios = totalServicios + aux;
                    total = total + aux;
                }
            }
            labelServices.Text = totalServicios.ToString();
            labelTotal.Text = total.ToString();
        }
    }
}
