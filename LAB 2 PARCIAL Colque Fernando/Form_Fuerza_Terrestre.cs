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
    public partial class Form_Fuerza_Terrestre : Form
    {
        public Form_Fuerza_Terrestre()
        {
            InitializeComponent();
        }

        private void Boton_Calcular_Porcentajes_Terrestres_Click(object sender, EventArgs e)
        {
            OrdenarSoldadosAsalto();
            OrdenarSoldadosApollo();
            OrdenarSoldadosMedico();
            OrdenarSoldadosFrancotirador();

        }
        public void OrdenarSoldadosAsalto()
        {
            Terrestre_hija_Asalto terrestre_Hija_AsaltoOP = new Terrestre_hija_Asalto();

            try
            {
                terrestre_Hija_AsaltoOP.SoldadosAtacadosForm1 = int.Parse(Text_Cargar_Terrestre_Asalto_Atacados.Text);
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }

            if(terrestre_Hija_AsaltoOP.SoldadosAtacadosForm1 >= 0 && terrestre_Hija_AsaltoOP.SoldadosAtacadosForm1 <= 31000)
            {
                terrestre_Hija_AsaltoOP.DeterminarCantidadSoldados();
                Text_Terrestre_Asalto_Intactos.Text = "Displonible Elite: " + terrestre_Hija_AsaltoOP.CantSoldadoTipo11 + " Comun: " + terrestre_Hija_AsaltoOP.CantSoldadoTipo21;
                Text_Terrestre_Asalto_Elite_MuertosHeridos.Text = "Elites Heridos: " + terrestre_Hija_AsaltoOP.SoldadosHeridos11 + " Muertos: " + terrestre_Hija_AsaltoOP.SoldadosMuertos11;
                Text_Terrestre_Asalto_Comun_MuertosHeridos.Text = "Comun Heridos: " + terrestre_Hija_AsaltoOP.SoldadosHeridos21 + " Muertos: " + terrestre_Hija_AsaltoOP.SoldadosMuertos21;
            }
            else
            {
                MessageBox.Show("Solo se puede cargar entre 0 y 31000 Soldados de Asalto");
            }
        }
        public void OrdenarSoldadosApollo()
        {
            Terrestre_hija_Apollo1 Terrestre_hija_ApolloOP = new Terrestre_hija_Apollo1();

            try
            {
                Terrestre_hija_ApolloOP.SoldadosAtacadosForm1 = int.Parse(Text_Cargar_Terrestre_Apollo_Atacados.Text);
            }catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (Terrestre_hija_ApolloOP.SoldadosAtacadosForm1 >= 0 && Terrestre_hija_ApolloOP.SoldadosAtacadosForm1 <= 6000)
            {
                Terrestre_hija_ApolloOP.DeterminarCantidadSoldados();
                Text_Terrestre_Apollo_Intactos.Text = "Displonible R: " + Terrestre_hija_ApolloOP.CantSoldadoTipo11 + " M: " + Terrestre_hija_ApolloOP.CantSoldadoTipo21;
                Text_Terrestre_Apollo_Heridos.Text = "Heridos R: " + Terrestre_hija_ApolloOP.SoldadosHeridos11 + " M: " + Terrestre_hija_ApolloOP.SoldadosHeridos21;
                Text_Terrestre_Apollo_Muertos.Text = "Muertos R: " + Terrestre_hija_ApolloOP.SoldadosMuertos11 + " M: " + Terrestre_hija_ApolloOP.SoldadosMuertos21;
            }
            else
            {
                MessageBox.Show("Solo se puede cargar entre 0 y 6000 Soldados de Apollo");
            }
        }
        public void OrdenarSoldadosMedico()
        {
            Terrestre_hija_Medico Terrestre_hija_MedicoOP = new Terrestre_hija_Medico();
            try
            {
                Terrestre_hija_MedicoOP.SoldadosAtacadosForm1 = int.Parse(Text_Cargar_Terrestre_Medicos_Atacados.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (Terrestre_hija_MedicoOP.SoldadosAtacadosForm1 >= 0 && Terrestre_hija_MedicoOP.SoldadosAtacadosForm1 <= 2000)
            {
                Terrestre_hija_MedicoOP.DeterminarCantidadSoldados();
                Text_Terrestre_Medico_Intactos.Text = "Displonible 1roA: " + Terrestre_hija_MedicoOP.CantSoldadoTipo11 + " ATFdB: " + Terrestre_hija_MedicoOP.CantSoldadoTipo21;
                Text_Terrestre_Medico_Heridos.Text = "Med Heridos 1roA: " + Terrestre_hija_MedicoOP.SoldadosHeridos11 + " ATFdB: " + Terrestre_hija_MedicoOP.SoldadosHeridos21;
                Text_Terrestre_Medico_Muertos.Text = "Med Muertos 1roA: " + Terrestre_hija_MedicoOP.SoldadosMuertos11 + " ATFdB: " + Terrestre_hija_MedicoOP.SoldadosMuertos21;
            }
            else
            {
                MessageBox.Show("Solo se puede cargar entre 0 y 2000 Medicos");
            }
        }
        public void OrdenarSoldadosFrancotirador()
        {
            Terrestre_hija_Francotirador Terrestre_hija_FrancotiradorOP = new Terrestre_hija_Francotirador();

            try
            {
                Terrestre_hija_FrancotiradorOP.SoldadosAtacadosForm1 = int.Parse(Text_Cargar_Terrestre_Francotirardor_Atacados.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (Terrestre_hija_FrancotiradorOP.SoldadosAtacadosForm1 >= 0 && Terrestre_hija_FrancotiradorOP.SoldadosAtacadosForm1 <= 250)
            {
                Terrestre_hija_FrancotiradorOP.DeterminarCantidadSoldados();
                Text_Terrestre_Francotirador_Intactos.Text = "Displonible AntiU: " + Terrestre_hija_FrancotiradorOP.CantSoldadoTipo11 + " AntiB: " + Terrestre_hija_FrancotiradorOP.CantSoldadoTipo21;
                Text_Terrestre_Francotirador_Heridos.Text = "Med Heridos AntiU: " + Terrestre_hija_FrancotiradorOP.SoldadosHeridos11 + " AntiB: " + Terrestre_hija_FrancotiradorOP.SoldadosHeridos21;
                Text_Terrestre_Francotirador_Muertos.Text = "Med Muertos AntiU: " + Terrestre_hija_FrancotiradorOP.SoldadosMuertos11 + " AntiB: " + Terrestre_hija_FrancotiradorOP.SoldadosMuertos21;
            }
            else
            {
                MessageBox.Show("Solo se puede cargar entre 0 y 250 Francotirador");
            }
        }

        /*private void Text_Cargar_Terrestre_Asalto_Atacados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("solo Numeros Positivos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void Text_Cargar_Terrestre_Apollo_Atacados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("solo Numeros Positivos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void Text_Cargar_Terrestre_Medicos_Atacados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("solo Numeros Positivos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void Text_Cargar_Terrestre_Francotirardor_Atacados_KeyPress(object sender, KeyPressEventArgs e)
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
