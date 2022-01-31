using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2_PARCIAL
{
    class Naval_hija_crucero : Naval_Padre_Clase
    {
        private int[] ArrayBarcos = new int[20];
        private int[] ArrayBarcosAuxiliar = new int[20];
        public void DeterminarParametros()
        {
            CantidadBarcos1 = 20;
            PorcentajeBarcosPerdidos1 = 80;
            PorcentajeBarcosIncapacitados1 = 65;
            CantMarinos1 = 600;
            Guardar_Datos();
            Determianr_Estado_De_Los_Barcos();
        }
        public void Guardar_Datos()
        {
            for (int i = 0; i < CantidadBarcos1; i++)
            {
                ArrayBarcos[i] = CantMarinos1;
            }
        }
        public void Determianr_Estado_De_Los_Barcos()
        {
            for (int i = 0; i < Barcos_Atacados1; i++)
            {
                int numRandomAcorazado = Random_procentaje1.Next(0, 101);
                ArrayBarcosAuxiliar[i] = numRandomAcorazado;
                NumeroRandom = numRandomAcorazado;
                //Perdidas
                if (ArrayBarcosAuxiliar[i] >= PorcentajeBarcosPerdidos1)
                {
                    Barcos_totales_perdidos += 1;
                }
                //Incapacitados
                if (ArrayBarcosAuxiliar[i] >= PorcentajeBarcosIncapacitados1 && ArrayBarcosAuxiliar[i] < PorcentajeBarcosPerdidos1)
                {
                    Barcos_incapacitados += 1;
                }
                //Dañados
                if (ArrayBarcosAuxiliar[i] >= 0 && ArrayBarcosAuxiliar[i] < PorcentajeBarcosIncapacitados1)
                {
                    Barcos_danados += 1;
                }
                //Marinos Muertos
                MarinosMuertos += ((NumeroRandom * ArrayBarcos[i]) / 100);
            }
        }
        public int Cantidad_Barcos_Intactos()
        {
            Barcos_intactos = CantidadBarcos1 - Barcos_Atacados1;
            return Barcos_intactos;
        }
    }
}
