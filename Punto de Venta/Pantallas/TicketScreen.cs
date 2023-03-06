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
    public partial class ticketScreen : Form
    {
        public ticketScreen()
        {
            InitializeComponent();
        }

        private void btnPrintTicket_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"Prueba.pdf", FileMode.Create);
            Document doc = new Document(PageSize.LETTER, 5, 5, 7, 7);
            PdfWriter pw = PdfWriter.GetInstance(doc, fs);
            doc.Open();

            //Definir la fuente
            iTextSharp.text.Font standarFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            iTextSharp.text.Font fuente2 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 15, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            //Encabezado
            doc.Add(new Paragraph("AXXA", fuente) {Alignment = Element.ALIGN_CENTER});
            doc.Add(new Paragraph("Ticket", fuente2) { Alignment = Element.ALIGN_CENTER });
            doc.Add(new Paragraph("PRODUCTOS DE CONTROL AXXA, S.L", standarFont) { Alignment = Element.ALIGN_CENTER });
            doc.Add(new Paragraph("Calle Janos. SantaClara", standarFont) { Alignment = Element.ALIGN_CENTER });
            doc.Add(new Paragraph("China, Nuevo León", standarFont) { Alignment = Element.ALIGN_CENTER });
            doc.Add(new Paragraph("67190", standarFont) { Alignment = Element.ALIGN_CENTER });
            doc.Add(new Paragraph("axxa@gmail.com", standarFont) { Alignment = Element.ALIGN_CENTER });
            doc.Add(new Paragraph("812 - 879 - 9540", standarFont) { Alignment = Element.ALIGN_CENTER });
            doc.Add(Chunk.NEWLINE);
            doc.Add(new Paragraph("No. TICKET:", standarFont) { Alignment = Element.ALIGN_CENTER });
            //AQUI PONER EL NUMERO DE TICKET
            doc.Add(new Paragraph("Fecha: ", standarFont) { Alignment = Element.ALIGN_CENTER });
            //AQUI PONER LA FECHA
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

            PdfPCell clPrecio = new PdfPCell(new Phrase("Precio U.", standarFont)) {HorizontalAlignment = Element.ALIGN_CENTER };
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
            doc.Add(tblEjemplo);

            doc.Add(Chunk.NEWLINE);

            PdfPTable tblTotal = new PdfPTable(2);
            tblTotal.WidthPercentage = 100;

            PdfPCell clTotal = new PdfPCell(new Phrase("Total:", standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clTotal.BorderWidth = 0;
            clTotal.BorderWidthBottom = 0;
            string totalInt = "0.0";
            PdfPCell clTotalCant = new PdfPCell(new Phrase(totalInt, standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
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
            clCantMP = new PdfPCell(new Phrase(cantiPagada, standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clCantMP.BorderWidth = 0;
            tblMetodoPago.AddCell(clNombreMP);
            tblMetodoPago.AddCell(clCantMP);

            clNombreMP = new PdfPCell(new Phrase("Tarjeta Debito", standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clNombreMP.BorderWidth = 0;
            clCantMP = new PdfPCell(new Phrase(cantiPagada, standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clCantMP.BorderWidth = 0;
            tblMetodoPago.AddCell(clNombreMP);
            tblMetodoPago.AddCell(clCantMP);

            clNombreMP = new PdfPCell(new Phrase("Efectivo", standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clNombreMP.BorderWidth = 0;
            clCantMP = new PdfPCell(new Phrase(cantiPagada, standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clCantMP.BorderWidth = 0;
            tblMetodoPago.AddCell(clNombreMP);
            tblMetodoPago.AddCell(clCantMP);

            clNombreMP = new PdfPCell(new Phrase("Cheque", standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clNombreMP.BorderWidth = 0;
            clCantMP = new PdfPCell(new Phrase(cantiPagada, standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clCantMP.BorderWidth = 0;
            tblMetodoPago.AddCell(clNombreMP);
            tblMetodoPago.AddCell(clCantMP);

            clNombreMP = new PdfPCell(new Phrase("Vales", standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clNombreMP.BorderWidth = 0;
            clCantMP = new PdfPCell(new Phrase(cantiPagada, standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clCantMP.BorderWidth = 0;
            tblMetodoPago.AddCell(clNombreMP);
            tblMetodoPago.AddCell(clCantMP);

            clNombreMP = new PdfPCell(new Phrase("Otro", standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clNombreMP.BorderWidth = 0;
            clCantMP = new PdfPCell(new Phrase(cantiPagada, standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clCantMP.BorderWidth = 0;
            tblMetodoPago.AddCell(clNombreMP);
            tblMetodoPago.AddCell(clCantMP);

            doc.Add(tblMetodoPago);
            doc.Add(Chunk.NEWLINE);
            doc.Add(new Paragraph("Caja:", standarFont) { Alignment = Element.ALIGN_CENTER });
            //Agregar aqui abajo la caja
            doc.Add(Chunk.NEWLINE);
            doc.Add(new Paragraph("GRACIAS POR TU COMPRA", standarFont) { Alignment = Element.ALIGN_CENTER });

            doc.Close();
            pw.Close();

            MessageBox.Show("Se imprimio el Ticket", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
