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
    public partial class WaytoPayScreen : Form
    {
      
        bool bandera;
        //public WaytoPayScreen()
        //{
        //    InitializeComponent();
        //    txtCreditCardPay.Enabled = false;
        //    txtCashPay.Enabled = false;
        //    txtVoucherPay.Enabled = false;
        //    txtDebitCardPay.Enabled = false;
        //    txtCheckPay.Enabled = false;
        //    txtOtherPay.Enabled = false;
        //    //dataGridWayToPay.Rows[0].Cells[0].Value = "B312";
        //    //dataGridWayToPay.Rows[0].Cells[1].Value = "Jamón";
        //    //dataGridWayToPay.Rows[0].Cells[2].Value = "30.00";
        //    //dataGridWayToPay.Rows[0].Cells[3].Value = "2";
        //    //dataGridWayToPay.Rows[0].Cells[4].Value = "0.00";
        //    //dataGridWayToPay.Rows[0].Cells[5].Value = "60.00";

        //}
        public WaytoPayScreen()
        {
            InitializeComponent();
            
        }
        #region NUMEROS
        private void txtCreditCardPay_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
        private void txtCashPay_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }
        private void txtVoucherPay_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }
        private void txtDebitCardPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        private void txtCheckPay_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
        private void txtOtherPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        #endregion NUMEROS

        #region MetodosDePago
        private void rbCreditCardPay_Click(object sender, EventArgs e)
        {
            
        }
        private void rbCashPay_Click(object sender, EventArgs e)
        {
           
        }
        private void rbVouchersPay_Click(object sender, EventArgs e)
        {
           
        }
        private void rbDebitCardPay_Click(object sender, EventArgs e)
        {
            
        }
        private void rbCheckPay_Click(object sender, EventArgs e)
        {
           
        }
        private void rbOtherPay_Click(object sender, EventArgs e)
        {
            
        }
        #endregion MetodosDePago

        #region FuncionesForms
        private void WaytoPayScreen_Load(object sender, EventArgs e)
        {
           
        }

        private void btnPayPay_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion FuncionesForms

        public void imrprimirTicket(float debitoFl, float creditoFl, float efectivoFl, float chequeFl, float valeFl, float otroFl)
        {
            
        }
    }
}
