using System;
using System.Windows.Forms;

namespace Punto_de_Venta
{
    public partial class departamentScreen : Form
    {
        bool selectionCombo;
        int indexBox;
        Procedures proc = new Procedures();
        public departamentScreen()
        {
            InitializeComponent();
            btnEditDepartament.Enabled = false;
            btnDeleteDepartament.Enabled = false;
            //dataGridDepartament.Rows[0].Cells[0].Value = "D012409";
            //dataGridDepartament.Rows[0].Cells[1].Value = "Mariscos";
            //dataGridDepartament.Rows[0].Cells[2].Value = "Si";
        }

        private void btnAddDepartament_Click(object sender, EventArgs e)
        {
            if (txtNameDepartament.TextLength == 0 || txtIdDepartament.TextLength == 0)
            {
                MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (selectionCombo == false)
            {
                MessageBox.Show("Seleccione un campo de Devolución", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id;
            string idTexto = txtIdDepartament.Text;
            Int32.TryParse(idTexto, out id);
           var aja = proc.AltaDepartamentos(txtNameDepartament.Text, id,cbDevolutionDepartament.Text);
            if (aja == true)
            {
                MessageBox.Show("Inserccion Realizada con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFilterDepartament.Text = "";
                txtIdDepartament.Text = "";
                txtNameDepartament.Text = "";
                cbDevolutionDepartament.Text = "Seleccionar";
            }
            dataGridDepartament.DataSource = proc.ListarDepartamentos();

        }

        private void departamentScreen_Load(object sender, EventArgs e)
        {

           // var esoTilin = proc.ListarDepartamentos();
            dataGridDepartament.DataSource = proc.ListarDepartamentos();
        }

        private void btnEditDepartament_Click(object sender, EventArgs e)
        {
            if (txtNameDepartament.TextLength == 0 || txtIdDepartament.TextLength == 0)
            {
                MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (selectionCombo == false)
            {
                MessageBox.Show("Seleccione un campo de Devolución", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id;
            string idTexto = txtIdDepartament.Text;
            Int32.TryParse(idTexto, out id);
            var esoTilin = proc.ActualizarDepartamentos(txtNameDepartament.Text, cbDevolutionDepartament.Text, id);
            if (esoTilin)
            {
                MessageBox.Show("La actualizacion se realizo con exito", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridDepartament.DataSource = proc.ListarDepartamentos();
                txtFilterDepartament.Text = "";
                txtIdDepartament.Text = "";
                txtNameDepartament.Text = "";
                cbDevolutionDepartament.Text = "Seleccionar";
            }
            else if (esoTilin == false)
            {
                MessageBox.Show("ERROR NO SE ACUTALIZO", "NO ACTUALIZDOE RROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtIdDepartament.Enabled = true;
            btnAddDepartament.Enabled = true;
            btnDeleteDepartament.Enabled = false;
            btnEditDepartament.Enabled = false;
        }

        private void dataGridDepartament_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditDepartament.Enabled = true;
            btnDeleteDepartament.Enabled = true;
            dataGridDepartament.AllowUserToOrderColumns = false;
            try
            {
                if (dataGridDepartament.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridDepartament.CurrentRow.Selected = true;
                    txtIdDepartament.Enabled = false;
                    btnAddDepartament.Enabled = false;
                    txtIdDepartament.Text = dataGridDepartament.Rows[e.RowIndex].Cells["Id Departamento"].Value.ToString();
                    txtNameDepartament.Text = dataGridDepartament.Rows[e.RowIndex].Cells["Departamento"].Value.ToString();
                    cbDevolutionDepartament.Text = dataGridDepartament.Rows[e.RowIndex].Cells["Acepta devoluciones"].Value.ToString();
                    //string IdEmpleadoyUsuario;
                    //int eseId;
                    //IdEmpleadoyUsuario = dataGridEmployees.CurrentRow.Cells["IdEmpleado"].Value.ToString();
                    //Int32.TryParse(IdEmpleadoyUsuario, out eseId);
                    //idCajeroSeleccionado = eseId;
                    //txtNameEmployees.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                    //txtLastName1Employees.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Apellido Paterno"].Value.ToString();
                    //txtLastName2Employees.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Apellido Materno"].Value.ToString();
                    //txtIdEmployees.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Clave de Usuario"].Value.ToString();
                    //txtEmailEmployees.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Correo"].Value.ToString();
                    //txtPayrollEmployees.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Nomina"].Value.ToString();
                    //txtPassEmployees.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Contraseña"].Value.ToString();
                    //txtCurpEmployees.Text = dataGridEmployees.Rows[e.RowIndex].Cells["CURP"].Value.ToString();
                    //dtpBirth.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Fecha Nacimiento"].Value.ToString();
                    //dtpJoinBusiness.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Fecha de Ingreso"].Value.ToString();

               

                }
                //else if(dataGridDepartament.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
                ////{
                ////    dataGridDepartament
                ////    txtIdDepartament.Enabled = true;
                //}
            }
            catch (Exception ArgumentOutOfRangeException)
            {

                //MessageBox.Show("SELECCIONA UNA PUTA CELDA NO LA PUTA COLUMNA");
            }
        }

        private void txtNameDepartament_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan letras en este campo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtIdDepartament_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan números en este campo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void cbDevolutionDepartament_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexBox = cbDevolutionDepartament.SelectedIndex;
            selectionCombo = true;
        }

        private void btnDeleteDepartament_Click(object sender, EventArgs e)
        {
            int id;
           string perro = txtIdDepartament.Text;
            Int32.TryParse(perro, out id);
            var estoTilin2Secuela = proc.BorrarDepartamentos(id);
            if (estoTilin2Secuela == true)
            {
                MessageBox.Show("Baja realizada con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridDepartament.DataSource = proc.ListarDepartamentos();
                txtFilterDepartament.Text = "";
                txtIdDepartament.Text = "";
                txtNameDepartament.Text = "";
                cbDevolutionDepartament.Text = "Seleccionar";
                
            }
            txtIdDepartament.Enabled = true;
            btnAddDepartament.Enabled = true;
            btnDeleteDepartament.Enabled = false;
            btnEditDepartament.Enabled = false;
        }

        private void txtFilterDepartament_TextChanged(object sender, EventArgs e)
        {
            if (txtFilterDepartament.Text != "")
            {
                dataGridDepartament.DataSource = proc.filtroScreenDepa(txtFilterDepartament.Text);
            }
            else
            {
                dataGridDepartament.DataSource = proc.ListarDepartamentos();
            }
        }

        //private void dataGridDepartament_CellLeave(object sender, DataGridViewCellEventArgs e)
        //{

        //}
    }
}
