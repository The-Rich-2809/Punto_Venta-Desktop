namespace Entrega_Final.Forms
{
    partial class Interfaz_Almacen
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
            this.Nud_Existencia = new System.Windows.Forms.NumericUpDown();
            this.Elegir = new System.Windows.Forms.GroupBox();
            this.Tabla = new System.Windows.Forms.RadioButton();
            this.Maquina = new System.Windows.Forms.RadioButton();
            this.Btn_Buscar = new CustomControls.RJControls.RJButton();
            this.Txt_Buscar = new CustomControls.RJControls.RJTextBox();
            this.Btn_Ag = new CustomControls.RJControls.RJButton();
            this.Btn_Cancelar = new CustomControls.RJControls.RJButton();
            this.Btn_Mod = new CustomControls.RJControls.RJButton();
            this.Dgv_Productos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Existencia)).BeginInit();
            this.Elegir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Productos)).BeginInit();
            this.SuspendLayout();
            // 
            // Nud_Existencia
            // 
            this.Nud_Existencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Nud_Existencia.ForeColor = System.Drawing.Color.White;
            this.Nud_Existencia.Location = new System.Drawing.Point(753, 66);
            this.Nud_Existencia.Name = "Nud_Existencia";
            this.Nud_Existencia.Size = new System.Drawing.Size(177, 26);
            this.Nud_Existencia.TabIndex = 15;
            // 
            // Elegir
            // 
            this.Elegir.Controls.Add(this.Tabla);
            this.Elegir.Controls.Add(this.Maquina);
            this.Elegir.ForeColor = System.Drawing.Color.White;
            this.Elegir.Location = new System.Drawing.Point(39, 42);
            this.Elegir.Name = "Elegir";
            this.Elegir.Size = new System.Drawing.Size(241, 156);
            this.Elegir.TabIndex = 20;
            this.Elegir.TabStop = false;
            this.Elegir.Text = "Elegir";
            // 
            // Tabla
            // 
            this.Tabla.AutoSize = true;
            this.Tabla.Location = new System.Drawing.Point(20, 66);
            this.Tabla.Name = "Tabla";
            this.Tabla.Size = new System.Drawing.Size(73, 24);
            this.Tabla.TabIndex = 1;
            this.Tabla.TabStop = true;
            this.Tabla.Text = "Tabla";
            this.Tabla.UseVisualStyleBackColor = true;
            this.Tabla.CheckedChanged += new System.EventHandler(this.Tabla_CheckedChanged);
            // 
            // Maquina
            // 
            this.Maquina.AutoSize = true;
            this.Maquina.Location = new System.Drawing.Point(20, 26);
            this.Maquina.Name = "Maquina";
            this.Maquina.Size = new System.Drawing.Size(95, 24);
            this.Maquina.TabIndex = 0;
            this.Maquina.TabStop = true;
            this.Maquina.Text = "Maquina";
            this.Maquina.UseVisualStyleBackColor = true;
            this.Maquina.CheckedChanged += new System.EventHandler(this.Maquina_CheckedChanged);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(54)))));
            this.Btn_Buscar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(54)))));
            this.Btn_Buscar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Buscar.BorderRadius = 0;
            this.Btn_Buscar.BorderSize = 0;
            this.Btn_Buscar.FlatAppearance.BorderSize = 0;
            this.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Buscar.ForeColor = System.Drawing.Color.White;
            this.Btn_Buscar.Location = new System.Drawing.Point(360, 108);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(177, 39);
            this.Btn_Buscar.TabIndex = 22;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.TextColor = System.Drawing.Color.White;
            this.Btn_Buscar.UseVisualStyleBackColor = false;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Txt_Buscar
            // 
            this.Txt_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Txt_Buscar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(54)))));
            this.Txt_Buscar.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.Txt_Buscar.BorderRadius = 0;
            this.Txt_Buscar.BorderSize = 2;
            this.Txt_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Buscar.ForeColor = System.Drawing.Color.White;
            this.Txt_Buscar.Location = new System.Drawing.Point(319, 53);
            this.Txt_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Buscar.Multiline = false;
            this.Txt_Buscar.Name = "Txt_Buscar";
            this.Txt_Buscar.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Txt_Buscar.PasswordChar = false;
            this.Txt_Buscar.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Txt_Buscar.PlaceholderText = "";
            this.Txt_Buscar.Size = new System.Drawing.Size(250, 39);
            this.Txt_Buscar.TabIndex = 21;
            this.Txt_Buscar.UnderlinedStyle = true;
            // 
            // Btn_Ag
            // 
            this.Btn_Ag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(54)))));
            this.Btn_Ag.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(54)))));
            this.Btn_Ag.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Ag.BorderRadius = 0;
            this.Btn_Ag.BorderSize = 0;
            this.Btn_Ag.FlatAppearance.BorderSize = 0;
            this.Btn_Ag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ag.ForeColor = System.Drawing.Color.White;
            this.Btn_Ag.Location = new System.Drawing.Point(849, 108);
            this.Btn_Ag.Name = "Btn_Ag";
            this.Btn_Ag.Size = new System.Drawing.Size(177, 40);
            this.Btn_Ag.TabIndex = 19;
            this.Btn_Ag.Text = "Agregar";
            this.Btn_Ag.TextColor = System.Drawing.Color.White;
            this.Btn_Ag.UseVisualStyleBackColor = false;
            this.Btn_Ag.Click += new System.EventHandler(this.Btn_Ag_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(54)))));
            this.Btn_Cancelar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(54)))));
            this.Btn_Cancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Cancelar.BorderRadius = 0;
            this.Btn_Cancelar.BorderSize = 0;
            this.Btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancelar.ForeColor = System.Drawing.Color.White;
            this.Btn_Cancelar.Location = new System.Drawing.Point(518, 196);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(177, 40);
            this.Btn_Cancelar.TabIndex = 17;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.TextColor = System.Drawing.Color.White;
            this.Btn_Cancelar.UseVisualStyleBackColor = false;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Mod
            // 
            this.Btn_Mod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(54)))));
            this.Btn_Mod.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(54)))));
            this.Btn_Mod.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Mod.BorderRadius = 0;
            this.Btn_Mod.BorderSize = 0;
            this.Btn_Mod.FlatAppearance.BorderSize = 0;
            this.Btn_Mod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Mod.ForeColor = System.Drawing.Color.White;
            this.Btn_Mod.Location = new System.Drawing.Point(666, 108);
            this.Btn_Mod.Name = "Btn_Mod";
            this.Btn_Mod.Size = new System.Drawing.Size(177, 39);
            this.Btn_Mod.TabIndex = 16;
            this.Btn_Mod.Text = "Modificar";
            this.Btn_Mod.TextColor = System.Drawing.Color.White;
            this.Btn_Mod.UseVisualStyleBackColor = false;
            this.Btn_Mod.Click += new System.EventHandler(this.Btn_Mod_Click);
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
            this.Dgv_Productos.Location = new System.Drawing.Point(12, 287);
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
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.Dgv_Productos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Productos.RowTemplate.Height = 28;
            this.Dgv_Productos.Size = new System.Drawing.Size(1878, 569);
            this.Dgv_Productos.TabIndex = 112;
            this.Dgv_Productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Productos_CellClick);
            // 
            // Interfaz_Almacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1902, 868);
            this.Controls.Add(this.Dgv_Productos);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Txt_Buscar);
            this.Controls.Add(this.Elegir);
            this.Controls.Add(this.Btn_Ag);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Mod);
            this.Controls.Add(this.Nud_Existencia);
            this.Name = "Interfaz_Almacen";
            this.Text = "Interfaz_Almacen";
            this.Load += new System.EventHandler(this.Interfaz_Almacen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Existencia)).EndInit();
            this.Elegir.ResumeLayout(false);
            this.Elegir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Productos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown Nud_Existencia;
        private CustomControls.RJControls.RJButton Btn_Mod;
        private CustomControls.RJControls.RJButton Btn_Cancelar;
        private CustomControls.RJControls.RJButton Btn_Ag;
        private System.Windows.Forms.GroupBox Elegir;
        private System.Windows.Forms.RadioButton Tabla;
        private System.Windows.Forms.RadioButton Maquina;
        private CustomControls.RJControls.RJTextBox Txt_Buscar;
        private CustomControls.RJControls.RJButton Btn_Buscar;
        private System.Windows.Forms.DataGridView Dgv_Productos;
    }
}