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
        Procedures proc = new Procedures();
        string numeroCaja;
        bool bandera;
        float montodePago;
        int metPago;
        float total;
        string nombreCajero;
        int idCajero;
        float totalaux;
        bool Credito = false;
        string Cred;
        bool Debito = false;
        string Deb;
        bool Efectivo = false;
        string Efec;
        bool Cheques = false;
        string Cheq;
        bool Vales = false;
        string val;
        bool otro = false;
        string otr;
        string Fecha;
        string FreakingCash;
        int CantidadMetodosActivos;
        float monto1;
        float monto2;
        float pasarTotal;
        int MetodoPago1de2;
        int MetodoPago2de2;
        DateTime fechaa;
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
        public WaytoPayScreen(string Total, string lblPapito, string fecha, string NumCaja, string cajeroNombre, int idCajeroActual)
        {
            InitializeComponent();
            txtCreditCardPay.Enabled = false;
            txtCashPay.Enabled = false;
            txtVoucherPay.Enabled = false;
            txtDebitCardPay.Enabled = false;
            
            totalblwaytopay.Text = lblPapito;
            txtCheckPay.Enabled = false;
            txtOtherPay.Enabled = false;
            Fecha = fecha;
            FreakingCash = NumCaja;
            nombreCajero = cajeroNombre;
            idCajero = idCajeroActual;
            //dataGridWayToPay.Rows[0].Cells[0].Value = "B312";
            //dataGridWayToPay.Rows[0].Cells[1].Value = "Jamón";
            //dataGridWayToPay.Rows[0].Cells[2].Value = "30.00";
            //dataGridWayToPay.Rows[0].Cells[3].Value = "2";
            //dataGridWayToPay.Rows[0].Cells[4].Value = "0.00";
            //dataGridWayToPay.Rows[0].Cells[5].Value = "60.00";

        }

        private void onePoint(KeyPressEventArgs e, String cadena)
        {
            int cont = 0;
            String caracter = "";
            for (int i = 0; i < cadena.Length; i++)
            {
                caracter = cadena.Substring(i, 1);
                if (caracter == ".")
                {
                    cont++;
                }
            }
            if (cont == 0)
            {
                bandera = true;
                if (e.KeyChar.ToString().Equals(".") && bandera)
                {
                    bandera = false;
                    e.Handled = false;
                }
                else if (Char.IsDigit(e.KeyChar))
                    e.Handled = false;
                else if (Char.IsControl(e.KeyChar))
                    e.Handled = false;
                else
                    e.Handled = true;
            }
            else
            {
                bandera = false;
                e.Handled = true;
                if (Char.IsDigit(e.KeyChar))
                    e.Handled = false;
                else if (Char.IsControl(e.KeyChar))
                    e.Handled = false;
                else
                    e.Handled = true;
            }
        }

        public bool onlyNumbers(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan números en este campo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return false;
            }
            return true;
        }
        #region NUMEROS
        private void txtCreditCardPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            onePoint(e, txtCreditCardPay.Text);
           // onlyNumbers(sender, e);
        }
        private void txtCashPay_KeyPress(object sender, KeyPressEventArgs e)
        {
          //  onlyNumbers(sender, e);
            onePoint(e, txtCashPay.Text);
        }
        private void txtVoucherPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            onePoint(e, txtVoucherPay.Text);
           // onlyNumbers(sender, e);
        }
        private void txtDebitCardPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            //onlyNumbers(sender, e);
            onePoint(e, txtDebitCardPay.Text);
        }
        private void txtCheckPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            onePoint(e, txtCheckPay.Text);
            //onlyNumbers(sender, e);
        }
        private void txtOtherPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            onePoint(e, txtOtherPay.Text);
           // onlyNumbers(sender, e);
        }
        #endregion NUMEROS

        #region MetodosDePago
        private void rbCreditCardPay_Click(object sender, EventArgs e)
        {
            if (txtCreditCardPay.Enabled == false)
            {
                txtCreditCardPay.Enabled = true;
                Credito = true;
            }
            else if (txtCreditCardPay.Enabled == true)
            {
                txtCreditCardPay.Enabled = false;
                txtCreditCardPay.Text = "";
            }
        }
        private void rbCashPay_Click(object sender, EventArgs e)
        {
            if (txtCashPay.Enabled == false)
            {
                txtCashPay.Enabled = true;
                Efectivo = true;
            }
            else if (txtCashPay.Enabled == true)
            {
                txtCashPay.Enabled = false;
                txtCashPay.Text = "";
            }
        }
        private void rbVouchersPay_Click(object sender, EventArgs e)
        {
            if (txtVoucherPay.Enabled == false)
            {
                txtVoucherPay.Enabled = true;
                Vales = true;
            }
            else if (txtVoucherPay.Enabled == true)
            {
                txtVoucherPay.Enabled = false;
                txtVoucherPay.Text = "";
            }
        }
        private void rbDebitCardPay_Click(object sender, EventArgs e)
        {
            if (txtDebitCardPay.Enabled == false)
            {
                txtDebitCardPay.Enabled = true;
                Debito = true;
            }
            else if (txtDebitCardPay.Enabled == true)
            {
                txtDebitCardPay.Enabled = false;
                txtDebitCardPay.Text = "";
            }
        }
        private void rbCheckPay_Click(object sender, EventArgs e)
        {
            if (txtCheckPay.Enabled == false)
            {
                txtCheckPay.Enabled = true;
                Cheques = true;
            }
            else if (txtCheckPay.Enabled == true)
            {
                txtCheckPay.Enabled = false;
                txtCheckPay.Text = "";
            }
        }
        private void rbOtherPay_Click(object sender, EventArgs e)
        {
            if (txtOtherPay.Enabled == false)
            {
                txtOtherPay.Enabled = true;
                otro = true;
            }
            else if (txtOtherPay.Enabled == true)
            {
                txtOtherPay.Enabled = false;
                txtOtherPay.Text = "";
            }
        }
        #endregion MetodosDePago

        #region FuncionesForms
        private void WaytoPayScreen_Load(object sender, EventArgs e)
        {
            dataGridWayToPay.DataSource = proc.ListarCarritoCompraPagar();
            dataGridWayToPay.Columns["Precio"].DefaultCellStyle.Format = "C2";
            dataGridWayToPay.Columns["Subtotal"].DefaultCellStyle.Format = "C2";
            if (dataGridWayToPay.Rows.Count > 0)
            {
                foreach (DataGridViewRow fila in dataGridWayToPay.Rows)
                {
                    fila.Cells["Precio"].Value.ToString();
                  
                    string totalstring;
                    float subtotal;
                    string precioUni;
                    float precioU;
                    int CANTLLEVAR;
                    string descuento;
                    float desc;
                      precioUni = fila.Cells["Precio"].Value.ToString();
                      CANTLLEVAR = (int)fila.Cells["A llevar"].Value;
                      
                    if (fila.Cells["Descuento"].Value.ToString() == string.Empty)
                    {
                        fila.Cells["Descuento"].Value = "0";
                        float.TryParse(precioUni, out precioU);
                        subtotal = precioU * CANTLLEVAR;
                        fila.Cells["Subtotal"].Value = subtotal;
                    }
                    else
                    {
                        
                        descuento = fila.Cells["Descuento"].Value.ToString();
                        float.TryParse(descuento, out desc);
                        desc = desc / 100.00f;
                        float.TryParse(precioUni, out precioU);
                        precioU = precioU * desc;
                        subtotal = precioU * CANTLLEVAR;
                        fila.Cells["Subtotal"].Value = subtotal;
                    }
                    total = subtotal;
                    totalaux = total + totalaux;
                    total = totalaux;
                    
                }
                finalPaylbl.Text = "$ ";
                finalPaylbl.Text += total.ToString("N2");
                //dataGridWayToPay.Rows.Insert(0,"TOTALLLL");
            }
            pasarTotal = total;
        }

        private void btnPayPay_Click(object sender, EventArgs e)
        {

            string debitoS = txtDebitCardPay.Text;
            float debitoFl;
            float.TryParse(debitoS, out debitoFl);
            string creditoS = txtCreditCardPay.Text;
            float creditoFl;
            float.TryParse(creditoS, out creditoFl);
            string efectivoS = txtCashPay.Text;
            float efectivoFl;
            float.TryParse(efectivoS, out efectivoFl);
            string chequeS = txtCheckPay.Text;
            float chequeFl;
            float.TryParse(chequeS, out chequeFl);
            string valesS = txtVoucherPay.Text;
            float valeFl;
            float.TryParse(valesS, out valeFl);
            string otroS = txtOtherPay.Text;
            float otroFl;
            float.TryParse(otroS, out otroFl);

            float montoPagado = debitoFl + creditoFl + efectivoFl + chequeFl + valeFl + otroFl;
            if(montoPagado < pasarTotal)
            {
                MessageBox.Show("La cantidad no es la correcta a pagar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            fechaa = DateTime.Parse(Fecha);
            string NombreProd;
            string CajaNumeroGenVenta;
            int CajaNumeroGenVentaid;
            CajaNumeroGenVenta = FreakingCash;
            Int32.TryParse(CajaNumeroGenVenta,out  CajaNumeroGenVentaid);
             proc.GenerarVenta(fechaa, CajaNumeroGenVentaid, montoPagado, pasarTotal, nombreCajero, idCajero);
            foreach (DataGridViewRow fila in dataGridWayToPay.Rows)
            {
                string CajeroNombre;
                int CajerId = 0;
                string NombreProducto;
                string Codigito;
                string Subtotal;
                string UnidadesLlevar;
                string PrecioU;
                string Discount;
                float disNum;
                int CodFinal;
                NombreProducto = fila.Cells["Producto"].Value.ToString();
               // Codigito = fila.Cells["Codigo"].Value.ToString();
                Subtotal = fila.Cells["Subtotal"].Value.ToString();
                UnidadesLlevar = fila.Cells["A llevar"].Value.ToString();
                PrecioU = fila.Cells["Precio"].Value.ToString();

                float subFlot;
                float.TryParse(Subtotal, out subFlot);
                int MontoFinal;
                string MontoF = finalPaylbl.Text;
                Int32.TryParse(MontoF, out MontoFinal);
                float totalVenta;
                int NumCaja;
                string CAJANUM;
                CAJANUM = FreakingCash;
                Int32.TryParse(CAJANUM, out NumCaja);
                float PrecioUniDis;
                float Costo;
                string costoStingDtg;
                costoStingDtg = fila.Cells["Costo"].Value.ToString();
                float PrecioUni;
                //Int32.TryParse(Codigito, out CodFinal);
                
                //float.TryParse(PrecioU,out PrecioUni);
                float Utilidad;
                float UtilidadAux;
                float PrecioUniAux;
                int UnidadesVendidas; Int32.TryParse(UnidadesLlevar, out UnidadesVendidas);
                if (fila.Cells["Descuento"].Value.ToString() == "0")
                {
                    fila.Cells["Descuento"].Value = "0";
                    float.TryParse(PrecioU, out PrecioUni);
                    subFlot = PrecioUni * UnidadesVendidas;
                    float.TryParse(costoStingDtg,out Costo);
                    UtilidadAux = PrecioUni - Costo;
                    Utilidad = UtilidadAux;
                    totalVenta = subFlot;
                    //fila.Cells["Subtotal"].Value = subtotal;
                }
                else
                {

                    Discount = fila.Cells["Descuento"].Value.ToString();
                    float.TryParse(Discount, out disNum);
                    disNum = disNum / 100.00f;
                    float.TryParse(PrecioU, out PrecioUni);
                    float.TryParse(PrecioU, out PrecioUniAux);
                    float.TryParse(costoStingDtg, out Costo);
                    
                    PrecioUniDis = PrecioUni * disNum;
                    PrecioUni = PrecioUniAux;
                    subFlot = PrecioUni * UnidadesVendidas;
                    UtilidadAux = PrecioUni - Costo - PrecioUniDis;
                    Utilidad = UtilidadAux;
                    totalVenta = subFlot - PrecioUniDis;
                   // fila.Cells["Subtotal"].Value = subtotal;
                }
                proc.GenerarVentaDetalle(0,NombreProducto,UnidadesVendidas, subFlot, PrecioUni , totalVenta, Utilidad * UnidadesVendidas);
                proc.RestarStockVenta(NombreProducto, UnidadesVendidas);
                proc.aumentarCantVendida(NombreProducto, UnidadesVendidas);
                //proc.RealizarVentas(total, NombreProducto, fechaa, subFlot, montodePago
                //    , MontoFinal, metPago, 0, NumCaja, Persona, UnidadesVendidas, PrecioUni, 105.5f);
            }


            if (Debito == true)
            {
                proc.GenerarTicketDB(0, debitoFl, 1);
            }
            if (Credito == true)
            {
                proc.GenerarTicketDB(0, creditoFl, 0);
            }
            if (Efectivo == true)
            {
                proc.GenerarTicketDB(0, efectivoFl, 2);
            }
            if (Cheques == true)
            {
                proc.GenerarTicketDB(0, chequeFl, 3);
            }
            if (Vales == true)
            {
                proc.GenerarTicketDB(0, valeFl, 4);
            }
            if (otro == true)
            {
                proc.GenerarTicketDB(0, otroFl, 5);
            }

            for (int i = 0; i < CantidadMetodosActivos; i++)
            {
                proc.GenerarTicketDB(0, monto1, 0);
                //proc.GenerarTicketDB(0, monto2, 1);
            }

            if (MessageBox.Show("¿Quiere imprimir el ticket de compra?", "Ticket", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                imrprimirTicket(debitoFl, creditoFl, efectivoFl, chequeFl, valeFl, otroFl);
            }

            MessageBox.Show("Compra realizada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
            
        }
        #endregion FuncionesForms

        public void imrprimirTicket(float debitoFl, float creditoFl, float efectivoFl, float chequeFl, float valeFl, float otroFl)
        {
            var idTicketActual = proc.obtenerIdVenta();
            string idTickerStr = idTicketActual.ToString();
            string nameTicket = "Ticket " + idTickerStr + ".pdf";
            FileStream fs = new FileStream(@nameTicket, FileMode.Create);
            Document doc = new Document(PageSize.LETTER, 5, 5, 7, 7);
            PdfWriter pw = PdfWriter.GetInstance(doc, fs);
            doc.Open();
            //Definir la fuente
            iTextSharp.text.Font standarFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            iTextSharp.text.Font fuente2 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 15, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            //Encabezado
            doc.Add(new Paragraph("AXXA", fuente) { Alignment = Element.ALIGN_CENTER });
            doc.Add(new Paragraph("Ticket", fuente2) { Alignment = Element.ALIGN_CENTER });
            doc.Add(new Paragraph("PRODUCTOS DE CONTROL AXXA, S.L", standarFont) { Alignment = Element.ALIGN_CENTER });
            doc.Add(new Paragraph("Calle Janos. SantaClara", standarFont) { Alignment = Element.ALIGN_CENTER });
            doc.Add(new Paragraph("China, Nuevo León", standarFont) { Alignment = Element.ALIGN_CENTER });
            doc.Add(new Paragraph("67190", standarFont) { Alignment = Element.ALIGN_CENTER });
            doc.Add(new Paragraph("axxa@gmail.com", standarFont) { Alignment = Element.ALIGN_CENTER });
            doc.Add(new Paragraph("812 - 879 - 9540", standarFont) { Alignment = Element.ALIGN_CENTER });
            doc.Add(Chunk.NEWLINE);
            doc.Add(new Paragraph("No. TICKET:", standarFont) { Alignment = Element.ALIGN_CENTER });
            doc.Add(new Paragraph(idTickerStr, standarFont) { Alignment = Element.ALIGN_CENTER });
            doc.Add(new Paragraph("Fecha: ", standarFont) { Alignment = Element.ALIGN_CENTER });
            doc.Add(new Paragraph(Fecha, standarFont) { Alignment = Element.ALIGN_CENTER });
            doc.Add(Chunk.NEWLINE);
            //Encabezado de columnas
            PdfPTable tblEjemplo = new PdfPTable(5);
            tblEjemplo.WidthPercentage = 100;

            PdfPCell clNombre = new PdfPCell(new Phrase("Producto", standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clNombre.BorderWidth = 0;
            clNombre.BorderWidthBottom = 0.75f;

            PdfPCell clCant = new PdfPCell(new Phrase("Cantidad", standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clCant.BorderWidth = 0;
            clCant.BorderWidthBottom = 0.75f;

            PdfPCell clPrecio = new PdfPCell(new Phrase("Precio U.", standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clPrecio.BorderWidth = 0;
            clPrecio.BorderWidthBottom = 0.75f;

            PdfPCell clDesc = new PdfPCell(new Phrase("Descuento", standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clDesc.BorderWidth = 0;
            clDesc.BorderWidthBottom = 0.75f;

            PdfPCell clSubtotal = new PdfPCell(new Phrase("Subtotal", standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clSubtotal.BorderWidth = 0;
            clSubtotal.BorderWidthBottom = 0.75f;

            tblEjemplo.AddCell(clNombre);
            tblEjemplo.AddCell(clCant);
            tblEjemplo.AddCell(clPrecio);
            tblEjemplo.AddCell(clDesc);
            tblEjemplo.AddCell(clSubtotal);

            //AQUI HACER UN CICLO PARA AGREGAR LOS PRODUCTOS
            foreach (DataGridViewRow fila in dataGridWayToPay.Rows)
            {
                string NombreProducto;
                string Subtotal;
                string UnidadesLlevar;
                string PrecioU;
                string Discount;

                NombreProducto = fila.Cells["Producto"].Value.ToString();
                Subtotal = fila.Cells["Subtotal"].Value.ToString();
                UnidadesLlevar = fila.Cells["A llevar"].Value.ToString();
                PrecioU = fila.Cells["Precio"].Value.ToString();
                Discount = fila.Cells["Descuento"].Value.ToString();

                clNombre = new PdfPCell(new Phrase(NombreProducto, standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
                clNombre.BorderWidth = 0;

                clCant = new PdfPCell(new Phrase(UnidadesLlevar, standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
                clCant.BorderWidth = 0;

                clPrecio = new PdfPCell(new Phrase(PrecioU, standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
                clPrecio.BorderWidth = 0;

                clDesc = new PdfPCell(new Phrase(Discount, standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
                clDesc.BorderWidth = 0;

                clSubtotal = new PdfPCell(new Phrase(Subtotal, standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
                clSubtotal.BorderWidth = 0;

                tblEjemplo.AddCell(clNombre);
                tblEjemplo.AddCell(clCant);
                tblEjemplo.AddCell(clPrecio);
                tblEjemplo.AddCell(clDesc);
                tblEjemplo.AddCell(clSubtotal);
            }

            doc.Add(tblEjemplo);

            doc.Add(Chunk.NEWLINE);

            PdfPTable tblTotal = new PdfPTable(2);
            tblTotal.WidthPercentage = 100;

            PdfPCell clTotal = new PdfPCell(new Phrase("Total:", standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clTotal.BorderWidth = 0;
            clTotal.BorderWidthBottom = 0;
            string totalString = pasarTotal.ToString();
            PdfPCell clTotalCant = new PdfPCell(new Phrase(totalString, standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clTotalCant.BorderWidth = 0;
            clTotalCant.BorderWidthBottom = 0;

            tblTotal.AddCell(clTotal);
            tblTotal.AddCell(clTotalCant);

            doc.Add(tblTotal);

            doc.Add(Chunk.NEWLINE);

            PdfPTable tblMetodoPago = new PdfPTable(2);
            tblMetodoPago.WidthPercentage = 100;

            PdfPCell clNombreMP = new PdfPCell(new Phrase("FORMAS DE PAGO", standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clNombreMP.BorderWidth = 0;
            clNombreMP.BorderWidthBottom = 0;

            PdfPCell clCantMP = new PdfPCell(new Phrase("Cantidad Pagada", standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clCantMP.BorderWidth = 0;
            clCantMP.BorderWidthBottom = 0;

            tblMetodoPago.AddCell(clNombreMP);
            tblMetodoPago.AddCell(clCantMP);
            string cantiPagada = "0.0";
            clNombreMP = new PdfPCell(new Phrase("Tarjeta de Credito", standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clNombreMP.BorderWidth = 0;
            string creditoStr = creditoFl.ToString();
            clCantMP = new PdfPCell(new Phrase(creditoStr, standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clCantMP.BorderWidth = 0;
            tblMetodoPago.AddCell(clNombreMP);
            tblMetodoPago.AddCell(clCantMP);
            
            clNombreMP = new PdfPCell(new Phrase("Tarjeta Debito", standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clNombreMP.BorderWidth = 0;
            string debitoStr = debitoFl.ToString();
            clCantMP = new PdfPCell(new Phrase(debitoStr, standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clCantMP.BorderWidth = 0;
            tblMetodoPago.AddCell(clNombreMP);
            tblMetodoPago.AddCell(clCantMP);

            clNombreMP = new PdfPCell(new Phrase("Efectivo", standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clNombreMP.BorderWidth = 0;
            string efectivoStr = efectivoFl.ToString();
            clCantMP = new PdfPCell(new Phrase(efectivoStr, standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clCantMP.BorderWidth = 0;
            tblMetodoPago.AddCell(clNombreMP);
            tblMetodoPago.AddCell(clCantMP);
            
            clNombreMP = new PdfPCell(new Phrase("Cheque", standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clNombreMP.BorderWidth = 0;
            string chequeStr = chequeFl.ToString();
            clCantMP = new PdfPCell(new Phrase(chequeStr, standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clCantMP.BorderWidth = 0;
            tblMetodoPago.AddCell(clNombreMP);
            tblMetodoPago.AddCell(clCantMP);

            clNombreMP = new PdfPCell(new Phrase("Vales", standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clNombreMP.BorderWidth = 0;
            string valeStr = valeFl.ToString();
            clCantMP = new PdfPCell(new Phrase(valeStr, standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clCantMP.BorderWidth = 0;
            tblMetodoPago.AddCell(clNombreMP);
            tblMetodoPago.AddCell(clCantMP);

            clNombreMP = new PdfPCell(new Phrase("Otro", standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clNombreMP.BorderWidth = 0;
            string otroStr = otroFl.ToString();
            clCantMP = new PdfPCell(new Phrase(otroStr, standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clCantMP.BorderWidth = 0;
            tblMetodoPago.AddCell(clNombreMP);
            tblMetodoPago.AddCell(clCantMP);

            doc.Add(tblMetodoPago);
            doc.Add(Chunk.NEWLINE);
            doc.Add(new Paragraph("Caja:", standarFont) { Alignment = Element.ALIGN_CENTER });
            doc.Add(new Paragraph(FreakingCash, standarFont) { Alignment = Element.ALIGN_CENTER });

            doc.Add(Chunk.NEWLINE);
            doc.Add(new Paragraph("GRACIAS POR TU COMPRA", standarFont) { Alignment = Element.ALIGN_CENTER });

            doc.Close();
            pw.Close();

            MessageBox.Show("Se imprimio el Ticket", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
