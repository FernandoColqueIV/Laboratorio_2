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
            Ordenar_Datos_Crucero();
            Ordenar_Datos_Destructor();
            Ordenar_Datos_Fragata();
            Ordenar_Datos_Lancha_Rapida();
            Ordenar_Datos_Porta_Aviones();
            Ordenar_Datos_Sub_Marino();
        }

        private void Ordenar_Datos_Acorazado() 
        {
            
            Naval_hija_acorazado naval_Hija_AcorazadoOP = new Naval_hija_acorazado();

            try
            { 
                naval_Hija_AcorazadoOP.Barcos_Atacados1 = int.Parse(Text_Cargar_Acorazado_Atacados.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);

            }

            if (naval_Hija_AcorazadoOP.Barcos_Atacados1>=0 && naval_Hija_AcorazadoOP.Barcos_Atacados1 <= 20)
            {
                naval_Hija_AcorazadoOP.DeterminarParametros();
                Text_Naval_Acorazado_Intactos.Text = "Acorazados intactos: " + naval_Hija_AcorazadoOP.Cantidad_Barcos_Intactos().ToString();
                Text_Naval_Acorazado_MarinosMuertos.Text = "Marinos Muertos: " + naval_Hija_AcorazadoOP.MarinosMuertos;
                Text_Naval_Acorazado_Incapacitados.Text = "Acorazados Incapacitados: " + naval_Hija_AcorazadoOP.Barcos_incapacitados.ToString();
                Text_Naval_Acorazado_Perdidos.Text = "Acorazados Perdidos: " + naval_Hija_AcorazadoOP.Barcos_totales_perdidos.ToString();
                Text_Naval_Acorazado_danado.Text = "Acorazados Dañados: " + naval_Hija_AcorazadoOP.Barcos_danados.ToString();
            }
            else
            {
                MessageBox.Show("Puede cargar hasta 20 Acorazados");
            }
        }
        private void Ordenar_Datos_Crucero()
        {
            Naval_hija_crucero naval_Hija_CruceroOP = new Naval_hija_crucero();

            try
            {
                naval_Hija_CruceroOP.Barcos_Atacados1 = int.Parse(Text_Cargar_Crucero_Atacados.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);

            }
            
            if (naval_Hija_CruceroOP.Barcos_Atacados1 >= 0 && naval_Hija_CruceroOP.Barcos_Atacados1 <= 20)
            {
                naval_Hija_CruceroOP.DeterminarParametros();
                Text_Naval_Crucero_Intactos.Text = "Cruceros intactos: " + naval_Hija_CruceroOP.Cantidad_Barcos_Intactos().ToString();
                Text_Naval_Crucero_MarinosMuertos.Text = "Marinos Muertos: " + naval_Hija_CruceroOP.MarinosMuertos;
                Text_Naval_Crucero_Incapacitados.Text = "Cruceros Incapacitados: " + naval_Hija_CruceroOP.Barcos_incapacitados.ToString();
                Text_Naval_Crucero_Perdido.Text = "Cruceros Perdidos: " + naval_Hija_CruceroOP.Barcos_totales_perdidos.ToString();
                Text_Naval_Crucero_danado.Text = "Cruceros Dañados: " + naval_Hija_CruceroOP.Barcos_danados.ToString();
            }
            else
            {
                MessageBox.Show("Puede cargar hasta 20 Cruceros");
            }
        }
        private void Ordenar_Datos_Destructor()
        {
            Naval_hija_Destructor naval_Hija_DestructorOP = new Naval_hija_Destructor();

            try
            {
                naval_Hija_DestructorOP.Barcos_Atacados1 = int.Parse(Text_Cargar_Destructor_Atacados.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);

            }
            
            if (naval_Hija_DestructorOP.Barcos_Atacados1 >= 0 && naval_Hija_DestructorOP.Barcos_Atacados1 <= 20)
            {
                naval_Hija_DestructorOP.DeterminarParametros();
                Text_Naval_Destructor_Intactos.Text = "Destructores intactos: " + naval_Hija_DestructorOP.Cantidad_Barcos_Intactos().ToString();
                Text_Naval_Destructor_MarinosMuertos.Text = "Marinos Muertos: " + naval_Hija_DestructorOP.MarinosMuertos;
                Text_Naval_Destructor_Incapacitados.Text = "Destructores Incapacitados: " + naval_Hija_DestructorOP.Barcos_incapacitados.ToString();
                Text_Naval_Destructor_Perdidos.Text = "Destructores Perdidos: " + naval_Hija_DestructorOP.Barcos_totales_perdidos.ToString();
                Text_Naval_Destructor_danado.Text = "Destructores Dañados: " + naval_Hija_DestructorOP.Barcos_danados.ToString();
            }
            else
            {
                MessageBox.Show("Puede cargar hasta 20 Destructores");
            }

        }
        private void Ordenar_Datos_Fragata()
        {
            Naval_hija_fragata naval_Hija_fragataOP = new Naval_hija_fragata();

            try
            {
                naval_Hija_fragataOP.Barcos_Atacados1 = int.Parse(Text_Cargar_Fragata_Atacados.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);

            }
           
            if (naval_Hija_fragataOP.Barcos_Atacados1 >= 0 && naval_Hija_fragataOP.Barcos_Atacados1 <= 10)
            {
                naval_Hija_fragataOP.DeterminarParametros();
               Text_Naval_Fragata_Intactos.Text = "Fragatas intactas: " + naval_Hija_fragataOP.Cantidad_Barcos_Intactos().ToString();
               Text_Naval_Fragata_MarinosMuertos.Text = "Marinos Muertos: " + naval_Hija_fragataOP.MarinosMuertos;
               Text_Naval_Fragata_Incapacitadas.Text= "Fragatas Incapacitadas: " + naval_Hija_fragataOP.Barcos_incapacitados.ToString();
               Text_Naval_Fragata_Perdidas.Text = "Fragatas Perdidas: " + naval_Hija_fragataOP.Barcos_totales_perdidos.ToString();
               Text_Naval_Fragata_danado.Text = "Fragatas Dañadss: " + naval_Hija_fragataOP.Barcos_danados.ToString();
            }
            else
            {
                MessageBox.Show("Puede cargar hasta 10 Fragatas");
            }

        }
        private void Ordenar_Datos_Lancha_Rapida()
        {
            Naval_hija_lanchaRapida naval_Hija_lanchaRapidaOP = new Naval_hija_lanchaRapida();

            try
            {
                naval_Hija_lanchaRapidaOP.Barcos_Atacados1 = int.Parse(Text_Cargar_LanchaRapida_Atacados.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);

            }
            
            if (naval_Hija_lanchaRapidaOP.Barcos_Atacados1 >= 0 && naval_Hija_lanchaRapidaOP.Barcos_Atacados1 <= 100)
            {
                naval_Hija_lanchaRapidaOP.DeterminarParametros();
                Text_Naval_LanchaRapida_Intactos.Text = "Lanchas Rapidas intactas: " + naval_Hija_lanchaRapidaOP.Cantidad_Barcos_Intactos().ToString();
                Text_Naval_LanchaRapida_MarinosMuertos.Text = "Marinos Muertos: " + naval_Hija_lanchaRapidaOP.MarinosMuertos;
                Text_Naval_LanchaRapida_Incapacitados.Text = "Lanchas Rapidas Incapacitadas: " + naval_Hija_lanchaRapidaOP.Barcos_incapacitados.ToString();
                Text_Naval_LanchaRapida_Perdidos.Text = "Lanchas Rapidas Perdidas: " + naval_Hija_lanchaRapidaOP.Barcos_totales_perdidos.ToString();
                Text_Naval_LanchaRapida_danado.Text = "Lanchas Rapidas Dañadas: " + naval_Hija_lanchaRapidaOP.Barcos_danados.ToString();
            }
            else
            {
                MessageBox.Show("Puede cargar hasta 100 Lanchas Rapidas");
            }
        }
        private void Ordenar_Datos_Porta_Aviones()
        {
            Naval_hija_portaAviones naval_Hija_PortaAvionesOP = new Naval_hija_portaAviones();

            try
            {
                naval_Hija_PortaAvionesOP.Barcos_Atacados1 = int.Parse(Text_Cargar_ProtaAviones_Atacados.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);

            }
                       
            if (naval_Hija_PortaAvionesOP.Barcos_Atacados1 >= 0 && naval_Hija_PortaAvionesOP.Barcos_Atacados1 <= 5)
            {
                naval_Hija_PortaAvionesOP.DeterminarParametros();
                Text_Naval_PortaAviones_Intactos.Text = "Porta Aviones intactos: " + naval_Hija_PortaAvionesOP.Cantidad_Barcos_Intactos().ToString();
                Text_Naval_PortaAviones_MarinosMuertos.Text = "Marinos Muertos: " + naval_Hija_PortaAvionesOP.MarinosMuertos;
                Text_Naval_PortaAviones_Incapacitados.Text = "Porta Aviones Incapacitados: " + naval_Hija_PortaAvionesOP.Barcos_incapacitados.ToString();
                Text_Naval_PortaAviones_Perdidos.Text = "Porta Aviones Perdidos: " + naval_Hija_PortaAvionesOP.Barcos_totales_perdidos.ToString();
                Text_Naval_PortaAviones_danado.Text = "Porta Aviones Dañados: " + naval_Hija_PortaAvionesOP.Barcos_danados.ToString();
            }
            else
            {
                MessageBox.Show("Puede cargar hasta 5 Porta Aviones");
            }
        }
        private void Ordenar_Datos_Sub_Marino()
        {
            Naval_hija_SubMarino naval_Hija_SubMarinoOP = new Naval_hija_SubMarino();

            try
            {
                naval_Hija_SubMarinoOP.Barcos_Atacados1 = int.Parse(Text_Cargar_SubMarino_Atacados.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);

            }
            
            if (naval_Hija_SubMarinoOP.Barcos_Atacados1 >= 0 && naval_Hija_SubMarinoOP.Barcos_Atacados1 <= 15)
            {
                naval_Hija_SubMarinoOP.DeterminarParametros();
                Text_Naval_SubMarino_Intactos.Text = "SubMarino intactos: " + naval_Hija_SubMarinoOP.Cantidad_Barcos_Intactos().ToString();
                Text_Naval_SubMarino_MarinosMuertos.Text = "Marinos Muertos: " + naval_Hija_SubMarinoOP.MarinosMuertos;
                Text_Naval_SubMarino_Incapacitados.Text = "SubMarino Incapacitados: " + naval_Hija_SubMarinoOP.Barcos_incapacitados.ToString();
                Text_Naval_SubMarino_Perdidos.Text = "SubMarino Perdidos: " + naval_Hija_SubMarinoOP.Barcos_totales_perdidos.ToString();
                Text_Naval_SubMarino_danado.Text = "SubMarino Dañados: " + naval_Hija_SubMarinoOP.Barcos_danados.ToString();
            }
            else
            {
                MessageBox.Show("Puede cargar hasta 15 Sub-Marinos");
            }
        }

        /*private void Text_Cargar_Acorazado_Atacados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar>=32 && e.KeyChar<=47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("solo Numeros Positivos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
        private void Text_Cargar_Crucero_Atacados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("solo Numeros Positivos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
        private void Text_Cargar_Destructor_Atacados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("solo Numeros Positivos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
        private void Text_Cargar_Fragata_Atacados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("solo Numeros Positivos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
        private void Text_Cargar_LanchaRapida_Atacados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("solo Numeros Positivos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
        private void Text_Cargar_ProtaAviones_Atacados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("solo Numeros Positivos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
        private void Text_Cargar_SubMarino_Atacados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("solo Numeros Positivos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
        */
        
    }
}
