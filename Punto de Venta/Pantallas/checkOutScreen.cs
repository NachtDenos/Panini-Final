using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_Venta.Pantallas
{
    public partial class checkOutScreen : Form
    {
        bool bandera;
        bool check1 = false;
        bool check2 = false;
        public checkOutScreen()
        {
            InitializeComponent();
            txtCreditCardCheckOut.Enabled = false;
            txtDebitCardCheckOut.Enabled = false;
            btnConfirmCheckOut.Enabled = false;
        }

        private void btnEditDepartament_Click(object sender, EventArgs e)
        {
            WaytoPayScreen TheOtherForm = new WaytoPayScreen();
            TheOtherForm.ShowDialog();
        }

        private void btnSearchCheckOut_Click(object sender, EventArgs e)
        {
            if (txtCodeCheckOut.TextLength == 0)
            {
                MessageBox.Show("Falta de escribir el codigo de reservación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
