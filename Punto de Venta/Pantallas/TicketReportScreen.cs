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
    public partial class TicketReportScreen : Form
    {
        Procedures proc = new Procedures();
        public TicketReportScreen()
        {
            InitializeComponent();
            ListarCajasCombo();
            txtIdTicketReportRecibo.Enabled = false;
            btnConsultTicketReportRecibo.Enabled = false;
            btnReprintTicketRecibo.Enabled = false;
            txtIdTicketReportNota.Enabled = false;
            btnConsultTicketReportNota.Enabled = false;
            btnReprintTicketNota.Enabled = false;
        }

        private void btnConsultTicketReport2_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultTicketReport1_Click(object sender, EventArgs e)
        {
            string numTicket;

            numTicket = txtIdTicketReportRecibo.Text;
            int ticket;
            Int32.TryParse(numTicket, out ticket);
            dataGridTicketReport.DataSource = proc.ObtenerTicket(ticket);
        }

        private void txtIdTicketReport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan números en este campo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void ListarCajasCombo()
        {
            Procedures usuarioObj = new Procedures();
            cbTicketReport.DataSource = usuarioObj.ListarCajaCombo();
            cbTicketReport.DisplayMember = "Numero de Caja"; //Nombre
            cbTicketReport.ValueMember = "Numero de Caja";//Valor real de l combox
        }

        private void TicketReportScreen_Load(object sender, EventArgs e)
        {

        }

        private void cbTicketReport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpTicketReport_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbNota_Click(object sender, EventArgs e)
        {
            if (txtIdTicketReportNota.Enabled == false)
            {
                txtIdTicketReportNota.Enabled = true;
                btnConsultTicketReportNota.Enabled = true;
                btnReprintTicketNota.Enabled = true;
                cbRecibo.Enabled = false;

            }
            else if (txtIdTicketReportNota.Enabled == true)
            {
                txtIdTicketReportNota.Enabled = false;
                btnConsultTicketReportNota.Enabled = false;
                btnReprintTicketNota.Enabled = false;
                cbRecibo.Enabled = true;
            }
        }

        private void cbRecibo_Click(object sender, EventArgs e)
        {
            if (txtIdTicketReportRecibo.Enabled == false)
            {
                txtIdTicketReportRecibo.Enabled = true;
                btnConsultTicketReportRecibo.Enabled = true;
                btnReprintTicketRecibo.Enabled = true;
                cbNota.Enabled = false;

            }
            else if (txtIdTicketReportRecibo.Enabled == true)
            {
                txtIdTicketReportRecibo.Enabled = false;
                btnConsultTicketReportRecibo.Enabled = false;
                btnReprintTicketRecibo.Enabled = false;
                cbNota.Enabled = true;
            }
        }

        private void btnConsultTicketReportNota_Click(object sender, EventArgs e)
        {
            string numTicket;
            numTicket = txtIdTicketReportNota.Text;
            int ticket;
            Int32.TryParse(numTicket, out ticket);
            dataGridTicketReport.DataSource = proc.ObtenerNota(ticket);
        }

        private void btnReprintTicketRecibo_Click(object sender, EventArgs e)
        {

        }

        private void btnReprintTicketNota_Click(object sender, EventArgs e)
        {

        }
    }
}
