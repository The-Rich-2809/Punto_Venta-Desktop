using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo
{
    internal class Productos
    {
        public string IdProducto { get; set; }       
        public string Nombre { get; set; }
        public string Empresa { get; set; }
        public string Descripción { get; set; }
        public double Precio { get; set; }
        public double Costo { get; set; }
        public double Existencia { get; set; }
    }
}
