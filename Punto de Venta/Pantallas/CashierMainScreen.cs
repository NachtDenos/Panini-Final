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


namespace Punto_de_Venta.Pantallas
{

    public partial class CashierMainScreen : Form 
    {
        
        int idCajeroAux;
        
        //DE SUGERENCIA, EL CLIENTE SI PAGA CON MAS DINERO DE LO NORMAL, SE LE DEBE REGRESAR CAMBIO EN EL CASO DE QUE ESTE APLIUE
        //UTILIDAD: Costo - Precio Unitario
        //Producto-----> codigo y su descripcion
        //Antes de pagar el cliente puede cancelar un producto
        public CashierMainScreen()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            //meter un Form dentro de otro Form
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildFormSales.Controls.Add(childForm);
            panelChildFormSales.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSales_Click(object sender, EventArgs e)
        {
            openChildForm(new SalesScreen());
        }








    }
}
