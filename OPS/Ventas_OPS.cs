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

namespace Entrega_Final
{
    internal class Ventas_OPS
    {
        public string Mensaje { get; set; }
        public bool ReadAll(Ventas Producto)
        {
            DataTable tablaProductos = new DataTable();

            Mensaje = String.Empty;
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sentencia = "select * from PRODUCTO where IdPRODUCTO = @Id;";
                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    cmdSelect.Parameters.AddWithValue("@Id", Producto.IdProducto);
                    adapter.SelectCommand = cmdSelect;
                    conexion.Open();
                    adapter.Fill(tablaProductos);
                    if (tablaProductos.Rows.Count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Producto No encontrado");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return false;
        }
        //Mostrar Productos
        public DataTable Mostrar_Pro(Ventas ventas)
        {
            DataTable tablaProductos = new DataTable();

            Mensaje = String.Empty;
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sentencia = "select * from PRODUCTO WHERE IdPRODUCTO = @Id";
                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    cmdSelect.Parameters.AddWithValue("@Id", ventas.IdProducto);
                    adapter.SelectCommand = cmdSelect;
                    conexion.Open();
                    adapter.Fill(tablaProductos);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return tablaProductos;
        }
        //Mostrar Ventas
        public DataTable Mostrar_Ventas(Ventas ventas)
        {
            DataTable tablaProductos = new DataTable();

            Mensaje = String.Empty;
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sentencia = "select * from VENTAS WHERE CVEEMPLEADO = @Id";
                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    cmdSelect.Parameters.AddWithValue("@Id", ventas.CveEmpleado);
                    adapter.SelectCommand = cmdSelect;
                    conexion.Open();
                    adapter.Fill(tablaProductos);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return tablaProductos;
        }
        public int generaIdVenta()
        {
            object tmp;
            int IdVenta = 0;
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdCreate;
                string sentencia = "select max(IdVENTA) from VENTAS";
                try
                {
                    cmdCreate = new SqlCommand(sentencia, conexion);
                    conexion.Open();
                    tmp = cmdCreate.ExecuteScalar();
                    if (tmp.Equals(DBNull.Value))
                    {
                        IdVenta = 10;
                    }
                    else
                    {
                        IdVenta = Convert.ToInt32(tmp);
                        IdVenta += 10;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return IdVenta;
        }
        public bool New_Venta(Ventas venta)
        {
            bool operaciones = false;
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand Consulta;
                string sentencia = @"Insert into VENTAS Values(@IdVenta,@Importe,@Fecha,@CveEmpleado)";
                int resultado = 0;

                Consulta = new SqlCommand(sentencia, conexion);
                Consulta.Parameters.AddWithValue("@IdVenta", venta.IdVentas);
                Consulta.Parameters.AddWithValue("@Importe", venta.Importe);
                Consulta.Parameters.AddWithValue("@Fecha", venta.Fecha);
                Consulta.Parameters.AddWithValue("@CveEmpleado", venta.CveEmpleado);

                try
                {
                    conexion.Open();

                    resultado = Consulta.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        Mensaje = "venta registrada correctamente";
                        operaciones = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message); 
                }
            }
            return operaciones;
        }
        public int Extraer_Empleado(Ventas ventas)
        {
            object tmp;
            int IdProveedor = 0;
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdCreate;
                string sentencia = "select IdEmpleado from EMPLEADO where Usuario = @User";
                try
                {
                    cmdCreate = new SqlCommand(sentencia, conexion);
                    cmdCreate.Parameters.AddWithValue("@User",ventas.User);
                    conexion.Open();
                    tmp = cmdCreate.ExecuteScalar();
                    if (tmp.Equals(DBNull.Value))
                    {
                        IdProveedor = 0;
                    }
                    else
                    {
                        IdProveedor = Convert.ToInt32(tmp);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return IdProveedor;
        }
        public DataTable Mostrar_Proveedores(Ventas Venta)
        {
            DataTable tablaProveedores = new DataTable();

            Mensaje = String.Empty;
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sentencia = "select * from VENTAS where CVEEMPLEADO = @User ";
                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    cmdSelect.Parameters.AddWithValue("@User", Venta.CveEmpleado);
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

    }
}
