using System;
using System.Windows.Forms;

namespace Punto_de_Venta
{
    public partial class departamentScreen : Form
    {
    
        int indexBox, indexBox2;
        bool selection = false;
        bool selection2 = false;
        bool selection3 = false;
        bool bandera;

        public departamentScreen()
        {
            InitializeComponent();
           
        }

        private void btnAddDepartament_Click(object sender, EventArgs e)
        {
            //Espacios vacios
            if (txtTypeRoomBedrooms.TextLength == 0 || txtNumberBedsBedrooms.TextLength == 0 || txtPriceNightBedrooms.TextLength == 0 ||
                txtNumPeopleBedroom.TextLength == 0 || txtCharacteBedrooms.TextLength == 0)
            {
                MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //ComboBox
            if (selection == false || selection2 == false || selection3 == false)
            {
                if (selection == false)
                    MessageBox.Show("Seleccione un Hotel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (selection2 == false)
                    MessageBox.Show("Seleccione un tipo de cama", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (selection3 == false)
                    MessageBox.Show("Seleccione un nivel de habitación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbHotelBedrooms.Text == "Seleccionar")
            {
                MessageBox.Show("Seleccione un hotel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbLevelRoomBedroom.Text == "Seleccionar")
            {
                MessageBox.Show("Seleccione un nivel de habitación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbTypeBedBedrooms.Text == "Seleccionar")
            {
                MessageBox.Show("Seleccione un tipo de habitación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (clbFrontBedroom.CheckedItems.Count == 0)
            {
                MessageBox.Show("Seleccione al menos una opción en 'Frente a...'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            clearTxt(); 
        }

        private void btnEditBedrooms_Click(object sender, EventArgs e)
        {
            //Espacios vacios
            if (txtTypeRoomBedrooms.TextLength == 0 || txtNumberBedsBedrooms.TextLength == 0 || txtPriceNightBedrooms.TextLength == 0 ||
                txtNumPeopleBedroom.TextLength == 0 || txtCharacteBedrooms.TextLength == 0)
            {
                MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //ComboBox
            if (selection == false || selection2 == false || selection3 == false)
            {
                if (selection == false)
                    MessageBox.Show("Seleccione un Hotel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (selection2 == false)
                    MessageBox.Show("Seleccione un tipo de cama", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (selection3 == false)
                    MessageBox.Show("Seleccione un nivel de habitación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbHotelBedrooms.Text == "Seleccionar")
            {
                MessageBox.Show("Seleccione un hotel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbLevelRoomBedroom.Text == "Seleccionar")
            {
                MessageBox.Show("Seleccione un nivel de habitación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbTypeBedBedrooms.Text == "Seleccionar")
            {
                MessageBox.Show("Seleccione un tipo de habitación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (clbFrontBedroom.CheckedItems.Count == 0)
            {
                MessageBox.Show("Seleccione al menos una opción en 'Frente a...'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            clearTxt();
        }

        private void btnDeleteBedrooms_Click(object sender, EventArgs e)
        {
            //TODO: Eliminar todo en base de datos
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
