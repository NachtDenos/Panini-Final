using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_Venta.Clases
{
    public class Ocupacion
    {
        public string idReporte { get; set; }
        public string ciudad { get; set; }
        public string pais { get; set; }
        public string nombreHotel { get; set; }
        public string fecha { get; set; }
        public string tipoHabitacion { get; set; }
        public int cantidadHabitaciones { get; set; }
        public int ocupacion { get; set; }
        public int personasHospedadas { get; set; }
    }
}
