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
    public partial class SellerReportScreen : Form
    {
        Procedures proc = new Procedures();
        public SellerReportScreen()
        {
            InitializeComponent();
            dataGridSellerReport.DataSource = proc.listarRCajero();
            calculoParaVenta();
            //dataGridSellerReport.Rows[0].Cells[0].Value = "09/09/2022"; //
            //dataGridSellerReport.Rows[0].Cells[1].Value = "Juan"; //Juan
            //dataGridSellerReport.Rows[0].Cells[2].Value = "Mariscos";
            //dataGridSellerReport.Rows[0].Cells[3].Value = "13";
            //dataGridSellerReport.Rows[0].Cells[4].Value = "10.00";
            //dataGridSellerReport.Rows[0].Cells[5].Value = "20.00";
        }

        private void txtCasherReport_TextChanged(object sender, EventArgs e)
        {
            if (txtCasherReport.Text != "")
            {
                dataGridSellerReport.DataSource = proc.listarRCajeroCajero(txtCasherReport.Text);
            }
            else
            {
                dataGridSellerReport.DataSource = proc.listarRCajero();
            }
            calculoParaVenta();
        }

        private void txtDepaCasherReport_TextChanged(object sender, EventArgs e)
        {
            if (txtDepaCasherReport.Text != "")
            {
                dataGridSellerReport.DataSource = proc.listarRCajeroDepa(txtDepaCasherReport.Text);
            }
            else
            {
                dataGridSellerReport.DataSource = proc.listarRCajero();
            }
            calculoParaVenta();
        }

        private void btnFiltroFechaCajeros_Click(object sender, EventArgs e)
        {
            DateTime fecha1Str = DateTime.Parse(dtpSellerReport1.Text);
            DateTime fecha2Str = DateTime.Parse(dtpSellerReport2.Text);
            dataGridSellerReport.DataSource = proc.listarRCajeroFecha(fecha1Str, fecha2Str);
            calculoParaVenta();
        }

        private void SellerReportScreen_Load(object sender, EventArgs e)
        {
            dataGridSellerReport.Columns["Suma Venta"].DefaultCellStyle.Format = "C2";
            dataGridSellerReport.Columns["Utilidad"].DefaultCellStyle.Format = "C2";
        }

        private void calculoParaVenta()
        {
            float Venta = 0.0f;
            float ventaAux = 0.0f;
            string ventaStr;

            float Utilidad = 0.0f;
            float utilidadAux = 0.0f;
            string utilidadStr;
            foreach (DataGridViewRow fila in dataGridSellerReport.Rows)
            {

                ventaStr = fila.Cells["Suma Venta"].Value.ToString();
                Venta = float.Parse(ventaStr);
                ventaAux = Venta + ventaAux;

                utilidadStr = fila.Cells["Utilidad"].Value.ToString();
                Utilidad = float.Parse(utilidadStr);
                utilidadAux = Utilidad + utilidadAux;
            }

            lblUtilidadCajero.Text = "";
            lblUtilidadCajero.Text += "$ ";
            lblUtilidadCajero.Text += utilidadAux.ToString("N2");

            lblVentaCajero.Text = "";
            lblVentaCajero.Text += "$ ";
            lblVentaCajero.Text += ventaAux.ToString("N2");

        }

    }
}
