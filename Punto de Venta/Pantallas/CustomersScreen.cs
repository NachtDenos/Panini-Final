﻿using System;
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
        bool selection = false;
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
            if (validEmail(txtEmailCustomers.Text) == false)
            {
                MessageBox.Show("Email no valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (selection == false)
            {
                if (selection == false)
                    MessageBox.Show("Seleccione una referencia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbReferenceCustomers.Text == "Seleccionar")
            {
                MessageBox.Show("Seleccione una referencia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dateValidFuture(dtpBirthCustomers.Value.Date) == false)
            {
                MessageBox.Show("Fecha no valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dateValidAge(dtpBirthCustomers.Value.AddYears(18)) == false)
            {
                MessageBox.Show("Fecha no valida. Es menor de edad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            clearTxt();
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

        private void txtPayrollCustomers_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(e);
        }

        private void txtPhoneCustomers_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(e);
        }

        private void txtCellPhoneCustomers_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(e);
        }

        private void txtCivilCustomers_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyLetters(e);
        }

        private void cbReferenceCustomers_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (txtNameCustomers.TextLength == 0 || txtLastName1Customers.TextLength == 0 || txtLastName2Customers.TextLength == 0 ||
                txtEmailCustomers.TextLength == 0 || txtPayrollCustomers.TextLength == 0 || txtAddressCustomers.TextLength == 0 ||
                txtPhoneCustomers.TextLength == 0 || txtCellPhoneCustomers.TextLength == 0 || txtRFCCustomers.TextLength == 0 ||
                txtCivilCustomers.TextLength == 0)
            {
                MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (validEmail(txtEmailCustomers.Text) == false)
            {
                MessageBox.Show("Email no valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (selection == false)
            {
                if (selection == false)
                    MessageBox.Show("Seleccione una referencia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbReferenceCustomers.Text == "Seleccionar")
            {
                MessageBox.Show("Seleccione una referencia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dateValidFuture(dtpBirthCustomers.Value.Date) == false)
            {
                MessageBox.Show("Fecha no valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dateValidAge(dtpBirthCustomers.Value.AddYears(18)) == false)
            {
                MessageBox.Show("Fecha no valida. Es menor de edad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            clearTxt();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            //TODO:Eliminar
        }

        private void clearTxt()
        {
            txtNameCustomers.Text = ""; 
            txtLastName1Customers.Text = "";
            txtLastName2Customers.Text = "";
            txtEmailCustomers.Text = "";
            txtPayrollCustomers.Text = "";
            txtAddressCustomers.Text = "";
            txtPhoneCustomers.Text = "";
            txtCellPhoneCustomers.Text = "";
            txtRFCCustomers.Text = "";
            txtCivilCustomers.Text = "";
            cbReferenceCustomers.Text = "Seleccionar";
        }
    }
}
