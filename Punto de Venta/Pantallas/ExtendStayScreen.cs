using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace Punto_de_Venta
{
    public partial class WaytoPayScreen : Form
    {
        public WaytoPayScreen()
        {
            InitializeComponent();
        }
       
        private void btnPayPay_Click(object sender, EventArgs e)
        {
            if (txtPeopleExtend.TextLength == 0)
            {
                MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.Close();
        }

        private void btnAddRoomExtend_Click(object sender, EventArgs e)
        {
            DateTime fecha1 = dtpLodgingExtend.Value;
            DateTime fecha2 = dtpLodgingExtend2.Value;

            if (fecha1 == fecha2)
            {
                MessageBox.Show("Las fechas no pueden ser iguales", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(fecha1 > fecha2)
            {
                MessageBox.Show("La primer fecha no puede ser mayor que la segunda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
        }

        private void txtPeopleExtend_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(e);
        }

        private void onlyNumbers(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
