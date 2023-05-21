using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_Venta.Clases
{
    public class Historial
    {
        public string idHistorial { get; set; }
        public string nombreCliente { get; set; }
        public string apellidoPCliente { get; set; }
        public string apellidoMCliente { get; set; }
        public string ciudad { get; set; }
        public string hotel { get; set; }
        public string tipoHabitacion { get; set; }
        public string cantidadPersonas { get; set; }
        public string codigoReservacion { get; set; }
        public string fechaReservacion { get; set; }
        public string fechaCheckIn { get; set; }
        public string fechaCheckOut { get; set; }
        public bool estatusReservacion { get; set; }
        public double anticipo { get; set; }
        public double hospedaje { get; set; }
        public double servicios { get; set; }
        public double total { get; set; }
    }
}
