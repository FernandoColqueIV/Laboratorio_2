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
            OrdenarSoldadosMedico();

        }
        public void OrdenarSoldadosAsalto()
        {
            Terrestre_hija_Asalto terrestre_Hija_AsaltoOP = new Terrestre_hija_Asalto();

            try
            {
                terrestre_Hija_AsaltoOP.Atacados_Form = int.Parse(Text_Cargar_Terrestre_Asalto_Atacados.Text);
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }

            if(terrestre_Hija_AsaltoOP.Atacados_Form >= 0 && terrestre_Hija_AsaltoOP.Atacados_Form <= 31000)
            {

                Calcular_Bajas_Todas_Unidades Terrestre_Calcular_BajasOP = new Calcular_Bajas_Todas_Unidades();
                terrestre_Hija_AsaltoOP.Asalto();

                Text_Terrestre_Asalto_Intactos.Text = "Displonible Veteranos: " + terrestre_Hija_AsaltoOP.Veteranos_cantidad + " Novatos: " + terrestre_Hija_AsaltoOP.Novatos_cantidad;
                Text_Terrestre_Asalto_Elite_MuertosHeridos.Text = "Veteranos Heridos: " + terrestre_Hija_AsaltoOP.Veteranos_heridos + " Muertos: " + terrestre_Hija_AsaltoOP.Veteranos_muertos;
                Text_Terrestre_Asalto_Comun_MuertosHeridos.Text = "Novatos Heridos: " + terrestre_Hija_AsaltoOP.Novatos_heridos + " Muertos: " + terrestre_Hija_AsaltoOP.Novatos_muertos;
            }
            else
            {
                MessageBox.Show("Solo se puede cargar entre 0 y 31000 Soldados de Asalto");
            }
        }
       
        public void OrdenarSoldadosMedico()
        {
            Terrestre_hija_Medico Terrestre_hija_MedicoOP = new Terrestre_hija_Medico();
            try
            {
                Terrestre_hija_MedicoOP.Atacados_Form = int.Parse(Text_Cargar_Terrestre_Medicos_Atacados.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (Terrestre_hija_MedicoOP.Atacados_Form >= 0 && Terrestre_hija_MedicoOP.Atacados_Form <= 2000)
            {
                Terrestre_hija_MedicoOP.DeterminarCantidadSoldados();
                Text_Terrestre_Medico_Intactos.Text = "Displonible Novatos: " + Terrestre_hija_MedicoOP.Veteranos_cantidad + " ATFdB: " + Terrestre_hija_MedicoOP.Novatos_cantidad;
                Text_Terrestre_Medico_Heridos.Text = "Novatos Muertos: " + Terrestre_hija_MedicoOP.Novatos_muertos + " Heridos: " + Terrestre_hija_MedicoOP.Novatos_heridos;
                Text_Terrestre_Medico_Muertos.Text = "Veteranos: " + Terrestre_hija_MedicoOP.Veteranos_muertos + " Heridos: " + Terrestre_hija_MedicoOP.Veteranos_heridos;
            }
            else
            {
                MessageBox.Show("Solo se puede cargar entre 0 y 2000 Medicos");
            }
        }
        

    }
}   
