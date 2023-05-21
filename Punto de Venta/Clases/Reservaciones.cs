using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_Venta.Clases
{
    public class Reservaciones
    {
        public string codigo { get; set; }
        public string nombreCliente { get; set; }
        public string apellidoPCliente { get; set; }
        public string apellidoMCliente { get; set; }
        public string hotel { get; set; }
        public string habitacion { get; set; }
        public string ciudad { get; set; }
        public string cantidadPersonas { get; set; }
        public string fechaInicial { get; set; }
        public string fechaFinal { get; set; }
        public string precio { get; set; }
        public bool checkIn { get; set; }
        public bool checkOut { get; set; }
        public string metodoDePago { get; set; }
        public string anticipo { get; set; }
        public string fechaDeRegistro { get; set; }
        public string horaDeRegistro { get; set; }
        public string usuarioRegistro { get; set; }
        public string correoCliente { get; set; }
        public string fechaCheckIn { get; set; }
        public string fechaCheckOut { get; set; }
        public bool EstatusReservacion { get; set; }

    }
}
