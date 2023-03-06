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
using static Punto_de_Venta.DatabaseBool;

namespace Punto_de_Venta.Pantallas
{

    public partial class CashierMainScreen : Form 
    {
        VentasTemp instancia = new VentasTemp();
        int idCajeroAux;
        Procedures proc = new Procedures();
        //DE SUGERENCIA, EL CLIENTE SI PAGA CON MAS DINERO DE LO NORMAL, SE LE DEBE REGRESAR CAMBIO EN EL CASO DE QUE ESTE APLIUE
        //UTILIDAD: Costo - Precio Unitario
        //Producto-----> codigo y su descripcion
        //Antes de pagar el cliente puede cancelar un producto
        public CashierMainScreen()
        {
            InitializeComponent();
        }
        public CashierMainScreen(string text, string caja, string claveUserActual, string nombreCajero, int idCajeroActual)
        {
            InitializeComponent();
            labelDate.Text = text;
            labelIdCashRegister.Text = caja;
            labelNamePerson.Text = nombreCajero;
            int cajita;
            idCajeroAux = idCajeroActual;
            Int32.TryParse(caja, out cajita);
            instancia.Caja = cajita;
            DateTime Fecha = DateTime.Parse(labelDate.Text);
            instancia.fecha = Fecha;
        }
        string Hora = DateTime.Now.ToString();
        string Fecha = DateTime.Now.ToString();
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
            var limpia = proc.limpiarVentaTemporal();
            this.Close();
        }

        private void buttonSales_Click(object sender, EventArgs e)
        {
            openChildForm(new SalesScreen(labelDate.Text, labelIdCashRegister.Text, labelNamePerson.Text, idCajeroAux));
            var limpia = proc.limpiarVentaTemporal();
            //Mandar aqui este pedo
        }

        private void panelChildFormSales_Paint(object sender, PaintEventArgs e)
        {

        }
        private void CashierMainScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            labelHour.Text = Hora;
        }
        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    //Despues de inicializar el timer, mediante los ticks lo seteo en un labl y este se encarga de desplegar la hr actual
        //    label12.Text = DateTime.Now.ToLongDateString();
        //}

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
            //labelDate.Text = DateTime.Now.ToShortDateString().ToUpper();
            //label9.Text = DateTime.Now.ToShortDateString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            labelHour.Text = DateTime.Now.ToShortTimeString();
        }

    }
}
