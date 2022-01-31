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
    public partial class Form2_ContadorBajas : Form
    {
        public Form2_ContadorBajas()
        {
            InitializeComponent();
        }

        private void Boton_accedeFuerzaTerrestre_Click(object sender, EventArgs e)
        {
            Form_Fuerza_Terrestre form_Fuerza_TerrestreOP = new Form_Fuerza_Terrestre();

            form_Fuerza_TerrestreOP.ShowDialog();
        }

        private void Boton_accederFuerzaNaval_Click(object sender, EventArgs e)
        {
            Form_fuerza_naval form_Fuerza_navalOP = new Form_fuerza_naval();

            form_Fuerza_navalOP.ShowDialog();
        }

        private void Boton_accederFuerzaAerea_Click(object sender, EventArgs e)
        {
            Form_Fuerza_Aerea form_Fuerza_AereaOP = new Form_Fuerza_Aerea();

            form_Fuerza_AereaOP.ShowDialog();
        }
    }
}
