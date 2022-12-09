namespace Entrega_Final
{
    partial class Interfaz_Productos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Nud_Precio = new System.Windows.Forms.NumericUpDown();
            this.Nud_Costo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_Eliminar = new CustomControls.RJControls.RJButton();
            this.Btn_Mod = new CustomControls.RJControls.RJButton();
            this.Btn_Agregar = new CustomControls.RJControls.RJButton();
            this.Btn_Cancelar = new CustomControls.RJControls.RJButton();
            this.Btn_M = new CustomControls.RJControls.RJButton();
            this.Btn_A = new CustomControls.RJControls.RJButton();
            this.Btn_Buscar = new CustomControls.RJControls.RJButton();
            this.Txt_Id = new CustomControls.RJControls.RJTextBox();
            this.Txt_Descripcion = new CustomControls.RJControls.RJTextBox();
            this.Txt_Nom_Pro = new CustomControls.RJControls.RJTextBox();
            this.CmbEmpresa = new CustomControls.RJControls.RJComboBox();
            this.Dgv_Productos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Precio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Costo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Productos)).BeginInit();
            this.SuspendLayout();
            // 
            // Nud_Precio
            // 
            this.Nud_Precio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Nud_Precio.Location = new System.Drawing.Point(611, 153);
            this.Nud_Precio.Name = "Nud_Precio";
            this.Nud_Precio.Size = new System.Drawing.Size(120, 26);
            this.Nud_Precio.TabIndex = 96;
            // 
            // Nud_Costo
            // 
            this.Nud_Costo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Nud_Costo.Location = new System.Drawing.Point(792, 153);
            this.Nud_Costo.Name = "Nud_Costo";
            this.Nud_Costo.Size = new System.Drawing.Size(120, 26);
            this.Nud_Costo.TabIndex = 97;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(631, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 29);
            this.label1.TabIndex = 106;
            this.label1.Text = "Nombre producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(890, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 29);
            this.label2.TabIndex = 107;
            this.label2.Text = "Empresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1150, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 29);
            this.label3.TabIndex = 108;
            this.label3.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(617, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 29);
            this.label4.TabIndex = 109;
            this.label4.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(787, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 29);
            this.label5.TabIndex = 110;
            this.label5.Text = "Costo";
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_Eliminar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_Eliminar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Eliminar.BorderRadius = 0;
            this.Btn_Eliminar.BorderSize = 0;
            this.Btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.Btn_Eliminar.Location = new System.Drawing.Point(53, 170);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(150, 40);
            this.Btn_Eliminar.TabIndex = 105;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.TextColor = System.Drawing.Color.White;
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Mod
            // 
            this.Btn_Mod.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_Mod.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_Mod.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Mod.BorderRadius = 0;
            this.Btn_Mod.BorderSize = 0;
            this.Btn_Mod.FlatAppearance.BorderSize = 0;
            this.Btn_Mod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Mod.ForeColor = System.Drawing.Color.White;
            this.Btn_Mod.Location = new System.Drawing.Point(53, 116);
            this.Btn_Mod.Name = "Btn_Mod";
            this.Btn_Mod.Size = new System.Drawing.Size(150, 40);
            this.Btn_Mod.TabIndex = 104;
            this.Btn_Mod.Text = "Modificar";
            this.Btn_Mod.TextColor = System.Drawing.Color.White;
            this.Btn_Mod.UseVisualStyleBackColor = false;
            this.Btn_Mod.Click += new System.EventHandler(this.Btn_Mod_Click);
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_Agregar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_Agregar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Agregar.BorderRadius = 0;
            this.Btn_Agregar.BorderSize = 0;
            this.Btn_Agregar.FlatAppearance.BorderSize = 0;
            this.Btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Agregar.ForeColor = System.Drawing.Color.White;
            this.Btn_Agregar.Location = new System.Drawing.Point(53, 62);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(150, 40);
            this.Btn_Agregar.TabIndex = 103;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.TextColor = System.Drawing.Color.White;
            this.Btn_Agregar.UseVisualStyleBackColor = false;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_Cancelar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_Cancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Cancelar.BorderRadius = 0;
            this.Btn_Cancelar.BorderSize = 0;
            this.Btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancelar.ForeColor = System.Drawing.Color.White;
            this.Btn_Cancelar.Location = new System.Drawing.Point(1202, 157);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(150, 40);
            this.Btn_Cancelar.TabIndex = 102;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.TextColor = System.Drawing.Color.White;
            this.Btn_Cancelar.UseVisualStyleBackColor = false;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_M
            // 
            this.Btn_M.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_M.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_M.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_M.BorderRadius = 0;
            this.Btn_M.BorderSize = 0;
            this.Btn_M.FlatAppearance.BorderSize = 0;
            this.Btn_M.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_M.ForeColor = System.Drawing.Color.White;
            this.Btn_M.Location = new System.Drawing.Point(1005, 185);
            this.Btn_M.Name = "Btn_M";
            this.Btn_M.Size = new System.Drawing.Size(150, 40);
            this.Btn_M.TabIndex = 101;
            this.Btn_M.Text = "Modificar";
            this.Btn_M.TextColor = System.Drawing.Color.White;
            this.Btn_M.UseVisualStyleBackColor = false;
            this.Btn_M.Click += new System.EventHandler(this.Btn_M_Click);
            // 
            // Btn_A
            // 
            this.Btn_A.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_A.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_A.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_A.BorderRadius = 0;
            this.Btn_A.BorderSize = 0;
            this.Btn_A.FlatAppearance.BorderSize = 0;
            this.Btn_A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_A.ForeColor = System.Drawing.Color.White;
            this.Btn_A.Location = new System.Drawing.Point(1005, 139);
            this.Btn_A.Name = "Btn_A";
            this.Btn_A.Size = new System.Drawing.Size(150, 40);
            this.Btn_A.TabIndex = 100;
            this.Btn_A.Text = "Agregar";
            this.Btn_A.TextColor = System.Drawing.Color.White;
            this.Btn_A.UseVisualStyleBackColor = false;
            this.Btn_A.Click += new System.EventHandler(this.Btn_A_Click);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_Buscar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_Buscar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Buscar.BorderRadius = 0;
            this.Btn_Buscar.BorderSize = 0;
            this.Btn_Buscar.FlatAppearance.BorderSize = 0;
            this.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Buscar.ForeColor = System.Drawing.Color.White;
            this.Btn_Buscar.Location = new System.Drawing.Point(356, 139);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(150, 40);
            this.Btn_Buscar.TabIndex = 99;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.TextColor = System.Drawing.Color.White;
            this.Btn_Buscar.UseVisualStyleBackColor = false;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Txt_Id
            // 
            this.Txt_Id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Txt_Id.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Txt_Id.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Txt_Id.BorderRadius = 0;
            this.Txt_Id.BorderSize = 2;
            this.Txt_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Id.ForeColor = System.Drawing.Color.White;
            this.Txt_Id.Location = new System.Drawing.Point(308, 93);
            this.Txt_Id.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Id.Multiline = false;
            this.Txt_Id.Name = "Txt_Id";
            this.Txt_Id.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Txt_Id.PasswordChar = false;
            this.Txt_Id.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Txt_Id.PlaceholderText = "";
            this.Txt_Id.Size = new System.Drawing.Size(250, 39);
            this.Txt_Id.TabIndex = 98;
            this.Txt_Id.UnderlinedStyle = true;
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Txt_Descripcion.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Txt_Descripcion.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Txt_Descripcion.BorderRadius = 0;
            this.Txt_Descripcion.BorderSize = 2;
            this.Txt_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Descripcion.ForeColor = System.Drawing.Color.White;
            this.Txt_Descripcion.Location = new System.Drawing.Point(1138, 60);
            this.Txt_Descripcion.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Descripcion.Multiline = false;
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Txt_Descripcion.PasswordChar = false;
            this.Txt_Descripcion.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Txt_Descripcion.PlaceholderText = "";
            this.Txt_Descripcion.Size = new System.Drawing.Size(250, 39);
            this.Txt_Descripcion.TabIndex = 95;
            this.Txt_Descripcion.UnderlinedStyle = true;
            // 
            // Txt_Nom_Pro
            // 
            this.Txt_Nom_Pro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Txt_Nom_Pro.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Txt_Nom_Pro.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Txt_Nom_Pro.BorderRadius = 0;
            this.Txt_Nom_Pro.BorderSize = 2;
            this.Txt_Nom_Pro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nom_Pro.ForeColor = System.Drawing.Color.White;
            this.Txt_Nom_Pro.Location = new System.Drawing.Point(611, 60);
            this.Txt_Nom_Pro.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Nom_Pro.Multiline = false;
            this.Txt_Nom_Pro.Name = "Txt_Nom_Pro";
            this.Txt_Nom_Pro.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Txt_Nom_Pro.PasswordChar = false;
            this.Txt_Nom_Pro.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Txt_Nom_Pro.PlaceholderText = "";
            this.Txt_Nom_Pro.Size = new System.Drawing.Size(250, 39);
            this.Txt_Nom_Pro.TabIndex = 94;
            this.Txt_Nom_Pro.UnderlinedStyle = true;
            // 
            // CmbEmpresa
            // 
            this.CmbEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CmbEmpresa.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.CmbEmpresa.BorderSize = 1;
            this.CmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CmbEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CmbEmpresa.ForeColor = System.Drawing.Color.White;
            this.CmbEmpresa.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.CmbEmpresa.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CmbEmpresa.ListTextColor = System.Drawing.Color.White;
            this.CmbEmpresa.Location = new System.Drawing.Point(892, 60);
            this.CmbEmpresa.MinimumSize = new System.Drawing.Size(200, 30);
            this.CmbEmpresa.Name = "CmbEmpresa";
            this.CmbEmpresa.Padding = new System.Windows.Forms.Padding(1);
            this.CmbEmpresa.Size = new System.Drawing.Size(200, 39);
            this.CmbEmpresa.TabIndex = 93;
            // 
            // Dgv_Productos
            // 
            this.Dgv_Productos.AllowUserToAddRows = false;
            this.Dgv_Productos.AllowUserToDeleteRows = false;
            this.Dgv_Productos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Productos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Dgv_Productos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Productos.EnableHeadersVisualStyles = false;
            this.Dgv_Productos.Location = new System.Drawing.Point(12, 273);
            this.Dgv_Productos.Name = "Dgv_Productos";
            this.Dgv_Productos.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Productos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Productos.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.Dgv_Productos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Productos.RowTemplate.Height = 28;
            this.Dgv_Productos.Size = new System.Drawing.Size(1406, 538);
            this.Dgv_Productos.TabIndex = 111;
            // 
            // Interfaz_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1430, 823);
            this.Controls.Add(this.Dgv_Productos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Mod);
            this.Controls.Add(this.Btn_Agregar);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_M);
            this.Controls.Add(this.Btn_A);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Txt_Id);
            this.Controls.Add(this.Nud_Costo);
            this.Controls.Add(this.Nud_Precio);
            this.Controls.Add(this.Txt_Descripcion);
            this.Controls.Add(this.Txt_Nom_Pro);
            this.Controls.Add(this.CmbEmpresa);
            this.Name = "Interfaz_Productos";
            this.Text = "Interfaz_Productos";
            this.Load += new System.EventHandler(this.Interfaz_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Precio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Costo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.RJControls.RJComboBox CmbEmpresa;
        private CustomControls.RJControls.RJTextBox Txt_Nom_Pro;
        private CustomControls.RJControls.RJTextBox Txt_Descripcion;
        private System.Windows.Forms.NumericUpDown Nud_Precio;
        private System.Windows.Forms.NumericUpDown Nud_Costo;
        private CustomControls.RJControls.RJTextBox Txt_Id;
        private CustomControls.RJControls.RJButton Btn_Buscar;
        private CustomControls.RJControls.RJButton Btn_A;
        private CustomControls.RJControls.RJButton Btn_M;
        private CustomControls.RJControls.RJButton Btn_Cancelar;
        private CustomControls.RJControls.RJButton Btn_Agregar;
        private CustomControls.RJControls.RJButton Btn_Mod;
        private CustomControls.RJControls.RJButton Btn_Eliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView Dgv_Productos;
    }
}