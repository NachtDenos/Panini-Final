using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_Venta.Pantallas
{
    public partial class checkOutScreen : Form
    {
        public checkOutScreen()
        {
            InitializeComponent();
        }

        private void btnEditDepartament_Click(object sender, EventArgs e)
        {
            WaytoPayScreen TheOtherForm = new WaytoPayScreen();
            TheOtherForm.ShowDialog();
        }

        private void btnAddDepartament_Click(object sender, EventArgs e)
        {

        }
    }
}
