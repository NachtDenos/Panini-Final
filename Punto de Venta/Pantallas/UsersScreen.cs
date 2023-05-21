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
using Punto_de_Venta.Clases;

namespace Punto_de_Venta
{
    public partial class EmployeesScreen : Form
    {
        EnlaceCassandra cass = new EnlaceCassandra();

        Usuario sus = new Usuario();
        public EmployeesScreen()
        {
            InitializeComponent();
            dataGridUsers.DataSource = cass.Obtener_usuarios();
            btnEditUsers.Enabled = false;
            btnDeleteUsers.Enabled = false;
            dataGridUsers.ClearSelection();
        }

        private void btnAddUsers_Click(object sender, EventArgs e)
        {
        //    if (txtNameUsers.TextLength == 0 || txtLastName1Users.TextLength == 0 || txtLastName2Users.TextLength == 0 ||
        //        txtEmailUsers.TextLength == 0 || txtPayrollUsers.TextLength == 0 || txtAddressUsers.TextLength == 0 ||
        //        txtPhoneUsers.TextLength == 0 || txtCellPhoneUsers.TextLength == 0 || txtPassUsers.TextLength == 0)
        //    {
        //        MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }
            //if (validEmail(txtEmailUsers.Text) == false)
            //{
            //    MessageBox.Show("Email no valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (dateValidFuture(dtpBirthUsers.Value.Date) == false)
            //{
            //    MessageBox.Show("Fecha no valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (dateValidAge(dtpBirthUsers.Value.AddYears(18)) == false)
            //{
            //    MessageBox.Show("Fecha no valida. Es menor de edad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (correctPass(txtPassUsers.Text) == false)
            //{
            //    MessageBox.Show("La contraseña tiene que tener 8 caracteres, mayusculas, minusculas, numeros y un caracter especial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            sus.nombre = txtNameUsers.Text;
            sus.contrasena = txtPassUsers.Text;
            sus.apellidoP = txtLastName1Users.Text;
            sus.apellidoM = txtLastName2Users.Text;
            string fechaReal = dtpBirthUsers.Text;
            String.Format("{0:yyyy-MM-dd}", fechaReal);
            sus.correo = txtEmailUsers.Text;
            sus.direccion = txtAddressUsers.Text;
            sus.nomina = txtPayrollUsers.Text;
            sus.telefono = txtCellPhoneUsers.Text;
            sus.telefonoCasa = txtPhoneUsers.Text;
            sus.status = true;
            sus.FechaNacimiento = fechaReal;
            sus.FechaIngreso = DateTime.Now.ToString("yyyy-MM-dd");
            sus.horaderegistro = DateTime.Now.ToString("HH:mm:ss");
            sus.rol = 1;
            var success = cass.InsertarOperativos(sus);
            if (success)
                MessageBox.Show("Se agrego al usuario.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            clearTxt();
            dataGridUsers.DataSource = cass.Obtener_usuarios();
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
            //if (txtNameUsers.TextLength == 0 || txtLastName1Users.TextLength == 0 || txtLastName2Users.TextLength == 0 ||
            //    txtEmailUsers.TextLength == 0 || txtPayrollUsers.TextLength == 0 || txtAddressUsers.TextLength == 0 ||
            //    txtPhoneUsers.TextLength == 0 || txtCellPhoneUsers.TextLength == 0 || txtPassUsers.TextLength == 0)
            //{
            //    MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //if (validEmail(txtEmailUsers.Text) == false)
            //{
            //    MessageBox.Show("Email no valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (dateValidFuture(dtpBirthUsers.Value.Date) == false)
            //{
            //    MessageBox.Show("Fecha no valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (dateValidAge(dtpBirthUsers.Value.AddYears(18)) == false)
            //{
            //    MessageBox.Show("Fecha no valida. Es menor de edad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (correctPass(txtPassUsers.Text) == false)
            //{
            //    MessageBox.Show("La contraseña tiene que tener 8 caracteres, mayusculas, minusculas, numeros y un caracter especial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}



            sus.nombre = txtNameUsers.Text;
            sus.contrasena = txtPassUsers.Text;
            sus.apellidoP = txtLastName1Users.Text;
            sus.apellidoM = txtLastName2Users.Text;
            string fechaReal = dtpBirthUsers.Text;
            String.Format("{0:yyyy-MM-dd}", fechaReal);
            sus.correo = txtEmailUsers.Text;
            sus.direccion = txtAddressUsers.Text;
            sus.nomina = txtPayrollUsers.Text;
            sus.telefono = txtCellPhoneUsers.Text;
            sus.telefonoCasa = txtPhoneUsers.Text;
            sus.status = true;
            sus.FechaNacimiento = fechaReal;
            sus.FechaIngreso = DateTime.Now.ToString("yyyy-MM-dd");
            sus.horaderegistro = DateTime.Now.ToString("HH:mm:ss");
            var success = cass.Modif_Usuarios(sus, dataGridUsers.CurrentRow.Cells[3].Value.ToString());
            if (success)
                MessageBox.Show("Se edito al usuario.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearTxt();
            btnAddUsers.Enabled = true;
            btnEditUsers.Enabled = false;
            btnDeleteUsers.Enabled = false;
            dataGridUsers.ClearSelection();
            dataGridUsers.DataSource = cass.Obtener_usuarios();
        }

        private void btnDeleteUsers_Click(object sender, EventArgs e)
        {
            //SEGURO QUE QUIERES ELIMINAR?
            var success = cass.Delete_Usuarios(dataGridUsers.CurrentRow.Cells[3].Value.ToString());
            if (success)
                MessageBox.Show("Se elimno al usuario.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnAddUsers.Enabled = true;
            btnEditUsers.Enabled = false;
            btnDeleteUsers.Enabled = false;
            clearTxt();
            dataGridUsers.ClearSelection();
            dataGridUsers.DataSource = cass.Obtener_usuarios();
        }

        private void dataGridUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridUsers.AllowUserToAddRows = false;
                if (dataGridUsers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridUsers.CurrentRow.Selected = true;
                    txtNameUsers.Text = dataGridUsers.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                    txtPassUsers.Text = dataGridUsers.Rows[e.RowIndex].Cells["contrasena"].Value.ToString();
                    txtLastName1Users.Text = dataGridUsers.Rows[e.RowIndex].Cells["apellidoP"].Value.ToString(); 
                    txtLastName2Users.Text = dataGridUsers.Rows[e.RowIndex].Cells["apellidoM"].Value.ToString();
                    dtpBirthUsers.Text = dataGridUsers.Rows[e.RowIndex].Cells["FechaNacimiento"].Value.ToString(); 
                    txtEmailUsers.Text = dataGridUsers.Rows[e.RowIndex].Cells["correo"].Value.ToString(); 
                    txtAddressUsers.Text = dataGridUsers.Rows[e.RowIndex].Cells["direccion"].Value.ToString();
                    txtPayrollUsers.Text = dataGridUsers.Rows[e.RowIndex].Cells["nomina"].Value.ToString();
                    txtCellPhoneUsers.Text = dataGridUsers.Rows[e.RowIndex].Cells["telefono"].Value.ToString();
                    txtPhoneUsers.Text = dataGridUsers.Rows[e.RowIndex].Cells["telefonoCasa"].Value.ToString();
                    btnEditUsers.Enabled = true;
                    btnDeleteUsers.Enabled = true;
                    btnAddUsers.Enabled = false;
                }
            }
            catch (Exception ArgumentOutOfRangeException)
            {
                MessageBox.Show("Seleccione una celda valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
