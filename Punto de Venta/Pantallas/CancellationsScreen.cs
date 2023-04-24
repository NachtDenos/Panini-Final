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
    public partial class DiscountsScreen : Form
    {
        
        public DiscountsScreen()
        {
            InitializeComponent();
           
          
        }

        private void addDiscountBtton_Click(object sender, EventArgs e)
        {
            if (txtCodeReservCancel.TextLength == 0)
            {
                MessageBox.Show("Falta de escribir el codigo de reservación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dateValidFuture(dtpDateCancel.Value.Date) == false)
            {
                MessageBox.Show("Fecha no valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtCodeReservCancel_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(e); 
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

    }
}
