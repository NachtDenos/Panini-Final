using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_Venta
{
    public partial class SalesScreen : Form
    {
        bool check1 = false;
        bool check2 = false;
        bool check3 = false;
        bool selection = false;
        bool bandera;
        EnlaceCassandra cass = new EnlaceCassandra();

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
            QuickSearchScreen TheOtherForm = new QuickSearchScreen();
            TheOtherForm.ShowDialog();
        }

        private void btnAddReser_Click(object sender, EventArgs e)
        {
            DateTime fecha1 = dtpLodgingReser.Value;
            DateTime fecha2 = dtpLodgingReser2.Value;

            if (txtPeopleReservations.TextLength == 0)
            {
                MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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
            }
            else if (txtCreditCardPayRe.Enabled == true)
            {
                txtCreditCardPayRe.Enabled = false;
                txtCreditCardPayRe.Text = "";
                check1 = false;
            }
            checkButton();
        }

        private void rbDebitCardPayRe_Click(object sender, EventArgs e)
        {
            if (txtDebitCardPayRe.Enabled == false)
            {
                txtDebitCardPayRe.Enabled = true;
                check2 = true;
            }
            else if (txtDebitCardPayRe.Enabled == true)
            {
                txtDebitCardPayRe.Enabled = false;
                txtDebitCardPayRe.Text = "";
                check2 = false;
            }
            checkButton();
        }

        private void rbTransferPayRe_Click(object sender, EventArgs e)
        {
            if (txtTransferPayRe.Enabled == false)
            {
                txtTransferPayRe.Enabled = true;
                check3 = true;
            }
            else if (txtTransferPayRe.Enabled == true)
            {
                txtTransferPayRe.Enabled = false;
                txtTransferPayRe.Text = "";
                check3 = false;
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
            //dataGridHotelRe.DataSource = cass.
        }
    }
}
