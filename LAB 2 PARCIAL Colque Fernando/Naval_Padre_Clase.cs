using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2_PARCIAL
{
    class Naval_Padre_Clase
    {
        private int marinosMuertos;
        private int barcos_totales_perdidos=0;
        private int Barcos_Atacados=0;
        private int barcos_incapacitados=0;
        private int barcos_intactos = 0;
        private int numeroRandom;
        private int barcos_danados=0;
        private int CantMarinos = 0;
        private int CantidadBarcos = 0;
        private int PorcentajeBarcosPerdidos=0;
        private int PorcentajeBarcosIncapacitados = 0;

        Random Random_procentaje = new Random();

        public int Barcos_totales_perdidos { get => barcos_totales_perdidos; set => barcos_totales_perdidos = value; }
        public int Barcos_Atacados1 { get => Barcos_Atacados; set => Barcos_Atacados = value; }
        public Random Random_procentaje1 { get => Random_procentaje; set => Random_procentaje = value; }
        public int Barcos_incapacitados { get => barcos_incapacitados; set => barcos_incapacitados = value; }
        public int MarinosMuertos { get => marinosMuertos; set => marinosMuertos = value; }
        public int Barcos_intactos { get => barcos_intactos; set => barcos_intactos = value; }
        public int NumeroRandom { get => numeroRandom; set => numeroRandom = value; }
        public int Barcos_danados { get => barcos_danados; set => barcos_danados = value; }
        public int CantMarinos1 { get => CantMarinos; set => CantMarinos = value; }
        public int CantidadBarcos1 { get => CantidadBarcos; set => CantidadBarcos = value; }
        public int PorcentajeBarcosPerdidos1 { get => PorcentajeBarcosPerdidos; set => PorcentajeBarcosPerdidos = value; }
        public int PorcentajeBarcosIncapacitados1 { get => PorcentajeBarcosIncapacitados; set => PorcentajeBarcosIncapacitados = value; }

        public Naval_Padre_Clase()
        {

        }
        public Naval_Padre_Clase(int marinos, int barcos_totales_perdidos, int Barcos_Atacados, int barcos_incapacitados, int barcos_intactos, int numeroRandom, int barcos_danados, int cantMarinos, int cantidadBarcos, int porcentajeBarcosPerdidos, int porcentajeBarcosIncapacitados)
        {
            this.marinosMuertos = marinos;
            this.barcos_totales_perdidos = barcos_totales_perdidos;
            this.Barcos_Atacados = Barcos_Atacados;
            this.barcos_incapacitados = barcos_incapacitados;
            this.barcos_intactos = barcos_intactos;
            this.numeroRandom = numeroRandom;
            this.barcos_danados = barcos_danados;
            this.CantMarinos = cantMarinos;
            CantidadBarcos = cantidadBarcos;
            PorcentajeBarcosPerdidos = porcentajeBarcosPerdidos;
            PorcentajeBarcosIncapacitados = porcentajeBarcosIncapacitados;
        }




    }
}
