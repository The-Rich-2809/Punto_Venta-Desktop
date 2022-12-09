namespace Entrega_Final
{
    partial class Interfaz_Home
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
            this.Hora_Fecha = new System.Windows.Forms.Timer(this.components);
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.Lbl_B = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.Hora = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Hora_Fecha
            // 
            this.Hora_Fecha.Enabled = true;
            this.Hora_Fecha.Tick += new System.EventHandler(this.Hora_Fecha_Tick);
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Usuario.ForeColor = System.Drawing.Color.Azure;
            this.Lbl_Usuario.Location = new System.Drawing.Point(280, 191);
            this.Lbl_Usuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(253, 73);
            this.Lbl_Usuario.TabIndex = 11;
            this.Lbl_Usuario.Text = "Usuario";
            // 
            // Lbl_B
            // 
            this.Lbl_B.AutoSize = true;
            this.Lbl_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_B.ForeColor = System.Drawing.Color.Azure;
            this.Lbl_B.Location = new System.Drawing.Point(141, 61);
            this.Lbl_B.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_B.Name = "Lbl_B";
            this.Lbl_B.Size = new System.Drawing.Size(571, 108);
            this.Lbl_B.TabIndex = 10;
            this.Lbl_B.Text = "¡Bienvenido!";
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.ForeColor = System.Drawing.Color.Azure;
            this.Fecha.Location = new System.Drawing.Point(669, 417);
            this.Fecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(118, 42);
            this.Fecha.TabIndex = 9;
            this.Fecha.Text = "label2";
            // 
            // Hora
            // 
            this.Hora.AutoSize = true;
            this.Hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora.ForeColor = System.Drawing.Color.Azure;
            this.Hora.Location = new System.Drawing.Point(795, 322);
            this.Hora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(204, 73);
            this.Hora.TabIndex = 8;
            this.Hora.Text = "label1";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Entrega_Final.Properties.Resources.PacoCarga;
            this.pictureBox4.Location = new System.Drawing.Point(856, 61);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(191, 182);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Entrega_Final.Properties.Resources.BriseñoToppo;
            this.pictureBox3.Location = new System.Drawing.Point(462, 322);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(146, 158);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Entrega_Final.Properties.Resources.SantanderJiren;
            this.pictureBox2.Location = new System.Drawing.Point(165, 322);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 158);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Entrega_Final.Properties.Resources.CampitosDyspo;
            this.pictureBox1.Location = new System.Drawing.Point(308, 322);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Interfaz_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1268, 564);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.Lbl_Usuario);
            this.Controls.Add(this.Lbl_B);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.Hora);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Interfaz_Home";
            this.Text = "Interfaz_Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer Hora_Fecha;
        public System.Windows.Forms.Label Lbl_Usuario;
        private System.Windows.Forms.Label Lbl_B;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Label Hora;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}