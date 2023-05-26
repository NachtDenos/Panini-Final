using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Punto_de_Venta.Clases;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;

namespace Punto_de_Venta.Pantallas
{
    public partial class checkOutScreen : Form
    {
        bool bandera;
        bool check1 = false;
        bool check2 = false;
        EnlaceCassandra cass = new EnlaceCassandra();
        ReservacionesDetalle reservationDetalle = new ReservacionesDetalle();
        Servicios serv = new Servicios();
        Ventas venta = new Ventas();
        Historial historia = new Historial();
        string personas;
        string precios;
        string serviciosS;
        float totalHospedaje = 0;
        float totalServicios = 0;
        float anticipo = 0;
        float total = 0;
        float aux = 0;
        string pagoGlobal = "";
        string metodoGlobal = "";
        bool debito;
        bool credito;
        bool puedePagar = false;
        int diasD;
        string nombreC, paisC, ciudadC, nombreClientC, apellPC, apellMC, fechaCIn, fechaReC, correoC;
        string tipoHabiTemp;
        string cantPersTemp;
        public checkOutScreen()
        {
            InitializeComponent();
            txtCreditCardCheckOut.Enabled = false;
            txtDebitCardCheckOut.Enabled = false;
            btnConfirmCheckOut.Enabled = false;
            btnConfirmServicesCheckOut.Enabled = false;
            dataGridServicesCheckOut.DataSource = cass.Obtener_servicios();
            btnSelectServicesCheckOut.Enabled = false;
            dataGridServicesCheckOut.Enabled = false;
        }

