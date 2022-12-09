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
    }
}
