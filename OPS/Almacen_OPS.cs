using Entrega_Final.Clases;
using Prototipo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entrega_Final.OPS
{
    internal class Almacen_OPS
    {
        public string Mensaje { get; set; }
        public bool Mod_Ex_PRO(Almacen almacen)
        {
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdCreate;

                int filasafectadas;
                string sentencia = @"Update PRODUCTO set EXISTENCIA = @Existencia where IdPRODUCTO = @Id";
                cmdCreate = new SqlCommand(sentencia, conexion);

                cmdCreate.Parameters.AddWithValue("@Existencia", almacen.Cantidad);
                cmdCreate.Parameters.AddWithValue("@Id", almacen.IdP);

                try
                {
                    conexion.Open();
                    filasafectadas = cmdCreate.ExecuteNonQuery();
                    if (filasafectadas > 0)
                    {
                        Mensaje = "Cantidad actualizada exitosamente";
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
        public int Extraer_Cantidad(Almacen almacen)
        {
            object tmp;
            int IdProducto = 0;
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdCreate;
                string sentencia = "select EXISTENCIA from PRODUCTO where IdPRODUCTO = @Id";
                try
                {
                    cmdCreate = new SqlCommand(sentencia, conexion);
                    cmdCreate.Parameters.AddWithValue("@Id", almacen.IdP);
                    conexion.Open();
                    tmp = cmdCreate.ExecuteScalar();
                    if (tmp.Equals(DBNull.Value))
                    {
                        IdProducto = 0;
                    }
                    else
                    {
                        IdProducto = Convert.ToInt32(tmp);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return IdProducto;
        }
    }
}
