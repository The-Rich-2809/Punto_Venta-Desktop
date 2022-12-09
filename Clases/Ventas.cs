using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_Final
{
    internal class Ventas
    {
        public string IdProducto { get; set; }
        public int IdVentas { get; set; }
        public int Importe { get; set; }
        public string Fecha { get; set; }
        public int CveEmpleado { get; set; }
        public string User { get; set; }
    }
}
