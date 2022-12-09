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
    public partial class Interfaz_Empleados : Form
    {
        int mod;
        public Interfaz_Empleados()
        {
            InitializeComponent();
            BackColor= Color.FromArgb(25,25,25);
            foreach(Control c in this.Agregar_Mod.Controls)
            {
                c.ForeColor= Color.White;
            }
        }
        private void Interfaz_Empleados_Load(object sender, EventArgs e)
        {
            MostrarEm();
            this.Dgv_Empleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Agregar_Mod.Enabled = false;
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            MostrarEm();
        }
        private void Agregar_Click(object sender, EventArgs e)
        {
            Empleados_OPS empleados_OPS = new Empleados_OPS();
            ID_Empleado.Text = Convert.ToString(empleados_OPS.generaIdUsuario());
            Mostrar(false, true);
            Btn_Registrar.Enabled = true;
            Btn_Mod.Enabled = false;
            Mod_User.Enabled = false;
            Agregar_Mod.Enabled = true;
            Cb_Nivel_User = empleados_OPS.LlenaComboRoles(Cb_Nivel_User);
        }
        private void Modificar_Click(object sender, EventArgs e)
        {
            if (Dgv_Empleados.Rows.Count > 0)
            {
                Llenar();
                Mostrar(false, true);
                Btn_Registrar.Enabled = false;
                Btn_Mod.Enabled = true;
                Mod_User.Enabled = true;
                Gb_Datos_User.Enabled = false;
            }
            else
            {
                MessageBox.Show("No hay datos a modificar");
            }
            mod = 0;
        }
        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (Dgv_Empleados.Rows.Count > 0)
            {
                Empleados_OPS empleados_OPS = new Empleados_OPS();
                int RenglonSeleccionado = Dgv_Empleados.CurrentRow.Index;
                int Id = Convert.ToInt32(Dgv_Empleados.Rows[RenglonSeleccionado].Cells[0].Value.ToString());
                DialogResult Resultado = MessageBox.Show("¿Desea eliminar al Empleado con Id " + Id + "?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Resultado == DialogResult.Yes)
                {
                    if (empleados_OPS.Eliminar_Tabla(Id))
                    {
                        MessageBox.Show(empleados_OPS.Mensaje);
                    }
                    else
                    {
                        MessageBox.Show(empleados_OPS.Mensaje);
                    }
                    MostrarEm();
                }
            }
            else
            {
                MessageBox.Show("No hay datos a eliminar");
            }
        }

        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
            Empleados empleados = new Empleados();
            Empleados_OPS empleados_OPS = new Empleados_OPS();

            empleados.IdEmpleado = Convert.ToInt32(ID_Empleado.Text);
            empleados.Usuario = Usuario.Text;
            empleados.Contraseña = Contraseña.Text;
            if(Cb_Nivel_User.Text == "Usuario"){empleados.Nivel_Usuario = "0";} else {empleados.Nivel_Usuario = "1";}
            empleados.Nombre = Txt_Nombre.Text;
            empleados.PrimerApellido = Txt_1Apellido.Text;
            empleados.SegundoApellido = Txt_2Apellido.Text;
            empleados.RFC = Txt_RFC.Text;
            empleados.Telefono = Txt_Telefono.Text;
            empleados.Fecha_Nacimiento = Dtp_Fecha_Nacimiento.Value.Year.ToString() + "/" + Dtp_Fecha_Nacimiento.Value.Month.ToString() + "/" + Dtp_Fecha_Nacimiento.Value.Day.ToString();
            empleados.Correo = Txt_Correo.Text;
            empleados.Calle = Txt_Calle.Text;
            empleados.NumExterior = Txt_NumExterior.Text;
            empleados.CodePostal = Txt_CP.Text;
            empleados.Ciudad = Txt_Ciudad.Text;
            empleados.Entidad = Cb_Entidad.Text;
            empleados.Fecha_Contrato = Dtp_Fecha_Contrato.Value.Year.ToString() + "/" + Dtp_Fecha_Contrato.Value.Month.ToString() + "/" + Dtp_Fecha_Contrato.Value.Day.ToString();
            empleados.Sueldo = Txt_Sueldo.Text;

            if (Validar(1))
            {
                QuitarValidar();
                if (Contraseña.Text == Rep_Contraseña.Text)
                {
                    errorProvider1.SetError(Contraseña, "");
                    errorProvider1.SetError(Rep_Contraseña, "");
                    if (empleados_OPS.ReadAll(Usuario.Text))
                    {
                        if (empleados_OPS.New_Empleado(empleados))
                        {
                            MessageBox.Show(empleados_OPS.Mensaje);
                            Cancelar();
                            MostrarEm();
                        }
                        else
                        {
                            MessageBox.Show(empleados_OPS.Mensaje);
                        }
                    } else{errorProvider1.SetError(Usuario, "Intenta con otro Usuario");}
                }
                else
                {                   
                    errorProvider1.SetError(Contraseña, "Contraseñas diferentes");
                    errorProvider1.SetError(Rep_Contraseña, "Contraseñas diferentes");
                }
            }

        }
        private void Btn_Mod_Click(object sender, EventArgs e)
        {
            Empleados empleados = new Empleados();
            Empleados_OPS empleados_OPS = new Empleados_OPS();

            int RenglonSeleccionado = Dgv_Empleados.CurrentRow.Index;
            string user = Dgv_Empleados.Rows[RenglonSeleccionado].Cells[1].Value.ToString();
            empleados.IdEmpleado = Convert.ToInt32(ID_Empleado.Text);
            empleados.Usuario = Usuario.Text;
            empleados.Contraseña = Contraseña.Text;
            if(Cb_Nivel_User.Text == "usuario") { empleados.Nivel_Usuario = "0"; } else { empleados.Nivel_Usuario = "1";}
            empleados.Nombre = Txt_Nombre.Text;
            empleados.PrimerApellido = Txt_1Apellido.Text;
            empleados.SegundoApellido = Txt_2Apellido.Text;
            empleados.RFC = Txt_RFC.Text;
            empleados.Telefono = Txt_Telefono.Text;
            empleados.Fecha_Nacimiento = Dtp_Fecha_Nacimiento.Value.Year.ToString() + "/" + Dtp_Fecha_Nacimiento.Value.Month.ToString() + "/" + Dtp_Fecha_Nacimiento.Value.Day.ToString();
            empleados.Correo = Txt_Correo.Text;
            empleados.Calle = Txt_Calle.Text;
            empleados.NumExterior = Txt_NumExterior.Text;
            empleados.CodePostal = Txt_CP.Text;
            empleados.Ciudad = Txt_Ciudad.Text;
            empleados.Entidad = Cb_Entidad.Text;
            empleados.Fecha_Contrato = Dtp_Fecha_Contrato.Value.Year.ToString() + "/" + Dtp_Fecha_Contrato.Value.Month.ToString() + "/" + Dtp_Fecha_Contrato.Value.Day.ToString();
            empleados.Sueldo = Txt_Sueldo.Text;

            if (Validar(mod))
            {
                QuitarValidar();
                if(mod == 1)
                {
                    if (Contraseña.Text == Rep_Contraseña.Text)
                    {
                        errorProvider1.SetError(Contraseña, "");
                        errorProvider1.SetError(Rep_Contraseña, "");
                        if (user == Usuario.Text)
                        {
                            DialogResult Resultado = MessageBox.Show("¿Deseas modificar al Empleado " + user + "?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (Resultado == DialogResult.Yes)
                            {
                                if (empleados_OPS.Mod_Empleados(empleados, mod))
                                {
                                    MessageBox.Show(empleados_OPS.Mensaje);
                                    Cancelar();
                                    MostrarEm();
                                }
                                else
                                {
                                    MessageBox.Show(empleados_OPS.Mensaje);
                                }
                            }
                        }
                        else
                        {
                            if (empleados_OPS.ReadAll(Usuario.Text))
                            {
                                DialogResult Resultado = MessageBox.Show("¿Deseas modificar al Empleado " + user + "?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                if (Resultado == DialogResult.Yes)
                                {
                                    if (empleados_OPS.Mod_Empleados(empleados, mod))
                                    {
                                        MessageBox.Show(empleados_OPS.Mensaje);
                                        Cancelar();
                                        MostrarEm();
                                    }
                                    else
                                    {
                                        MessageBox.Show(empleados_OPS.Mensaje);
                                    }
                                }
                            }else { errorProvider1.SetError(Usuario, "Intenta con otro Usuario"); }
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(Contraseña, "Contraseñas diferentes");
                        errorProvider1.SetError(Rep_Contraseña, "Contraseñas diferentes");
                    }             
                }
                else
                {
                    DialogResult Resultado = MessageBox.Show("¿Deseas modificar al Empleado " + user + "?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (Resultado == DialogResult.Yes)
                    {
                        if (empleados_OPS.Mod_Empleados(empleados, mod))
                        {
                            MessageBox.Show(empleados_OPS.Mensaje);
                            Cancelar();
                            MostrarEm();
                        }
                        else
                        {
                            MessageBox.Show(empleados_OPS.Mensaje);
                        }
                    }
                }
            }
        }
        private void Mod_User_Click(object sender, EventArgs e)
        {
            Empleados_OPS empleados_OPS = new Empleados_OPS();
            Mod_User.Enabled = false;
            Gb_Datos_User.Enabled = true;
            int RenglonSeleccionado = Dgv_Empleados.CurrentRow.Index;
            Usuario.Text = Dgv_Empleados.Rows[RenglonSeleccionado].Cells[1].Value.ToString();
            Cb_Nivel_User = empleados_OPS.LlenaComboRoles(Cb_Nivel_User);
            if (Dgv_Empleados.Rows[RenglonSeleccionado].Cells[2].Value.ToString() == "0")
            {
                Cb_Nivel_User.Text = "usuario";
            }
            else
            {
                Cb_Nivel_User.Text = "administración";
            }
            mod = 1;
        }
        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        public void Cancelar()
        {
            Mostrar(true, false);
            Limpiar();
        }
        public void Llenar()
        {
            int RenglonSeleccionado = Dgv_Empleados.CurrentRow.Index;
            ID_Empleado.Text = Dgv_Empleados.Rows[RenglonSeleccionado].Cells[0].Value.ToString();
            Txt_Correo.Text = Dgv_Empleados.Rows[RenglonSeleccionado].Cells[3].Value.ToString();
            Txt_Nombre.Text = Dgv_Empleados.Rows[RenglonSeleccionado].Cells[4].Value.ToString();
            Txt_1Apellido.Text = Dgv_Empleados.Rows[RenglonSeleccionado].Cells[5].Value.ToString();
            Txt_2Apellido.Text = Dgv_Empleados.Rows[RenglonSeleccionado].Cells[6].Value.ToString();
            Dtp_Fecha_Nacimiento.Text = Dgv_Empleados.Rows[RenglonSeleccionado].Cells[7].Value.ToString();
            Txt_RFC.Text = Dgv_Empleados.Rows[RenglonSeleccionado].Cells[8].Value.ToString();
            Txt_Telefono.Text = Dgv_Empleados.Rows[RenglonSeleccionado].Cells[9].Value.ToString();
            Txt_Calle.Text = Dgv_Empleados.Rows[RenglonSeleccionado].Cells[10].Value.ToString();
            Txt_NumExterior.Text = Dgv_Empleados.Rows[RenglonSeleccionado].Cells[11].Value.ToString();
            Txt_CP.Text = Dgv_Empleados.Rows[RenglonSeleccionado].Cells[12].Value.ToString();
            Txt_Ciudad.Text = Dgv_Empleados.Rows[RenglonSeleccionado].Cells[13].Value.ToString();
            Cb_Entidad.Text = Dgv_Empleados.Rows[RenglonSeleccionado].Cells[14].Value.ToString();
            Dtp_Fecha_Contrato.Text = Dgv_Empleados.Rows[RenglonSeleccionado].Cells[15].Value.ToString();
            Txt_Sueldo.Text = Dgv_Empleados.Rows[RenglonSeleccionado].Cells[16].Value.ToString();
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
            Gb_Datos_User.Enabled = con;
        }
        public void Limpiar()
        {
            Txt_Nombre.Text = "";
            Txt_1Apellido.Text = "";
            Txt_2Apellido.Text = "";
            Txt_Telefono.Text = "";
            Txt_Calle.Text = "";
            Txt_RFC.Text = "";
            Txt_NumExterior.Text = "";
            Txt_CP.Text = "";
            Txt_Ciudad.Text = "";
            Cb_Entidad.Text = "";
            Txt_Sueldo.Text = "";
            Txt_Correo.Text = "";
            Usuario.Text = "";
            Contraseña.Text = "";
            Rep_Contraseña.Text = "";
            Cb_Nivel_User.Text = "";
            ID_Empleado.Text = "ID"; 
        }
        public void MostrarEm()
        {
            Empleados_OPS empleados = new Empleados_OPS();
            Dgv_Empleados.DataSource = empleados.Mostrar_Empleados();
        }

        public bool Validar(int am)
        {
            bool s = true;

            if(am == 1)
            {
                if (Usuario.Text == "")
                {
                    s = false;
                    errorProvider1.SetError(Usuario, "Ingresa un Usuario");
                }
                if (Contraseña.Text == "")
                {
                    s = false;
                    errorProvider1.SetError(Contraseña, "Inserta una contraseña");
                }
                if (Rep_Contraseña.Text == "")
                {
                    s = false;
                    errorProvider1.SetError(Rep_Contraseña, "Inserta una contraseña");
                }
                if (Cb_Nivel_User.Text == "")
                {
                    s = false;
                    errorProvider1.SetError(Cb_Nivel_User, "Ingresa un Nivel de Usuario");
                }
            }
            if (Txt_Nombre.Text == "")
            {
                s = false;
                errorProvider1.SetError(Txt_Nombre, "Inserta el Nombre de la Empresa");
            }
            if (Txt_1Apellido.Text == "")
            {
                s = false;
                errorProvider1.SetError(Txt_1Apellido, "Inserta el Primer Apellido");
            }
            if (Txt_2Apellido.Text == "")
            {
                s = false;
                errorProvider1.SetError(Txt_2Apellido, "Inserta el Segundo Apellido");
            }
            if (Txt_RFC.Text == "")
            {
                s = false;
                errorProvider1.SetError(Txt_RFC, "Inserta el Primer Apellido");
            }
            if (Txt_Telefono.Text == "")
            {
                s = false;
                errorProvider1.SetError(Txt_Telefono, "Inserta el Primer Apellido");
            }
            if (Txt_Correo.Text == "")
            {
                s = false;
                errorProvider1.SetError(Txt_Correo, "Inserta el Primer Apellido");
            }
            if (Txt_Calle.Text == "")
            {
                s = false;
                errorProvider1.SetError(Txt_Calle, "Inserta el Primer Apellido");
            }
            if (Txt_NumExterior.Text == "")
            {
                s = false;
                errorProvider1.SetError(Txt_NumExterior, "Inserta el Primer Apellido");
            }
            if (Txt_CP.Text == "")
            {
                s = false;
                errorProvider1.SetError(Txt_CP, "Inserta el Primer Apellido");
            }
            if (Txt_Ciudad.Text == "")
            {
                s = false;
                errorProvider1.SetError(Txt_Ciudad, "Inserta el Primer Apellido");
            }
            if (Cb_Entidad.Text == "")
            {
                s = false;
                errorProvider1.SetError(Cb_Entidad, "Inserta el Primer Apellido");
            }
            if (Txt_Sueldo.Text == "")
            {
                s = false;
                errorProvider1.SetError(Txt_Sueldo, "Inserta el Primer Apellido");
            }
            return s;
        }
        public void QuitarValidar()
        {
            errorProvider1.SetError(Usuario, "");
            errorProvider1.SetError(Txt_Nombre, "");
            errorProvider1.SetError(Txt_1Apellido, "");
            errorProvider1.SetError(Txt_2Apellido, "");
            errorProvider1.SetError(Txt_Telefono, "");
            errorProvider1.SetError(Txt_RFC, "");
            errorProvider1.SetError(Txt_Calle, "");
            errorProvider1.SetError(Txt_NumExterior, "");
            errorProvider1.SetError(Txt_CP, "");
            errorProvider1.SetError(Txt_Ciudad, "");
            errorProvider1.SetError(Cb_Entidad, "");
            errorProvider1.SetError(Txt_Sueldo, "");
            errorProvider1.SetError(Txt_Correo, "");
            errorProvider1.SetError(Usuario, "");
            errorProvider1.SetError(Contraseña, "");
            errorProvider1.SetError(Rep_Contraseña, "");
            errorProvider1.SetError(Cb_Nivel_User, "");
        }
    }

}
