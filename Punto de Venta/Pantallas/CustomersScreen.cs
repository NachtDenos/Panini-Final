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
using Cassandra.Data;
using Punto_de_Venta.Clases;

namespace Punto_de_Venta
{
    public partial class SellerReportScreen : Form
    {
        Clientes client = new Clientes();
        EnlaceCassandra cass = new EnlaceCassandra();
        bool selection = false;
        public SellerReportScreen()
        {
            InitializeComponent();
            dataGridCustomers.DataSource = cass.Obtener_clientes();
            btnEditCustomer.Enabled = false;
            btnDeleteCustomer.Enabled = false;
            dataGridCustomers.ClearSelection();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            /*if (txtNameCustomers.TextLength == 0 || txtLastName1Customers.TextLength == 0 || txtLastName2Customers.TextLength == 0 ||
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
            }*/

            client.nombre = txtNameCustomers.Text; 
            client.apellidoP = txtLastName1Customers.Text; 
            client.apellidoM = txtLastName2Customers.Text;
            client.fechaNacimiento = dtpBirthCustomers.Text;
            client.correo = txtEmailCustomers.Text;
            client.direccion = txtAddressCustomers.Text;
            client.nomina = txtPayrollCustomers.Text;
            client.telefonoCasa = txtPhoneCustomers.Text;
            client.telefonoPersonal = txtCellPhoneCustomers.Text;
            client.rfc = txtRFCCustomers.Text;
            client.estado = "activo";
            client.situacionCivil = txtCivilCustomers.Text;
            client.referencias = cbReferenceCustomers.Text;
            client.FechaIngreso = DateTime.Now.ToString("yyyy-MM-dd");
            client.horaderegistro = DateTime.Now.ToString("HH:mm:ss");
            var success = cass.insert_Clientes(client);
            if (success)
            {
                dataGridCustomers.DataSource = cass.Obtener_clientes();
                MessageBox.Show("Se agrego al cliente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            clearTxt();
            dataGridCustomers.ClearSelection();
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
            /*if (txtNameCustomers.TextLength == 0 || txtLastName1Customers.TextLength == 0 || txtLastName2Customers.TextLength == 0 ||
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
            }*/
            client.nombre = txtNameCustomers.Text;
            client.apellidoP = txtLastName1Customers.Text;
            client.apellidoM = txtLastName2Customers.Text;
            client.fechaNacimiento = dtpBirthCustomers.Text;
            client.correo = txtEmailCustomers.Text;
            client.direccion = txtAddressCustomers.Text;
            client.nomina = txtPayrollCustomers.Text;
            client.telefonoCasa = txtPhoneCustomers.Text;
            client.telefonoPersonal = txtCellPhoneCustomers.Text;
            client.rfc = txtRFCCustomers.Text;
            client.estado = "activo";
            client.situacionCivil = txtCivilCustomers.Text;
            client.referencias = cbReferenceCustomers.Text;
            var success = cass.UpdateClientes(client);
            if (success)
            {
                MessageBox.Show("Se edito al cliente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridCustomers.DataSource = cass.Obtener_clientes();
            }

            clearTxt();
            btnAddCustomer.Enabled = true;
            btnEditCustomer.Enabled = false;
            btnDeleteCustomer.Enabled = false;
            txtNameCustomers.Enabled = true;
            txtRFCCustomers.Enabled = true;
            txtEmailCustomers.Enabled = true;
            dataGridCustomers.ClearSelection();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            var success = cass.DeleteClientes(dataGridCustomers.CurrentRow.Cells[4].Value.ToString(), dataGridCustomers.CurrentRow.Cells[0].Value.ToString(), dataGridCustomers.CurrentRow.Cells[8].Value.ToString());
            if (success)
                MessageBox.Show("Se elimno al usuario.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearTxt();
            btnAddCustomer.Enabled = true;
            btnEditCustomer.Enabled = false;
            btnDeleteCustomer.Enabled = false;
            txtNameCustomers.Enabled = true;
            txtRFCCustomers.Enabled = true;
            txtEmailCustomers.Enabled = true;
            dataGridCustomers.ClearSelection();
            dataGridCustomers.DataSource = cass.Obtener_clientes();
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

        private void dataGridCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridCustomers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridCustomers.CurrentRow.Selected = true;

                    txtNameCustomers.Text = dataGridCustomers.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                    txtLastName1Customers.Text = dataGridCustomers.Rows[e.RowIndex].Cells["apellidoP"].Value.ToString();
                    txtLastName2Customers.Text = dataGridCustomers.Rows[e.RowIndex].Cells["apellidoM"].Value.ToString();
                    dtpBirthCustomers.Text = dataGridCustomers.Rows[e.RowIndex].Cells["fechaNacimiento"].Value.ToString();
                    txtEmailCustomers.Text = dataGridCustomers.Rows[e.RowIndex].Cells["correo"].Value.ToString();
                    txtAddressCustomers.Text = dataGridCustomers.Rows[e.RowIndex].Cells["direccion"].Value.ToString();
                    txtPhoneCustomers.Text = dataGridCustomers.Rows[e.RowIndex].Cells["telefonoCasa"].Value.ToString();
                    txtCellPhoneCustomers.Text = dataGridCustomers.Rows[e.RowIndex].Cells["telefonoPersonal"].Value.ToString();
                    txtRFCCustomers.Text = dataGridCustomers.Rows[e.RowIndex].Cells["rfc"].Value.ToString();
                    txtCivilCustomers.Text = dataGridCustomers.Rows[e.RowIndex].Cells["situacionCivil"].Value.ToString();
                    cbReferenceCustomers.Text = dataGridCustomers.Rows[e.RowIndex].Cells["referencias"].Value.ToString();
                    txtPayrollCustomers.Text = dataGridCustomers.Rows[e.RowIndex].Cells["nomina"].Value.ToString();
                    btnDeleteCustomer.Enabled = true;
                    btnEditCustomer.Enabled = true;
                    btnAddCustomer.Enabled = false;
                    txtNameCustomers.Enabled = false;
                    txtRFCCustomers.Enabled = false;
                    txtEmailCustomers.Enabled = false;
                }
            }
            catch (Exception ArgumentOutOfRangeException)
            {
                MessageBox.Show("Seleccione una celda valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
