using Prototipo;
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
    public partial class Inicio_S : Form
    {
        public Inicio_S()
        {
            InitializeComponent();
        }
        private Form FormularioSec = null;

        private void Iniciar_Click(object sender, EventArgs e)
        {
            Iniciar_Sesion iniciar_Sesion = new Iniciar_Sesion();
            if (Ingresar_Usuario.Text == "" && Ingresar_Contraseña.Text == "")
            {
                MessageBox.Show("Campos en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if(iniciar_Sesion.In_Sesion(Ingresar_Usuario.Text, Ingresar_Contraseña.Text))
                {
                    Ingresar_Usuario.Text = "";
                    Ingresar_Contraseña.Text = "";
                }
                //this.Hide();
                //this.Dispose();
            }
        }
    }
}
