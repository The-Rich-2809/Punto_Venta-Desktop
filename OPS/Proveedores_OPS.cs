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
    internal class Proveedores_OPS
    {
        public string Mensaje { get; set; }

        //Metodo para agregar otro proveedor
        public bool New_Proveedor(Proveedores Pro)
        {
            bool Operacion = false;

            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand Consulta;
                int resultado = 0;
                string SentenciaSQL = @"Insert Into PROVEEDORES Values (@CvePro,@Empresa,@Encargado,@Telefono,@Fecha_Visita,@Fecha_Entrega);";
                Consulta = new SqlCommand(SentenciaSQL, conexion);

                Consulta.Parameters.AddWithValue("@CvePro", Pro.CVEProveedor);
                Consulta.Parameters.AddWithValue("@Empresa", Pro.Empresa);
                Consulta.Parameters.AddWithValue("@Encargado", Pro.Encargado);
                Consulta.Parameters.AddWithValue("@Telefono", Pro.Telefono);
                Consulta.Parameters.AddWithValue("@Fecha_Visita", Pro.Fecha_Visita);
                Consulta.Parameters.AddWithValue("@Fecha_Entrega", Pro.Fecha_Entrega);

                try
                {
                    conexion.Open();

                    resultado = Consulta.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        Mensaje = "Proveedor registrado correctamente";
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

        //Buscar si el proveedor ya esta registrado
        public bool ReadAll(Proveedores Pro)
        {
            DataTable tablaProveedores = new DataTable();
            bool consulta = false;

            Mensaje = String.Empty;
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sentencia = "select * from PROVEEDORES where NOMBRE_EMPRESA = @Pro;";
                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    cmdSelect.Parameters.AddWithValue("@Pro", Pro.Empresa);
                    adapter.SelectCommand = cmdSelect;
                    conexion.Open();
                    adapter.Fill(tablaProveedores);
                    if (tablaProveedores.Rows.Count > 0)
                    {
                        MessageBox.Show("Proveedor ya registrado");
                    }
                    else
                    {
                        consulta = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return consulta;
        }

        //Mostrar los datos de los proveedores
        public DataTable Mostrar_Proveedores()
        {
            DataTable tablaProveedores = new DataTable();

            Mensaje = String.Empty;
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sentencia = "select * from PROVEEDORES ";
                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    adapter.SelectCommand = cmdSelect;
                    conexion.Open();
                    adapter.Fill(tablaProveedores);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return tablaProveedores;
            }
        }

        public bool Eliminar_Tabla (int i)

        {
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdCreate;
                int filasafectadas;
                string sentencia = @"delete from PROVEEDORES where CVEPROVEEDOR = @id";
                cmdCreate = new SqlCommand(sentencia, conexion);
                cmdCreate.Parameters.AddWithValue("@id", Convert.ToString(i));
                try
                {
                    conexion.Open();
                    filasafectadas = cmdCreate.ExecuteNonQuery();
                    if (filasafectadas > 0)
                    {
                        Mensaje = "Usuario elimidado exitosamente";
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

        public int generaIdUsuario()
        {
            object tmp;
            int IdProveedor = 0;
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdCreate;
                string sentencia = "select max(CVEPROVEEDOR) from PROVEEDORES";
                try
                {
                    cmdCreate = new SqlCommand(sentencia, conexion);
                    conexion.Open();
                    tmp = cmdCreate.ExecuteScalar();
                    if (tmp.Equals(DBNull.Value))
                    {
                        IdProveedor = 1;
                    }
                    else
                    {
                        IdProveedor = Convert.ToInt32(tmp);
                        IdProveedor = IdProveedor + 100;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return IdProveedor;
        }

        public bool Mod_Proveedores(Proveedores proveedores)
        {
            bool x = false;
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdCreate;
               
                int filasafectadas;
                string sentencia = @"update PROVEEDORES set NOMBRE_EMPRESA = @NomEmpresa, NOMBRE_ENCARGADO = @NomEncargado, TELEFONO = @Tel, FECHA_VISITA = @FVisita, FECHA_ENTREGA = @FEntrega where CVEPROVEEDOR = @Cve";
                cmdCreate = new SqlCommand(sentencia, conexion);

                cmdCreate.Parameters.AddWithValue("@NomEmpresa", proveedores.Empresa);
                cmdCreate.Parameters.AddWithValue("@NomEncargado", proveedores.Encargado);
                cmdCreate.Parameters.AddWithValue("@Tel", proveedores.Telefono);
                cmdCreate.Parameters.AddWithValue("@FVisita", proveedores.Fecha_Visita);
                cmdCreate.Parameters.AddWithValue("@FEntrega", proveedores.Fecha_Entrega);
                cmdCreate.Parameters.AddWithValue("@Cve", proveedores.CVEProveedor);

                try
                {
                    conexion.Open();
                    filasafectadas = cmdCreate.ExecuteNonQuery();
                    if (filasafectadas > 0)
                    {
                        Mensaje = "Proveedor actualizado exitosamente";
                        x= true;
                    }

                }
                catch (Exception ex)
                {
                    Mensaje = ex.Message;
                }
            }
            return x;
        }
    }
}
