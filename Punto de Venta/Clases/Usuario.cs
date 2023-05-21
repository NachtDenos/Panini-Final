
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_Venta.Clases
{
    public class Usuario
    {
        public string nombre { get; set; }
        public string apellidoP { get; set; }
        public string apellidoM { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public string FechaNacimiento { get; set; }
        public string nomina { get; set; }
        public string telefonoCasa { get; set; }
        public string FechaIngreso { get; set; }
        public string horaderegistro { get; set; }
        public string contrasena { get; set; }
        public string direccion { get; set; }
        public bool status { get; set; }
        public int rol { get; set; }
    }
}