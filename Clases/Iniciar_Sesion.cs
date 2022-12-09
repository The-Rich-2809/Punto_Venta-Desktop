using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entrega_Final;

namespace Prototipo
{
    internal class Iniciar_Sesion
    {
        
        public bool In_Sesion(string Usuer,string Contra)
        {
            DataTable tablaUsuarios = new DataTable();

            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sentencia = @"Select * from EMPLEADO where Usuario = @idusuario and Contrasena = HASHBYTES('SHA1',@Con);";
                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    cmdSelect.Parameters.AddWithValue("@idusuario", Usuer);
                    cmdSelect.Parameters.AddWithValue("@Con", Contra);
                    adapter.SelectCommand = cmdSelect;
                    conexion.Open();
                    adapter.Fill(tablaUsuarios);

                    if (tablaUsuarios.Rows.Count > 0)
                    {
                        string nivel = tablaUsuarios.Rows[0]["Nivel_Empleado"].ToString();
                        if (nivel == "0")
                        {
                            Interfaz_Em interfaz_Em = new Interfaz_Em();
                            interfaz_Em.Usuario.Text = Usuer;
                            interfaz_Em.ShowDialog();
                            return true;
                        }
                        if (nivel == "1")
                        {
                            Interfaz_Admin interfaz_Admin = new Interfaz_Admin();
                            interfaz_Admin.Usuario.Text = Usuer;
                            interfaz_Admin.ShowDialog();
                            return true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usario y/o contraseña incorrectos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return false;
        }
    }
}
