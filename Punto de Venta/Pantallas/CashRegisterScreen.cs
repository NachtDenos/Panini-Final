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
        int cajaSelection;
        public CashRegisterScreen()
        {
            InitializeComponent();
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
            
        }

        private void btnEditCashRegister_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridCashRegister_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cbCashRegister_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnDeleteCashRegister_Click(object sender, EventArgs e)
        {
           
        }
    }
}
