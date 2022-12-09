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
    public partial class Interfaz_Home : Form
    {
        public Interfaz_Home()
        {
            InitializeComponent();
        }

        private void Hora_Fecha_Tick(object sender, EventArgs e)
        {
            Hora.Text = DateTime.Now.ToString("HH:mm:ss");
            Fecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
