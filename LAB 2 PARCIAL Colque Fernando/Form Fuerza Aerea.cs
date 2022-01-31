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
    public partial class Form_Fuerza_Aerea : Form
    {
        public Form_Fuerza_Aerea()
        {
            InitializeComponent();
        }

        private void Boton_Aerea_CalcularBajas_Click(object sender, EventArgs e)
        {
            OrdenarDatosCazaCOmbate();
            OrdenarDatosCombatePolivalente();
            OrdenarDatosCombateAtaqueTierra();
            OrdenarDatosHelicoptero();
            OrdenarDatosBombarderoTactico();
            OrdenarDatosTransporteMilitar();


        }


        public void OrdenarDatosCazaCOmbate()
        {
            Aerea_hija_CazaCombate aerea_Hija_CazaCombateOP = new Aerea_hija_CazaCombate();

            try
            {
                aerea_Hija_CazaCombateOP.AvionesAtacadosForm1 = Int32.Parse(Text_Aerea_Cargar_CazaCombate_Atacados.Text);
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (aerea_Hija_CazaCombateOP.AvionesAtacadosForm1 >= 0 && aerea_Hija_CazaCombateOP.AvionesAtacadosForm1 <= 40)
            {
                aerea_Hija_CazaCombateOP.AvionDeUnPasajero();

                Text_Aerea_CazaCombate_Intactos.Text = "Cazas Intactos: " + aerea_Hija_CazaCombateOP.Aviones_Intactos1;
                Text_Aerea_CazaCombate_Perdidos.Text = "Cazas Perdidos: " + aerea_Hija_CazaCombateOP.Aviones_Perdidos1;
                Text_Aerea_CazaCombate_FueraDeCombate.Text = "Cazas FdC: " + aerea_Hija_CazaCombateOP.Aviones_FueraDeCombate1;
                Text_Aerea_CazaCombate_Danados.Text = "Cazas Dañados: " + aerea_Hija_CazaCombateOP.Aviones_Danados1;
                Text_Aerea_CazaCombate_Muertos_Heridos.Text = "Pilotos M: " + aerea_Hija_CazaCombateOP.Piloto_1_Muerto1+ "  H: "+aerea_Hija_CazaCombateOP.Piloto_1_Herido1;
            }
            else
            {
                MessageBox.Show("Puede cargar hasta 40 Cazas");
            }
        }
        public void OrdenarDatosCombatePolivalente()
        {
            Aerea_hija_CombatePolivalente Aerea_hija_CombatePolivalenteOP = new Aerea_hija_CombatePolivalente();


            try
            {
                Aerea_hija_CombatePolivalenteOP.AvionesAtacadosForm1 = Int32.Parse(Text_Aerea_Cargar_Polivalente_Atacados.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (Aerea_hija_CombatePolivalenteOP.AvionesAtacadosForm1 >= 0 && Aerea_hija_CombatePolivalenteOP.AvionesAtacadosForm1 <= 35)
            {
                Aerea_hija_CombatePolivalenteOP.AvionDeUnPasajero();

                Text_Aerea_Polivalente_Intactos.Text = "Polivalentes Intactos: " + Aerea_hija_CombatePolivalenteOP.Aviones_Intactos1;
                Text_Aerea_Polivalente_Perdidos.Text = "Polivalentes Perdidos: " + Aerea_hija_CombatePolivalenteOP.Aviones_Perdidos1;
                Text_Aerea_Polivalente_FueraDeCombate.Text = "Polivalentes FdC: " + Aerea_hija_CombatePolivalenteOP.Aviones_FueraDeCombate1;
                Text_Aerea_Polivalente_Danados.Text = "Polivalentes Dañados: " + Aerea_hija_CombatePolivalenteOP.Aviones_Danados1;
                Text_Aerea_Polivalente_Muertos.Text = "Pilotos M: " + Aerea_hija_CombatePolivalenteOP.Piloto_1_Muerto1 + "  H: " + Aerea_hija_CombatePolivalenteOP.Piloto_1_Herido1;
            }
            else
            {
                MessageBox.Show("Puede cargar hasta 35 Aviones Polivalentes");
            }
        }
        public void OrdenarDatosCombateAtaqueTierra()
        {
            Aerea_hija_AtaqueTierra Aerea_hija_AtaqueTierraOP = new Aerea_hija_AtaqueTierra();

            try
            {
                Aerea_hija_AtaqueTierraOP.AvionesAtacadosForm1 = Int32.Parse(Text_Aerea_Cargar_AtaqueTierra_Atacados.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (Aerea_hija_AtaqueTierraOP.AvionesAtacadosForm1 >= 0 && Aerea_hija_AtaqueTierraOP.AvionesAtacadosForm1 <= 40)
            {
                Aerea_hija_AtaqueTierraOP.AvionDeUnPasajero();

                Text_Aerea_AtaqueTierra_Intactos.Text = "Ataque T Intactos: " + Aerea_hija_AtaqueTierraOP.Aviones_Intactos1;
                Text_Aerea_AtaqueTierra_Perdidos.Text = "Ataque T Perdidos: " + Aerea_hija_AtaqueTierraOP.Aviones_Perdidos1;
                Text_Aerea_AtaqueTierra_FueraDeCombate.Text = "Ataque T FdC: " + Aerea_hija_AtaqueTierraOP.Aviones_FueraDeCombate1;
                Text_Aerea_AtaqueTierra_Danados.Text = "Ataque T Dañados: " + Aerea_hija_AtaqueTierraOP.Aviones_Danados1;
                Text_Aerea_AtaqueTierra_Muertos.Text = "Pilotos M: " + Aerea_hija_AtaqueTierraOP.Piloto_1_Muerto1 + "  H: " + Aerea_hija_AtaqueTierraOP.Piloto_1_Herido1;
            }
            else
            {
                MessageBox.Show("Puede cargar hasta 40 Aviones Ataque Tierra");
            }
        }
        public void OrdenarDatosHelicoptero()
        {
            Aerea_hija_Helicoptero Aerea_hija_HelicopteroOP = new Aerea_hija_Helicoptero();

            try
            {
                Aerea_hija_HelicopteroOP.AvionesAtacadosForm1 = Int32.Parse(Text_Aerea_Cargar_Helicoptero_Atacados.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (Aerea_hija_HelicopteroOP.AvionesAtacadosForm1 >= 0 && Aerea_hija_HelicopteroOP.AvionesAtacadosForm1 <= 20)
            {
                Aerea_hija_HelicopteroOP.AvionDeUnPasajero();

                Text_Aerea_Helicoptero_Intactos.Text = "Helicopteros Intactos: " + Aerea_hija_HelicopteroOP.Aviones_Intactos1;
                Text_Aerea_Helicoptero_Perdidos.Text = "Helicopteros Perdidos: " + Aerea_hija_HelicopteroOP.Aviones_Perdidos1;
                Text_Aerea_Helicoptero_FueraDeCombate.Text = "Helicopteros FdC: " + Aerea_hija_HelicopteroOP.Aviones_FueraDeCombate1;
                Text_Aerea_Helicoptero_Danados.Text = "Helicopteros Dañados: " + Aerea_hija_HelicopteroOP.Aviones_Danados1;
                Text_Aerea_Helicoptero_Muertos.Text = "Pilotos M: " + Aerea_hija_HelicopteroOP.Piloto_1_Muerto1 + "  H: " + Aerea_hija_HelicopteroOP.Piloto_1_Herido1;
                Text_Aerea_Pasajeros_Helicoptero_Muertos.Text = "Psajeros M: " + Aerea_hija_HelicopteroOP.Pasajeros_Muertos1 + "  H: " + Aerea_hija_HelicopteroOP.Pasajeros_Heridos1;

            }
            else
            {
                MessageBox.Show("Puede cargar hasta 20 Helicopteros");
            }
        }
        public void OrdenarDatosBombarderoTactico()
        {
            Aerea_hija_Bombardero_Tactico Aerea_hija_Bombardero_TacticoOP = new Aerea_hija_Bombardero_Tactico();

            try
            {
                Aerea_hija_Bombardero_TacticoOP.AvionesAtacadosForm1 = Int32.Parse(Text_Aerea_Cargar_Bombardero_Tactico_Atacados.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (Aerea_hija_Bombardero_TacticoOP.AvionesAtacadosForm1 >= 0 && Aerea_hija_Bombardero_TacticoOP.AvionesAtacadosForm1 <= 5)
            {
                Aerea_hija_Bombardero_TacticoOP.AvionDeUnPasajero();

                Text_Aerea_Bombardero_Tactico_Intactos.Text = "Helicopteros Intactos: " + Aerea_hija_Bombardero_TacticoOP.Aviones_Intactos1;
                Text_Aerea_Bombardero_Tactico_Perdidos.Text = "Helicopteros Perdidos: " + Aerea_hija_Bombardero_TacticoOP.Aviones_Perdidos1;
                Text_Aerea_Bombardero_Tactico_FueraDeCombate.Text = "Helicopteros FdC: " + Aerea_hija_Bombardero_TacticoOP.Aviones_FueraDeCombate1;
                Text_Aerea_Bombardero_Tactico_Danados.Text = "Helicopteros Dañados: " + Aerea_hija_Bombardero_TacticoOP.Aviones_Danados1;
                Text_Aerea_Bombardero_Tactico_Muertos.Text = "Pilotos M: " + Aerea_hija_Bombardero_TacticoOP.Piloto_1_Muerto1 + "  H: " + Aerea_hija_Bombardero_TacticoOP.Piloto_1_Herido1;
                Text_Aerea_Pasajeros_Bombardero_Tactico_Muertos.Text = "Pasajeros M: " + Aerea_hija_Bombardero_TacticoOP.Pasajeros_Muertos1 + "  H: " + Aerea_hija_Bombardero_TacticoOP.Pasajeros_Heridos1;

            }
            else
            {
                MessageBox.Show("Puede cargar hasta 5 Bombardero Tacticos");
            }
        }
        public void OrdenarDatosTransporteMilitar()
        {
            Aerea_hija_TransporteMilitar Aerea_hija_TransporteMilitarOP = new Aerea_hija_TransporteMilitar();

            try
            {
                Aerea_hija_TransporteMilitarOP.AvionesAtacadosForm1 = Int32.Parse(Text_Aerea_Cargar_TransporteMilitar_Aacados.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (Aerea_hija_TransporteMilitarOP.AvionesAtacadosForm1 >= 0 && Aerea_hija_TransporteMilitarOP.AvionesAtacadosForm1 <= 10)
            {
                Aerea_hija_TransporteMilitarOP.AvionDeUnPasajero();

                Text_Aerea_TransporteMilitar_Intactos.Text = "Transporte M Intactos: " + Aerea_hija_TransporteMilitarOP.Aviones_Intactos1;
                Text_Aerea_TransporteMilitar_Perdidos.Text = "Transporte M Perdidos: " + Aerea_hija_TransporteMilitarOP.Aviones_Perdidos1;
                Text_Aerea_TransporteMilitar_FueraDeCombate.Text = "Transporte M FdC: " + Aerea_hija_TransporteMilitarOP.Aviones_FueraDeCombate1;
                Text_Aerea_TransporteMilitar_Danados.Text = "Transporte M Dañados: " + Aerea_hija_TransporteMilitarOP.Aviones_Danados1;
                Text_Aerea_TransporteMilitar_Muertos.Text = "Pilotos M: " + Aerea_hija_TransporteMilitarOP.Piloto_1_Muerto1 + "  H: " + Aerea_hija_TransporteMilitarOP.Piloto_1_Herido1;
                Text_Aerea_Pasajeros_TransporteMilitar_Muertos.Text = "Pasajeros M: " + Aerea_hija_TransporteMilitarOP.Pasajeros_Muertos1 + "  H: " + Aerea_hija_TransporteMilitarOP.Pasajeros_Heridos1;

            }
            else
            {
                MessageBox.Show("Puede cargar hasta 10 Transportes Militares");
            }
        }

            
        /*
        private void Text_Aerea_Cargar_AtaqueTierra_Atacados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("solo Numeros Positivos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void Text_Aerea_Cargar_Polivalente_Atacados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("solo Numeros Positivos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void Text_Aerea_Cargar_CazaCombate_Atacados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("solo Numeros Positivos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void Text_Aerea_Cargar_TransporteMilitar_Aacados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("solo Numeros Positivos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void Text_Aerea_Cargar_Bombardero_Tactico_Atacados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("solo Numeros Positivos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void Text_Aerea_Cargar_Helicoptero_Atacados_KeyPress(object sender, KeyPressEventArgs e)
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
