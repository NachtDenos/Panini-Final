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
    public partial class InventaryScreen : Form
    {

        EnlaceCassandra cass = new EnlaceCassandra();
        Reservaciones reservation = new Reservaciones();
        Ocupacion ocupado = new Ocupacion();
        Ocupacion2 ocupado2 = new Ocupacion2();
        string codigoReString;
        string cantidadPersonasT;
        string ciudadT;
        string hotelT;
        string paisT;
        int contador = 0;

        public InventaryScreen()
        {
            InitializeComponent();
            btnConfirmCheckIn.Enabled = false;
        }

        private void btnConfirmCheckIn_Click(object sender, EventArgs e)
        {
            if (txtCodeCheckIn.TextLength == 0)
            {
                MessageBox.Show("Falta de escribir el codigo de reservación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            reservation.checkIn = true;
            reservation.codigo = codigoReString;
            reservation.fechaCheckIn = DateTime.Now.ToString("yyyy-MM-dd");
            var succes = cass.reservacionCheckIn(reservation);
            if(succes)
                MessageBox.Show("Se realizó el CheckIn.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            List<ReservacionesDetalle> reservacionesA = cass.Obtener_reservacionesDetalle(codigoReString);
            foreach (ReservacionesDetalle reservacionObt in reservacionesA)
            {
                cantidadPersonasT = reservacionObt.Personas;
                contador++;
            }

            List<Reservaciones> reservacionesB = cass.Obtener_reservaciones(codigoReString);
            foreach (Reservaciones reservacionAga in reservacionesB)
            {
                ciudadT = reservacionAga.ciudad;
                hotelT = reservacionAga.hotel;
            }
            List<Hoteles> hotelA = cass.Obtener_hotelesPais(hotelT);
            foreach (Hoteles hotelObt in hotelA)
            {
                paisT = hotelObt.pais;
            }

            int cantPersonasInt = int.Parse(cantidadPersonasT);
            cass.incrementarContadorCancelacion();

            ocupado.idReporte = cass.obtenerContadorCancelacion();
            ocupado.ciudad = ciudadT;
            ocupado.pais = paisT;
            ocupado.nombreHotel = hotelT;
            ocupado.fecha = DateTime.Now.ToString("yyyy-MM-dd");
            ocupado.cantidadHabitaciones = contador;
            ocupado.ocupacion = cantPersonasInt;
            ocupado.personasHospedadas = cantPersonasInt;

            ocupado2.idReporte = cass.obtenerContadorCancelacion();
            ocupado2.ciudad = ciudadT;
            ocupado2.pais = paisT;
            ocupado2.nombreHotel = hotelT;
            ocupado2.fecha = DateTime.Now.ToString("yyyy-MM-dd");
            ocupado2.ocupacion = cantPersonasInt;
            

            cass.InsertarOcupacion(ocupado);
            cass.InsertarOcupacion2(ocupado2);

            dataGridCheckIn.DataSource = cass.Obtener_reservaciones("0");
            btnConfirmCheckIn.Enabled = false;

        }

        private void onlyNumbers(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCodeCheckIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(e);
        }

        private void dataGridCheckIn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridCheckIn.AllowUserToAddRows = false;
                if (dataGridCheckIn.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridCheckIn.CurrentRow.Selected = true;
                    codigoReString = dataGridCheckIn.Rows[e.RowIndex].Cells["codigo"].Value.ToString();
                    btnConfirmCheckIn.Enabled = true; 
                }
            }
            catch (Exception ArgumentOutOfRangeException)
            {
                MessageBox.Show("Seleccione una celda valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelectCodeCheckIn_Click(object sender, EventArgs e)
        {
            dataGridCheckIn.DataSource = cass.Obtener_reservaciones(txtCodeCheckIn.Text);
        }
    }
}
