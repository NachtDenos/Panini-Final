using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Punto_de_Venta.DatabaseBool;

namespace Punto_de_Venta
{
    public partial class DataBaseSelectionForm : Form
    {
        public DataBaseSelectionForm()
        {
            InitializeComponent();
        }
        public bool isSQL = false;
        private void SQLserverDBbuttonProject_Click(object sender, EventArgs e)
        {

            LoginScreenWnD TheOtherForm = new LoginScreenWnD();
            DatabaseBool.IsSQl = true;
            //isSQL = true;
            this.Hide();
            TheOtherForm.ShowDialog();
            //Esta parte del This.Show se encarga de cuando la forma2 se cierre regrese y muestra la forma 1 o la que sea antes o yo especifico
            this.Show();
            //El admin puede crear mas cajas
           
        }
        //Checa en tus fotos para el cerrar o abrir mediante un show dialog

        private void DataBaseSelectionForm_Load(object sender, EventArgs e)
        {
           
        }

        private void DataBaseSelectionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //SAle de la aplicacion y termina de ejecutarse
            Application.Exit();
        }

        private void CassandraDBProjectButton_Click(object sender, EventArgs e)
        {
            
            LoginScreenWnD TheOtherForm = new LoginScreenWnD();
            DatabaseBool.IsSQl = false;
            isSQL = false;
            this.Hide();
            TheOtherForm.ShowDialog();
            //Esta parte del This.Show se encarga de cuando la forma2 se cierre regrese y muestra la forma 1 o la que sea antes o yo especifico
            this.Show();
            //El admin puede crear mas cajas
        }
    }
}
