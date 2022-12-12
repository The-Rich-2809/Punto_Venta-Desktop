using Prototipo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace Entrega_Final
{
    public partial class Interfaz_Productos : Form
    {
        public Interfaz_Productos()
        {
            InitializeComponent();
        }

        private void Interfaz_Productos_Load(object sender, EventArgs e)
        {
            MosPro();
            Mostrar_Empresas();
            Mostrar_Com(0);
            this.Dgv_Productos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        

        public void Cancelar()
        {
            Limpiar();
            Mostrar_Com(0);
        }
        public void Llenar()
        {
            int RenglonSeleccionado = Dgv_Productos.CurrentRow.Index;
            Txt_Id.Text = Dgv_Productos.Rows[RenglonSeleccionado].Cells[0].Value.ToString();
            CmbEmpresa.Text = Dgv_Productos.Rows[RenglonSeleccionado].Cells[1].Value.ToString();
            Txt_Nom_Pro.Text = Dgv_Productos.Rows[RenglonSeleccionado].Cells[2].Value.ToString();
            Txt_Descripcion.Text = Dgv_Productos.Rows[RenglonSeleccionado].Cells[3].Value.ToString();
            Nud_Precio.Text = Dgv_Productos.Rows[RenglonSeleccionado].Cells[4].Value.ToString();
            Nud_Costo.Text = Dgv_Productos.Rows[RenglonSeleccionado].Cells[5].Value.ToString();;
        }
        public bool Validar() 
        {
            if (Txt_Nom_Pro.Text == "" || CmbEmpresa.Text == "" || Txt_Descripcion.Text == "" || Nud_Precio.Text == "0" || Nud_Costo.Text == "0" || Nud_Precio.Text == "" || Nud_Costo.Text == "")
            {
                MessageBox.Show("Faltan campos a llenar");
                return false;
            }
            else if(Convert.ToInt32(Nud_Precio.Text)  <= Convert.ToInt32(Nud_Costo.Text))
            {
                MessageBox.Show("El precio no puede ser menor o igual al costo");
                return false;
            }
            return true;
        }
        public void Mostrar_Com(int i)
        {
            switch(i)
            {
                case 0:
                    {
                        label1.Enabled = false;
                        label2.Enabled = false;
                        label3.Enabled = false;
                        label4.Enabled = false;
                        label5.Enabled = false;
                        Txt_Id.Enabled = false;
                        Txt_Nom_Pro.Enabled = false;
                        CmbEmpresa.Enabled = false;
                        Txt_Descripcion.Enabled = false;
                        Nud_Precio.Enabled = false;
                        Nud_Costo.Enabled = false;
                        Btn_Buscar.Enabled = false;
                        Btn_A.Enabled = false;
                        Btn_M.Enabled = false;
                        Btn_Cancelar.Enabled = false;
                        Btn_Agregar.Enabled = true;
                        Btn_Mod.Enabled = true;
                        Btn_Eliminar.Enabled = true;

                        break;
                    }
                case 1:
                    {
                        label1.Enabled = false;
                        label2.Enabled = false;
                        label3.Enabled = false;
                        label4.Enabled = false;
                        label5.Enabled = false;
                        Txt_Id.Enabled = true;
                        Txt_Nom_Pro.Enabled = false;
                        CmbEmpresa.Enabled = false;
                        Txt_Descripcion.Enabled = false;
                        Nud_Precio.Enabled = false;
                        Nud_Costo.Enabled = false;
                        Btn_Buscar.Enabled = true;
                        Btn_A.Enabled = false;
                        Btn_M.Enabled = false;
                        Btn_Cancelar.Enabled = true;
                        Btn_Agregar.Enabled = false;
                        Btn_Mod.Enabled = false;
                        Btn_Eliminar.Enabled = false;
                        break;
                    }
                case 2:
                    {
                        label1.Enabled = true;
                        label2.Enabled = true;
                        label3.Enabled = true;
                        label4.Enabled = true;
                        label5.Enabled = true;
                        Txt_Id.Enabled = false;
                        Txt_Nom_Pro.Enabled = true;
                        CmbEmpresa.Enabled = true;
                        Txt_Descripcion.Enabled = true;
                        Nud_Precio.Enabled = true;
                        Nud_Costo.Enabled = true;
                        Btn_Buscar.Enabled = false;
                        Btn_A.Enabled = false;
                        Btn_M.Enabled = true;
                        Btn_Cancelar.Enabled = true;
                        Btn_Agregar.Enabled = false;
                        Btn_Mod.Enabled = false;
                        Btn_Eliminar.Enabled = false;
                        break;
                    }
                case 3:
                    {
                        label1.Enabled = true;
                        label2.Enabled = true;
                        label3.Enabled = true;
                        label4.Enabled = true;
                        label5.Enabled = true;
                        Txt_Id.Enabled = true;
                        Txt_Id.Enabled = false;
                        Txt_Nom_Pro.Enabled = true;
                        CmbEmpresa.Enabled = true;
                        Txt_Descripcion.Enabled = true;
                        Nud_Precio.Enabled = true;
                        Nud_Costo.Enabled = true;
                        Btn_Buscar.Enabled = false;
                        Btn_A.Enabled = true;
                        Btn_M.Enabled = false;
                        Btn_Cancelar.Enabled = true;
                        Btn_Agregar.Enabled = false;
                        Btn_Mod.Enabled = false;
                        Btn_Eliminar.Enabled = false;
                        break;
                    }
            }
        }
        public void Mostrar_Empresas()
        {
            using (SqlConnection Conecta = Conexion.Conectar())
            {
                SqlDataReader Reader;
                SqlCommand Consulta;
                string SentenciaSQL;
                SentenciaSQL = @"Select NOMBRE_EMPRESA from PROVEEDORES;";
                Consulta = new SqlCommand(SentenciaSQL, Conecta);
                Conecta.Open();
                //Acciones sobre la base de datos
                Reader = Consulta.ExecuteReader();
                CmbEmpresa.Items.Clear();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        CmbEmpresa.Items.Add(Reader.GetString(0));
                    }
                }
                else
                {
                    MessageBox.Show("No devolvueron datos");
                }
            }
        }
        public void Limpiar()
        {
            Txt_Id.Text = "";
            Txt_Nom_Pro.Text = "";
            CmbEmpresa.Text = "";
            Txt_Descripcion.Text = "";
            Nud_Precio.Text = "0";
            Nud_Costo.Text = "0";
        }
        public void MosPro()
        {
            Producto_OPS producto_OPS = new Producto_OPS();
            Dgv_Productos.DataSource = producto_OPS.Mostrar_Productos();
        }

        
        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            Mostrar_Com(1);
        }
        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            if(Txt_Id.Text != "0" && Txt_Id.Text != "")
            {
                Producto_OPS producto_OPS = new Producto_OPS();
                if (producto_OPS.ReadAll(Txt_Id.Text))
                {
                    MessageBox.Show(producto_OPS.Mensaje);
                    Mostrar_Com(3);
                }
                else
                {
                    MessageBox.Show(producto_OPS.Mensaje);
                }
            }
            else
            {
                MessageBox.Show("No se puede buscar con esos datos");
            }
        }
        private void Btn_A_Click(object sender, EventArgs e)
        {
            if(Validar())
            {
                Productos productos = new Productos();
                Producto_OPS producto_OPS = new Producto_OPS();
                productos.IdProducto = Txt_Id.Text;
                productos.Nombre = Txt_Nom_Pro.Text;
                productos.Empresa = CmbEmpresa.Text;
                productos.Descripción = Txt_Descripcion.Text;
                productos.Precio = Convert.ToDouble(Nud_Precio.Text);
                productos.Costo = Convert.ToDouble(Nud_Costo.Text);
                
                if(producto_OPS.New_Producto(productos))
                {
                    MessageBox.Show(producto_OPS.Mensaje);
                    Cancelar();
                    MosPro();
                }
                else
                {
                    MessageBox.Show(producto_OPS.Mensaje);
                }
            }
        }
        private void Btn_Mod_Click(object sender, EventArgs e)
        {
            Llenar();
            Mostrar_Com(2);
        }
        private void Btn_M_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                int Renglon = Dgv_Productos.CurrentRow.Index;
                string nombre = Dgv_Productos.Rows[Renglon].Cells[2].Value.ToString();
                DialogResult Resultado = MessageBox.Show("¿Desea Modificar al Producto " + nombre + "?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Resultado == DialogResult.Yes)
                {
                    Productos productos = new Productos();
                    Producto_OPS producto_OPS = new Producto_OPS();
                    productos.IdProducto = Txt_Id.Text;
                    productos.Nombre = Txt_Nom_Pro.Text;
                    productos.Empresa = CmbEmpresa.Text;
                    productos.Descripción = Txt_Descripcion.Text;
                    productos.Precio = Convert.ToDouble(Nud_Precio.Text);
                    productos.Costo = Convert.ToDouble(Nud_Costo.Text);

                    if (producto_OPS.Mod_Productos(productos))
                    {
                        MessageBox.Show(producto_OPS.Mensaje);
                        Cancelar();
                        MosPro();
                    }
                    else
                    {
                        MessageBox.Show(producto_OPS.Mensaje);
                    }
                }
            }
        }
        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }
        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (Dgv_Productos.Rows.Count > 0)
            {
                Producto_OPS producto_OPS = new Producto_OPS();
                int Renglon = Dgv_Productos.CurrentRow.Index;
                string nombre = Dgv_Productos.Rows[Renglon].Cells[2].Value.ToString();
                DialogResult Resultado = MessageBox.Show("¿Desea eliminar al Producto " + nombre + "?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Resultado == DialogResult.Yes)
                {
                    if (producto_OPS.Eliminar_Tabla(Dgv_Productos.Rows[Renglon].Cells[0].Value.ToString()))
                    {
                        MessageBox.Show(producto_OPS.Mensaje);
                        MosPro();
                        Cancelar();
                    }
                    else
                    {
                        MessageBox.Show(producto_OPS.Mensaje);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay datos a eliminar");
            }
        }
    }
}
