using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//agregar estas clases
using System.Data;
using System.Data.SqlClient;

namespace Entrega_Final
{
    public class Conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection conexion;
            SqlConnectionStringBuilder CadenaConexion = new SqlConnectionStringBuilder();

            //(localdb)\MSSQLLocalDB Conexion pruebas
            CadenaConexion.DataSource = @"(localdb)\MSSQLLocalDB";
            CadenaConexion.IntegratedSecurity = true;
            CadenaConexion.InitialCatalog = "TiendaAbarrotes";           
            conexion = new SqlConnection(CadenaConexion.ConnectionString);
            return conexion;
        }
    }
}
