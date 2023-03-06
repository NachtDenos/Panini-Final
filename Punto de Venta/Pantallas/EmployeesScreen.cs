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
        Procedures proc = new Procedures();
        public EmployeesScreen()
        {
            InitializeComponent();
            btnEditEmployees.Enabled = false;
            btnDeleteEmployees.Enabled = false;
            dataGridEmployees.ClearSelection();
            //dataGridEmployees.Rows[0].Cells[0].Value = "Juan";
            //dataGridEmployees.Rows[0].Cells[1].Value = "Pérez";
            //dataGridEmployees.Rows[0].Cells[2].Value = "Martínez";
            //dataGridEmployees.Rows[0].Cells[3].Value = "ROCE000131HNLDNDA9";
            //dataGridEmployees.Rows[0].Cells[4].Value = "02/03/2002";
            //dataGridEmployees.Rows[0].Cells[5].Value = "eeatienda2001@hotmail.com";
            //dataGridEmployees.Rows[0].Cells[6].Value = "006756243534";
            //dataGridEmployees.Rows[0].Cells[7].Value = "09/09/2022";
            //dataGridEmployees.Rows[0].Cells[8].Value = "C117";
            //dataGridEmployees.Rows[0].Cells[9].Value = "123";
        }

        private void buttonExitEmployees_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddEmployees_Click(object sender, EventArgs e)
        {
            //Validacion de espacios vacios
            if (txtNameEmployees.TextLength == 0 || txtLastName1Employees.TextLength == 0 || txtLastName2Employees.TextLength == 0 ||
                txtPassEmployees.TextLength == 0 || txtPayrollEmployees.TextLength == 0 || txtCurpEmployees.TextLength == 0 || txtEmailEmployees.TextLength == 0
                || txtIdEmployees.TextLength == 0)
            {
                MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(validEmail(txtEmailEmployees.Text) == false)
            {
                MessageBox.Show("Correo no valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(CurpValida(txtCurpEmployees.Text) == false)
            {
                MessageBox.Show("CURP no valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(dateValidFuture(dtpBirth.Value.Date) == false)
            {
                MessageBox.Show("Fecha no valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dateValidFuture(dtpJoinBusiness.Value.Date) == false)
            {
                MessageBox.Show("Fecha no valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dateValidAge(dtpBirth.Value.AddYears(18)) == false)
            {
                MessageBox.Show("Fecha no valida. Es menor de edad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string Nomina = txtPayrollEmployees.Text;
            int nomina;
            Int32.TryParse(Nomina,out nomina);
            DateTime fechaN = DateTime.Parse(dtpBirth.Text);
            DateTime fechaI = DateTime.Parse(dtpJoinBusiness.Text);
            var result = proc.InsertarEmpleados(txtNameEmployees.Text,txtLastName1Employees.Text, txtLastName2Employees.Text, txtIdEmployees.Text, txtPassEmployees.Text, fechaN, fechaI, txtCurpEmployees.Text, txtEmailEmployees.Text, nomina);
            if (result == true)
            {
                MessageBox.Show("Inserccion Realizada con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridEmployees.DataSource = proc.ListarCajero();
                txtNameEmployees.Text = "";
                txtLastName1Employees.Text = "";
                txtLastName2Employees.Text = "";
                txtIdEmployees.Text = "";
                txtEmailEmployees.Text = "";
                txtPayrollEmployees.Text = "";
                txtPassEmployees.Text = "";
                txtCurpEmployees.Text = "";
                dtpBirth.Text = "";
                dtpJoinBusiness.Text = "";
            }
            else
                MessageBox.Show("No se realizo la inserccion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            dataGridEmployees.DataSource = proc.ListarCajero();
        }

        private void SearchBtton_Click(object sender, EventArgs e)
        {
            
            dataGridEmployees.DataSource = proc.ListarCajero();
        }

        int idCajeroSeleccionado;
        private void btnEditEmployees_Click(object sender, EventArgs e)
        {
            //Validacion de espacios vacios
            if (txtNameEmployees.TextLength == 0 || txtLastName1Employees.TextLength == 0 || txtLastName2Employees.TextLength == 0 ||
                txtPassEmployees.TextLength == 0 || txtPayrollEmployees.TextLength == 0 || txtCurpEmployees.TextLength == 0 || txtEmailEmployees.TextLength == 0
                || txtIdEmployees.TextLength == 0)
            {
                MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (validEmail(txtEmailEmployees.Text) == false)
            {
                MessageBox.Show("Correo no valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CurpValida(txtCurpEmployees.Text) == false)
            {
                MessageBox.Show("CURP no valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dateValidFuture(dtpBirth.Value.Date) == false)
            {
                MessageBox.Show("Fecha no valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dateValidFuture(dtpJoinBusiness.Value.Date) == false)
            {
                MessageBox.Show("Fecha no valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dateValidAge(dtpBirth.Value.AddYears(18)) == false)
            {
                MessageBox.Show("Fecha no valida. Es menor de edad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime fechaN = DateTime.Parse(dtpBirth.Text);
            DateTime fechaI = DateTime.Parse(dtpJoinBusiness.Text);
            string Nomina = txtPayrollEmployees.Text;
            int nomina;
            Int32.TryParse(Nomina, out nomina);
            var pepe = proc.ActualizarUsuarios(idCajeroSeleccionado, txtNameEmployees.Text, txtLastName1Employees.Text, txtLastName2Employees.Text, txtIdEmployees.Text, txtPassEmployees.Text,
                txtCurpEmployees.Text, txtEmailEmployees.Text, fechaN, fechaI, nomina);
            if (pepe == true)
            {
                MessageBox.Show("Edicion realizada con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridEmployees.DataSource = proc.ListarCajero();
                txtNameEmployees.Text = "";
                txtLastName1Employees.Text = "";
                txtLastName2Employees.Text = "";
                txtIdEmployees.Text = "";
                txtEmailEmployees.Text = "";
                txtPayrollEmployees.Text = "";
                txtPassEmployees.Text = "";
                txtCurpEmployees.Text = "";
                dtpBirth.Text = "";
                dtpJoinBusiness.Text = "";
            }
            else
            {
                MessageBox.Show("NO SE REALIZO LA ACTUALIZACION", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //if (dataGridEmployees.SelectedRows.Count > 0)
            //{
            //    string IdEmpleadoyUsuario;
            //    int eseId;
            //    IdEmpleadoyUsuario = dataGridEmployees.CurrentRow.Cells["IdEmpleado"].Value.ToString();
            //    Int32.TryParse(IdEmpleadoyUsuario, out eseId);
            //}
            //else
            //{
            //    MessageBox.Show("Debe seleccionar una Fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            btnAddEmployees.Enabled = true;
            dataGridEmployees.ClearSelection();
        }

        private void EmployeesScreen_Load(object sender, EventArgs e)
        {
            
            dataGridEmployees.DataSource = proc.ListarCajero();
        }

        private void dataGridEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridEmployees.AllowUserToOrderColumns = false;
            try
            {
                if (dataGridEmployees.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridEmployees.CurrentRow.Selected = true;

                    string IdEmpleadoyUsuario;
                    int eseId;
                    IdEmpleadoyUsuario = dataGridEmployees.CurrentRow.Cells["IdEmpleado"].Value.ToString();
                    Int32.TryParse(IdEmpleadoyUsuario, out eseId);
                    idCajeroSeleccionado = eseId;
                    txtNameEmployees.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                    txtLastName1Employees.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Apellido Paterno"].Value.ToString();
                    txtLastName2Employees.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Apellido Materno"].Value.ToString();
                    txtIdEmployees.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Clave de Usuario"].Value.ToString();
                    txtEmailEmployees.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Correo"].Value.ToString();
                    txtPayrollEmployees.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Nomina"].Value.ToString();
                    txtPassEmployees.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Contraseña"].Value.ToString();
                    txtCurpEmployees.Text = dataGridEmployees.Rows[e.RowIndex].Cells["CURP"].Value.ToString();
                    dtpBirth.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Fecha Nacimiento"].Value.ToString();
                    dtpJoinBusiness.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Fecha de Ingreso"].Value.ToString();
                    btnEditEmployees.Enabled = true;
                    btnDeleteEmployees.Enabled = true;
                    btnAddEmployees.Enabled = false;
                }
            }
            catch (Exception ArgumentOutOfRangeException)
            {
                
                //MessageBox.Show("SELECCIONA UNA PUTA CELDA NO LA PUTA COLUMNA");
            }
            //if (dataGridEmployees.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            //{
            //    dataGridEmployees.CurrentRow.Selected = true;

            //    string IdEmpleadoyUsuario;
            //    int eseId;
            //    IdEmpleadoyUsuario = dataGridEmployees.CurrentRow.Cells["IdEmpleado"].Value.ToString();
            //    Int32.TryParse(IdEmpleadoyUsuario, out eseId);
            //    idCajeroSeleccionado = eseId;
            //    txtNameEmployees.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            //    txtLastName1Employees.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Apellido Paterno"].Value.ToString();
            //    txtLastName2Employees.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Apellido Materno"].Value.ToString();
            //    txtIdEmployees.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Clave de Usuario"].Value.ToString();
            //    txtEmailEmployees.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Correo"].Value.ToString();
            //    txtPayrollEmployees.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Nomina"].Value.ToString();
            //    txtPassEmployees.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Contraseña"].Value.ToString();
            //    txtCurpEmployees.Text = dataGridEmployees.Rows[e.RowIndex].Cells["CURP"].Value.ToString();
            //    dtpBirth.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Fecha Nacimiento"].Value.ToString();
            //    dtpJoinBusiness.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Fecha de Ingreso"].Value.ToString();
            //}
        }

        private void btnDeleteEmployees_Click(object sender, EventArgs e)
        {
            var AR_152 = proc.BorrarEmpleados(idCajeroSeleccionado);
            if (AR_152 == true)
            {
                MessageBox.Show("Se elimino el empleado con exito", "Exíto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNameEmployees.Text = "";
                txtLastName1Employees.Text = "";
                txtLastName2Employees.Text = "";
                txtIdEmployees.Text = "";
                txtEmailEmployees.Text = "";
                txtPayrollEmployees.Text = "";
                txtPassEmployees.Text = "";
                txtCurpEmployees.Text = "";
                dtpBirth.Text = "";
                dtpJoinBusiness.Text = "";
                dataGridEmployees.DataSource = proc.ListarCajero();
                //NO TENGO IDEA
           
            }
            else
            {
                MessageBox.Show("NO se elimino el empleado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridEmployees.DataSource = proc.ListarCajero();
            }
            btnAddEmployees.Enabled = true;
            dataGridEmployees.ClearSelection();
        }

        private void txtPayrollEmployees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan números en este campo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtIdEmployees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan números en este campo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtNameEmployees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan letras en este campo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtLastName1Employees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan letras en este campo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtLastName2Employees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan letras en este campo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
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
     
        private bool CurpValida(string curp)
        {
            var re = @"^([A-Z][AEIOUX][A-Z]{2}\d{2}(?:0[1-9]|1[0-2])(?:0[1-9]|[12]\d|3[01])[HM](?:AS|B[CS]|C[CLMSH]|D[FG]|G[TR]|HG|JC|M[CNS]|N[ETL]|OC|PL|Q[TR]|S[PLR]|T[CSL]|VZ|YN|ZS)[B-DF-HJ-NP-TV-Z]{3}[A-Z\d])(\d)$";
            Regex rx = new Regex(re, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            var validado = rx.IsMatch(curp);

            if (!validado)  
                return false;

            //Validar que coincida el dígito verificador
            if (!curp.EndsWith(DigitoVerificador(curp.ToUpper())))
                return false;

            return true; //Validado
        }

        private string DigitoVerificador(string curp17)
        {
            var dic = "0123456789ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
            var suma = 0.0;
            var digito = 0.0;
            for (var i = 0; i < 17; i++)
                suma = suma + dic.IndexOf(curp17[i]) * (18 - i);
            digito = 10 - suma % 10;
            if (digito == 10) return "0";
            return digito.ToString();
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
            if(fecha <= hoy)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void txtFilterEmployees_TextChanged(object sender, EventArgs e)
        {
            if (txtFilterEmployees.Text != "")
            {
                dataGridEmployees.DataSource = proc.filtroScreenEmpleados(txtFilterEmployees.Text);
            }
            else
            {
                dataGridEmployees.DataSource = proc.ListarCajero();
            }
        }
    }
}
