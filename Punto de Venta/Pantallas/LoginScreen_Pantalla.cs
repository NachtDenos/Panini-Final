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
using static Punto_de_Venta.DatabaseBool;
using Punto_de_Venta;
using System.Data.SqlTypes;

namespace Punto_de_Venta
{
    public partial class LoginScreenWnD : Form
    {
        string UserTextHolder;
        string PasswordTextHolder;
        int indexBox;
        bool selection = false;
        
        public LoginScreenWnD()
        {
            InitializeComponent();
        }
        int dummy = -1;
        private void LoginScreenWnd_Load(object sender, EventArgs e)
        { 
            //borrar esta cosa
            if (IsSQl == true) //It seems to work
            {
                
                dummy = -1;
            }
            //UserTextHolder = " C117 ";
            //PasswordTextHolder = "123456";
            //UserNameSQLSideTextBox.Text = UserTextHolder;
            ////Crear un label dinamico que aparezca cuando pase el mouse o el textbox este seleccionado 
            //PassawordUSRsql.Text = PasswordTextHolder;
        }

        private void LoginScreenWnD_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void comboBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexBox = comboBoxUser.SelectedIndex;
            selection = true;
        }

        Procedures controles = new Procedures();

        private void LoginSQLbutton_Click(object sender, EventArgs e)
        {
            if (IsSQl == true)
            {
                if (selection == false)
                    MessageBox.Show("No seleccionó su puesto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {

          
                    if (indexBox == 1)
                    {
                        string Tipo = "0";
                        var result = controles.Login(UserNameSQLSideTextBox.Text, PassawordUSRsql.Text, Tipo);
                        if (result == true)
                        {
                           // int claveUserI = Int32.Parse(UserNameSQLSideTextBox.Text);
                            Pantallas.CashRegisterToUseWND theRegisterToUse = new Pantallas.CashRegisterToUseWND(UserNameSQLSideTextBox.Text);
                            this.Hide();
                            theRegisterToUse.ShowDialog();
                            this.Show();


                        }
                        else if (result == false)
                        {
                            MessageBox.Show("Credenciales de Cajero no validas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                      
                    }
                    if (indexBox == 0)
                    {
                        string TipoAdmin = "1";
                        


                        Usuario user = new Usuario();
                        user.Username = UserNameSQLSideTextBox.Text;
                        user.password = PassawordUSRsql.Text;
                        var result2 = controles.LoginAdministrador(user.Username, user.password, TipoAdmin);
                        if (result2 == true)
                        {
                            Pantallas.MainMenuAdmin TheOtherForm = new Pantallas.MainMenuAdmin();
                            this.Hide();
                            TheOtherForm.ShowDialog();
                            this.Show();
                        }
                        else if (result2 == false)
                        {
                            MessageBox.Show("Credenciales de Administrador no validas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }


                  
                }
            }
           
        }
    }
}

