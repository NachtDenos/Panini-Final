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
    public partial class CashRegisterScreen : Form
    {
        int indexBox;
        bool selection = false;
        Procedures proc = new Procedures();
        int cajaSelection;
        public CashRegisterScreen()
        {
            InitializeComponent();
            btnEditCashRegister.Enabled = false;
            btnDeleteCashRegister.Enabled = false;
            dataGridCashRegister.DataSource = proc.ListarCaja();
            //dataGridCashRegister.Rows[0].Cells[0].Value = "1";
            //dataGridCashRegister.Rows[0].Cells[1].Value = "Si";
        }

        private void txtIdCashRegister_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan números en este campo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void btnAddCashResgister_Click(object sender, EventArgs e)
        {
            if (txtIdCashRegister.TextLength == 0)
            {
                MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (selection == false)
            {
                MessageBox.Show("No seleccionó la disponibilidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idCaja = Int32.Parse(txtIdCashRegister.Text);

            var variable = proc.AltaCaja(idCaja, cbCashRegister.Text);
            if (variable)
            {
                MessageBox.Show("Inserccion Realizada con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridCashRegister.DataSource = proc.ListarCaja();
                clearText();
            }
            else
                MessageBox.Show("No se realizo la inserccion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            dataGridCashRegister.DataSource = proc.ListarCaja();
        }

        private void btnEditCashRegister_Click(object sender, EventArgs e)
        {
            if (txtIdCashRegister.TextLength == 0)
            {
                MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (selection == false)
            {
                MessageBox.Show("No seleccionó la disponibilidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int idCaja = Int32.Parse(txtIdCashRegister.Text);
            var variable = proc.EditarCaja(idCaja, cbCashRegister.Text);
            if (variable)
            {
                MessageBox.Show("Edicion realizada con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridCashRegister.DataSource = proc.ListarCaja();
                clearText();
            }
            else
                MessageBox.Show("No se realizo la edicion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            dataGridCashRegister.DataSource = proc.ListarCaja();
            btnEditCashRegister.Enabled = false;
            btnDeleteCashRegister.Enabled = false;
            btnAddCashResgister.Enabled = true;
        }

        private void dataGridCashRegister_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 
                dataGridCashRegister.AllowUserToOrderColumns = false;
                if (dataGridCashRegister.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    int eseId;
                    string idCaja;
                    idCaja = dataGridCashRegister.CurrentRow.Cells["Numero de Caja"].Value.ToString();
                    Int32.TryParse(idCaja, out eseId);
                    cajaSelection = eseId;
                    txtIdCashRegister.Text = dataGridCashRegister.Rows[e.RowIndex].Cells["Numero de Caja"].Value.ToString();
                    cbCashRegister.Text = dataGridCashRegister.Rows[e.RowIndex].Cells["Disponibilidad"].Value.ToString();
                    dataGridCashRegister.CurrentRow.Selected = true;
                    btnEditCashRegister.Enabled = true;
                    btnDeleteCashRegister.Enabled = true;
                    btnAddCashResgister.Enabled = false;
                }
            }
            catch (Exception ArgumentOutOfRangeException)
            {

            }
        }

        private void cbCashRegister_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexBox = cbCashRegister.SelectedIndex;
            selection = true;
        }

        private void clearText()
        {
            txtIdCashRegister.Text = "";
            cbCashRegister.Text = "Seleccionar";
        }

        private void btnDeleteCashRegister_Click(object sender, EventArgs e)
        {
            Procedures proc = new Procedures();
            var eliminado = proc.BajaCaja(cajaSelection);
            if (eliminado == true)
            {
                MessageBox.Show("Se elimino la caja con exito", "Exíto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridCashRegister.DataSource = proc.ListarCaja();
                clearText();
            }
            else
            {
                MessageBox.Show("NO se elimino la caja", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataGridCashRegister.ClearSelection();
            btnEditCashRegister.Enabled = false;
            btnDeleteCashRegister.Enabled = false;
            btnAddCashResgister.Enabled = true;
        }
    }
}
