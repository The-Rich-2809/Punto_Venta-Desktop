namespace Entrega_Final
{
    partial class Interfaz_Proveedores
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
            this.components = new System.ComponentModel.Container();
            this.Dgv_Proveedores = new System.Windows.Forms.DataGridView();
            this.Agregar_Mod = new System.Windows.Forms.GroupBox();
            this.CmbDiaVisita = new CustomControls.RJControls.RJComboBox();
            this.CmbDiaEntrega = new CustomControls.RJControls.RJComboBox();
            this.Telefono = new CustomControls.RJControls.RJTextBox();
            this.Btn_Cancelar = new CustomControls.RJControls.RJButton();
            this.Nombre_Encargado = new CustomControls.RJControls.RJTextBox();
            this.Agregar_Proveedor = new CustomControls.RJControls.RJButton();
            this.Nombre_Empresa = new CustomControls.RJControls.RJTextBox();
            this.Mod_Pro = new CustomControls.RJControls.RJButton();
            this.ID_Proveedor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Eliminar = new CustomControls.RJControls.RJButton();
            this.Modificar = new CustomControls.RJControls.RJButton();
            this.Agregar = new CustomControls.RJControls.RJButton();
            this.Actualizar = new CustomControls.RJControls.RJButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Proveedores)).BeginInit();
            this.Agregar_Mod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Proveedores
            // 
            this.Dgv_Proveedores.AllowUserToAddRows = false;
            this.Dgv_Proveedores.AllowUserToDeleteRows = false;
            this.Dgv_Proveedores.AllowUserToResizeRows = false;
            this.Dgv_Proveedores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Proveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dgv_Proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Proveedores.Location = new System.Drawing.Point(12, 12);
            this.Dgv_Proveedores.Name = "Dgv_Proveedores";
            this.Dgv_Proveedores.RowHeadersWidth = 62;
            this.Dgv_Proveedores.RowTemplate.Height = 28;
            this.Dgv_Proveedores.Size = new System.Drawing.Size(1965, 309);
            this.Dgv_Proveedores.TabIndex = 12;
            // 
            // Agregar_Mod
            // 
            this.Agregar_Mod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Agregar_Mod.Controls.Add(this.CmbDiaVisita);
            this.Agregar_Mod.Controls.Add(this.CmbDiaEntrega);
            this.Agregar_Mod.Controls.Add(this.Telefono);
            this.Agregar_Mod.Controls.Add(this.Btn_Cancelar);
            this.Agregar_Mod.Controls.Add(this.Nombre_Encargado);
            this.Agregar_Mod.Controls.Add(this.Agregar_Proveedor);
            this.Agregar_Mod.Controls.Add(this.Nombre_Empresa);
            this.Agregar_Mod.Controls.Add(this.Mod_Pro);
            this.Agregar_Mod.Controls.Add(this.ID_Proveedor);
            this.Agregar_Mod.Controls.Add(this.label3);
            this.Agregar_Mod.Controls.Add(this.label6);
            this.Agregar_Mod.Controls.Add(this.label2);
            this.Agregar_Mod.Controls.Add(this.label4);
            this.Agregar_Mod.Controls.Add(this.label5);
            this.Agregar_Mod.Controls.Add(this.label1);
            this.Agregar_Mod.Controls.Add(this.label7);
            this.Agregar_Mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregar_Mod.ForeColor = System.Drawing.Color.White;
            this.Agregar_Mod.Location = new System.Drawing.Point(350, 387);
            this.Agregar_Mod.Name = "Agregar_Mod";
            this.Agregar_Mod.Size = new System.Drawing.Size(1367, 378);
            this.Agregar_Mod.TabIndex = 17;
            this.Agregar_Mod.TabStop = false;
            this.Agregar_Mod.Text = "Editar";
            // 
            // CmbDiaVisita
            // 
            this.CmbDiaVisita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CmbDiaVisita.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.CmbDiaVisita.BorderSize = 1;
            this.CmbDiaVisita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CmbDiaVisita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CmbDiaVisita.ForeColor = System.Drawing.Color.White;
            this.CmbDiaVisita.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.CmbDiaVisita.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sábado",
            "Domingo"});
            this.CmbDiaVisita.ListBackColor = System.Drawing.Color.DimGray;
            this.CmbDiaVisita.ListTextColor = System.Drawing.Color.White;
            this.CmbDiaVisita.Location = new System.Drawing.Point(782, 194);
            this.CmbDiaVisita.MinimumSize = new System.Drawing.Size(200, 30);
            this.CmbDiaVisita.Name = "CmbDiaVisita";
            this.CmbDiaVisita.Padding = new System.Windows.Forms.Padding(1);
            this.CmbDiaVisita.Size = new System.Drawing.Size(200, 30);
            this.CmbDiaVisita.TabIndex = 117;
            // 
            // CmbDiaEntrega
            // 
            this.CmbDiaEntrega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CmbDiaEntrega.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.CmbDiaEntrega.BorderSize = 1;
            this.CmbDiaEntrega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CmbDiaEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CmbDiaEntrega.ForeColor = System.Drawing.Color.White;
            this.CmbDiaEntrega.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.CmbDiaEntrega.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sábado",
            "Domingo"});
            this.CmbDiaEntrega.ListBackColor = System.Drawing.Color.DimGray;
            this.CmbDiaEntrega.ListTextColor = System.Drawing.Color.White;
            this.CmbDiaEntrega.Location = new System.Drawing.Point(1005, 194);
            this.CmbDiaEntrega.MinimumSize = new System.Drawing.Size(200, 30);
            this.CmbDiaEntrega.Name = "CmbDiaEntrega";
            this.CmbDiaEntrega.Padding = new System.Windows.Forms.Padding(1);
            this.CmbDiaEntrega.Size = new System.Drawing.Size(200, 30);
            this.CmbDiaEntrega.TabIndex = 116;
            // 
            // Telefono
            // 
            this.Telefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Telefono.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.Telefono.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Telefono.BorderRadius = 0;
            this.Telefono.BorderSize = 2;
            this.Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefono.ForeColor = System.Drawing.Color.White;
            this.Telefono.Location = new System.Drawing.Point(573, 185);
            this.Telefono.Margin = new System.Windows.Forms.Padding(4);
            this.Telefono.Multiline = false;
            this.Telefono.Name = "Telefono";
            this.Telefono.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Telefono.PasswordChar = false;
            this.Telefono.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Telefono.PlaceholderText = "";
            this.Telefono.Size = new System.Drawing.Size(168, 44);
            this.Telefono.TabIndex = 24;
            this.Telefono.UnderlinedStyle = true;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.Btn_Cancelar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.Btn_Cancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Cancelar.BorderRadius = 20;
            this.Btn_Cancelar.BorderSize = 0;
            this.Btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancelar.ForeColor = System.Drawing.Color.White;
            this.Btn_Cancelar.Location = new System.Drawing.Point(770, 241);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(150, 40);
            this.Btn_Cancelar.TabIndex = 20;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.TextColor = System.Drawing.Color.White;
            this.Btn_Cancelar.UseVisualStyleBackColor = false;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Nombre_Encargado
            // 
            this.Nombre_Encargado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Nombre_Encargado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.Nombre_Encargado.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Nombre_Encargado.BorderRadius = 0;
            this.Nombre_Encargado.BorderSize = 2;
            this.Nombre_Encargado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_Encargado.ForeColor = System.Drawing.Color.White;
            this.Nombre_Encargado.Location = new System.Drawing.Point(367, 185);
            this.Nombre_Encargado.Margin = new System.Windows.Forms.Padding(4);
            this.Nombre_Encargado.Multiline = false;
            this.Nombre_Encargado.Name = "Nombre_Encargado";
            this.Nombre_Encargado.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Nombre_Encargado.PasswordChar = false;
            this.Nombre_Encargado.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Nombre_Encargado.PlaceholderText = "";
            this.Nombre_Encargado.Size = new System.Drawing.Size(167, 44);
            this.Nombre_Encargado.TabIndex = 23;
            this.Nombre_Encargado.UnderlinedStyle = true;
            // 
            // Agregar_Proveedor
            // 
            this.Agregar_Proveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.Agregar_Proveedor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.Agregar_Proveedor.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Agregar_Proveedor.BorderRadius = 20;
            this.Agregar_Proveedor.BorderSize = 0;
            this.Agregar_Proveedor.FlatAppearance.BorderSize = 0;
            this.Agregar_Proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Agregar_Proveedor.ForeColor = System.Drawing.Color.White;
            this.Agregar_Proveedor.Location = new System.Drawing.Point(428, 241);
            this.Agregar_Proveedor.Name = "Agregar_Proveedor";
            this.Agregar_Proveedor.Size = new System.Drawing.Size(166, 40);
            this.Agregar_Proveedor.TabIndex = 115;
            this.Agregar_Proveedor.Text = "Agregar Proveedor";
            this.Agregar_Proveedor.TextColor = System.Drawing.Color.White;
            this.Agregar_Proveedor.UseVisualStyleBackColor = false;
            this.Agregar_Proveedor.Click += new System.EventHandler(this.Agregar_Proveedor_Click);
            // 
            // Nombre_Empresa
            // 
            this.Nombre_Empresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Nombre_Empresa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.Nombre_Empresa.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Nombre_Empresa.BorderRadius = 0;
            this.Nombre_Empresa.BorderSize = 2;
            this.Nombre_Empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_Empresa.ForeColor = System.Drawing.Color.White;
            this.Nombre_Empresa.Location = new System.Drawing.Point(159, 185);
            this.Nombre_Empresa.Margin = new System.Windows.Forms.Padding(4);
            this.Nombre_Empresa.Multiline = false;
            this.Nombre_Empresa.Name = "Nombre_Empresa";
            this.Nombre_Empresa.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Nombre_Empresa.PasswordChar = false;
            this.Nombre_Empresa.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Nombre_Empresa.PlaceholderText = "";
            this.Nombre_Empresa.Size = new System.Drawing.Size(166, 44);
            this.Nombre_Empresa.TabIndex = 22;
            this.Nombre_Empresa.UnderlinedStyle = true;
            // 
            // Mod_Pro
            // 
            this.Mod_Pro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.Mod_Pro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.Mod_Pro.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Mod_Pro.BorderRadius = 20;
            this.Mod_Pro.BorderSize = 0;
            this.Mod_Pro.FlatAppearance.BorderSize = 0;
            this.Mod_Pro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mod_Pro.ForeColor = System.Drawing.Color.White;
            this.Mod_Pro.Location = new System.Drawing.Point(600, 241);
            this.Mod_Pro.Name = "Mod_Pro";
            this.Mod_Pro.Size = new System.Drawing.Size(164, 40);
            this.Mod_Pro.TabIndex = 19;
            this.Mod_Pro.Text = "Modificar Proveedor";
            this.Mod_Pro.TextColor = System.Drawing.Color.White;
            this.Mod_Pro.UseVisualStyleBackColor = false;
            this.Mod_Pro.Click += new System.EventHandler(this.Mod_Pro_Click);
            // 
            // ID_Proveedor
            // 
            this.ID_Proveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ID_Proveedor.AutoSize = true;
            this.ID_Proveedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ID_Proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_Proveedor.ForeColor = System.Drawing.Color.White;
            this.ID_Proveedor.Location = new System.Drawing.Point(471, 120);
            this.ID_Proveedor.Name = "ID_Proveedor";
            this.ID_Proveedor.Size = new System.Drawing.Size(28, 22);
            this.ID_Proveedor.TabIndex = 114;
            this.ID_Proveedor.Text = "ID";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(569, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 89;
            this.label3.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(363, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 113;
            this.label6.Text = "ID Proveedor";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(363, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 87;
            this.label2.Text = "Nombre del Encargado";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(153, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 32);
            this.label4.TabIndex = 91;
            this.label4.Text = "Proveedores";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(778, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 92;
            this.label5.Text = "Día de Visita";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(154, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 85;
            this.label1.Text = "Nombre de la Empresa";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1001, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 93;
            this.label7.Text = "Día de Entrega";
            // 
            // Eliminar
            // 
            this.Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.Eliminar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.Eliminar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Eliminar.BorderRadius = 20;
            this.Eliminar.BorderSize = 0;
            this.Eliminar.FlatAppearance.BorderSize = 0;
            this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.ForeColor = System.Drawing.Color.White;
            this.Eliminar.Location = new System.Drawing.Point(1118, 327);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(118, 40);
            this.Eliminar.TabIndex = 21;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.TextColor = System.Drawing.Color.White;
            this.Eliminar.UseVisualStyleBackColor = false;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Modificar
            // 
            this.Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.Modificar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.Modificar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Modificar.BorderRadius = 20;
            this.Modificar.BorderSize = 0;
            this.Modificar.FlatAppearance.BorderSize = 0;
            this.Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modificar.ForeColor = System.Drawing.Color.White;
            this.Modificar.Location = new System.Drawing.Point(996, 327);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(116, 40);
            this.Modificar.TabIndex = 20;
            this.Modificar.Text = "Modificar";
            this.Modificar.TextColor = System.Drawing.Color.White;
            this.Modificar.UseVisualStyleBackColor = false;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // Agregar
            // 
            this.Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.Agregar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.Agregar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Agregar.BorderRadius = 20;
            this.Agregar.BorderSize = 0;
            this.Agregar.FlatAppearance.BorderSize = 0;
            this.Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregar.ForeColor = System.Drawing.Color.White;
            this.Agregar.Location = new System.Drawing.Point(874, 327);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(116, 40);
            this.Agregar.TabIndex = 19;
            this.Agregar.Text = "Agregar";
            this.Agregar.TextColor = System.Drawing.Color.White;
            this.Agregar.UseVisualStyleBackColor = false;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Actualizar
            // 
            this.Actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.Actualizar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.Actualizar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Actualizar.BorderRadius = 20;
            this.Actualizar.BorderSize = 0;
            this.Actualizar.FlatAppearance.BorderSize = 0;
            this.Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actualizar.ForeColor = System.Drawing.Color.White;
            this.Actualizar.Location = new System.Drawing.Point(720, 327);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(150, 40);
            this.Actualizar.TabIndex = 18;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.TextColor = System.Drawing.Color.White;
            this.Actualizar.UseVisualStyleBackColor = false;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Interfaz_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1989, 876);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.Agregar_Mod);
            this.Controls.Add(this.Dgv_Proveedores);
            this.Name = "Interfaz_Proveedores";
            this.Text = "Interfaz_Proveedores";
            this.Load += new System.EventHandler(this.Interfaz_Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Proveedores)).EndInit();
            this.Agregar_Mod.ResumeLayout(false);
            this.Agregar_Mod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Proveedores;
        private System.Windows.Forms.GroupBox Agregar_Mod;
        private System.Windows.Forms.Label ID_Proveedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton Actualizar;
        private CustomControls.RJControls.RJButton Agregar_Proveedor;
        private CustomControls.RJControls.RJButton Mod_Pro;
        private CustomControls.RJControls.RJButton Btn_Cancelar;
        private CustomControls.RJControls.RJButton Agregar;
        private CustomControls.RJControls.RJButton Modificar;
        private CustomControls.RJControls.RJButton Eliminar;
        private CustomControls.RJControls.RJTextBox Nombre_Empresa;
        private CustomControls.RJControls.RJTextBox Nombre_Encargado;
        private CustomControls.RJControls.RJTextBox Telefono;
        private CustomControls.RJControls.RJComboBox CmbDiaVisita;
        private CustomControls.RJControls.RJComboBox CmbDiaEntrega;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}