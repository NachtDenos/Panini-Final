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
    public partial class CashRegisterToUseWND : Form
    {
        public string prueba;
        public CashRegisterToUseWND()
        {
            InitializeComponent();
            RegisterToUseCB.Text = "Seleccionar";
        }

        private void CloseRegisterToUserWnd_Click(object sender, EventArgs e)
        {
            //var dialog = new DialogResult();
            this.Close();
            //dialog = MessageBox.Show("")
        }

        private void GoToSellerScreenbUTTN_Click_1(object sender, EventArgs e)
        {
            Pantallas.CashierMainScreen cashierMainScreen = new Pantallas.CashierMainScreen();
            this.Hide();
            cashierMainScreen.ShowDialog();
            this.Show();
        }
    }
}
