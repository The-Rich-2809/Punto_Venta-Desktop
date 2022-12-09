using CustomControls.RJControls;
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
    public partial class Interfaz_Proveedores : Form
    {
        public Interfaz_Proveedores()
        {
            InitializeComponent();
        }
        private void Interfaz_Proveedores_Load(object sender, EventArgs e)
        {
            MostrarPro();
            this.Dgv_Proveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Agregar_Mod.Enabled = false;
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            MostrarPro();
        }
        private void Agregar_Click(object sender, EventArgs e)
        {
            Proveedores_OPS Pro_OPS = new Proveedores_OPS();
            ID_Proveedor.Text = Convert.ToString(Pro_OPS.generaIdUsuario());
            Mostrar(false, true);
            Agregar_Proveedor.Enabled = true;
            Mod_Pro.Enabled = false;

        }
        private void Modificar_Click(object sender, EventArgs e)
        {
            if (Dgv_Proveedores.Rows.Count > 0)
            {
                Llenar();
                Mostrar(false, true);
                Agregar_Proveedor.Enabled = false;
                Mod_Pro.Enabled = true;
            }
            else
            {
                MessageBox.Show("No hay datos a modificar");
            }
        }
        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (Dgv_Proveedores.Rows.Count > 0)
            {
                Proveedores_OPS Pro_OPS = new Proveedores_OPS();
                int RenglonSeleccionado = Dgv_Proveedores.CurrentRow.Index;
                int Id = Convert.ToInt32(Dgv_Proveedores.Rows[RenglonSeleccionado].Cells[0].Value.ToString());
                DialogResult Resultado = MessageBox.Show("¿Desea eliminar al Usuario con Id " + Id + "?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Resultado == DialogResult.Yes)
                {
                    if (Pro_OPS.Eliminar_Tabla(Id))
                    {
                        MessageBox.Show(Pro_OPS.Mensaje);
                    }
                    else
                    {
                        MessageBox.Show(Pro_OPS.Mensaje);
                    }
                }
                MostrarPro();
            }
            else
            {
                MessageBox.Show("No hay datos a eliminar");
            }
        }

        private void Agregar_Proveedor_Click(object sender, EventArgs e)
        {
            Proveedores Proveedor = new Proveedores();
            Proveedores_OPS Pro_OPS = new Proveedores_OPS();

            if (Validar())
            {
                QuitarValidar();
                Proveedor.CVEProveedor = Convert.ToInt32(ID_Proveedor.Text);
                Proveedor.Empresa = Nombre_Empresa.Text;
                Proveedor.Encargado = Nombre_Encargado.Text;
                Proveedor.Telefono = Telefono.Text;
                Proveedor.Fecha_Visita = CmbDiaVisita.Text;
                Proveedor.Fecha_Entrega = CmbDiaEntrega.Text;

                if (Pro_OPS.ReadAll(Proveedor))
                {
                    if (Pro_OPS.New_Proveedor(Proveedor))
                    {
                        MessageBox.Show(Pro_OPS.Mensaje);
                        Cancelar();
                    }
                    else
                    {
                        MessageBox.Show(Pro_OPS.Mensaje);
                    }
                }
            }
        }
        private void Mod_Pro_Click(object sender, EventArgs e)
        {
            Proveedores proveedores = new Proveedores();
            Proveedores_OPS Pro_Ops = new Proveedores_OPS();
            bool b = true;

            int RenglonSeleccionado = Dgv_Proveedores.CurrentRow.Index;
            string id = Dgv_Proveedores.Rows[RenglonSeleccionado].Cells[1].Value.ToString();
            proveedores.CVEProveedor = Convert.ToInt32(ID_Proveedor.Text);
            proveedores.Empresa = Nombre_Empresa.Text;
            proveedores.Encargado = Nombre_Encargado.Text;
            proveedores.Telefono = Telefono.Text;
            proveedores.Fecha_Visita = CmbDiaVisita.Text;
            proveedores.Fecha_Entrega = CmbDiaEntrega.Text;

            foreach (Control c in this.Agregar_Mod.Controls)
            {
                if (c.Text == "")
                {
                    MessageBox.Show("Recuerda llenar todos los campos");
                    b = false;
                    break;
                }
            }
            if (b == true)
            {
                if (id == Nombre_Empresa.Text)
                {
                    DialogResult Resultado = MessageBox.Show("¿Deseas modificar al Proveedor con ID " + ID_Proveedor.Text + "?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (Resultado == DialogResult.Yes)
                    {
                        if (Pro_Ops.Mod_Proveedores(proveedores))
                        {
                            MessageBox.Show(Pro_Ops.Mensaje);
                            Cancelar();
                        }
                        else
                        {
                            MessageBox.Show(Pro_Ops.Mensaje);
                        }
                    }
                }
                else
                {
                    if (Pro_Ops.ReadAll(proveedores))
                    {
                        DialogResult Resultado = MessageBox.Show("¿Deseas modificar al Proveedor con ID " + ID_Proveedor.Text + "?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (Resultado == DialogResult.Yes)
                        {
                            if (Pro_Ops.Mod_Proveedores(proveedores))
                            {
                                MessageBox.Show(Pro_Ops.Mensaje);
                                Cancelar();
                            }
                            else
                            {
                                MessageBox.Show(Pro_Ops.Mensaje);
                            }
                        }
                    }
                }
            }
        }
        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        public void Cancelar()
        {
            Mostrar(true, false);
            MostrarPro();
            Limpiar();
        }
        public void Llenar()
        {
            int RenglonSeleccionado = Dgv_Proveedores.CurrentRow.Index;
            ID_Proveedor.Text = Dgv_Proveedores.Rows[RenglonSeleccionado].Cells[0].Value.ToString();
            Nombre_Empresa.Text = Dgv_Proveedores.Rows[RenglonSeleccionado].Cells[1].Value.ToString();
            Nombre_Encargado.Text = Dgv_Proveedores.Rows[RenglonSeleccionado].Cells[2].Value.ToString();
            Telefono.Text = Dgv_Proveedores.Rows[RenglonSeleccionado].Cells[3].Value.ToString();
            CmbDiaVisita.Text = Dgv_Proveedores.Rows[RenglonSeleccionado].Cells[4].Value.ToString();
            CmbDiaEntrega.Text = Dgv_Proveedores.Rows[RenglonSeleccionado].Cells[5].Value.ToString();
        }
        public void Mostrar(bool bot, bool con)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button || c is DataGridView)
                {
                    c.Enabled = bot;
                }
            }
            Agregar_Mod.Enabled = con;
        }
        public void MostrarPro()
        {
            Proveedores_OPS Pro_Ops = new Proveedores_OPS();
            Dgv_Proveedores.DataSource = Pro_Ops.Mostrar_Proveedores();
        }
        public void Limpiar()
        {
            foreach (Control c in this.Agregar_Mod.Controls)
            {
                if(c is TextBox)
                {

                }
            }
            Nombre_Empresa.Text = "";
            Nombre_Encargado.Text = "";
            Telefono.Text = "";
            CmbDiaVisita.Text = "";
            CmbDiaEntrega.Text = "";
        }

        public bool Validar()
        {
            bool s = true;

            if(Nombre_Empresa.Text == "")
            {
                s = false;
                errorProvider1.SetError(Nombre_Empresa, "Inserta el Nombre de la Empresa");
            }
            if (Nombre_Encargado.Text == "")
            {
                s = false;
                errorProvider1.SetError(Nombre_Encargado, "Inserta el Nombre del Encargado");
            }
            if (Telefono.Text == "")
            {
                s = false;
                errorProvider1.SetError(Telefono, "Inserta el Telefono");
            }
            if (CmbDiaVisita.Text == "")
            {
                s = false;
                errorProvider1.SetError(CmbDiaVisita, "Inserta el Dia de Visita");
            }
            if (CmbDiaEntrega.Text == "")
            {
                s = false;
                errorProvider1.SetError(CmbDiaEntrega, "Inserta el Dia de Visita");
            }
            return s;
        }
        public void QuitarValidar()
        {
            errorProvider1.SetError(Nombre_Empresa, "");
            errorProvider1.SetError(Nombre_Encargado, "");
            errorProvider1.SetError(Telefono, "");
            errorProvider1.SetError(CmbDiaVisita, "");
            errorProvider1.SetError(CmbDiaEntrega, "");
        }
    }
}
