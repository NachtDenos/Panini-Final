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
    public partial class SalesReportScreen : Form
    {

        EnlaceCassandra cass = new EnlaceCassandra();
        public SalesReportScreen()
        {
            InitializeComponent();
        }

        private void txtCustomerHistory_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyLetters(e);
        }

        private void txtYearHistory_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(e);
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

        private void btnCustomerHistory_Click(object sender, EventArgs e)
        {
            dataGridHistoryReport.DataSource = cass.obtReporteHistorialEmail(txtCustomerHistory.Text);
        }

        private void btnYearHistory_Click(object sender, EventArgs e)
        {

        }
    }
}
