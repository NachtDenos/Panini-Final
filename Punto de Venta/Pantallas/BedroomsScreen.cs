using System;
using System.Windows.Forms;
using Punto_de_Venta.Clases;

namespace Punto_de_Venta
{
    public partial class departamentScreen : Form
    {
    
        int indexBox, indexBox2;
        bool selection = false;
        bool selection2 = false;
        bool selection3 = false;
        bool bandera;
        Habitaciones cuarto = new Habitaciones();
        EnlaceCassandra cass = new EnlaceCassandra();

        public departamentScreen()
        {
            InitializeComponent();
            var hotel = cass.obtener_hotel_cb();
            cbHotelBedrooms.DataSource = hotel;
            cbHotelBedrooms.DisplayMember = "hotel";
            dataGridBedrooms.DataSource = cass.Obtener_habitaciones();
            btnEditBedrooms.Enabled = false;
            btnDeleteBedrooms.Enabled = false;
        }

        private void btnAddDepartament_Click(object sender, EventArgs e)
        {
            //Espacios vacios
            //if (txtTypeRoomBedrooms.TextLength == 0 || txtNumberBedsBedrooms.TextLength == 0 || txtPriceNightBedrooms.TextLength == 0 ||
            //    txtNumPeopleBedroom.TextLength == 0 || txtCharacteBedrooms.TextLength == 0)
            //{
            //    MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //ComboBox
            //if (selection == false || selection2 == false || selection3 == false)
            //{
            //    if (selection == false)
            //        MessageBox.Show("Seleccione un Hotel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    else if (selection2 == false)
            //        MessageBox.Show("Seleccione un tipo de cama", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    else if (selection3 == false)
            //        MessageBox.Show("Seleccione un nivel de habitación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //if (cbHotelBedrooms.Text == "Seleccionar")
            //{
            //    MessageBox.Show("Seleccione un hotel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (cbLevelRoomBedroom.Text == "Seleccionar")
            //{
            //    MessageBox.Show("Seleccione un nivel de habitación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (cbTypeBedBedrooms.Text == "Seleccionar")
            //{
            //    MessageBox.Show("Seleccione un tipo de habitación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (clbFrontBedroom.CheckedItems.Count == 0)
            //{
            //    MessageBox.Show("Seleccione al menos una opción en 'Frente a...'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            cuarto.hotel = cbHotelBedrooms.Text;
            cuarto.tipoHabitacion = txtTypeRoomBedrooms.Text;
            cuarto.numeroCamas = txtNumberBedsBedrooms.Text;
            cuarto.tiposCama = cbTypeBedBedrooms.Text;
            cuarto.precioPorNoche = txtPriceNightBedrooms.Text;
            cuarto.cantidadPersonas = txtNumPeopleBedroom.Text;
            cuarto.nivelHabitacion = cbLevelRoomBedroom.Text;
            cuarto.FechaRegistro = DateTime.Now.ToString("yyyy-MM-dd");
            cuarto.horaderegistro = DateTime.Now.ToString("HH:mm:ss");
            string frenteA = "";
            for (int x = 0; x<clbFrontBedroom.CheckedItems.Count; x++)
            {
                if (x + 1 == clbFrontBedroom.CheckedItems.Count)
                    frenteA += clbFrontBedroom.CheckedItems[x].ToString();
                else
                    frenteA += clbFrontBedroom.CheckedItems[x].ToString() + "";
            }
            cuarto.frenteA = frenteA;
            cuarto.caracteristicas = txtCharacteBedrooms.Text;
            string amenidades = "";
            for (int x = 0; x<clbAmenitiesBedrooms.CheckedItems.Count; x++)
            {
                if (x + 1 == clbAmenitiesBedrooms.CheckedItems.Count)
                    amenidades += clbAmenitiesBedrooms.CheckedItems[x].ToString();
                else
                    amenidades += clbAmenitiesBedrooms.CheckedItems[x].ToString();
            }
            cuarto.amenidades = amenidades;
            var success = cass.InsertarHabitaciones(cuarto);
            if (success)
            {
                //dataGridBedrooms.DataSource = cass.Obtener_hoteles();
                MessageBox.Show("Se agrego la habitación.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            clearTxt();
            dataGridBedrooms.ClearSelection();
            dataGridBedrooms.DataSource = cass.Obtener_habitaciones();
        }

        private void btnEditBedrooms_Click(object sender, EventArgs e)
        {
            //Espacios vacios
            //if (txtTypeRoomBedrooms.TextLength == 0 || txtNumberBedsBedrooms.TextLength == 0 || txtPriceNightBedrooms.TextLength == 0 ||
            //    txtNumPeopleBedroom.TextLength == 0 || txtCharacteBedrooms.TextLength == 0)
            //{
            //    MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //ComboBox
            //if (selection == false || selection2 == false || selection3 == false)
            //{
            //    if (selection == false)
            //        MessageBox.Show("Seleccione un Hotel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    else if (selection2 == false)
            //        MessageBox.Show("Seleccione un tipo de cama", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    else if (selection3 == false)
            //        MessageBox.Show("Seleccione un nivel de habitación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //if (cbHotelBedrooms.Text == "Seleccionar")
            //{
            //    MessageBox.Show("Seleccione un hotel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (cbLevelRoomBedroom.Text == "Seleccionar")
            //{
            //    MessageBox.Show("Seleccione un nivel de habitación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (cbTypeBedBedrooms.Text == "Seleccionar")
            //{
            //    MessageBox.Show("Seleccione un tipo de habitación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (clbFrontBedroom.CheckedItems.Count == 0)
            //{
            //    MessageBox.Show("Seleccione al menos una opción en 'Frente a...'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            cuarto.hotel = cbHotelBedrooms.Text;
            cuarto.tipoHabitacion = txtTypeRoomBedrooms.Text;
            cuarto.numeroCamas = txtNumberBedsBedrooms.Text;
            cuarto.tiposCama = cbTypeBedBedrooms.Text;
            cuarto.precioPorNoche = txtPriceNightBedrooms.Text;
            cuarto.cantidadPersonas = txtNumPeopleBedroom.Text;
            cuarto.nivelHabitacion = cbLevelRoomBedroom.Text;
            string frenteA = "";
            for (int x = 0; x < clbFrontBedroom.CheckedItems.Count; x++)
            {
                if (x + 1 == clbFrontBedroom.CheckedItems.Count)
                    frenteA += clbFrontBedroom.CheckedItems[x].ToString();
                else
                    frenteA += clbFrontBedroom.CheckedItems[x].ToString() + "";
            }
            cuarto.frenteA = frenteA;
            cuarto.caracteristicas = txtCharacteBedrooms.Text;
            string amenidades = "";
            for (int x = 0; x < clbAmenitiesBedrooms.CheckedItems.Count; x++)
            {
                if (x + 1 == clbAmenitiesBedrooms.CheckedItems.Count)
                    amenidades += clbAmenitiesBedrooms.CheckedItems[x].ToString();
                else
                    amenidades += clbAmenitiesBedrooms.CheckedItems[x].ToString();
            }
            cuarto.amenidades = amenidades;
            var success = cass.UpdateHabitaciones(cuarto);
            if (success)
            {
                //dataGridBedrooms.DataSource = cass.Obtener_hoteles();
                MessageBox.Show("Se edito la habitación.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            clearTxt();
            btnAddBedrooms.Enabled = true;
            btnEditBedrooms.Enabled = false;
            btnDeleteBedrooms.Enabled = false;
            dataGridBedrooms.ClearSelection();
            dataGridBedrooms.DataSource = cass.Obtener_habitaciones();
        }

        private void btnDeleteBedrooms_Click(object sender, EventArgs e)
        {
            var success = cass.DeleteHabitaciones(dataGridBedrooms.CurrentRow.Cells[1].Value.ToString());
            if (success)
                MessageBox.Show("Se elimno la habitacion.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearTxt();
            btnAddBedrooms.Enabled = true;
            btnEditBedrooms.Enabled = false;
            btnDeleteBedrooms.Enabled = false;
            dataGridBedrooms.ClearSelection();
            dataGridBedrooms.DataSource = cass.Obtener_habitaciones();
        }

        private void cbTypeBedBedrooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            selection2 = true;
        }

        private void cbLevelRoomBedroom_SelectedIndexChanged(object sender, EventArgs e)
        {
            selection3 = true;
        }

        private void txtNumberBedsBedrooms_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(e);
        }

        private void txtNumPeopleBedroom_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(e);
        }

        private void txtPriceNightBedrooms_KeyPress(object sender, KeyPressEventArgs e)
        {
            onePoint(e, txtPriceNightBedrooms.Text);
        }

        private void cbHotelBedrooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            selection = true;
        }

        private void onlyNumbers(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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

        private void dataGridBedrooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridBedrooms.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridBedrooms.CurrentRow.Selected = true;

                    cbHotelBedrooms.Text = dataGridBedrooms.Rows[e.RowIndex].Cells["hotel"].Value.ToString();
                    txtTypeRoomBedrooms.Text = dataGridBedrooms.Rows[e.RowIndex].Cells["tipoHabitacion"].Value.ToString();
                    txtNumberBedsBedrooms.Text = dataGridBedrooms.Rows[e.RowIndex].Cells["numeroCamas"].Value.ToString();
                    cbTypeBedBedrooms.Text = dataGridBedrooms.Rows[e.RowIndex].Cells["tiposCama"].Value.ToString();
                    txtPriceNightBedrooms.Text = dataGridBedrooms.Rows[e.RowIndex].Cells["precioPorNoche"].Value.ToString();
                    txtNumPeopleBedroom.Text = dataGridBedrooms.Rows[e.RowIndex].Cells["cantidadPersonas"].Value.ToString();
                    cbLevelRoomBedroom.Text = dataGridBedrooms.Rows[e.RowIndex].Cells["nivelHabitacion"].Value.ToString();  
                    txtCharacteBedrooms.Text = dataGridBedrooms.Rows[e.RowIndex].Cells["caracteristicas"].Value.ToString();
                    btnDeleteBedrooms.Enabled = true;
                    btnEditBedrooms.Enabled = true;
                    btnAddBedrooms.Enabled = false;
                }
            }
            catch (Exception ArgumentOutOfRangeException)
            {
                MessageBox.Show("Seleccione una celda valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearTxt()
        {
            txtTypeRoomBedrooms.Text = "";
            txtNumberBedsBedrooms.Text = "";
            txtPriceNightBedrooms.Text = "";
            txtNumPeopleBedroom.Text = "";
            txtCharacteBedrooms.Text = "";
            cbHotelBedrooms.Text = "Seleccionar";
            cbLevelRoomBedroom.Text = "Seleccionar";
            cbTypeBedBedrooms.Text = "Seleccionar";
        }
    }
}
