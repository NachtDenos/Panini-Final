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
    public partial class SalesScreen : Form
    {
        
       
        public SalesScreen()
        {
            InitializeComponent();
           
        }

        private void btnQuickSearchSales_Click(object sender, EventArgs e)
        {
            QuickSearchScreen TheOtherForm = new QuickSearchScreen();
            TheOtherForm.ShowDialog();
        }

        private void btnPaySales_Click(object sender, EventArgs e)
        {
           
            WaytoPayScreen TheOtherForm = new WaytoPayScreen();
            TheOtherForm.ShowDialog();
        }

        private void txtQuantitySales_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
        }

        public bool onlyNumbers(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan números en este campo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return false;
            }
            return true;
        }

        private void txtQuantityDeleteSales_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
        }

        private void btnAddSales_Click(object sender, EventArgs e)
        {
            
           
        }

        private void btnDeleteSales_Click(object sender, EventArgs e)
        {
           
        }

        private void txtNumberSales_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan números en este campo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void dataGridProductSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        //Hacer que lo que seleccione al datagrid sea lo que se meta a la tabla temporal,
        //Ya sabes como es el datgriceelclick, obtener lo seleccionado de esa celda y con eso nada mas le decimos que cuanta cantidad y ya
        private void btnFilterSales_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridCarritoSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridCarritoSales_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
           
        }

        private void btnAddEmployees_Click(object sender, EventArgs e)
        {
            QuickSearchScreen TheOtherForm = new QuickSearchScreen();
            TheOtherForm.ShowDialog();
        }
    }
}
