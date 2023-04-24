using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Punto_de_Venta
{
    public partial class SellerReportScreen : Form
    {
       
        public SellerReportScreen()
        {
            InitializeComponent();
            
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (txtNameCustomers.TextLength == 0 || txtLastName1Customers.TextLength == 0 || txtLastName2Customers.TextLength == 0 ||
                txtEmailCustomers.TextLength == 0 || txtPayrollCustomers.TextLength == 0 || txtAddressCustomers.TextLength == 0 ||
                txtPhoneCustomers.TextLength == 0 || txtCellPhoneCustomers.TextLength == 0 || txtRFCCustomers.TextLength == 0 ||
                txtCivilCustomers.TextLength == 0)
            {
                MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void onlyLetters(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan letras en este campo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
            if (validEmail(txtEmailCustomers.Text) == false)
            {
                MessageBox.Show("Email no valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtNameCustomers_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyLetters(e);
        }

        private void txtLastName1Customers_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyLetters(e);
        }

        private void txtLastName2Customers_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyLetters(e);
        }

        public static bool validEmail(string checkEmail)
        {
            string emailFormato;
            emailFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(checkEmail, emailFormato))
            {
                if (Regex.Replace(checkEmail, emailFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
