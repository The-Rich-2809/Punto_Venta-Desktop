using FontAwesome.Sharp;
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
    public partial class Interfaz_Em : Form
    {
        private Form FormularioSec = null;
        private IconButton currentBtn;
        private Panel IzBordeBtn;
        public Interfaz_Em()
        {
            InitializeComponent();
            IzBordeBtn = new Panel();
            IzBordeBtn.Size = new Size(7, 200);
            Panel_Controles.Controls.Add(IzBordeBtn);
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        public struct Colores
        {
            public static Color color1 = Color.FromArgb(255, 195, 0);
            public static Color color2 = Color.FromArgb(1, 154, 255);
            public static Color color3 = Color.MediumSlateBlue;
            public static Color color4 = Color.FromArgb(0, 150, 54);
            public static Color color5 = Color.Red;

        }
        private void ActivarBtn(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DesBtn();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(30, 30, 30);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                IzBordeBtn.BackColor = color;
                IzBordeBtn.Location = new Point(currentBtn.Location.X, currentBtn.Location.Y);
                IzBordeBtn.Visible = true;
                IzBordeBtn.BringToFront();
            }
        }
        public void DesBtn()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(25, 25, 25);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void AbrirSegundoForm(Form Formulario)
        {
            if (FormularioSec != null)
            {
                FormularioSec.Close();
            }
            else
            {
                FormularioSec = Formulario;
                Formulario.TopLevel = false;
                Formulario.FormBorderStyle = FormBorderStyle.None;
                Formulario.Dock = DockStyle.Fill;
                Form_Sec.Controls.Add(Formulario);
                Form_Sec.Tag = Formulario;
                Formulario.BringToFront();
                Formulario.Show();
                FormularioSec = null;

            }
        }
        private void Reset()
        {
            DesBtn();
            IzBordeBtn.Visible = false;
        }

        private void Btn_Ventas_Click(object sender, EventArgs e)
        {
            ActivarBtn(sender, Colores.color3);
            Interfaz_Ventas ventas = new Interfaz_Ventas();
            ventas.Usuario = Usuario.Text;
            AbrirSegundoForm(ventas);
        }
        private void Btn_VentasR_Click(object sender, EventArgs e)
        {
            ActivarBtn(sender, Colores.color4);
            Interfaz_VentasRealizadas ventas = new Interfaz_VentasRealizadas();
            ventas.Usuario = Usuario.Text;
            AbrirSegundoForm(ventas);
        }
        private void Btn_Home_Click(object sender, EventArgs e)
        {
            inicio();
            Reset();
        }
        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            ActivarBtn(sender, Colores.color5);
            this.Close();
        }

        private void Interfaz_Em_Load(object sender, EventArgs e)
        {
            inicio();
        }
        public void inicio()
        {
            Interfaz_Home interfaz_Home = new Interfaz_Home();
            interfaz_Home.Lbl_Usuario.Text = Usuario.Text;
            AbrirSegundoForm(interfaz_Home);
        }
    }
}
