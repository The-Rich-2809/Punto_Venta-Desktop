using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entrega_Final
{
    public partial class Interfaz_VentasRealizadas : Form
    {
        public string Usuario { get; set; }
        public Interfaz_VentasRealizadas()
        {
            InitializeComponent();
        }

        private void Interfaz_VentasRealizadas_Load(object sender, EventArgs e)
        {
            Ventas Venta = new Ventas();
            Ventas_OPS OPS = new Ventas_OPS();
            Venta.User = Usuario;
            Venta.CveEmpleado = OPS.Extraer_Empleado(Venta);
            Dgv_Ventas.DataSource = OPS.Mostrar_Ventas(Venta);
        }
    }
}
