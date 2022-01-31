using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2_PARCIAL
{
    class Terrestre_hija_Apollo : Terrestre_Padre_Clase
    {

        //Datos_Soldados_General Datos_Soldados_GeneralOP = new Datos_Soldados_General();
        private int CantSoldadoApolloRecarga = 4000;
        private int CantSoldadoApolloMortero = 2001;
        public int CantSoldadoAsaltoElite1 { get => CantSoldadoAsaltoElite; set => CantSoldadoAsaltoElite = value; }
        public int CantSoldadoAsaltoComun1 { get => CantSoldadoAsaltoComun; set => CantSoldadoAsaltoComun = value; }

        public void DeterminarCantidadElitesYComunes()
        {

            Random RandomElitesComunes = new Random();

            for (int i = 0; i < SoldadosAtacadosForm1; i++)
            {
                int RandomElitesComunesAux = RandomElitesComunes.Next(1, 101);

                if (CantSoldadoApolloRecarga > 0 && RandomElitesComunesAux <= 75)
                {
                    int RandomElitesHeridosMuertosAux = RandomElitesComunes.Next(1, 101);

                    if (RandomElitesHeridosMuertosAux >= 66)
                    {
                        SoldadosMuertos11 += 1;
                        CantSoldadoApolloRecarga -= 1;
                    }
                    if (RandomElitesHeridosMuertosAux < 66)
                    {
                        SoldadosHeridos11 += 1;
                        CantSoldadoApolloRecarga -= 1;
                    }
                }

                if (CantSoldadoApolloRecarga == 0 && RandomElitesComunesAux <= 75)
                {
                    RandomElitesComunesAux = 75;
                }

                if (CantSoldadoApolloMortero > 0 && RandomElitesComunesAux > 75)
                {
                    int RandomComunHeridosMuertosAux = RandomElitesComunes.Next(1, 101);

                    if (RandomComunHeridosMuertosAux <= 25)
                    {
                        SoldadosHeridos21 += 1;
                        CantSoldadoApolloMortero -= 1;
                    }
                    if (RandomComunHeridosMuertosAux > 25)
                    {
                        SoldadosMuertos21 += 1;
                        CantSoldadoApolloMortero -= 1;
                    }

                }
            }
        }

    }
}
