using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2_PARCIAL
{
    class Datos_Soldados_General
    {
        //Marinos
        private int CantMarinoFragata = 250;
        private int CantMarinoCrucero = 600;
        private int CantMarinoDestructor = 700;
        private int CantMarinoAcorazado = 1300;
        private int CantMarinoPortaAviones = 2000;
        private int LanchaRapida = 6;
        private int CantMarinoSubMarinos = 200;

        public int CantMarinoFragata1 { get => CantMarinoFragata; set => CantMarinoFragata = value; }
        public int CantMarinoCrucero1 { get => CantMarinoCrucero; set => CantMarinoCrucero = value; }
        public int CantMarinoDestructor1 { get => CantMarinoDestructor; set => CantMarinoDestructor = value; }
        public int CantMarinoAcorazado1 { get => CantMarinoAcorazado; set => CantMarinoAcorazado = value; }
        public int CantMarinoPortaAviones1 { get => CantMarinoPortaAviones; set => CantMarinoPortaAviones = value; }
        public int LanchaRapida1 { get => LanchaRapida; set => LanchaRapida = value; }
        public int CantMarinoSubMarinos1 { get => CantMarinoSubMarinos; set => CantMarinoSubMarinos = value; }

        //Soldados De Tierra
        private int CantSoldadoAsaltoComun = 30000;
        private int CantSoldadoAsaltoElite = 1000;
        private int CantSoldadoApolloRebastecedor = 4000;
        private int CantSoldadoApolloMortero = 2000;
        private int CantSoldadoMedicoPrimerosAuxilios = 1500;
        private int CantSoldadoMedicosAtenderTraumasFrenteDeBAtalla = 500;
        private int CantSoldadoFrancotiradorAntiUnidad = 150;
        private int CantSoldadoFrancotiradorAntiBlindado = 100;
        private int CantSoldadoTanque = 5;
        private int CantSoldadoTransporte = 50;
        private int CantSoldado4x4 = 4;
        private int CantSoldadoObusMovil = 6;
        private int CantSoldadoObusFijo = 7;

        public int CantSoldadoAsaltoComun1 { get => CantSoldadoAsaltoComun; set => CantSoldadoAsaltoComun = value; }
        public int CantSoldadoAsaltoElite1 { get => CantSoldadoAsaltoElite; set => CantSoldadoAsaltoElite = value; }
        public int CantSoldadoApolloRebastecedor1 { get => CantSoldadoApolloRebastecedor; set => CantSoldadoApolloRebastecedor = value; }
        public int CantSoldadoApolloMortero1 { get => CantSoldadoApolloMortero; set => CantSoldadoApolloMortero = value; }
        public int CantSoldadoMedicoPrimerosAuxilios1 { get => CantSoldadoMedicoPrimerosAuxilios; set => CantSoldadoMedicoPrimerosAuxilios = value; }
        public int CantSoldadoMedicosAtenderTraumasFrenteDeBAtalla1 { get => CantSoldadoMedicosAtenderTraumasFrenteDeBAtalla; set => CantSoldadoMedicosAtenderTraumasFrenteDeBAtalla = value; }
        public int CantSoldadoFrancotiradorAntiUnidad1 { get => CantSoldadoFrancotiradorAntiUnidad; set => CantSoldadoFrancotiradorAntiUnidad = value; }
        public int CantSoldadoFrancotiradorAntiBlindado1 { get => CantSoldadoFrancotiradorAntiBlindado; set => CantSoldadoFrancotiradorAntiBlindado = value; }
        public int CantSoldadoTanque1 { get => CantSoldadoTanque; set => CantSoldadoTanque = value; }
        public int CantSoldadoTransporte1 { get => CantSoldadoTransporte; set => CantSoldadoTransporte = value; }
        public int CantSoldado4x41 { get => CantSoldado4x4; set => CantSoldado4x4 = value; }
        public int CantSoldadoObusMovil1 { get => CantSoldadoObusMovil; set => CantSoldadoObusMovil = value; }
        public int CantSoldadoObusFijo1 { get => CantSoldadoObusFijo; set => CantSoldadoObusFijo = value; }

        //SoldadosAire
        private int CantAireSoldadoTransporteMilitar = 150;
        private int CantAireSoldadoTransporteCivil = 300;
        private int CantAireSoldadoRepostador = 8;
        private int CantAireSoldadoHelicoptero = 3;
        private int CantAireSoldadoBombardero = 4;
        private int CantAireSoldadoBusquedaYRescate = 3;

        private int CantAirePilotoTransporteMilitar = 2;
        private int CantAirePilotoTransporteCivil = 2;
        private int CantAirePilotoRepostador = 2;
        private int CantAirePilotoHelicoptero = 2;
        private int CantAirePilotoBombardero = 2;
        private int CantAirePilotoBusquedaYRescate = 1;
        private int CantAirePilotoAtaqueTierra = 1;
        private int CantAirePilotoCaza = 1;
        private int CantAirePilotoPolivalente = 1;

        public int CantAireSoldadoTransporteMilitar1 { get => CantAireSoldadoTransporteMilitar; set => CantAireSoldadoTransporteMilitar = value; }
        public int CantAireSoldadoTransporteCivil1 { get => CantAireSoldadoTransporteCivil; set => CantAireSoldadoTransporteCivil = value; }
        public int CantAireSoldadoRepostador1 { get => CantAireSoldadoRepostador; set => CantAireSoldadoRepostador = value; }
        public int CantAireSoldadoHelicoptero1 { get => CantAireSoldadoHelicoptero; set => CantAireSoldadoHelicoptero = value; }
        public int CantAireSoldadoBombardero1 { get => CantAireSoldadoBombardero; set => CantAireSoldadoBombardero = value; }
        public int CantAireSoldadoBusquedaYRescate1 { get => CantAireSoldadoBusquedaYRescate; set => CantAireSoldadoBusquedaYRescate = value; }
        public int CantAirePilotoTransporteMilitar1 { get => CantAirePilotoTransporteMilitar; set => CantAirePilotoTransporteMilitar = value; }
        public int CantAirePilotoTransporteCivil1 { get => CantAirePilotoTransporteCivil; set => CantAirePilotoTransporteCivil = value; }
        public int CantAirePilotoRepostador1 { get => CantAirePilotoRepostador; set => CantAirePilotoRepostador = value; }
        public int CantAirePilotoHelicoptero1 { get => CantAirePilotoHelicoptero; set => CantAirePilotoHelicoptero = value; }
        public int CantAirePilotoBombardero1 { get => CantAirePilotoBombardero; set => CantAirePilotoBombardero = value; }
        public int CantAirePilotoBusquedaYRescate1 { get => CantAirePilotoBusquedaYRescate; set => CantAirePilotoBusquedaYRescate = value; }
        public int CantAirePilotoAtaqueTierra1 { get => CantAirePilotoAtaqueTierra; set => CantAirePilotoAtaqueTierra = value; }
        public int CantAirePilotoCaza1 { get => CantAirePilotoCaza; set => CantAirePilotoCaza = value; }
        public int CantAirePilotoPolivalente1 { get => CantAirePilotoPolivalente; set => CantAirePilotoPolivalente = value; }

    }
}
