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
    public partial class InventaryScreen : Form
    {
       
        public InventaryScreen()
        {
            InitializeComponent();
            
        }

        private void btnConfirmCheckIn_Click(object sender, EventArgs e)
        {
            if (txtCodeCheckIn.TextLength == 0)
            {
                MessageBox.Show("Falta de escribir el codigo de reservación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtCodeCheckIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(e);
        }
    }
}
