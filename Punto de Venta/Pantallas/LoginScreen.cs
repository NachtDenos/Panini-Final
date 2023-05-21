using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

using Punto_de_Venta;
using System.Data.SqlTypes;


namespace Punto_de_Venta
{
    public partial class LoginScreenWnD : Form
    {
        int indexBox;
        bool selection = false;
        EnlaceCassandra cass = new EnlaceCassandra();
        public LoginScreenWnD()
        {
            InitializeComponent();
        }
        private void LoginScreenWnd_Load(object sender, EventArgs e)
        {
            cass.ObtenerUsuarios();
        }

        private void LoginScreenWnD_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void comboBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexBox = cbUserLogin.SelectedIndex;
            selection = true;
        }

        private void LoginSQLbutton_Click(object sender, EventArgs e)
        {
            if (selection == false)
                MessageBox.Show("No seleccionó su puesto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //Empleado
                if (indexBox == 1)
                {
                    // int claveUserI = Int32.Parse(UserNameSQLSideTextBox.Text);
                    if (cass.login2(txtUserNameLogin.Text, txtPassLogin.Text))
                    {
                        Pantallas.UserrMainScreen cashierMainScreen = new Pantallas.UserrMainScreen();
                        this.Hide();
                        cashierMainScreen.ShowDialog();
                        this.Show();
                    }
                }
                if (indexBox == 0)
                {
                    //Administrador
                    if (cass.login(txtUserNameLogin.Text, txtPassLogin.Text, indexBox))
                    {
                        Pantallas.MainAdminScreen TheOtherForm = new Pantallas.MainAdminScreen();
                        this.Hide();
                        TheOtherForm.ShowDialog();
                        this.Show();
                    }
                }
            }
        }
    }
}

