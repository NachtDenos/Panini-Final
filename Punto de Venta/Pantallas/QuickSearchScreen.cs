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
    public partial class QuickSearchScreen : Form
    {
        Procedures proc = new Procedures();
        public QuickSearchScreen()
        {
            InitializeComponent();
            dataGridQuickSearch.DataSource = proc.consultaRapida();
            //dataGridQuickSearch.Rows[0].Cells[0].Value = "B412";
            //dataGridQuickSearch.Rows[0].Cells[1].Value = "Salmón";
            //dataGridQuickSearch.Rows[0].Cells[2].Value = "60.00";
            //dataGridQuickSearch.Rows[0].Cells[3].Value = "15";
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

        private void btnFilterQuickSearch_Click(object sender, EventArgs e)
        {
            if(txtIdCashRegister.Text != "" && txtNameQuickSearch.Text != "")
            {
                int filtro = Int32.Parse(txtIdCashRegister.Text);
                dataGridQuickSearch.DataSource = proc.filtroConsultaRapida(filtro, txtNameQuickSearch.Text);
            }
            else if (txtIdCashRegister.Text == "" && txtNameQuickSearch.Text != "")
            {
                dataGridQuickSearch.DataSource = proc.filtroConsultaRapida(txtNameQuickSearch.Text);
            }
            else if (txtIdCashRegister.Text != "" && txtNameQuickSearch.Text == "")
            {
                int filtro = Int32.Parse(txtIdCashRegister.Text);
                dataGridQuickSearch.DataSource = proc.filtroConsultaRapida(filtro);
            }
            else
            {
                dataGridQuickSearch.DataSource = proc.consultaRapida();
            }
        }
    }
}
