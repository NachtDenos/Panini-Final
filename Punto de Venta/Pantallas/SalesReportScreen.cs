using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Punto_de_Venta.Clases;

namespace Punto_de_Venta
{
    public partial class ReturnScreen : Form
    {

        EnlaceCassandra cass = new EnlaceCassandra();

        public ReturnScreen()
        {
            InitializeComponent();
        }

        private void txtCountrySalesR_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyLetters(e);
        }

        private void txtYearSalesR_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(e);
        }

        private void txtCitySalesR_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnHotelReportSales_Click(object sender, EventArgs e)
        {
            dataGridSalesReport.DataSource = cass.obtReporteVentasNombre(txtHotelSalesR.Text);
        }

        private void btnCityReportSales_Click(object sender, EventArgs e)
        {
            dataGridSalesReport.DataSource = cass.obtReporteVentasCiudad(txtCitySalesR.Text);
        }

        private void btnCountryReportSales_Click(object sender, EventArgs e)
        {
            dataGridSalesReport.DataSource = cass.obtReporteVentasPais(txtCountrySalesR.Text);
        }

        private void btnYearReportSales_Click(object sender, EventArgs e)
        {
            dataGridSalesReport.DataSource = cass.obtReporteVentasAnio(txtYearSalesR.Text);
        }
    }
}
