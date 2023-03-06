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
        int ComboBoxIndex;
        bool IsSelected;
        public string prueba;
        string claveUserAux;
        public CashRegisterToUseWND()
        {
            InitializeComponent();
            ListarCajasCombo();
            RegisterToUseCB.Text = "Seleccionar";
        }

        public CashRegisterToUseWND(string claveUser)
        {
            InitializeComponent();
            ListarCajasCombo();
            RegisterToUseCB.Text = "Seleccionar";
            claveUserAux = claveUser;
            ponerNombreCajero(claveUser);
            ponerIdCajeroActual(claveUser);
        }

        private void CloseRegisterToUserWnd_Click(object sender, EventArgs e)
        {
            //var dialog = new DialogResult();
            this.Close();
            //dialog = MessageBox.Show("")
        }

        private void RegisterToUseCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxIndex = RegisterToUseCB.SelectedIndex;
            IsSelected = true;
        }

        private void GoToSellerScreenbUTTN_Click(object sender, EventArgs e)
        {
            
            if (IsSelected == false)
            {
                MessageBox.Show("No ha seleccionado una caja en la cual cobrar", "Elija una caja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (IsSelected == true)
            {
                string prueba = dtpCajaCobro.Text;
                string cajaString = RegisterToUseCB.Text;
                string nameCajero = cbNombreCajero.Text;
                int idCajeroActual = Int32.Parse(cbIdCajero.Text);
                Pantallas.CashierMainScreen cashierMainScreen = new Pantallas.CashierMainScreen(prueba, cajaString, claveUserAux, nameCajero, idCajeroActual);
                this.Hide();
                cashierMainScreen.ShowDialog();
                this.Show();
            }

        }
        private void ListarCajasCombo()
        {
            Procedures usuarioObj = new Procedures();
            RegisterToUseCB.DataSource = usuarioObj.ListarCajaCombo();
            RegisterToUseCB.DisplayMember = "Numero de Caja"; //Nombre
            RegisterToUseCB.ValueMember = "Numero de Caja";//Valor real de l combox
        }

        private void ponerNombreCajero(string claveUserActual)
        {
            Procedures usuarioObj = new Procedures();
            cbNombreCajero.DataSource = usuarioObj.obtenerCajeroCobra(claveUserActual);
            cbNombreCajero.DisplayMember = "Nombre"; //Nombre
            cbNombreCajero.ValueMember = "idEmpleado";
        }

        private void ponerIdCajeroActual(string claveUserActual)
        {
            Procedures usuarioObj = new Procedures();
            cbIdCajero.DataSource = usuarioObj.obtenerCajeroCobra(claveUserActual);
            cbIdCajero.DisplayMember = "idEmpleado";
            cbIdCajero.ValueMember = "idEmpleado";
        }

    }
}
