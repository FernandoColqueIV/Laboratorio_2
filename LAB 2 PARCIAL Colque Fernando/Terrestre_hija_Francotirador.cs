﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2_PARCIAL
{
    class Terrestre_hija_Francotirador:Terrestre_Padre_Clase
    {
        public void DeterminarCantidadSoldados()
        {
            CantSoldadoTipo11 = 150;
            CantSoldadoTipo21 = 100;
            PorcentajeHeridosMuertosTipo11 = 80;
            PorcentajeHeridosMuertosTipo21 = 70;
            PorcentajeTipo11 = 50;
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