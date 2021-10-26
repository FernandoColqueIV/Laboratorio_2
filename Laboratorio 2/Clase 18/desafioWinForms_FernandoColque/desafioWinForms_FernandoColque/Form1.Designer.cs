
namespace desafioWinForms_FernandoColque
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CheckBermuda = new System.Windows.Forms.CheckBox();
            this.CheckMangaCorta = new System.Windows.Forms.CheckBox();
            this.BottonPantalon = new System.Windows.Forms.RadioButton();
            this.BottonCamisa = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BotonPremium = new System.Windows.Forms.RadioButton();
            this.BotonStandar = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.BotonCalcularPrecioFinal = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ventas Al Por Mayor-Los 3 gorditos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CheckBermuda);
            this.groupBox1.Controls.Add(this.CheckMangaCorta);
            this.groupBox1.Controls.Add(this.BottonPantalon);
            this.groupBox1.Controls.Add(this.BottonCamisa);
            this.groupBox1.Location = new System.Drawing.Point(13, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 92);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Prenda";
            // 
            // CheckBermuda
            // 
            this.CheckBermuda.AutoSize = true;
            this.CheckBermuda.Location = new System.Drawing.Point(101, 55);
            this.CheckBermuda.Name = "CheckBermuda";
            this.CheckBermuda.Size = new System.Drawing.Size(68, 17);
            this.CheckBermuda.TabIndex = 3;
            this.CheckBermuda.Text = "Bermuda";
            this.CheckBermuda.UseVisualStyleBackColor = true;
            // 
            // CheckMangaCorta
            // 
            this.CheckMangaCorta.AutoSize = true;
            this.CheckMangaCorta.Location = new System.Drawing.Point(101, 31);
            this.CheckMangaCorta.Name = "CheckMangaCorta";
            this.CheckMangaCorta.Size = new System.Drawing.Size(87, 17);
            this.CheckMangaCorta.TabIndex = 2;
            this.CheckMangaCorta.Text = "Manga Corta";
            this.CheckMangaCorta.UseVisualStyleBackColor = true;
            // 
            // BottonPantalon
            // 
            this.BottonPantalon.AutoSize = true;
            this.BottonPantalon.Location = new System.Drawing.Point(7, 54);
            this.BottonPantalon.Name = "BottonPantalon";
            this.BottonPantalon.Size = new System.Drawing.Size(67, 17);
            this.BottonPantalon.TabIndex = 1;
            this.BottonPantalon.TabStop = true;
            this.BottonPantalon.Text = "Pantalòn";
            this.BottonPantalon.UseVisualStyleBackColor = true;
            // 
            // BottonCamisa
            // 
            this.BottonCamisa.AutoSize = true;
            this.BottonCamisa.Location = new System.Drawing.Point(7, 30);
            this.BottonCamisa.Name = "BottonCamisa";
            this.BottonCamisa.Size = new System.Drawing.Size(59, 17);
            this.BottonCamisa.TabIndex = 0;
            this.BottonCamisa.TabStop = true;
            this.BottonCamisa.Text = "Camisa";
            this.BottonCamisa.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BotonPremium);
            this.groupBox2.Controls.Add(this.BotonStandar);
            this.groupBox2.Location = new System.Drawing.Point(15, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 49);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calidad de la Prenda";
            // 
            // BotonPremium
            // 
            this.BotonPremium.AutoSize = true;
            this.BotonPremium.Location = new System.Drawing.Point(99, 19);
            this.BotonPremium.Name = "BotonPremium";
            this.BotonPremium.Size = new System.Drawing.Size(65, 17);
            this.BotonPremium.TabIndex = 1;
            this.BotonPremium.TabStop = true;
            this.BotonPremium.Text = "Premium";
            this.BotonPremium.UseVisualStyleBackColor = true;
            // 
            // BotonStandar
            // 
            this.BotonStandar.AutoSize = true;
            this.BotonStandar.Location = new System.Drawing.Point(6, 19);
            this.BotonStandar.Name = "BotonStandar";
            this.BotonStandar.Size = new System.Drawing.Size(68, 17);
            this.BotonStandar.TabIndex = 0;
            this.BotonStandar.TabStop = true;
            this.BotonStandar.Text = "Standard";
            this.BotonStandar.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxPrecio);
            this.groupBox3.Location = new System.Drawing.Point(13, 211);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(95, 48);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Precio";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(7, 20);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(82, 20);
            this.textBoxPrecio.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxCantidad);
            this.groupBox4.Location = new System.Drawing.Point(114, 211);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(101, 48);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cantidad";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(6, 20);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(81, 20);
            this.textBoxCantidad.TabIndex = 1;
            // 
            // BotonCalcularPrecioFinal
            // 
            this.BotonCalcularPrecioFinal.Location = new System.Drawing.Point(21, 275);
            this.BotonCalcularPrecioFinal.Name = "BotonCalcularPrecioFinal";
            this.BotonCalcularPrecioFinal.Size = new System.Drawing.Size(180, 53);
            this.BotonCalcularPrecioFinal.TabIndex = 5;
            this.BotonCalcularPrecioFinal.Text = "Calcular Precio Final";
            this.BotonCalcularPrecioFinal.UseVisualStyleBackColor = true;
            this.BotonCalcularPrecioFinal.Click += new System.EventHandler(this.BotonCalcularPrecioFinal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 337);
            this.Controls.Add(this.BotonCalcularPrecioFinal);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ventas al por mayor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton BottonPantalon;
        private System.Windows.Forms.RadioButton BottonCamisa;
        private System.Windows.Forms.CheckBox CheckBermuda;
        private System.Windows.Forms.CheckBox CheckMangaCorta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton BotonPremium;
        private System.Windows.Forms.RadioButton BotonStandar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Button BotonCalcularPrecioFinal;
    }
}

