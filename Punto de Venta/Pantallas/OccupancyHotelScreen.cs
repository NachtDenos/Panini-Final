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
        EnlaceCassandra cass = new EnlaceCassandra();
        public CashRegisterScreen()
        {
            InitializeComponent();
        }

        private void txtCountryOccupancy_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyLetters(e);
        }

        private void txtYearOccupancy_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(e);
        }

        private void txtCityOccupancy_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyLetters(e);
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

        private void btnHotelOcup_Click(object sender, EventArgs e)
        {
            dataGridOccupancyReport.DataSource = cass.obtReporteOcupacionhotel(txtHotelOccupancy.Text);
            dataGridOccupancyReport2.DataSource = cass.obtReporteOcupacionhotel2(txtHotelOccupancy.Text);
        }

        private void btnCityOcup_Click(object sender, EventArgs e)
        {
            dataGridOccupancyReport.DataSource = cass.obtReporteOcupacionciudad(txtCityOccupancy.Text);
            dataGridOccupancyReport2.DataSource = cass.obtReporteOcupacionciudad2(txtCityOccupancy.Text);
        }

        private void btnYearOcup_Click(object sender, EventArgs e)
        {
            dataGridOccupancyReport.DataSource = cass.obtReporteOcupacionanio(txtYearOccupancy.Text);
            dataGridOccupancyReport2.DataSource = cass.obtReporteOcupacionanio2(txtYearOccupancy.Text);
        }

        private void btnCountryOcup_Click(object sender, EventArgs e)
        {
            dataGridOccupancyReport.DataSource = cass.obtReporteOcupacionpais(txtCountryOccupancy.Text);
            dataGridOccupancyReport2.DataSource = cass.obtReporteOcupacionpais2(txtCountryOccupancy.Text);
        }
    }
}
