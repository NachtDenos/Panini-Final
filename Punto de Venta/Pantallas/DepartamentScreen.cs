using System;
using System.Windows.Forms;

namespace Punto_de_Venta
{
    public partial class departamentScreen : Form
    {
        bool selectionCombo;
        int indexBox;
        
        public departamentScreen()
        {
            InitializeComponent();
           
        }

        private void btnAddDepartament_Click(object sender, EventArgs e)
        {

        }

        private void departamentScreen_Load(object sender, EventArgs e)
        {
        }

        private void btnEditDepartament_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridDepartament_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
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
            
        }

        private void btnDeleteDepartament_Click(object sender, EventArgs e)
        {
            
        }

        private void txtFilterDepartament_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
