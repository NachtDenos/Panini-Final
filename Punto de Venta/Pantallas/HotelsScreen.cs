﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Punto_de_Venta.Clases;

namespace Punto_de_Venta
{
    public partial class productsScreen : Form
    {
        Hoteles hotel = new Hoteles();
        EnlaceCassandra cass = new EnlaceCassandra();
        bool selection = false;
        public productsScreen()
        {
            InitializeComponent();
            dataGridHotels.DataSource = cass.Obtener_hoteles();
        }
        
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            //if (txtNameHotelHotels.TextLength == 0 || txtCountryHotels.TextLength == 0 || txtCityHotels.TextLength == 0 ||
            //    txtStateHotels.TextLength == 0 || txtFloorsHotels.TextLength == 0 || txtRoomsHotels.TextLength == 0 ||
            //    txtBeachHotels.TextLength == 0 || txtPoolsHotels.TextLength == 0 || txtEventsHotels.TextLength == 0)
            //{
            //    MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //if (selection == false)
            //{
            //    MessageBox.Show("Seleccione una zona turistica", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (dateValidFuture(dtpOperatHotels.Value.Date) == false)
            //{
            //    MessageBox.Show("Fecha no valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            hotel.hotel = txtNameHotelHotels.Text;
            hotel.pais = txtCountryHotels.Text;
            hotel.ciudad = txtCityHotels.Text;
            hotel.estado = txtStateHotels.Text;
            int numeroPisosReal = int.Parse(txtFloorsHotels.Text);
            hotel.numeroPisos = numeroPisosReal;
            int numeroHabitacionesReal = int.Parse(txtRoomsHotels.Text);
            hotel.cantidadHabitaciones = numeroHabitacionesReal;
            hotel.zonaTuristica = cbZoneHotels.Text;
            hotel.frentePlaya = txtBeachHotels.Text;
            int numeroPiscinasReal = int.Parse(txtPoolsHotels.Text);
            hotel.cantidadPiscinas = numeroPiscinasReal;
            int numeroSalonesReal = int.Parse(txtEventsHotels.Text);
            hotel.salonesEventos = numeroSalonesReal;
            string fechaReal = dtpOperatHotels.Text;
            String.Format("{0:yyyy-MM-dd}", fechaReal);
            hotel.inicioOperaciones = fechaReal;

            var success = cass.InsertarHoteles(hotel);
            if (success)
            {
                dataGridHotels.DataSource = cass.Obtener_hoteles();
                MessageBox.Show("Se agrego el hotel.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            clearTxt();
            dataGridHotels.ClearSelection();
        }

        private void onlyLetters(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan letras en este campo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }
        private void onlyNumbers(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbZoneHotels_SelectedIndexChanged(object sender, EventArgs e)
        {
            selection = true;
        }

        private bool dateValidFuture(DateTime fecha)
        {
            DateTime hoy = DateTime.Today;
            if (fecha > hoy)
            {
                return false;
            }
            return true;
        }

        private void btnEditHotels_Click(object sender, EventArgs e)
        {
            //if (txtNameHotelHotels.TextLength == 0 || txtCountryHotels.TextLength == 0 || txtCityHotels.TextLength == 0 ||
            //    txtStateHotels.TextLength == 0 || txtFloorsHotels.TextLength == 0 || txtRoomsHotels.TextLength == 0 ||
            //    txtBeachHotels.TextLength == 0 || txtPoolsHotels.TextLength == 0 || txtEventsHotels.TextLength == 0)
            //{
            //    MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //if (selection == false)
            //{
            //    MessageBox.Show("Seleccione una zona turistica", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (cbZoneHotels.Text == "Seleccionar")
            //{
            //    MessageBox.Show("Seleccione una zona turistica", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (dateValidFuture(dtpOperatHotels.Value.Date) == false)
            //{
            //    MessageBox.Show("Fecha no valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            clearTxt();
        }

        private void btnDeleteHotels_Click(object sender, EventArgs e)
        {
            //TODO: Bajas
        }

        private void txtNameHotelHotels_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyLetters(e);
        }

        private void txtCountryHotels_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyLetters(e);
        }

        private void txtCityHotels_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyLetters(e);
        }

        private void txtStateHotels_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyLetters(e);
        }

        private void txtFloorsHotels_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(e);
        }

        private void txtRoomsHotels_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(e);
        }

        private void txtBeachHotels_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyLetters(e);
        }

        private void txtPoolsHotels_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(e);
        }

        private void txtEventsHotels_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(e);
        }

        private void clearTxt()
        {
            txtNameHotelHotels.Text = "";
            txtCountryHotels.Text = "";
            txtCityHotels.Text = "";
            txtStateHotels.Text = "";
            txtFloorsHotels.Text = "";
            txtRoomsHotels.Text = "";
            txtBeachHotels.Text = "";
            txtPoolsHotels.Text = "";
            txtEventsHotels.Text = "";
            cbZoneHotels.Text = "Seleccionar";
        }
    }
}
