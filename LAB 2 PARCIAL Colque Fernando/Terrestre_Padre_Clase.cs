using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2_PARCIAL
{
    class Terrestre_Padre_Clase
    {
        private int SoldadosAtacados1 = 0;
        private int SoldadosAtacados2 = 0;
        private int SoldadosMuertos1 = 0;
        private int SoldadosHeridos1 = 0;
        private int SoldadosMuertos2 = 0;
        private int SoldadosHeridos2 = 0;
        private int SoldadosAtacadosForm = 0;
        private int CantSoldadoTipo1;
        private int CantSoldadoTipo2;
        private int PorcentajeHeridosMuertosTipo1;
        private int PorcentajeHeridosMuertosTipo2;
        private int PorcentajeTipo1;
        private int PorcentajeTipo2;

        public Terrestre_Padre_Clase(int soldadosAtacados1, int soldadosAtacados2, int soldadosMuertos1, int soldadosHeridos1, int soldadosMuertos2, int soldadosHeridos2, int soldadosAtacadosForm, int cantSoldadoTipo1, int cantSoldadoTipo2, int porcentajeHeridosMuertosTipo1, int porcentajeHeridosMuertosTipo2, int porcentajeTipo1, int porcentajeTipo2 = 0)
        {
            SoldadosAtacados1 = soldadosAtacados1;
            SoldadosAtacados2 = soldadosAtacados2;
            SoldadosMuertos1 = soldadosMuertos1;
            SoldadosHeridos1 = soldadosHeridos1;
            SoldadosMuertos2 = soldadosMuertos2;
            SoldadosHeridos2 = soldadosHeridos2;
            SoldadosAtacadosForm = soldadosAtacadosForm;
            CantSoldadoTipo1 = cantSoldadoTipo1;
            CantSoldadoTipo2 = cantSoldadoTipo2;
            PorcentajeHeridosMuertosTipo1 = porcentajeHeridosMuertosTipo1;
            PorcentajeHeridosMuertosTipo2 = porcentajeHeridosMuertosTipo2;
            PorcentajeTipo1 = porcentajeTipo1;
            PorcentajeTipo2 = porcentajeTipo2;
        }

        public Terrestre_Padre_Clase()
        {

        }

        public int SoldadosAtacados11 { get => SoldadosAtacados1; set => SoldadosAtacados1 = value; }
        public int SoldadosAtacados21 { get => SoldadosAtacados2; set => SoldadosAtacados2 = value; }
        public int SoldadosAtacadosForm1 { get => SoldadosAtacadosForm; set => SoldadosAtacadosForm = value; }
        public int SoldadosHeridos11 { get => SoldadosHeridos1; set => SoldadosHeridos1 = value; }
        public int SoldadosMuertos11 { get => SoldadosMuertos1; set => SoldadosMuertos1 = value; }
        public int SoldadosMuertos21 { get => SoldadosMuertos2; set => SoldadosMuertos2 = value; }
        public int SoldadosHeridos21 { get => SoldadosHeridos2; set => SoldadosHeridos2 = value; }
        public int CantSoldadoTipo11 { get => CantSoldadoTipo1; set => CantSoldadoTipo1 = value; }
        public int CantSoldadoTipo21 { get => CantSoldadoTipo2; set => CantSoldadoTipo2 = value; }
        public int PorcentajeHeridosMuertosTipo11 { get => PorcentajeHeridosMuertosTipo1; set => PorcentajeHeridosMuertosTipo1 = value; }
        public int PorcentajeHeridosMuertosTipo21 { get => PorcentajeHeridosMuertosTipo2; set => PorcentajeHeridosMuertosTipo2 = value; }
        public int PorcentajeTipo11 { get => PorcentajeTipo1; set => PorcentajeTipo1 = value; }
        public int PorcentajeTipo21 { get => PorcentajeTipo2; set => PorcentajeTipo2 = value; }
    }
}
