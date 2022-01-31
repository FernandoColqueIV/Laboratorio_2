using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2_PARCIAL
{
    class Terrestre_hija_Apollo1:Terrestre_Padre_Clase
    {
        public void DeterminarCantidadSoldados()
        {
            CantSoldadoTipo11 = 4000;
            CantSoldadoTipo21 = 2001;
            PorcentajeHeridosMuertosTipo11 = 60;
            PorcentajeHeridosMuertosTipo21 = 50;
            PorcentajeTipo11 = 60;
            Random RandomNum = new Random();

            for (int i = 0; i < SoldadosAtacadosForm1; i++)
            {
                int RandomNumAux = RandomNum.Next(1, 101);

                if (CantSoldadoTipo11 > 0 && RandomNumAux <= PorcentajeTipo11)
                {
                    int RandonHeridosMuertosAux = RandomNum.Next(1, 101);

                    if (RandonHeridosMuertosAux >= PorcentajeHeridosMuertosTipo11)
                    {
                        SoldadosMuertos11 += 1;
                        CantSoldadoTipo11 -= 1;
                    }
                    if (RandonHeridosMuertosAux < PorcentajeHeridosMuertosTipo11)
                    {
                        SoldadosHeridos11 += 1;
                        CantSoldadoTipo11 -= 1;
                    }
                }
                if (CantSoldadoTipo11 == 0 && RandomNumAux <= PorcentajeTipo11)
                {
                    RandomNumAux = PorcentajeHeridosMuertosTipo11;
                }
                if (CantSoldadoTipo21 > 0 && RandomNumAux > PorcentajeTipo11)
                {
                    int RandonHeridosMuertosAux2 = RandomNum.Next(1, 101);

                    if (RandonHeridosMuertosAux2 <= PorcentajeHeridosMuertosTipo21)
                    {
                        SoldadosHeridos21 += 1;
                        CantSoldadoTipo21 -= 1;
                    }
                    if (RandonHeridosMuertosAux2 > PorcentajeHeridosMuertosTipo21)
                    {
                        SoldadosMuertos21 += 1;
                        CantSoldadoTipo21 -= 1;
                    }
                }
            }
        }


    }
}
