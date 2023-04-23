using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Punto_de_Venta
{
    public partial class TicketReportScreen : Form
    {
       
        public TicketReportScreen()
        {
            InitializeComponent();
            
        }

        private void btnActiveUser_Click(object sender, EventArgs e)
        {
            //TODO: validacion para seleccionar en el dataGrid desactivando el boton
            if (correctPass(txtPassTempActive.Text) == false)
            {
                MessageBox.Show("La contraseña tiene que tener 8 caracteres, mayusculas, minusculas, numeros y un caracter especial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Se asigno la contraseña temporal.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private bool correctPass(string pass)
        {
            bool mayus = false, min = false, number = false, charaE = false;
            for (int i = 0; i < pass.Length; i++)
            {
                if (Char.IsUpper(pass, i))
                    mayus = true;
                else if (Char.IsLower(pass, i))
                    min = true;
                else if (Char.IsDigit(pass, i))
                    number = true;
                else
                    charaE = true;
            }
            if (mayus && min && number && charaE && pass.Length >= 8)
                return true;
            return false; 
        }

    }
}
