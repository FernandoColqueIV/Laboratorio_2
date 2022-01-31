using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2_PARCIAL
{
    class Aerea_Padre_Clase
    {
        private int Piloto_1_Herido;
        private int Piloto_2_Herido;
        private int Piloto_1_Muerto=0;
        private int Piloto_2_Muerto;
        private int Pasajeros_Heridos;
        private int Pasajeros_Muertos;
        private int AvionesAtacadosForm = 0;

        private int Aviones_Intactos;
        private int Aviones_Perdidos;
        private int Aviones_Danados;
        private int Aviones_FueraDeCombate;

        private int PorcentajeMuertoPiloto;
        private int PorcentajeDanoAvionDanado;
        private int PorcentajeDanoAvionFueraCombate;
        private int PorcentajeDanoAvionPerdido;
        private int PorcentajePasajeroMuertos;
        private int PorcentajePasajeroHeridos;

        private int Cant_Pasajeros_Aeronave;

        public int Piloto_1_Herido1 { get => Piloto_1_Herido; set => Piloto_1_Herido = value; }
        public int Piloto_2_Herido1 { get => Piloto_2_Herido; set => Piloto_2_Herido = value; }
        public int Piloto_1_Muerto1 { get => Piloto_1_Muerto; set => Piloto_1_Muerto = value; }
        public int Piloto_2_Muerto1 { get => Piloto_2_Muerto; set => Piloto_2_Muerto = value; }
        public int Pasajeros_Heridos1 { get => Pasajeros_Heridos; set => Pasajeros_Heridos = value; }
        public int Pasajeros_Muertos1 { get => Pasajeros_Muertos; set => Pasajeros_Muertos = value; }
        public int AvionesAtacadosForm1 { get => AvionesAtacadosForm; set => AvionesAtacadosForm = value; }
        public int Aviones_Intactos1 { get => Aviones_Intactos; set => Aviones_Intactos = value; }
        public int Aviones_Perdidos1 { get => Aviones_Perdidos; set => Aviones_Perdidos = value; }
        public int Aviones_Danados1 { get => Aviones_Danados; set => Aviones_Danados = value; }
        public int Aviones_FueraDeCombate1 { get => Aviones_FueraDeCombate; set => Aviones_FueraDeCombate = value; }
        public int PorcentajeMuertoPiloto1 { get => PorcentajeMuertoPiloto; set => PorcentajeMuertoPiloto = value; }
        public int PorcentajeDanoAvionDanado1 { get => PorcentajeDanoAvionDanado; set => PorcentajeDanoAvionDanado = value; }
        public int PorcentajeDanoAvionFueraCombate1 { get => PorcentajeDanoAvionFueraCombate; set => PorcentajeDanoAvionFueraCombate = value; }
        public int PorcentajeDanoAvionPerdido1 { get => PorcentajeDanoAvionPerdido; set => PorcentajeDanoAvionPerdido = value; }
        public int Cant_Pasajeros_Aeronave1 { get => Cant_Pasajeros_Aeronave; set => Cant_Pasajeros_Aeronave = value; }
        public int PorcentajePasajeroMuertos1 { get => PorcentajePasajeroMuertos; set => PorcentajePasajeroMuertos = value; }
        public int PorcentajePasajeroHeridos1 { get => PorcentajePasajeroHeridos; set => PorcentajePasajeroHeridos = value; }

        public Aerea_Padre_Clase(int piloto_1_Herido, int piloto_2_Herido, int piloto_1_Muerto, int piloto_2_Muerto, int pasajeros_Heridos, int pasajeros_Muertos, int avionesAtacadosForm, int aviones_Intactos, int aviones_Perdidos, int aviones_Danados, int aviones_FueraDeCombate, int porcentajeMuertoPiloto, int porcentajeDanoAvionDanado, int porcentajeDanoAvionFueraCombate, int porcentajeDanoAvionPerdido, int cant_Pasajeros_Aeronave, int porcentajePasajeroMuertos, int porcentajePasajeroHeridos)
        {
            Piloto_1_Herido = piloto_1_Herido;
            Piloto_2_Herido = piloto_2_Herido;
            Piloto_1_Muerto = piloto_1_Muerto;
            Piloto_2_Muerto = piloto_2_Muerto;
            Pasajeros_Heridos = pasajeros_Heridos;
            Pasajeros_Muertos = pasajeros_Muertos;
            AvionesAtacadosForm = avionesAtacadosForm;
            Aviones_Intactos = aviones_Intactos;
            Aviones_Perdidos = aviones_Perdidos;
            Aviones_Danados = aviones_Danados;
            Aviones_FueraDeCombate = aviones_FueraDeCombate;
            PorcentajeMuertoPiloto = porcentajeMuertoPiloto;
            PorcentajeDanoAvionDanado = porcentajeDanoAvionDanado;
            PorcentajeDanoAvionFueraCombate = porcentajeDanoAvionFueraCombate;
            PorcentajeDanoAvionPerdido = porcentajeDanoAvionPerdido;
            Cant_Pasajeros_Aeronave = cant_Pasajeros_Aeronave;
            PorcentajePasajeroMuertos = porcentajePasajeroMuertos;
            PorcentajePasajeroHeridos = porcentajePasajeroHeridos;
        }

        public Aerea_Padre_Clase()
        {

        }
    }
}
