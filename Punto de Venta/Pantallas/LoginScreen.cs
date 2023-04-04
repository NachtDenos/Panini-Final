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
        
        public LoginScreenWnD()
        {
            InitializeComponent();
        }
        private void LoginScreenWnd_Load(object sender, EventArgs e)
        { 

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
                if (indexBox == 1)
                {
                    // int claveUserI = Int32.Parse(UserNameSQLSideTextBox.Text);
                    Pantallas.UserrMainScreen cashierMainScreen = new Pantallas.UserrMainScreen();
                    this.Hide();
                    cashierMainScreen.ShowDialog();
                    this.Show();
                }
                if (indexBox == 0)
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

