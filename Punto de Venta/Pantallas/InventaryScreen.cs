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
        Procedures proc = new Procedures();
        public InventaryScreen()
        {
            InitializeComponent();
            dataGridInventary.DataSource = proc.ListarInventario();
            //dataGridInventary.Rows[0].Cells[0].Value = "Mariscos";
            //dataGridInventary.Rows[0].Cells[1].Value = "Salmón";
            //dataGridInventary.Rows[0].Cells[2].Value = "kilogramos";
            //dataGridInventary.Rows[0].Cells[3].Value = "50.00";
            //dataGridInventary.Rows[0].Cells[4].Value = "60.00";
            //dataGridInventary.Rows[0].Cells[5].Value = "15";
            //dataGridInventary.Rows[0].Cells[6].Value = "40";
            //dataGridInventary.Rows[0].Cells[7].Value = "0";
        }

        private void txtInventaryExiste_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan números en este campo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtInventaryExiste_TextChanged(object sender, EventArgs e)
        {
            if(txtInventaryExiste.Text != "")
            {
                int filtro = Int32.Parse(txtInventaryExiste.Text);
                dataGridInventary.DataSource = proc.filtroExist(filtro);
            }
            else
            {
                dataGridInventary.DataSource = proc.ListarInventario();
            }
        }

        private void txtInventaryDepart_TextChanged(object sender, EventArgs e)
        {
            if (txtInventaryDepart.Text != "")
            {
                dataGridInventary.DataSource = proc.filtroDepaIn(txtInventaryDepart.Text);
            }
            else
            {
                dataGridInventary.DataSource = proc.ListarInventario();
            }
        }

        private void rdYesOutInventary_Click(object sender, EventArgs e)
        {
            if (rdNoOutInventary.Enabled == false)
            {
                rdNoOutInventary.Enabled = true;
                dataGridInventary.DataSource = proc.ListarInventario();
            }
            else
            {
                rdNoOutInventary.Enabled = false;
                dataGridInventary.DataSource = proc.filtroAgotado(0);
            }
        }

        private void rdNoOutInventary_Click(object sender, EventArgs e)
        {
            if (rdYesOutInventary.Enabled == false)
            {
                rdYesOutInventary.Enabled = true;
                dataGridInventary.DataSource = proc.ListarInventario();
            }
            else
            {
                rdYesOutInventary.Enabled = false;
                dataGridInventary.DataSource = proc.filtroAgotado(1);
            }
        }

        private void rdYesDecreaseInventary_Click(object sender, EventArgs e)
        {
            if (rdNoDecreaseInventary.Enabled == false)
            {
                rdNoDecreaseInventary.Enabled = true;
                dataGridInventary.DataSource = proc.ListarInventario();
            }
            else
            {
                rdNoDecreaseInventary.Enabled = false;
                dataGridInventary.DataSource = proc.filtroMerma(1);
            }
        }

        private void rdNoDecreaseInventary_Click(object sender, EventArgs e)
        {
            if (rdYesDecreaseInventary.Enabled == false)
            {
                rdYesDecreaseInventary.Enabled = true;
                dataGridInventary.DataSource = proc.ListarInventario();
            }
            else
            {
                rdYesDecreaseInventary.Enabled = false;
                dataGridInventary.DataSource = proc.filtroMerma(0);
            }
        }

        private void InventaryScreen_Load(object sender, EventArgs e)
        {
            dataGridInventary.Columns["Costo"].DefaultCellStyle.Format = "C2";
            dataGridInventary.Columns["Precio Unitario"].DefaultCellStyle.Format = "C2";
        }
    }
}
