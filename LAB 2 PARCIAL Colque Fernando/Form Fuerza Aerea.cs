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
           // OrdenarDatosCombatePolivalente();
           // OrdenarDatosCombateAtaqueTierra();
            OrdenarDatosHelicoptero();
           // OrdenarDatosBombarderoTactico();
            OrdenarDatosTransporteMilitar();


        }
        public void OrdenarDatosCazaCOmbate()
        {
            Aerea_CazaCombate aerea_Hija_CazaCombateOP = new Aerea_CazaCombate();

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
                Text_Aerea_CazaCombate_Muertos_Heridos.Text = "Pilotos M: " + aerea_Hija_CazaCombateOP.Piloto_Muerto1+ "  H: "+aerea_Hija_CazaCombateOP.Piloto_Herido1;
            }
            else
            {
                MessageBox.Show("Puede cargar hasta 40 Cazas");
            }
        }    
        public void OrdenarDatosHelicoptero()
        {
            Aerea_Helicoptero Aerea_hija_HelicopteroOP = new Aerea_Helicoptero();

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
                Text_Aerea_Helicoptero_Muertos.Text = "Pilotos M: " + Aerea_hija_HelicopteroOP.Piloto_Muerto1 + "  H: " + Aerea_hija_HelicopteroOP.Piloto_Herido1;
                Text_Aerea_Pasajeros_Helicoptero_Muertos.Text = "Psajeros M: " + Aerea_hija_HelicopteroOP.Pasajeros_Muertos1 + "  H: " + Aerea_hija_HelicopteroOP.Pasajeros_Heridos1;

            }
            else
            {
                MessageBox.Show("Puede cargar hasta 20 Helicopteros");
            }
        }
       
        public void OrdenarDatosTransporteMilitar()
        {
            Aerea_TransporteMilitar Aerea_hija_TransporteMilitarOP = new Aerea_TransporteMilitar();

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
                Text_Aerea_TransporteMilitar_Muertos.Text = "Pilotos M: " + Aerea_hija_TransporteMilitarOP.Piloto_Muerto1 + "  H: " + Aerea_hija_TransporteMilitarOP.Piloto_Herido1;
                Text_Aerea_Pasajeros_TransporteMilitar_Muertos.Text = "Pasajeros M: " + Aerea_hija_TransporteMilitarOP.Pasajeros_Muertos1 + "  H: " + Aerea_hija_TransporteMilitarOP.Pasajeros_Heridos1;
            }
            else
            {
                MessageBox.Show("Puede cargar hasta 10 Transportes Militares");
            }
        }
    }
}
