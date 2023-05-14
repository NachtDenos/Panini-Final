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
    public partial class productsScreen : Form
    {
        Hoteles hotel = new Hoteles();
        EnlaceCassandra cass = new EnlaceCassandra();
        bool selection = false;
        public productsScreen()
        {
            InitializeComponent();
            dataGridHotels.DataSource = cass.Obtener_hoteles();
            btnEditHotels.Enabled = false;
            btnDeleteHotels.Enabled = false;
            dataGridHotels.ClearSelection();
        }
        
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            //if (txtNameHotelHotels.TextLength == 0 || txtCountryHotels.TextLength == 0 || txtCityHotels.TextLength == 0 ||
            //    txtStateHotels.TextLength == 0 || txtFloorsHotels.TextLength == 0 || txtRoomsHotels.TextLength == 0 ||
            //    txtBeachHotels.TextLength == 0 || txtPoolsHotels.TextLength == 0 || txtEventsHotels.TextLength == 0)
            //{
            //    MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //if (selection == false)
            //{
            //    MessageBox.Show("Seleccione una zona turistica", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (dateValidFuture(dtpOperatHotels.Value.Date) == false)
            //{
            //    MessageBox.Show("Fecha no valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            hotel.hotel = txtNameHotelHotels.Text;
            hotel.pais = txtCountryHotels.Text;
            hotel.ciudad = txtCityHotels.Text;
            hotel.estado = txtStateHotels.Text;
            //int numeroPisosReal = int.Parse(txtFloorsHotels.Text);
            hotel.numeroPisos = txtFloorsHotels.Text;
            //int numeroHabitacionesReal = int.Parse(txtRoomsHotels.Text);
            hotel.cantidadHabitaciones = txtRoomsHotels.Text;
            hotel.zonaTuristica = cbZoneHotels.Text;
           // int numeroPiscinasReal = int.Parse(txtPoolsHotels.Text);
            hotel.cantidadPiscinas = txtPoolsHotels.Text;
            //int numeroSalonesReal = int.Parse(txtEventsHotels.Text);
            hotel.salonesEventos = txtEventsHotels.Text;
            hotel.frentePlaya = cbBeachHotels.Text; 
            string fechaReal = dtpOperatHotels.Text;
            String.Format("{0:yyyy-MM-dd}", fechaReal);
            hotel.inicioOperaciones = fechaReal;
            hotel.FechaRegistro = DateTime.Now.ToString("yyyy-MM-dd");
            hotel.horaderegistro = DateTime.Now.ToString("HH:mm:ss");
            string soyservicios="";
            for(int x = 0; x<clbServicesHotels.CheckedItems.Count; x++)
            {
                if (x + 1 == clbServicesHotels.CheckedItems.Count)
                    soyservicios += clbServicesHotels.CheckedItems[x].ToString();
                else
                    soyservicios += clbServicesHotels.CheckedItems[x].ToString() + " ";
            }
            hotel.serviciosAdicionales = soyservicios;
            var success = cass.InsertarHoteles(hotel);
            if (success)
            {
                dataGridHotels.DataSource = cass.Obtener_hoteles();
                MessageBox.Show("Se agrego el hotel.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            clearTxt();
            dataGridHotels.ClearSelection();
        }

        private void onlyLetters(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan letras en este campo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }
        private void onlyNumbers(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbZoneHotels_SelectedIndexChanged(object sender, EventArgs e)
        {
            selection = true;
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

        private void btnEditHotels_Click(object sender, EventArgs e) //NO LO PROBÉ
        {
            //if (txtNameHotelHotels.TextLength == 0 || txtCountryHotels.TextLength == 0 || txtCityHotels.TextLength == 0 ||
            //    txtStateHotels.TextLength == 0 || txtFloorsHotels.TextLength == 0 || txtRoomsHotels.TextLength == 0 ||
            //    txtBeachHotels.TextLength == 0 || txtPoolsHotels.TextLength == 0 || txtEventsHotels.TextLength == 0)
            //{
            //    MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //if (selection == false)
            //{
            //    MessageBox.Show("Seleccione una zona turistica", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (cbZoneHotels.Text == "Seleccionar")
            //{
            //    MessageBox.Show("Seleccione una zona turistica", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (dateValidFuture(dtpOperatHotels.Value.Date) == false)
            //{
            //    MessageBox.Show("Fecha no valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            hotel.hotel = txtNameHotelHotels.Text;
            hotel.pais = txtCountryHotels.Text;
            hotel.ciudad = txtCityHotels.Text;
            hotel.estado = txtStateHotels.Text;
            //int numeroPisosReal = int.Parse(txtFloorsHotels.Text);
            hotel.numeroPisos = txtFloorsHotels.Text;
            //int numeroHabitacionesReal = int.Parse(txtRoomsHotels.Text);
            hotel.cantidadHabitaciones = txtRoomsHotels.Text;
            hotel.zonaTuristica = cbZoneHotels.Text;
            // int numeroPiscinasReal = int.Parse(txtPoolsHotels.Text);
            hotel.cantidadPiscinas = txtPoolsHotels.Text;
            //int numeroSalonesReal = int.Parse(txtEventsHotels.Text);
            hotel.salonesEventos = txtEventsHotels.Text;
            hotel.frentePlaya = cbBeachHotels.Text;
            string fechaReal = dtpOperatHotels.Text;
            String.Format("{0:yyyy-MM-dd}", fechaReal);
            hotel.inicioOperaciones = fechaReal;
            string soyservicios = "";
            for (int x = 0; x < clbServicesHotels.CheckedItems.Count; x++)
            {
                if (x + 1 == clbServicesHotels.CheckedItems.Count)
                    soyservicios += clbServicesHotels.CheckedItems[x].ToString();
                else
                    soyservicios += clbServicesHotels.CheckedItems[x].ToString() + " ";
            }
            hotel.serviciosAdicionales = soyservicios;
            var success = cass.UpdateHotel(hotel);
            if (success)
            {
                dataGridHotels.DataSource = cass.Obtener_hoteles();
                MessageBox.Show("Se modificó el hotel.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            clearTxt();
            btnAddHotels.Enabled = true;
            btnEditHotels.Enabled = false;
            btnDeleteHotels.Enabled = false;
            dataGridHotels.ClearSelection();
            dataGridHotels.DataSource = cass.Obtener_hoteles();
        }

        private void btnDeleteHotels_Click(object sender, EventArgs e)
        {
            var success = cass.DeleteHotel(dataGridHotels.CurrentRow.Cells[0].Value.ToString());
            if (success)
                MessageBox.Show("Se elimno al hotel.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearTxt();
            btnAddHotels.Enabled = true;
            btnEditHotels.Enabled = false;
            btnDeleteHotels.Enabled = false;
            dataGridHotels.ClearSelection();
            dataGridHotels.DataSource = cass.Obtener_hoteles();
        }

        private void txtNameHotelHotels_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyLetters(e);
        }

        private void txtCountryHotels_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyLetters(e);
        }

        private void txtCityHotels_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyLetters(e);
        }

        private void txtStateHotels_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyLetters(e);
        }

        private void txtFloorsHotels_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(e);
        }

        private void txtRoomsHotels_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(e);
        }

        private void txtBeachHotels_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyLetters(e);
        }

        private void txtPoolsHotels_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(e);
        }

        private void txtEventsHotels_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(e);
        }

        private void clearTxt()
        {
            txtNameHotelHotels.Text = "";
            txtCountryHotels.Text = "";
            txtCityHotels.Text = "";
            txtStateHotels.Text = "";
            txtFloorsHotels.Text = "";
            txtRoomsHotels.Text = "";
            txtPoolsHotels.Text = "";
            txtEventsHotels.Text = "";
            cbZoneHotels.Text = "Seleccionar";
            cbBeachHotels.Text = "Seleccionar";
        }

        private void dataGridHotels_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridHotels.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridHotels.CurrentRow.Selected = true;

                    txtNameHotelHotels.Text = dataGridHotels.Rows[e.RowIndex].Cells["hotel"].Value.ToString();
                    txtCountryHotels.Text = dataGridHotels.Rows[e.RowIndex].Cells["pais"].Value.ToString();
                    txtCityHotels.Text = dataGridHotels.Rows[e.RowIndex].Cells["ciudad"].Value.ToString();
                    txtStateHotels.Text = dataGridHotels.Rows[e.RowIndex].Cells["estado"].Value.ToString();
                    txtFloorsHotels.Text = dataGridHotels.Rows[e.RowIndex].Cells["numeroPisos"].Value.ToString();
                    txtRoomsHotels.Text = dataGridHotels.Rows[e.RowIndex].Cells["cantidadHabitaciones"].Value.ToString();
                    cbZoneHotels.Text = dataGridHotels.Rows[e.RowIndex].Cells["zonaTuristica"].Value.ToString();
                    //txtCellPhoneCustomers.Text = dataGridHotels.Rows[e.RowIndex].Cells["serviciosAdicionales"].Value.ToString();
                    cbBeachHotels.Text = dataGridHotels.Rows[e.RowIndex].Cells["frentePlaya"].Value.ToString();
                    txtPoolsHotels.Text = dataGridHotels.Rows[e.RowIndex].Cells["cantidadPiscinas"].Value.ToString();
                    txtEventsHotels.Text = dataGridHotels.Rows[e.RowIndex].Cells["salonesEventos"].Value.ToString();
                    dtpOperatHotels.Text = dataGridHotels.Rows[e.RowIndex].Cells["inicioOperaciones"].Value.ToString();
                    btnDeleteHotels.Enabled = true;
                    btnEditHotels.Enabled = true;
                    btnAddHotels.Enabled = false;
                }
            }
            catch (Exception ArgumentOutOfRangeException)
            {
                MessageBox.Show("Seleccione una celda valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
