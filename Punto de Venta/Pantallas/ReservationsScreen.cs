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

    public partial class SalesScreen : Form
    {
        bool check1 = false;
        bool check2 = false;
        bool check3 = false;
        bool selection = false;
        bool bandera;
        bool debito;
        bool credito;
        bool transferencia;
        EnlaceCassandra cass = new EnlaceCassandra();
        HabitacionesTemporales cuartoTemp = new HabitacionesTemporales();
        Reservaciones reservation = new Reservaciones();
        Random random = new Random();
        string anticipoGlobal = "";
        string metodoGlobal = "";

        public SalesScreen()
        {
            InitializeComponent();
            btnConfirmReser.Enabled = false;
            txtTransferPayRe.Enabled = false;
            txtDebitCardPayRe.Enabled = false;
            txtCreditCardPayRe.Enabled = false;
            var ciudad = cass.obtener_ciudad_cb();
            cbCityReservations.DataSource = ciudad;
            cbCityReservations.DisplayMember = "ciudad";
        }


        private void btnAddEmployees_Click(object sender, EventArgs e)
        {
            //if (txtCustomerReservation.TextLength == 0)
            //{
            //    MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //if (selection == false)
            //{
            //    MessageBox.Show("Seleccione una ciudad a visitar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            int codeInt = random.Next(1 , 10001);
            string codigoReserva = codeInt.ToString();
            //EN PROCESO, ES PARA DAR DE ALTA LA RESERVACION
            reservation.codigo = codigoReserva;
            reservation.nombreCliente = dataGridCustomerRe.CurrentRow.Cells[0].Value.ToString();
            reservation.apellidoPCliente = dataGridCustomerRe.CurrentRow.Cells[1].Value.ToString();
            reservation.apellidoMCliente = dataGridCustomerRe.CurrentRow.Cells[2].Value.ToString();
            reservation.ciudad = cbCityReservations.Text;
            reservation.hotel = dataGridHotelRe.CurrentRow.Cells[0].Value.ToString();
            reservation.checkIn = false;
            reservation.checkOut = false;
            string fechaReal1 = dtpLodgingReser.Text;
            String.Format("{0:yyyy-MM-dd}", fechaReal1);
            string fechaReal2 = dtpLodgingReser2.Text;
            String.Format("{0:yyyy-MM-dd}", fechaReal2);
            reservation.fechaInicial = fechaReal1;
            reservation.fechaFinal = fechaReal2;
            reservation.metodoDePago = metodoGlobal;
            if (credito == true)
            {
                anticipoGlobal = txtCreditCardPayRe.Text;
            }
            if (debito == true)
            {
                anticipoGlobal = txtDebitCardPayRe.Text;
            }
            if (transferencia == true)
            {
                anticipoGlobal = txtTransferPayRe.Text;
            }
            reservation.anticipo = anticipoGlobal;
            reservation.fechaDeRegistro = DateTime.Now.ToString("yyyy-MM-dd");
            reservation.horaDeRegistro = DateTime.Now.ToString("HH:mm:ss"); ;
            reservation.usuarioRegistro = "Kevin";
            var success = cass.InsertarReservaciones(reservation);

            foreach (DataGridViewRow row in dataGridRoomsChosenRe.Rows)
            {
                if (!row.IsNewRow)
                {
                    reservation.habitacion = row.Cells[1].Value.ToString();
                    reservation.cantidadPersonas = row.Cells[5].Value.ToString();
                    reservation.precio = row.Cells[4].Value.ToString();
                    var success2 = cass.InsertarReservacionesDetalle(reservation);
                }
            }

            QuickSearchScreen TheOtherForm = new QuickSearchScreen(codigoReserva);
            TheOtherForm.ShowDialog();
            bool limpieza = cass.limpiarHabitacionTemporal();
            dataGridRoomsChosenRe.DataSource = cass.Obtener_habitacionesTemporales();
            dataGridCustomerRe.ClearSelection();
            dataGridHotelRe.ClearSelection();
            dataGridRoomsRe.ClearSelection();
        }

        private void btnAddReser_Click(object sender, EventArgs e)
        {
            DateTime fecha1 = dtpLodgingReser.Value;
            DateTime fecha2 = dtpLodgingReser2.Value;
            string cantPerson = dataGridRoomsRe.CurrentRow.Cells[5].Value.ToString();
            string cantPersonSoli = txtPeopleReservations.Text;
            int cantPersonInt = int.Parse(cantPerson);
            int cantPersonSoliInt = int.Parse(cantPersonSoli);

            if (txtPeopleReservations.TextLength == 0)
            {
                MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(cantPersonSoliInt > cantPersonInt)
            {
                MessageBox.Show("El número de personas solicitadas sobrepasa la capacidad de la habitación.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            cuartoTemp.hotel = dataGridRoomsRe.CurrentRow.Cells[0].Value.ToString();
            cuartoTemp.tipoHabitacion = dataGridRoomsRe.CurrentRow.Cells[1].Value.ToString();
            cuartoTemp.numeroCamas = dataGridRoomsRe.CurrentRow.Cells[2].Value.ToString();
            cuartoTemp.tiposCama = dataGridRoomsRe.CurrentRow.Cells[3].Value.ToString();
            cuartoTemp.precioPorNoche = dataGridRoomsRe.CurrentRow.Cells[4].Value.ToString();
            cuartoTemp.cantidadPersonas = dataGridRoomsRe.CurrentRow.Cells[5].Value.ToString();
            cuartoTemp.nivelHabitacion = dataGridRoomsRe.CurrentRow.Cells[6].Value.ToString();
            cuartoTemp.frenteA = dataGridRoomsRe.CurrentRow.Cells[7].Value.ToString();
            cuartoTemp.caracteristicas = dataGridRoomsRe.CurrentRow.Cells[8].Value.ToString();
            cuartoTemp.amenidades = dataGridRoomsRe.CurrentRow.Cells[9].Value.ToString();
            cuartoTemp.estatus = true;
            string fechaInicioReal = dtpLodgingReser.Text;
            string fechaFinalReal = dtpLodgingReser2.Text;
            String.Format("{0:yyyy-MM-dd}", fechaInicioReal);
            String.Format("{0:yyyy-MM-dd}", fechaFinalReal);
            cuartoTemp.fechaEntrada = fechaInicioReal;
            cuartoTemp.fechaSalida = fechaFinalReal;
            cuartoTemp.cantidadPersonasSolicitada = txtPeopleReservations.Text;
            //cuartoTemp.FechaRegistro = dataGridRoomsRe.CurrentRow.Cells[11].Value.ToString();
            //cuartoTemp.horaderegistro = dataGridRoomsRe.CurrentRow.Cells[12].Value.ToString();

            var success = cass.InsertarHabitacionesTemporales(cuartoTemp);
            if (success)
            {
                MessageBox.Show("Se agrego la habitación.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataGridRoomsChosenRe.DataSource = cass.Obtener_habitacionesTemporales();
        }

        private void txtPeopleReservations_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(e);
        }

        private void onlyNumbers(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void rbCreditCardPayRe_Click(object sender, EventArgs e)
        {
            if (txtCreditCardPayRe.Enabled == false)
            {
                txtCreditCardPayRe.Enabled = true;
                check1 = true;
                rbDebitCardPayRe.Enabled = false;
                rbTransferPayRe.Enabled = false;
                metodoGlobal = "Trajeta de Credito";
                credito = true;
            }
            else if (txtCreditCardPayRe.Enabled == true)
            {
                txtCreditCardPayRe.Enabled = false;
                txtCreditCardPayRe.Text = "";
                check1 = false;
                rbDebitCardPayRe.Enabled = true;
                rbTransferPayRe.Enabled = true;
                credito = false;
            }
            checkButton();
        }

        private void rbDebitCardPayRe_Click(object sender, EventArgs e)
        {
            if (txtDebitCardPayRe.Enabled == false)
            {
                txtDebitCardPayRe.Enabled = true;
                check2 = true;
                rbCreditCardPayRe.Enabled = false;
                rbTransferPayRe.Enabled = false;
                metodoGlobal = "Tarjeta de Debito";
                debito = true;
            }
            else if (txtDebitCardPayRe.Enabled == true)
            {
                txtDebitCardPayRe.Enabled = false;
                txtDebitCardPayRe.Text = "";
                check2 = false;
                rbCreditCardPayRe.Enabled = true;
                rbTransferPayRe.Enabled = true;
                debito = false;
            }
            checkButton();
        }

        private void rbTransferPayRe_Click(object sender, EventArgs e)
        {
            if (txtTransferPayRe.Enabled == false)
            {
                txtTransferPayRe.Enabled = true;
                check3 = true;
                rbDebitCardPayRe.Enabled = false;
                rbCreditCardPayRe.Enabled = false;
                metodoGlobal = "Transferencia";
                transferencia = true;
            }
            else if (txtTransferPayRe.Enabled == true)
            {
                txtTransferPayRe.Enabled = false;
                txtTransferPayRe.Text = "";
                check3 = false;
                rbDebitCardPayRe.Enabled = true;
                rbCreditCardPayRe.Enabled = true;
                transferencia = false;
            }
            checkButton();
        }

        private void checkButton()
        {
            if (check1 == true || check2 == true || check3)
                btnConfirmReser.Enabled = true;
            else
                btnConfirmReser.Enabled = false;
        }

        private void cbCityReservations_SelectedIndexChanged(object sender, EventArgs e)
        {
            selection = true;
        }

        private void txtCreditCardPayRe_KeyPress(object sender, KeyPressEventArgs e)
        {
            onePoint(e, txtCreditCardPayRe.Text); 
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

        private void txtDebitCardPayRe_KeyPress(object sender, KeyPressEventArgs e)
        {
            onePoint(e, txtDebitCardPayRe.Text);
        }

        private void txtTransferPayRe_KeyPress(object sender, KeyPressEventArgs e)
        {
            onePoint(e, txtTransferPayRe.Text);
        }

        private void btnSelectReservation_Click(object sender, EventArgs e)
        {
            dataGridRoomsRe.DataSource = cass.obtHabitacionesHotel(dataGridHotelRe.CurrentRow.Cells[0].Value.ToString());
        }

        private void btnSearchNameReservation_Click(object sender, EventArgs e)
        {
            dataGridCustomerRe.DataSource = cass.obtClientesNombre(txtCustomerReservation.Text);
        }

        private void btnSearchRFCReservation_Click(object sender, EventArgs e)
        {
            dataGridCustomerRe.DataSource = cass.obtClientesRFC(txtCustomerReservation.Text);
        }

        private void btnSearchEmailReservation_Click(object sender, EventArgs e)
        {
            dataGridCustomerRe.DataSource = cass.obtClientesEmail(txtCustomerReservation.Text);
        }

        private void btnSelectCityReservation_Click(object sender, EventArgs e)
        {
            DateTime fecha1 = dtpLodgingReser.Value;
            DateTime fecha2 = dtpLodgingReser2.Value;
            if (fecha1 == fecha2)
            {
                MessageBox.Show("Las fechas no pueden ser iguales", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (fecha1 > fecha2)
            {
                MessageBox.Show("La primer fecha no puede ser mayor que la segunda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dataGridHotelRe.DataSource = cass.obtHotelesCiudad(cbCityReservations.Text);
        }

        private void dataGridCustomerRe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridCustomerRe.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridCustomerRe.CurrentRow.Selected = true;
                }
            }
            catch (Exception ArgumentOutOfRangeException)
            {
                MessageBox.Show("Seleccione una celda valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridHotelRe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridHotelRe.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridHotelRe.CurrentRow.Selected = true;
                }
            }
            catch (Exception ArgumentOutOfRangeException)
            {
                MessageBox.Show("Seleccione una celda valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridRoomsRe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridRoomsRe.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridRoomsRe.CurrentRow.Selected = true;
                }
            }
            catch (Exception ArgumentOutOfRangeException)
            {
                MessageBox.Show("Seleccione una celda valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
