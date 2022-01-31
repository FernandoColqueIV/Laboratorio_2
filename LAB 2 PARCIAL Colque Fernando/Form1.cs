using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_2_PARCIAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Boton_acceder_Click(object sender, EventArgs e)
        {
            usuario usuarioOP = new usuario();

            //paso el textbox a un string para poder comparar dicha variable 
            string usuario =textBox_usuario.Text;
            string contrasena = textBox_contrasena.Text;

            //transformamos el NumIdentificacion a entero y lo comparamos con 
            //la contraseña en usuarioOP.contraseña
            if (Int32.Parse(textBox_nroIdentificacion.Text)==usuarioOP.Num_Identifiacion1 && usuario==usuarioOP.Usuario1 && contrasena==usuarioOP.Contraseña) { 
            
                Form2_ContadorBajas form2_ContadorBajasOP = new Form2_ContadorBajas();

                form2_ContadorBajasOP.Show();

                //cerrar form1
                this.Hide();
            }
            else
            {
                MessageBox.Show(" LOS DATOS INTRODUCIDOS SON INCORRECTOS ");
            }

        }

        private void textBox_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 69) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("solo Letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void textBox_nroIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
    }
}
