
namespace LAB_2_PARCIAL
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Boton_acceder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_usuario = new System.Windows.Forms.TextBox();
            this.textBox_contrasena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_nroIdentificacion = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Boton_acceder
            // 
            this.Boton_acceder.Location = new System.Drawing.Point(156, 327);
            this.Boton_acceder.Name = "Boton_acceder";
            this.Boton_acceder.Size = new System.Drawing.Size(75, 23);
            this.Boton_acceder.TabIndex = 0;
            this.Boton_acceder.Text = "Acceder";
            this.Boton_acceder.UseVisualStyleBackColor = true;
            this.Boton_acceder.Click += new System.EventHandler(this.Boton_acceder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "USUARIO";
            // 
            // textBox_usuario
            // 
            this.textBox_usuario.Location = new System.Drawing.Point(12, 301);
            this.textBox_usuario.Name = "textBox_usuario";
            this.textBox_usuario.Size = new System.Drawing.Size(100, 20);
            this.textBox_usuario.TabIndex = 2;
            this.textBox_usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_usuario_KeyPress);
            // 
            // textBox_contrasena
            // 
            this.textBox_contrasena.Location = new System.Drawing.Point(282, 301);
            this.textBox_contrasena.Name = "textBox_contrasena";
            this.textBox_contrasena.Size = new System.Drawing.Size(100, 20);
            this.textBox_contrasena.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CONTRASEÑA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nro IDENTIFICACION";
            // 
            // textBox_nroIdentificacion
            // 
            this.textBox_nroIdentificacion.Location = new System.Drawing.Point(144, 301);
            this.textBox_nroIdentificacion.Name = "textBox_nroIdentificacion";
            this.textBox_nroIdentificacion.Size = new System.Drawing.Size(100, 20);
            this.textBox_nroIdentificacion.TabIndex = 6;
            this.textBox_nroIdentificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_nroIdentificacion_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LAB_2_PARCIAL.Properties.Resources.military_vector_illustration_army_background_260nw_1833037471;
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(394, 362);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_nroIdentificacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_contrasena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Boton_acceder);
            this.Name = "Form1";
            this.Text = "Contador de Bajas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Boton_acceder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_usuario;
        private System.Windows.Forms.TextBox textBox_contrasena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_nroIdentificacion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

