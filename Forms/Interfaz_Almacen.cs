using Entrega_Final.Clases;
using Entrega_Final.OPS;
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

namespace Entrega_Final.Forms
{
    public partial class Interfaz_Almacen : Form
    {
        public Interfaz_Almacen()
        {
            InitializeComponent();
        }

        private void Interfaz_Almacen_Load(object sender, EventArgs e)
        {
            MosPro();
            Cancelar();
            Btn_Cancelar.Enabled = false;
            Txt_Buscar.Enabled = false;
            Btn_Buscar.Enabled = false;
        }

        private void Btn_Mod_Click(object sender, EventArgs e)
        {
            int CI;
            Almacen almacen = new Almacen();
            Almacen_OPS almacen_OPS = new Almacen_OPS();

            if (Maquina.Checked)
            {
                almacen.IdP = Txt_Buscar.Text;
                CI = almacen_OPS.Extraer_Cantidad(almacen);
            }
            else
            {
                int RenglonSeleccionado = Dgv_Productos.CurrentRow.Index;
                almacen.IdP = Dgv_Productos.Rows[RenglonSeleccionado].Cells[0].Value.ToString();
                CI = Convert.ToInt32(Dgv_Productos.Rows[RenglonSeleccionado].Cells[6].Value.ToString());
            }

            almacen.Cantidad = Convert.ToInt32(Nud_Existencia.Text);
            DialogResult Resultado = MessageBox.Show("¿Desea pasar de " + CI + " a " + Nud_Existencia.Text + " productos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Resultado == DialogResult.Yes)
            {
                if (almacen_OPS.Mod_Ex_PRO(almacen))
                {
                    MessageBox.Show(almacen_OPS.Mensaje);
                    MosPro();
                    Cancelar();
                }
            }

        }
        private void Btn_Ag_Click(object sender, EventArgs e)
        {
            int CI;
            Almacen almacen = new Almacen();
            Almacen_OPS almacen_OPS = new Almacen_OPS();

            if (Maquina.Checked)
            {
                almacen.IdP = Txt_Buscar.Text;
                CI = almacen_OPS.Extraer_Cantidad(almacen);
            }
            else
            {
                int RenglonSeleccionado = Dgv_Productos.CurrentRow.Index;
                almacen.IdP = Dgv_Productos.Rows[RenglonSeleccionado].Cells[0].Value.ToString();
                CI = Convert.ToInt32(Dgv_Productos.Rows[RenglonSeleccionado].Cells[6].Value.ToString());
            }

            almacen.Cantidad = Convert.ToInt32(Nud_Existencia.Text) + CI;
            DialogResult Resultado = MessageBox.Show("¿Desea agregar " + Nud_Existencia.Text + " productos más para pasar de " + CI + " a " + almacen.Cantidad + " ?", 
                "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Resultado == DialogResult.Yes)
            {
                if (almacen_OPS.Mod_Ex_PRO(almacen))
                {
                    MessageBox.Show(almacen_OPS.Mensaje);
                    MosPro();
                    Cancelar();
                }
            }
        }
        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        public void B_Mod()
        {
            Btn_Mod.Enabled = true;
            Nud_Existencia.Enabled = true;
            Btn_Ag.Enabled = false;
            Btn_Ag.Enabled = true;

        }
        public void Cancelar()
        {
            if(Tabla.Checked)
            {
                Btn_Mod.Enabled = false;
                Btn_Ag.Enabled = false;
                Nud_Existencia.Enabled = false;
                Nud_Existencia.Text = "0";
                Txt_Buscar.Enabled = false;
                Txt_Buscar.Text = "";
                Btn_Buscar.Enabled = false;
            }
            else
            {
                Btn_Mod.Enabled = false;
                Btn_Ag.Enabled = false;
                Nud_Existencia.Enabled = false;
                Nud_Existencia.Text = "0";
                Txt_Buscar.Enabled = true;
                Txt_Buscar.Text= "";
                Btn_Buscar.Enabled = true;
            }
            
        }
        public void MosPro()
        {
            Producto_OPS producto_OPS = new Producto_OPS();
            Dgv_Productos.DataSource = producto_OPS.Mostrar_Productos();
            Dgv_Productos.AutoSize = true;
        }

        private void Maquina_CheckedChanged(object sender, EventArgs e)
        {
            Cancelar();
            Btn_Cancelar.Enabled = true;
        }
        private void Tabla_CheckedChanged(object sender, EventArgs e)
        {
            Cancelar();
            Btn_Cancelar.Enabled = true;
        }
        private void Dgv_Productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(Tabla.Checked)
            {
                int RenglonSeleccionado = Dgv_Productos.CurrentRow.Index;
                Nud_Existencia.Text = Dgv_Productos.Rows[RenglonSeleccionado].Cells[6].Value.ToString();
                B_Mod();
            }
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < Dgv_Productos.Rows.Count; i++)
            {
                if (Txt_Buscar.Text == Dgv_Productos.Rows[i].Cells[0].Value.ToString())
                {
                    Nud_Existencia.Text = Dgv_Productos.Rows[i].Cells[6].Value.ToString();
                    i = Dgv_Productos.Rows.Count + 1;              
                    B_Mod();
                    Txt_Buscar.Enabled = false;
                    Btn_Buscar.Enabled = false;
                }
            }
            if (i == Dgv_Productos.Rows.Count)
            {
                MessageBox.Show("Producto no encontrado");
            }
        }
    }
}
