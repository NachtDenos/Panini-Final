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
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Punto_de_Venta
{
    public partial class ReturnScreen : Form
    {
        bool boton1 = false, boton2 = false;
        int ticket;
        string ticketNota;
        float CostProducto;
        int CodProducto;
        int Aeliminar;
        int Seregreso;
        DateTime laFecha;
        string motivo;
        string NombreProduc;
        int mermacion;
        public ReturnScreen()
        {
            InitializeComponent();
        }

        private void btnOkReturn_Click(object sender, EventArgs e)
        {
           
        }

        private void txtIdReturn_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtQuantityReturn_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void dataGridReturn1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridReturn2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buttonEnableEdit(DataGridViewCellEventArgs e)
        {
           
        }

        private void rbYesReturn_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddReturn_Click(object sender, EventArgs e)
        {
           
        }

        private void filterBtnticket_Click(object sender, EventArgs e)
        {
            
        }

        private void ReturnScreen_Load(object sender, EventArgs e)
        {
           
        }

        private void rbNoReturn_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDeleteReturn_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
