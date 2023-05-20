using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_Venta.Clases
{
    public class Ventas
    {
        public string idVentas { get; set; }
        public string ciudad { get; set; }
        public string pais { get; set; }
        public string nombreHotel { get; set; }
        public string fecha { get; set; }
        public double IngresosPorHospedaje { get; set; }
        public double IngresosPorServicios { get; set; }
        public double IngresosTotales { get; set; }
    }
}
