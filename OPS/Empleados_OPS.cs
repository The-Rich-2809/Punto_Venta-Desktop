using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entrega_Final;
using CustomControls.RJControls;

namespace Prototipo
{
    internal class Empleados_OPS
    {
        public string Mensaje { get; set; }

        public bool ReadAll(string Usuario)
        {
            DataTable tablaEmpleados = new DataTable();
            bool consulta = false;

            Mensaje = String.Empty;
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sentencia = "select * from EMPLEADO where Usuario = @Usuario;";
                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    cmdSelect.Parameters.AddWithValue("@Usuario", Usuario);
                    adapter.SelectCommand = cmdSelect;
                    conexion.Open();
                    adapter.Fill(tablaEmpleados);

                    if (tablaEmpleados.Rows.Count > 0)
                    {
                        Mensaje = "Empleado ya registrado";
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
        public bool New_Empleado(Empleados empleados)
        {
            bool Operacion = false;

            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand Consulta;
                int resultado = 0;
                string SentenciaSQL = @"Insert Into EMPLEADO Values (@Id,LOWER(@User),HASHBYTES('SHA1',@Contra),@Nivel,@Correo,@Nombre,@PrimerA,@SegundoA,@F_Nac,@RFC,@Telefono,@Calle,@NumE,@Code,@City,@Entidad,@F_Con,@Sueldo);";
                Consulta = new SqlCommand(SentenciaSQL, conexion);

                Consulta.Parameters.AddWithValue("@Id", empleados.IdEmpleado);
                Consulta.Parameters.AddWithValue("@User", empleados.Usuario);
                Consulta.Parameters.AddWithValue("@Contra", empleados.Contraseña);
                Consulta.Parameters.AddWithValue("@Nivel", empleados.Nivel_Usuario);
                Consulta.Parameters.AddWithValue("@Correo", empleados.Correo);
                Consulta.Parameters.AddWithValue("@Nombre", empleados.Nombre);
                Consulta.Parameters.AddWithValue("@PrimerA", empleados.PrimerApellido);
                Consulta.Parameters.AddWithValue("@SegundoA", empleados.SegundoApellido);
                Consulta.Parameters.AddWithValue("@F_Nac", empleados.Fecha_Nacimiento);
                Consulta.Parameters.AddWithValue("@RFC", empleados.RFC);
                Consulta.Parameters.AddWithValue("@Telefono", empleados.Telefono);
                Consulta.Parameters.AddWithValue("@Calle", empleados.Calle);
                Consulta.Parameters.AddWithValue("@NumE", empleados.NumExterior);
                Consulta.Parameters.AddWithValue("@Code", empleados.CodePostal);
                Consulta.Parameters.AddWithValue("@City", empleados.Ciudad);
                Consulta.Parameters.AddWithValue("@Entidad", empleados.Entidad);
                Consulta.Parameters.AddWithValue("@F_Con", empleados.Fecha_Contrato);
                Consulta.Parameters.AddWithValue("@Sueldo", empleados.Sueldo);

                try
                {
                    conexion.Open();
                    resultado = Consulta.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        Mensaje = "Empleado registrado correctamente";
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
        public bool Mod_Empleados(Empleados empleados,int Sin_Con)
        {
            bool x = false;
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdCreate;

                int filasafectadas;
                if(Sin_Con == 1)
                {
                    string sentencia = @"update Empleado set Usuario = LOWER(@User), Contrasena = HASHBYTES('SHA1',@Contra), Nivel_Empleado = @Nivel, Correo = @Correo, NOMBRE = @NOMBRE, PRIMERAPELLIDO = @PRIMER, SEGUNDOAPELLIDO = @SEGUNDO, 
                    FECHA_NACIMIENTO = @NACIMIENTO, RFC = @RFC, TELEFONO = @TELEFONO, CALLE = @CALLE, NEXTERIOR = @NEXTERIOR, CodPOSTAL = @CodPOSTAL, CIUDAD = @CIUDAD, 
                    ENTIDAD = @ENTIDAD, FECHACONTRA = @FECHACONTRA, SUELDO = @SUELDO where IdEmpleado = @IdEmpleado;";
                    cmdCreate = new SqlCommand(sentencia, conexion);
                }
                else
                {
                    string sentencia = @"update EMPLEADO set Correo = @Correo, NOMBRE = @NOMBRE, PRIMERAPELLIDO = @PRIMER, SEGUNDOAPELLIDO = @SEGUNDO, 
                    FECHA_NACIMIENTO = @NACIMIENTO, RFC = @RFC, TELEFONO = @TELEFONO, CALLE = @CALLE, NEXTERIOR = @NEXTERIOR, CodPOSTAL = @CodPOSTAL, CIUDAD = @CIUDAD, 
                    ENTIDAD = @ENTIDAD, FECHACONTRA = @FECHACONTRA, SUELDO = @SUELDO where IdEmpleado = @IdEmpleado;";
                    cmdCreate = new SqlCommand(sentencia, conexion);
                }
                if (Sin_Con == 1)
                {
                    cmdCreate.Parameters.AddWithValue("@User", empleados.Usuario);
                    cmdCreate.Parameters.AddWithValue("@Contra", empleados.Contraseña);
                    cmdCreate.Parameters.AddWithValue("@Nivel", empleados.Nivel_Usuario);
                }
                cmdCreate.Parameters.AddWithValue("@Correo", empleados.Correo);
                cmdCreate.Parameters.AddWithValue("@NOMBRE", empleados.Nombre);
                cmdCreate.Parameters.AddWithValue("@PRIMER", empleados.PrimerApellido);
                cmdCreate.Parameters.AddWithValue("@SEGUNDO", empleados.SegundoApellido);
                cmdCreate.Parameters.AddWithValue("@NACIMIENTO", empleados.Fecha_Nacimiento);
                cmdCreate.Parameters.AddWithValue("@RFC", empleados.RFC);
                cmdCreate.Parameters.AddWithValue("@TELEFONO", empleados.Telefono);
                cmdCreate.Parameters.AddWithValue("@CALLE", empleados.Calle);
                cmdCreate.Parameters.AddWithValue("@NEXTERIOR", empleados.NumExterior);
                cmdCreate.Parameters.AddWithValue("@CodPOSTAL", empleados.CodePostal);
                cmdCreate.Parameters.AddWithValue("@CIUDAD", empleados.Ciudad);
                cmdCreate.Parameters.AddWithValue("@ENTIDAD", empleados.Entidad);
                cmdCreate.Parameters.AddWithValue("@FECHACONTRA", empleados.Fecha_Contrato);
                cmdCreate.Parameters.AddWithValue("@SUELDO", empleados.Sueldo);
                cmdCreate.Parameters.AddWithValue("@IdEmpleado", empleados.IdEmpleado);

                try
                {
                    conexion.Open();
                    filasafectadas = cmdCreate.ExecuteNonQuery();
                    if (filasafectadas > 0)
                    {
                        Mensaje = "Usuario actualizado exitosamente";
                        x = true;
                    }

                }
                catch (Exception ex)
                {
                    Mensaje = ex.Message;
                }
            }
            return x;
        }
        public bool Eliminar_Tabla(int i)

        {
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdCreate;
                int filasafectadas;
                string sentencia = @"delete from EMPLEADO where IdEmpleado = @id";
                cmdCreate = new SqlCommand(sentencia, conexion);
                cmdCreate.Parameters.AddWithValue("@id", Convert.ToString(i));
                try
                {
                    conexion.Open();
                    filasafectadas = cmdCreate.ExecuteNonQuery();
                    if (filasafectadas > 0)
                    {
                        Mensaje = "Empleado elimidado exitosamente";
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
        public DataTable Mostrar_Empleados()
        {
            DataTable tablaEmpleados = new DataTable();

            Mensaje = String.Empty;
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sentencia = "select IdEmpleado,Usuario,Nivel_Empleado,Correo,NOMBRE,PRIMERAPELLIDO,SEGUNDOAPELLIDO,FECHA_NACIMIENTO,RFC,TELEFONO,CALLE,NEXTERIOR,CodPOSTAL,CIUDAD,ENTIDAD,FECHACONTRA,SUELDO from EMPLEADO";
                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    adapter.SelectCommand = cmdSelect;
                    conexion.Open();
                    adapter.Fill(tablaEmpleados);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                return tablaEmpleados;
            }
        }

        public RJComboBox LlenaComboRoles(RJComboBox combo)
        {
            using (SqlConnection conexion = Conexion.Conectar())
            {

                SqlCommand cmdSelect;
                SqlDataAdapter AdapterRoles = new SqlDataAdapter();
                DataTable TablaRoles = new DataTable();
                string sentencia = "Select idrol,identificador from rol";
                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    AdapterRoles.SelectCommand = cmdSelect;
                    conexion.Open();
                    AdapterRoles.Fill(TablaRoles);
                    combo.DataSource = TablaRoles;
                    combo.DisplayMember = "identificador";
                    combo.ValueMember = "idrol";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return combo;
        }
        public int generaIdUsuario()
        {
            object tmp;
            int IdEmpleado = 0;
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdCreate;
                string sentencia = "select max(IdEmpleado) from EMPLEADO";
                try
                {
                    cmdCreate = new SqlCommand(sentencia, conexion);
                    conexion.Open();
                    tmp = cmdCreate.ExecuteScalar();
                    if (tmp.Equals(DBNull.Value))
                    {
                        IdEmpleado = 1;
                    }
                    else
                    {
                        IdEmpleado = Convert.ToInt32(tmp);
                        IdEmpleado++;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return IdEmpleado;
        }
    }
}
