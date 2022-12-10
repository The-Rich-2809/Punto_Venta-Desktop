namespace Entrega_Final
{
    partial class Interfaz_Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interfaz_Admin));
            this.Panel_Controles = new System.Windows.Forms.Panel();
            this.Btn_Almacen = new FontAwesome.Sharp.IconButton();
            this.IcoUsuario = new FontAwesome.Sharp.IconPictureBox();
            this.Usuario = new System.Windows.Forms.Label();
            this.Btn_Salir = new FontAwesome.Sharp.IconButton();
            this.Btn_Productos = new FontAwesome.Sharp.IconButton();
            this.Btn_Proveedores = new FontAwesome.Sharp.IconButton();
            this.Btn_Empleados = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Home = new System.Windows.Forms.PictureBox();
            this.Form_Sec = new System.Windows.Forms.Panel();
            this.Panel_Controles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcoUsuario)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Home)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Controles
            // 
            this.Panel_Controles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Panel_Controles.Controls.Add(this.Btn_Almacen);
            this.Panel_Controles.Controls.Add(this.IcoUsuario);
            this.Panel_Controles.Controls.Add(this.Usuario);
            this.Panel_Controles.Controls.Add(this.Btn_Salir);
            this.Panel_Controles.Controls.Add(this.Btn_Productos);
            this.Panel_Controles.Controls.Add(this.Btn_Proveedores);
            this.Panel_Controles.Controls.Add(this.Btn_Empleados);
            this.Panel_Controles.Controls.Add(this.panel1);
            this.Panel_Controles.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Controles.Location = new System.Drawing.Point(0, 0);
            this.Panel_Controles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Panel_Controles.Name = "Panel_Controles";
            this.Panel_Controles.Size = new System.Drawing.Size(1283, 90);
            this.Panel_Controles.TabIndex = 0;
            // 
            // Btn_Almacen
            // 
            this.Btn_Almacen.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_Almacen.FlatAppearance.BorderSize = 0;
            this.Btn_Almacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Almacen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Almacen.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            this.Btn_Almacen.IconColor = System.Drawing.Color.White;
            this.Btn_Almacen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Almacen.IconSize = 60;
            this.Btn_Almacen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Almacen.Location = new System.Drawing.Point(608, 0);
            this.Btn_Almacen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Almacen.Name = "Btn_Almacen";
            this.Btn_Almacen.Padding = new System.Windows.Forms.Padding(7, 0, 13, 0);
            this.Btn_Almacen.Size = new System.Drawing.Size(167, 90);
            this.Btn_Almacen.TabIndex = 14;
            this.Btn_Almacen.Text = "Almacen";
            this.Btn_Almacen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Almacen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Almacen.UseVisualStyleBackColor = true;
            this.Btn_Almacen.Click += new System.EventHandler(this.Btn_Almacen_Click);
            // 
            // IcoUsuario
            // 
            this.IcoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.IcoUsuario.IconChar = FontAwesome.Sharp.IconChar.User;
            this.IcoUsuario.IconColor = System.Drawing.Color.White;
            this.IcoUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcoUsuario.IconSize = 64;
            this.IcoUsuario.Location = new System.Drawing.Point(894, 12);
            this.IcoUsuario.Name = "IcoUsuario";
            this.IcoUsuario.Size = new System.Drawing.Size(73, 64);
            this.IcoUsuario.TabIndex = 0;
            this.IcoUsuario.TabStop = false;
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.ForeColor = System.Drawing.Color.White;
            this.Usuario.Location = new System.Drawing.Point(972, 21);
            this.Usuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(100, 37);
            this.Usuario.TabIndex = 13;
            this.Usuario.Text = "label1";
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Salir.FlatAppearance.BorderSize = 0;
            this.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Salir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Salir.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.Btn_Salir.IconColor = System.Drawing.Color.White;
            this.Btn_Salir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Salir.IconSize = 60;
            this.Btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Salir.Location = new System.Drawing.Point(1124, 0);
            this.Btn_Salir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Padding = new System.Windows.Forms.Padding(7, 0, 13, 0);
            this.Btn_Salir.Size = new System.Drawing.Size(159, 90);
            this.Btn_Salir.TabIndex = 9;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Productos
            // 
            this.Btn_Productos.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_Productos.FlatAppearance.BorderSize = 0;
            this.Btn_Productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Productos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Productos.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.Btn_Productos.IconColor = System.Drawing.Color.White;
            this.Btn_Productos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Productos.IconSize = 60;
            this.Btn_Productos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Productos.Location = new System.Drawing.Point(441, 0);
            this.Btn_Productos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Productos.Name = "Btn_Productos";
            this.Btn_Productos.Padding = new System.Windows.Forms.Padding(7, 0, 13, 0);
            this.Btn_Productos.Size = new System.Drawing.Size(167, 90);
            this.Btn_Productos.TabIndex = 7;
            this.Btn_Productos.Text = "Productos";
            this.Btn_Productos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Productos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Productos.UseVisualStyleBackColor = true;
            this.Btn_Productos.Click += new System.EventHandler(this.Btn_Productos_Click);
            // 
            // Btn_Proveedores
            // 
            this.Btn_Proveedores.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_Proveedores.FlatAppearance.BorderSize = 0;
            this.Btn_Proveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Proveedores.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Proveedores.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.Btn_Proveedores.IconColor = System.Drawing.Color.White;
            this.Btn_Proveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Proveedores.IconSize = 60;
            this.Btn_Proveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Proveedores.Location = new System.Drawing.Point(274, 0);
            this.Btn_Proveedores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Proveedores.Name = "Btn_Proveedores";
            this.Btn_Proveedores.Padding = new System.Windows.Forms.Padding(7, 0, 13, 0);
            this.Btn_Proveedores.Size = new System.Drawing.Size(167, 90);
            this.Btn_Proveedores.TabIndex = 6;
            this.Btn_Proveedores.Text = "Proveedores";
            this.Btn_Proveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Proveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Proveedores.UseVisualStyleBackColor = true;
            this.Btn_Proveedores.Click += new System.EventHandler(this.Btn_Proveedores_Click);
            // 
            // Btn_Empleados
            // 
            this.Btn_Empleados.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_Empleados.FlatAppearance.BorderSize = 0;
            this.Btn_Empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Empleados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Empleados.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.Btn_Empleados.IconColor = System.Drawing.Color.White;
            this.Btn_Empleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Empleados.IconSize = 60;
            this.Btn_Empleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Empleados.Location = new System.Drawing.Point(107, 0);
            this.Btn_Empleados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Empleados.Name = "Btn_Empleados";
            this.Btn_Empleados.Padding = new System.Windows.Forms.Padding(7, 0, 13, 0);
            this.Btn_Empleados.Size = new System.Drawing.Size(167, 90);
            this.Btn_Empleados.TabIndex = 5;
            this.Btn_Empleados.Text = "Empleados";
            this.Btn_Empleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Empleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Empleados.UseVisualStyleBackColor = true;
            this.Btn_Empleados.Click += new System.EventHandler(this.Btn_Empleados_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(107, 90);
            this.panel1.TabIndex = 4;
            // 
            // Btn_Home
            // 
            this.Btn_Home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Home.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Home.Image")));
            this.Btn_Home.Location = new System.Drawing.Point(0, 0);
            this.Btn_Home.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Home.Name = "Btn_Home";
            this.Btn_Home.Size = new System.Drawing.Size(107, 90);
            this.Btn_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Home.TabIndex = 1;
            this.Btn_Home.TabStop = false;
            this.Btn_Home.Click += new System.EventHandler(this.Btn_Home_Click);
            // 
            // Form_Sec
            // 
            this.Form_Sec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Form_Sec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Form_Sec.Location = new System.Drawing.Point(0, 90);
            this.Form_Sec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Form_Sec.Name = "Form_Sec";
            this.Form_Sec.Size = new System.Drawing.Size(1283, 600);
            this.Form_Sec.TabIndex = 1;
            // 
            // Interfaz_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 690);
            this.Controls.Add(this.Form_Sec);
            this.Controls.Add(this.Panel_Controles);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Interfaz_Admin";
            this.Text = "Interfaz_Admin";
            this.Load += new System.EventHandler(this.Interfaz_Admin_Load);
            this.Panel_Controles.ResumeLayout(false);
            this.Panel_Controles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcoUsuario)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Home)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Controles;
        private FontAwesome.Sharp.IconButton Btn_Productos;
        private FontAwesome.Sharp.IconButton Btn_Proveedores;
        private FontAwesome.Sharp.IconButton Btn_Empleados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Btn_Home;
        private FontAwesome.Sharp.IconButton Btn_Salir;
        private System.Windows.Forms.Panel Form_Sec;
        public System.Windows.Forms.Label Usuario;
        private FontAwesome.Sharp.IconPictureBox IcoUsuario;
        private FontAwesome.Sharp.IconButton Btn_Almacen;
    }
}