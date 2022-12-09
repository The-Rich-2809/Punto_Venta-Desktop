using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Entrega_Final;

namespace Prototipo
{
    internal class Producto_OPS
    {
        public string Mensaje { get; set; }

        public bool ReadAll(string code)
        {
            DataTable tablaProductos = new DataTable();

            Mensaje = String.Empty;
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sentencia = "select * from PRODUCTO where IdPRODUCTO = @IdPRODUCTO;";
                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    cmdSelect.Parameters.AddWithValue("@IdPRODUCTO", code);
                    adapter.SelectCommand = cmdSelect;
                    conexion.Open();
                    adapter.Fill(tablaProductos);

                    if (tablaProductos.Rows.Count > 0)
                    {
                        Mensaje = "Producto ya registrado";
                        return false;
                    }
                    else
                    {
                        Mensaje = "Producto Nuevo";
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return false;
        }
        public bool New_Producto(Productos Pro)
        {
            bool Operacion = false;

            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand Consulta;
                int resultado = 0;
                string SentenciaSQL = @"Insert Into PRODUCTO Values (@Id,@Empresa,@Nombre,@Descripcion,@Precio,@Costo,@Existencia);";
                Consulta = new SqlCommand(SentenciaSQL, conexion);

                Consulta.Parameters.AddWithValue("@Id", Pro.IdProducto);
                Consulta.Parameters.AddWithValue("@Empresa", Pro.Empresa);
                Consulta.Parameters.AddWithValue("@Nombre", Pro.Nombre);
                Consulta.Parameters.AddWithValue("@Descripcion", Pro.Descripción);
                Consulta.Parameters.AddWithValue("@Precio", Pro.Precio);
                Consulta.Parameters.AddWithValue("@Costo", Pro.Costo);
                Consulta.Parameters.AddWithValue("@Existencia", "0");

                try
                {
                    conexion.Open();

                    resultado = Consulta.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        Mensaje = "Producto registrado correctamente";
                        Operacion = true;
                    }
                }
                catch (Exception ex)
                {
                    Mensaje = ex.Message;
                }
            }
            return Operacion;
        }
        public bool Mod_Productos(Productos Pro)
        {
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand Consulta;

                int filasafectadas;
                string sentencia = @"update PRODUCTO set EMPRESA = @Empresa, NOMBRE = @Nombre, DESCRIPCION = @Descripcion, PRECIO = @Precio, COSTO = @Costo where IdPRODUCTO = @Id";
                Consulta = new SqlCommand(sentencia, conexion);

                Consulta.Parameters.AddWithValue("@Empresa", Pro.Empresa);
                Consulta.Parameters.AddWithValue("@Nombre", Pro.Nombre);
                Consulta.Parameters.AddWithValue("@Descripcion", Pro.Descripción);
                Consulta.Parameters.AddWithValue("@Precio", Pro.Precio);
                Consulta.Parameters.AddWithValue("@Costo", Pro.Costo);
                Consulta.Parameters.AddWithValue("@Id", Pro.IdProducto);

                try
                {
                    conexion.Open();
                    filasafectadas = Consulta.ExecuteNonQuery();
                    if (filasafectadas > 0)
                    {
                        Mensaje = "Producto actualizado exitosamente";
                        return true;
                    }

                }
                catch (Exception ex)
                {
                    Mensaje = ex.Message;
                }
            }
            return false;
        }
        public bool Eliminar_Tabla(string i)

        {
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdCreate;
                int filasafectadas;
                string sentencia = @"delete from PRODUCTO where IdPRODUCTO = @id";
                cmdCreate = new SqlCommand(sentencia, conexion);
                cmdCreate.Parameters.AddWithValue("@id", i);
                try
                {
                    conexion.Open();
                    filasafectadas = cmdCreate.ExecuteNonQuery();
                    if (filasafectadas > 0)
                    {
                        Mensaje = "Prducto elimidado exitosamente";
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Mensaje = ex.Message;
                }
            }
            return false;
        }
        public DataTable Mostrar_Productos()
        {
            DataTable tablaProductos = new DataTable();

            Mensaje = String.Empty;
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sentencia = "select * from PRODUCTO ";
                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    adapter.SelectCommand = cmdSelect;
                    conexion.Open();
                    adapter.Fill(tablaProductos);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                return tablaProductos;
            }
        }
    }
}
