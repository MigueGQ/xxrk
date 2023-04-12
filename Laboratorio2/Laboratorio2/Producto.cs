using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    internal class Producto
    {
        public string Nombre { get; set; }
        public string Proveedor { get; set; }
        public DateTime FechaCaducidad { get; set; }
        public DateTime FechaEntrada { get; set; }
        public string Detalles { get; set; }
        public decimal Precio { get; set; }
        public int UnidadesDisponibles { get; set; }
    }
}