        private void btnEditDepartament_Click(object sender, EventArgs e)
        {
            //POR MIENTRAS
            //TODO: Esta cosa
            //WaytoPayScreen TheOtherForm = new WaytoPayScreen();
            //TheOtherForm.ShowDialog();
            MessageBox.Show("En proceso...", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSearchCheckOut_Click(object sender, EventArgs e)
        {
            if (txtCodeCheckOut.TextLength == 0)
            {
                MessageBox.Show("Falta de escribir el codigo de reservación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime fecha1;
            DateTime fecha2;
            TimeSpan diferencia;
            
            dataGridRoomsCheckOut.DataSource = cass.Obtener_reservacionesDetalle(txtCodeCheckOut.Text);
            cass.Obtener_reservaciones(txtCodeCheckOut.Text);

            List<Reservaciones> reservacionesRe = cass.Obtener_reservaciones(txtCodeCheckOut.Text);
            foreach (Reservaciones reservacionObt in reservacionesRe)
            {
                fecha1 = DateTime.Parse(reservacionObt.fechaInicial);
                fecha2 = DateTime.Parse(reservacionObt.fechaFinal);
                diferencia = fecha2 - fecha1;
                diasD = diferencia.Days; 
            }

            int hola = diasD;

            totalHospedaje = 0;
            totalServicios = 0;
            anticipo = 0;
            total = 0;
            aux = 0;
            foreach (DataGridViewRow row in dataGridRoomsCheckOut.Rows)
            {
                if (!row.IsNewRow)
                {
                    precios = row.Cells[3].Value.ToString();
                    float preciof = float.Parse(precios);
                    aux = diasD * preciof;
                    totalHospedaje = totalHospedaje + aux;
                }
            }
            List<Reservaciones> anticipoRe = cass.Obtener_reservaciones(txtCodeCheckOut.Text);
            foreach (Reservaciones habitacionObt in anticipoRe)
            {
                string anticipoString = habitacionObt.anticipo.ToString();
                anticipo = float.Parse(anticipoString);
            }

            total = totalHospedaje - anticipo;

            dataGridServicesCheckOut.Enabled = true;
            labelTotal.Text = total.ToString();
            labelAnticipo.Text = anticipo.ToString();
            labelHospedaje.Text = totalHospedaje.ToString();
            labelServices.Text = totalServicios.ToString();
            cass.limpiarServiciosTemporal();
            dataGridServices2CheckOut.DataSource = cass.Obtener_serviciosTemp();
            puedePagar = true;
        }

        private void onlyNumbers(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCodeCheckOut_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(e);
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

        private void txtCreditCardCheckOut_KeyPress(object sender, KeyPressEventArgs e)
        {
            onePoint(e, txtCreditCardCheckOut.Text);
        }

        private void txtDebitCardCheckOut_KeyPress(object sender, KeyPressEventArgs e)
        {
            onePoint(e, txtDebitCardCheckOut.Text);
        }

        private void rbCreditCardCheckOut_Click(object sender, EventArgs e)
        {
            if (txtCreditCardCheckOut.Enabled == false)
            {
                txtCreditCardCheckOut.Enabled = true;
                check1 = true;
                rbDebitCardCheckOut.Enabled = false;
                metodoGlobal = "Trajeta de Credito";
                credito = true;
            }
            else if (txtCreditCardCheckOut.Enabled == true)
            {
                txtCreditCardCheckOut.Enabled = false;
                txtCreditCardCheckOut.Text = "";
                check1 = false;
                rbDebitCardCheckOut.Enabled = true;
                credito = false;
            }
            checkButton();
        }

        private void rbDebitCardCheckOut_Click(object sender, EventArgs e)
        {
            if (txtDebitCardCheckOut.Enabled == false)
            {
                txtDebitCardCheckOut.Enabled = true;
                check2 = true;
                rbCreditCardCheckOut.Enabled = false;
                metodoGlobal = "Trajeta de Debito";
                debito = true;
            }
            else if (txtDebitCardCheckOut.Enabled == true)
            {
                txtDebitCardCheckOut.Enabled = false;
                txtDebitCardCheckOut.Text = "";
                check2 = false;
                rbCreditCardCheckOut.Enabled = true;
                debito = false;
            }
            checkButton();
        }

        private void checkButton()
        {
            if(check1 == true || check2 == true)
                btnConfirmCheckOut.Enabled = true;
            else
                btnConfirmCheckOut.Enabled = false; 
        }

        private void btnConfirmCheckOut_Click(object sender, EventArgs e)
        {
            if (puedePagar == false)
            {
                MessageBox.Show("Falta de seleccionar el codigo de reservación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (credito == true)
            {
                pagoGlobal = txtCreditCardCheckOut.Text;
            }
            if (debito == true)
            {
                pagoGlobal = txtDebitCardCheckOut.Text;
            }

            string totalPagarString = labelTotal.Text;
            float totalAPagar = float.Parse(totalPagarString);
            float pagof = float.Parse(pagoGlobal);
            if (totalAPagar > pagof || totalAPagar < pagof)
            {
                MessageBox.Show("Ingrese un monto valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<Reservaciones> reservacionesA = cass.Obtener_reservaciones(txtCodeCheckOut.Text);
            foreach (Reservaciones reservacionObt in reservacionesA)
            {
                nombreC = reservacionObt.hotel;
                ciudadC = reservacionObt.ciudad;
                nombreClientC = reservacionObt.nombreCliente;
                apellPC = reservacionObt.apellidoPCliente;
                apellMC = reservacionObt.apellidoMCliente;
                fechaCIn = reservacionObt.fechaCheckIn;
                fechaReC = reservacionObt.fechaDeRegistro;
                correoC = reservacionObt.correoCliente;
            }

            List<Hoteles> hotelA = cass.Obtener_hotelesPais(nombreC);
            foreach (Hoteles hotelObt in hotelA)
            {
                paisC = hotelObt.pais;
            }

            double hospedajeD = double.Parse(labelHospedaje.Text);
            double serviciosD = double.Parse(labelServices.Text);
            double totalD = double.Parse(labelTotal.Text);
            double anticipoD = double.Parse(labelAnticipo.Text);
            cass.incrementarContadorCancelacion();

            venta.idVentas = cass.obtenerContadorCancelacion();
            venta.nombreHotel = nombreC;
            venta.ciudad = ciudadC;
            venta.pais = paisC;
            venta.fecha = DateTime.Now.ToString("yyyy-MM-dd");
            venta.IngresosPorHospedaje = hospedajeD;
            venta.IngresosPorServicios = serviciosD;
            venta.IngresosTotales = totalD;

            var success = cass.InsertarVentas(venta);
            if (success) {
                SaveFileDialog guardar = new SaveFileDialog();
                guardar.FileName = DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf";
                string paginahtml_texto = Properties.Resources.plantilla.ToString();
                paginahtml_texto = paginahtml_texto.Replace("@HOTEL", nombreC);
                paginahtml_texto = paginahtml_texto.Replace("@CIUDAD", ciudadC);
                paginahtml_texto = paginahtml_texto.Replace("@HOSPEDAJE", hospedajeD.ToString("C"));
                paginahtml_texto = paginahtml_texto.Replace("@SERVICIOS", serviciosD.ToString("C"));
                paginahtml_texto = paginahtml_texto.Replace("@TOTAL", totalD.ToString("C"));
                paginahtml_texto = paginahtml_texto.Replace("@FECHA", DateTime.Now.ToString("yyyy-MM-dd"));
                if (guardar.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        pdfDoc.Add(new Phrase(""));
                        using (StringReader sr = new StringReader(paginahtml_texto))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                        }
                        pdfDoc.Close();
                        stream.Close();
                    }
                }
                    MessageBox.Show("Se realizo el checkOut correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
            foreach (DataGridViewRow row in dataGridRoomsCheckOut.Rows)
            {
                if (!row.IsNewRow)
                {
                    tipoHabiTemp = row.Cells[0].Value.ToString();
                    cantPersTemp = row.Cells[2].Value.ToString();
                }
            }

            historia.idHistorial = cass.obtenerContadorCancelacion();
            historia.nombreCliente = nombreClientC;
            historia.apellidoPCliente = apellPC;
            historia.apellidoMCliente = apellMC;
            historia.correoCliente = correoC;
            historia.hotel = nombreC;
            historia.ciudad = ciudadC;
            historia.tipoHabitacion = tipoHabiTemp;
            historia.cantidadPersonas = cantPersTemp;
            historia.codigoReservacion = txtCodeCheckOut.Text;
            historia.fechaReservacion = fechaReC;
            historia.fechaCheckIn = fechaCIn;
            historia.fechaCheckOut = DateTime.Now.ToString("yyyy-MM-dd");
            historia.estatusReservacion = false;
            historia.anticipo = anticipoD;
            historia.hospedaje = hospedajeD;
            historia.servicios = serviciosD;
            historia.total = totalD;




            var succes2 = cass.InsertarHistorial(historia);

            #region TICKET

            #endregion

            totalHospedaje = 0;
            totalServicios = 0;
            anticipo = 0;
            total = 0;
            aux = 0;
            labelServices.Text = totalServicios.ToString();
            labelHospedaje.Text = totalHospedaje.ToString();
            labelAnticipo.Text = anticipo.ToString();
            labelTotal.Text = total.ToString();
            txtCodeCheckOut.Text = "";
            dataGridRoomsCheckOut.DataSource = cass.Obtener_reservacionesDetalle("0");
            cass.limpiarServiciosTemporal();
            puedePagar = false;
        }

        private void dataGridServicesCheckOut_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridServicesCheckOut.AllowUserToAddRows = false;
                if (dataGridServicesCheckOut.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridServicesCheckOut.CurrentRow.Selected = true;
                    
                    btnSelectServicesCheckOut.Enabled = true;
                }
            }
            catch (Exception ArgumentOutOfRangeException)
            {
                MessageBox.Show("Seleccione una celda valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelectServicesCheckOut_Click(object sender, EventArgs e)
        {
            serv.Servicio = dataGridServicesCheckOut.CurrentRow.Cells[0].Value.ToString();
            serv.PrecioDeServicio = dataGridServicesCheckOut.CurrentRow.Cells[1].Value.ToString();

            var success = cass.InsertarServiciosTemporales(serv);
            if (success)
            {
                MessageBox.Show("Se agrego el servicio adicional.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dataGridServices2CheckOut.DataSource = cass.Obtener_serviciosTemp();

            dataGridServicesCheckOut.ClearSelection();
            btnSelectServicesCheckOut.Enabled = false;
            btnConfirmServicesCheckOut.Enabled = true; 
        }

        private void btnConfirmServicesCheckOut_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridServices2CheckOut.Rows)
            {
                if (!row.IsNewRow)
                {
                    serviciosS = row.Cells[1].Value.ToString();
                    aux = float.Parse(serviciosS);
                    totalServicios = totalServicios + aux;
                    total = total + aux;
                }
            }
            btnSelectServicesCheckOut.Enabled = false;
            btnConfirmServicesCheckOut.Enabled = false;
            dataGridServicesCheckOut.Enabled = false;
            labelServices.Text = totalServicios.ToString();
            labelTotal.Text = total.ToString();
        }
    }
}
