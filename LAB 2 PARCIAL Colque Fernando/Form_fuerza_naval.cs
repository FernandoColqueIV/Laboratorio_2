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
    public partial class Form_fuerza_naval : Form
    {
        public Form_fuerza_naval()
        {
            InitializeComponent();
        }
        private void Boton_Naval_CalcularBajas_Click(object sender, EventArgs e)
        {
            Ordenar_Datos_Acorazado();
            Ordenar_Datos_Destructor();
            Ordenar_Datos_Lancha_Rapida();
        }
        private void Ordenar_Datos_Acorazado() 
        {
            Naval_hija_acorazado naval_Hija_AcorazadoOP = new Naval_hija_acorazado();

            try
            { 
                naval_Hija_AcorazadoOP.Barcos_AtacadosForm1 = int.Parse(Text_Cargar_Acorazado_Atacados.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);

            }
            if (naval_Hija_AcorazadoOP.Barcos_AtacadosForm1 >= 0 && naval_Hija_AcorazadoOP.Barcos_AtacadosForm1 <= 20)
            {
                naval_Hija_AcorazadoOP.Acorazado();
                Text_Naval_Acorazado_Intactos.Text = "Acorazados intactos: " + naval_Hija_AcorazadoOP.Barcos_Intactos1.ToString();
                Text_Naval_Acorazado_Marinos_Muertos_Heridos.Text = "Marinos Muertos: " + naval_Hija_AcorazadoOP.Marinero_Muerto1;
                Text_Naval_Acorazado_Incapacitados.Text = "Acorazados Incapacitados: " + naval_Hija_AcorazadoOP.Barcos_FueraDeCombate1.ToString();
                Text_Naval_Acorazado_Perdidos.Text = "Acorazados Perdidos: " + naval_Hija_AcorazadoOP.Barcos_Perdidos1.ToString();
                Text_Naval_Acorazado_danado.Text = "Acorazados Dañados: " + naval_Hija_AcorazadoOP.Barcos_Danados1.ToString();
                Text_Naval_Acorazado_Capitanes_Muertos_Heridos.Text = "Capitanes Muertos: " + naval_Hija_AcorazadoOP.Capitan_Muerto1;
                Text_Naval_Acorazado_Marinos_Muertos_Heridos.Text = "Marinos Muertos: " + naval_Hija_AcorazadoOP.Marinero_Muerto1 + " Heridos: " + naval_Hija_AcorazadoOP.Marinero_Herido1.ToString();
            }
            else
            {
                MessageBox.Show("Puede cargar hasta 20 Acorazados");
            }
        }
        private void Ordenar_Datos_Destructor()
        {
            Naval_hija_Destructor naval_Hija_DestructorOP = new Naval_hija_Destructor();

            try
            {
                naval_Hija_DestructorOP.Barcos_AtacadosForm1 = int.Parse(Text_Cargar_Destructor_Atacados.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);

            }
            if (naval_Hija_DestructorOP.Barcos_AtacadosForm1 >= 0 && naval_Hija_DestructorOP.Barcos_AtacadosForm1 <= 20)
            {
                naval_Hija_DestructorOP.DeterminarParametros();
                Text_Naval_Destructor_Intactos.Text = "Destructores intactos: " + naval_Hija_DestructorOP.Barcos_Intactos1.ToString();
                Text_Naval_Destructor_Incapacitados.Text = "Destructores Incapacitados: " + naval_Hija_DestructorOP.Porcentaje_Dano_Barco_Fuera_Combate1.ToString();
                Text_Naval_Destructor_Perdidos.Text = "Destructores Perdidos: " + naval_Hija_DestructorOP.Barcos_Perdidos1.ToString();
                Text_Naval_Destructor_danado.Text = "Destructores Dañados: " + naval_Hija_DestructorOP.Barcos_Danados1.ToString();
                Text_Naval_Destructor_MarinosMuertos.Text = "Marinos Muertos: " + naval_Hija_DestructorOP.Marinero_Muerto1 + " Heridos: "+naval_Hija_DestructorOP.Marinero_Herido1;
                Text_Naval_DEstructor_Capitanes_Heridos_Muertos.Text = "Capitanes Muertos: " + naval_Hija_DestructorOP.Capitan_Muerto1;
            }
            else
            {
                MessageBox.Show("Puede cargar hasta 20 Destructores");
            }
        }
        private void Ordenar_Datos_Lancha_Rapida()
        {
            Naval_hija_lanchaRapida naval_Hija_lanchaRapidaOP = new Naval_hija_lanchaRapida();

            try
            {
                naval_Hija_lanchaRapidaOP.Barcos_AtacadosForm1 = int.Parse(Text_Cargar_LanchaRapida_Atacados.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);

            }
            
            if (naval_Hija_lanchaRapidaOP.Barcos_AtacadosForm1 >= 0 && naval_Hija_lanchaRapidaOP.Barcos_AtacadosForm1 <= 100)
            {
                naval_Hija_lanchaRapidaOP.LanchaRapida();
                Text_Naval_LanchaRapida_Intactos.Text = "Lanchas Rapidas intactas: " + naval_Hija_lanchaRapidaOP.Barcos_Intactos1.ToString();
                Text_Naval_LanchaRapida_Incapacitados.Text = "Lanchas Rapidas Incapacitadas: " + naval_Hija_lanchaRapidaOP.Barcos_FueraDeCombate1.ToString();
                Text_Naval_LanchaRapida_Perdidos.Text = "Lanchas Rapidas Perdidas: " + naval_Hija_lanchaRapidaOP.Barcos_Perdidos1.ToString();
                Text_Naval_LanchaRapida_danado.Text = "Lanchas Rapidas Dañadas: " + naval_Hija_lanchaRapidaOP.Barcos_Danados1.ToString();
                Text_Naval_LanchaRapida_MarinosMuertos.Text = "Marinos Muertos: " + naval_Hija_lanchaRapidaOP.Marinero_Muerto1+" Heridos: "+naval_Hija_lanchaRapidaOP.Marinero_Herido1;
                Text_Naval_LanchaRapida_Capitanes_Heridos_Muertos.Text = "Capitanes Muertos: " + naval_Hija_lanchaRapidaOP.Capitan_Muerto1;
            }
            else
            {
                MessageBox.Show("Puede cargar hasta 100 Lanchas Rapidas");
            }
        }
        
        
 
    }
}
