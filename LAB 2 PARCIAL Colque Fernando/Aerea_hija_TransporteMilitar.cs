using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2_PARCIAL
{
    class Aerea_hija_TransporteMilitar:Aerea_Padre_Clase
    {
        public void AvionDeUnPasajero()
        {
            PorcentajeMuertoPiloto1 = 80;
            PorcentajeDanoAvionDanado1 = 85;
            PorcentajeDanoAvionFueraCombate1 = 95;
            PorcentajeDanoAvionPerdido1 = 100;
            Aviones_Intactos1 = 10;
            Cant_Pasajeros_Aeronave1 = 100;
            PorcentajePasajeroHeridos1 = 15;
            PorcentajePasajeroMuertos1 = 30;

            Random RandomNum = new Random();

            for (int i = 0; i < AvionesAtacadosForm1; i++)
            {
                int RandomNumPiloto = RandomNum.Next(1, 101);

                if (RandomNumPiloto > PorcentajeMuertoPiloto1)
                {
                    Piloto_1_Muerto1 += 1;
                    Aviones_Intactos1 -= 1;
                    Aviones_Perdidos1 += 1;
                    Pasajeros_Muertos1 += Cant_Pasajeros_Aeronave1;

                }

                if (RandomNumPiloto <= PorcentajeMuertoPiloto1)
                {

                    int RandomNumPilotoHerido = RandomNum.Next(1, 101);

                    if (RandomNumPilotoHerido < PorcentajeDanoAvionDanado1)
                    {
                        Aviones_Danados1 += 1;
                        Aviones_Intactos1 -= 1;
                        Piloto_1_Herido1 += 1;

                        Pasajeros_Muertos_Heridos();
                    }
                    if (RandomNumPilotoHerido >= PorcentajeDanoAvionDanado1 && RandomNumPilotoHerido <= PorcentajeDanoAvionFueraCombate1)
                    {
                        Aviones_FueraDeCombate1 += 1;
                        Aviones_Intactos1 -= 1;
                        Piloto_1_Herido1 += 1;

                        Pasajeros_Muertos_Heridos();
                    }
                    if (RandomNumPilotoHerido > PorcentajeDanoAvionFueraCombate1 && RandomNumPilotoHerido <= PorcentajeDanoAvionPerdido1)
                    {
                        Aviones_Perdidos1 += 1;
                        Aviones_Intactos1 -= 1;


                        int RandomNumPilotoHeridoMuerto = RandomNum.Next(1, 101);

                        if (RandomNumPilotoHeridoMuerto > 75)
                        {
                            Piloto_1_Herido1 += 1;

                            Pasajeros_Muertos_Heridos();
                        }
                        else
                        {
                            Piloto_1_Muerto1 += 1;

                            Pasajeros_Muertos1 += Cant_Pasajeros_Aeronave1;
                        }
                    }
                }
            }
        }
        public void Pasajeros_Muertos_Heridos()
        {
            Random RandomNum = new Random();

            for (int j = 0; j < Cant_Pasajeros_Aeronave1; j++)
            {
                int RandomNumPasajerosHeridoMuerto = RandomNum.Next(1, 101);

                if (RandomNumPasajerosHeridoMuerto <= PorcentajePasajeroHeridos1)
                {
                    Pasajeros_Heridos1 += 1;
                }
                if (RandomNumPasajerosHeridoMuerto > PorcentajePasajeroHeridos1 && RandomNumPasajerosHeridoMuerto < PorcentajePasajeroMuertos1)
                {
                    Pasajeros_Muertos1 += 1;
                }
            }
        }

    }
}
