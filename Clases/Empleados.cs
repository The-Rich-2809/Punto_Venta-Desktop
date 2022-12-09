using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo
{
    internal class Empleados
    {
        public int IdEmpleado { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Nivel_Usuario { get; set; }
        public string Correo { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string RFC { get; set; }
        public string Telefono { get; set; }
        public string Fecha_Nacimiento { get; set; }
        public string Calle { get; set; }
        public string NumExterior { get; set; }
        public string CodePostal { get; set; }
        public string Ciudad { get; set; }
        public string Entidad { get; set; }
        public string Fecha_Contrato { get; set; }
        public string Sueldo { get; set; }
    }
}
