﻿namespace Entrega_Final
{
    partial class Interfaz_Ventas
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
            this.Nud_Pro = new System.Windows.Forms.NumericUpDown();
            this.Lbl_Total = new System.Windows.Forms.Label();
            this.Dgv_Producto = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Can_Venta = new CustomControls.RJControls.RJButton();
            this.Btn_Terminar = new CustomControls.RJControls.RJButton();
            this.Btn_Cancelar = new CustomControls.RJControls.RJButton();
            this.Btn_Eliminar = new CustomControls.RJControls.RJButton();
            this.Btn_Modificar = new CustomControls.RJControls.RJButton();
            this.Btn_Modificar_Pro = new CustomControls.RJControls.RJButton();
            this.Btn_Buscar = new CustomControls.RJControls.RJButton();
            this.Code_Pro = new CustomControls.RJControls.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Pro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Nud_Pro
            // 
            this.Nud_Pro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Nud_Pro.ForeColor = System.Drawing.Color.White;
            this.Nud_Pro.Location = new System.Drawing.Point(582, 180);
            this.Nud_Pro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Nud_Pro.Name = "Nud_Pro";
            this.Nud_Pro.Size = new System.Drawing.Size(202, 26);
            this.Nud_Pro.TabIndex = 9;
            // 
            // Lbl_Total
            // 
            this.Lbl_Total.AutoSize = true;
            this.Lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Total.ForeColor = System.Drawing.SystemColors.Window;
            this.Lbl_Total.Location = new System.Drawing.Point(1190, 97);
            this.Lbl_Total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Total.Name = "Lbl_Total";
            this.Lbl_Total.Size = new System.Drawing.Size(58, 64);
            this.Lbl_Total.TabIndex = 10;
            this.Lbl_Total.Text = "0";
            // 
            // Dgv_Producto
            // 
            this.Dgv_Producto.AllowUserToAddRows = false;
            this.Dgv_Producto.AllowUserToDeleteRows = false;
            this.Dgv_Producto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Producto.DefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Producto.GridColor = System.Drawing.Color.SlateBlue;
            this.Dgv_Producto.Location = new System.Drawing.Point(52, 325);
            this.Dgv_Producto.Name = "Dgv_Producto";
            this.Dgv_Producto.RowHeadersWidth = 62;
            this.Dgv_Producto.RowTemplate.Height = 28;
            this.Dgv_Producto.Size = new System.Drawing.Size(1425, 332);
            this.Dgv_Producto.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(1142, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 64);
            this.label1.TabIndex = 14;
            this.label1.Text = "$";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Entrega_Final.Properties.Resources.pixil_frame_0;
            this.pictureBox1.Location = new System.Drawing.Point(1257, 54);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Can_Venta
            // 
            this.Btn_Can_Venta.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_Can_Venta.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_Can_Venta.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Can_Venta.BorderRadius = 0;
            this.Btn_Can_Venta.BorderSize = 0;
            this.Btn_Can_Venta.FlatAppearance.BorderSize = 0;
            this.Btn_Can_Venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Can_Venta.ForeColor = System.Drawing.Color.White;
            this.Btn_Can_Venta.Location = new System.Drawing.Point(794, 171);
            this.Btn_Can_Venta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Can_Venta.Name = "Btn_Can_Venta";
            this.Btn_Can_Venta.Size = new System.Drawing.Size(142, 49);
            this.Btn_Can_Venta.TabIndex = 8;
            this.Btn_Can_Venta.Text = "Cancelar Venta";
            this.Btn_Can_Venta.TextColor = System.Drawing.Color.White;
            this.Btn_Can_Venta.UseVisualStyleBackColor = false;
            this.Btn_Can_Venta.Click += new System.EventHandler(this.Btn_Can_Venta_Click);
            // 
            // Btn_Terminar
            // 
            this.Btn_Terminar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_Terminar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_Terminar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Terminar.BorderRadius = 0;
            this.Btn_Terminar.BorderSize = 0;
            this.Btn_Terminar.FlatAppearance.BorderSize = 0;
            this.Btn_Terminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Terminar.ForeColor = System.Drawing.Color.White;
            this.Btn_Terminar.Location = new System.Drawing.Point(990, 111);
            this.Btn_Terminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Terminar.Name = "Btn_Terminar";
            this.Btn_Terminar.Size = new System.Drawing.Size(142, 49);
            this.Btn_Terminar.TabIndex = 7;
            this.Btn_Terminar.Text = "Terminar Venta";
            this.Btn_Terminar.TextColor = System.Drawing.Color.White;
            this.Btn_Terminar.UseVisualStyleBackColor = false;
            this.Btn_Terminar.Click += new System.EventHandler(this.Btn_Terminar_Click);
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
            this.Btn_Cancelar.Location = new System.Drawing.Point(794, 112);
            this.Btn_Cancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(142, 49);
            this.Btn_Cancelar.TabIndex = 6;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.TextColor = System.Drawing.Color.White;
            this.Btn_Cancelar.UseVisualStyleBackColor = false;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
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
            this.Btn_Eliminar.Location = new System.Drawing.Point(794, 54);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(142, 49);
            this.Btn_Eliminar.TabIndex = 5;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.TextColor = System.Drawing.Color.White;
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_Modificar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_Modificar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Modificar.BorderRadius = 0;
            this.Btn_Modificar.BorderSize = 0;
            this.Btn_Modificar.FlatAppearance.BorderSize = 0;
            this.Btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Modificar.ForeColor = System.Drawing.Color.White;
            this.Btn_Modificar.Location = new System.Drawing.Point(582, 54);
            this.Btn_Modificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(202, 49);
            this.Btn_Modificar.TabIndex = 4;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.TextColor = System.Drawing.Color.White;
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Btn_Modificar_Pro
            // 
            this.Btn_Modificar_Pro.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_Modificar_Pro.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_Modificar_Pro.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Modificar_Pro.BorderRadius = 0;
            this.Btn_Modificar_Pro.BorderSize = 0;
            this.Btn_Modificar_Pro.FlatAppearance.BorderSize = 0;
            this.Btn_Modificar_Pro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Modificar_Pro.ForeColor = System.Drawing.Color.White;
            this.Btn_Modificar_Pro.Location = new System.Drawing.Point(582, 112);
            this.Btn_Modificar_Pro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Modificar_Pro.Name = "Btn_Modificar_Pro";
            this.Btn_Modificar_Pro.Size = new System.Drawing.Size(202, 49);
            this.Btn_Modificar_Pro.TabIndex = 3;
            this.Btn_Modificar_Pro.Text = "Modificar Cantidad";
            this.Btn_Modificar_Pro.TextColor = System.Drawing.Color.White;
            this.Btn_Modificar_Pro.UseVisualStyleBackColor = false;
            this.Btn_Modificar_Pro.Click += new System.EventHandler(this.Btn_Modificar_Pro_Click);
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
            this.Btn_Buscar.Location = new System.Drawing.Point(400, 112);
            this.Btn_Buscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(118, 48);
            this.Btn_Buscar.TabIndex = 2;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.TextColor = System.Drawing.Color.White;
            this.Btn_Buscar.UseVisualStyleBackColor = false;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Code_Pro
            // 
            this.Code_Pro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Code_Pro.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Code_Pro.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Code_Pro.BorderRadius = 0;
            this.Code_Pro.BorderSize = 2;
            this.Code_Pro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Code_Pro.ForeColor = System.Drawing.Color.White;
            this.Code_Pro.Location = new System.Drawing.Point(128, 114);
            this.Code_Pro.Margin = new System.Windows.Forms.Padding(6);
            this.Code_Pro.Multiline = false;
            this.Code_Pro.Name = "Code_Pro";
            this.Code_Pro.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.Code_Pro.PasswordChar = false;
            this.Code_Pro.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Code_Pro.PlaceholderText = "";
            this.Code_Pro.Size = new System.Drawing.Size(262, 47);
            this.Code_Pro.TabIndex = 0;
            this.Code_Pro.UnderlinedStyle = true;
            // 
            // Interfaz_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1536, 789);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgv_Producto);
            this.Controls.Add(this.Lbl_Total);
            this.Controls.Add(this.Nud_Pro);
            this.Controls.Add(this.Btn_Can_Venta);
            this.Controls.Add(this.Btn_Terminar);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Btn_Modificar_Pro);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Code_Pro);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Interfaz_Ventas";
            this.Text = "Interfaz_Ventas";
            this.Load += new System.EventHandler(this.Interfaz_Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Pro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJTextBox Code_Pro;
        private CustomControls.RJControls.RJButton Btn_Buscar;
        private CustomControls.RJControls.RJButton Btn_Modificar_Pro;
        private CustomControls.RJControls.RJButton Btn_Modificar;
        private CustomControls.RJControls.RJButton Btn_Eliminar;
        private CustomControls.RJControls.RJButton Btn_Cancelar;
        private CustomControls.RJControls.RJButton Btn_Can_Venta;
        private CustomControls.RJControls.RJButton Btn_Terminar;
        private System.Windows.Forms.NumericUpDown Nud_Pro;
        private System.Windows.Forms.Label Lbl_Total;
        private System.Windows.Forms.DataGridView Dgv_Producto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}