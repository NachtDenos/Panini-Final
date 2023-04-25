using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Text.RegularExpressions;

namespace Punto_de_Venta
{
    public partial class EmployeesScreen : Form
    {
        
        public EmployeesScreen()
        {
            InitializeComponent();
            
        }

        private void btnAddUsers_Click(object sender, EventArgs e)
        {
            if (txtNameUsers.TextLength == 0 || txtLastName1Users.TextLength == 0 || txtLastName2Users.TextLength == 0 ||
                txtEmailUsers.TextLength == 0 || txtPayrollUsers.TextLength == 0 || txtAddressUsers.TextLength == 0 ||
                txtPhoneUsers.TextLength == 0 || txtCellPhoneUsers.TextLength == 0 || txtPassUsers.TextLength == 0)
            {
                MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (validEmail(txtEmailUsers.Text) == false)
            {
                MessageBox.Show("Email no valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dateValidFuture(dtpBirthUsers.Value.Date) == false)
            {
                MessageBox.Show("Fecha no valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dateValidAge(dtpBirthUsers.Value.AddYears(18)) == false)
            {
                MessageBox.Show("Fecha no valida. Es menor de edad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (correctPass(txtPassUsers.Text) == false)
            {
                MessageBox.Show("La contraseña tiene que tener 8 caracteres, mayusculas, minusculas, numeros y un caracter especial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            clearTxt();
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
        private bool dateValidFuture(DateTime fecha)
        {
            DateTime hoy = DateTime.Today;
            if (fecha > hoy)
            {
                return false;
            }
            return true;
        }

        private bool dateValidAge(DateTime fecha)
        {
            DateTime hoy = DateTime.Today;
            if (fecha <= hoy)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool correctPass(string pass)
        {
            bool mayus = false, min = false, number = false, charaE = false;
            for (int i = 0; i < pass.Length; i++)
            {
                if (Char.IsUpper(pass, i))
                    mayus = true;
                else if (Char.IsLower(pass, i))
                    min = true;
                else if (Char.IsDigit(pass, i))
                    number = true;
                else
                    charaE = true;
            }
            if (mayus && min && number && charaE && pass.Length >= 8)
                return true;
            return false;
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
        private void clearTxt()
        {
            txtNameUsers.Text = "";
            txtLastName1Users.Text = "";
            txtLastName2Users.Text = "";
            txtEmailUsers.Text = "";
            txtPayrollUsers.Text = "";
            txtAddressUsers.Text = "";
            txtPhoneUsers.Text = "";
            txtCellPhoneUsers.Text = "";
            txtPassUsers.Text = "";
        }

        private void txtNameUsers_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyLetters(e);
        }

        private void txtLastName1Users_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyLetters(e);
        }

        private void txtLastName2Users_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyLetters(e);
        }

        private void txtPayrollUsers_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(e);
        }

        private void txtPhoneUsers_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(e);
        }

        private void txtCellPhoneUsers_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(e);
        }

        private void btnEditUsers_Click(object sender, EventArgs e)
        {
            if (txtNameUsers.TextLength == 0 || txtLastName1Users.TextLength == 0 || txtLastName2Users.TextLength == 0 ||
                txtEmailUsers.TextLength == 0 || txtPayrollUsers.TextLength == 0 || txtAddressUsers.TextLength == 0 ||
                txtPhoneUsers.TextLength == 0 || txtCellPhoneUsers.TextLength == 0 || txtPassUsers.TextLength == 0)
            {
                MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (validEmail(txtEmailUsers.Text) == false)
            {
                MessageBox.Show("Email no valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dateValidFuture(dtpBirthUsers.Value.Date) == false)
            {
                MessageBox.Show("Fecha no valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dateValidAge(dtpBirthUsers.Value.AddYears(18)) == false)
            {
                MessageBox.Show("Fecha no valida. Es menor de edad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (correctPass(txtPassUsers.Text) == false)
            {
                MessageBox.Show("La contraseña tiene que tener 8 caracteres, mayusculas, minusculas, numeros y un caracter especial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            clearTxt();
        }

        private void btnDeleteUsers_Click(object sender, EventArgs e)
        {
            //TODO:Hacer eliminacion
        }
    }
}
