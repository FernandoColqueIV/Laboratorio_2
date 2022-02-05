using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2_PARCIAL
{
    public abstract class Variables_Aereas : Variables_Naval
    {
        private int Piloto_Herido=0;
        private int Piloto_Muerto=0;
        private int Pasajeros_Heridos=0;
        private int Pasajeros_Muertos = 0;

        private int AvionesAtacadosForm = 0;

        private int Aviones_Intactos = 0;
        private int Aviones_Perdidos = 0;
        private int Aviones_Danados = 0;
        private int Aviones_FueraDeCombate = 0;

        private int PorcentajeMuertoPiloto = 0;
        private int PorcentajeDanoAvionDanado = 0;
        private int PorcentajeDanoAvionFueraCombate = 0;
        private int PorcentajeDanoAvionPerdido = 0;
        private int PorcentajePasajeroMuertos = 0;
        private int PorcentajePasajeroHeridos = 0;

        private int Cant_Pasajeros_Aeronave = 0;

        public Variables_Aereas()
        {

        }

        public Variables_Aereas(int piloto_Herido, int piloto_Muerto, int pasajeros_Heridos, int pasajeros_Muertos, int avionesAtacadosForm, int aviones_Intactos, int aviones_Perdidos, int aviones_Danados, int aviones_FueraDeCombate, int porcentajeMuertoPiloto, int porcentajeDanoAvionDanado, int porcentajeDanoAvionFueraCombate, int porcentajeDanoAvionPerdido, int porcentajePasajeroMuertos, int porcentajePasajeroHeridos, int cant_Pasajeros_Aeronave)
        {
            this.Piloto_Herido = piloto_Herido;
            this.Piloto_Muerto = piloto_Muerto;
            this.Pasajeros_Heridos = pasajeros_Heridos;
            this.Pasajeros_Muertos = pasajeros_Muertos;
            this.AvionesAtacadosForm = avionesAtacadosForm;
            this.Aviones_Intactos = aviones_Intactos;
            this.Aviones_Perdidos = aviones_Perdidos;
            this.Aviones_Danados = aviones_Danados;
            this.Aviones_FueraDeCombate = aviones_FueraDeCombate;
            this.PorcentajeMuertoPiloto = porcentajeMuertoPiloto;
            this.PorcentajeDanoAvionDanado = porcentajeDanoAvionDanado;
            this.PorcentajeDanoAvionFueraCombate = porcentajeDanoAvionFueraCombate;
            this.PorcentajeDanoAvionPerdido = porcentajeDanoAvionPerdido;
            this.PorcentajePasajeroMuertos = porcentajePasajeroMuertos;
            this.PorcentajePasajeroHeridos = porcentajePasajeroHeridos;
            this.Cant_Pasajeros_Aeronave = cant_Pasajeros_Aeronave;
        }

        public int Piloto_Herido1 { get => Piloto_Herido; set => Piloto_Herido = value; }
        public int Piloto_Muerto1 { get => Piloto_Muerto; set => Piloto_Muerto = value; }
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
        public int PorcentajePasajeroMuertos1 { get => PorcentajePasajeroMuertos; set => PorcentajePasajeroMuertos = value; }
        public int PorcentajePasajeroHeridos1 { get => PorcentajePasajeroHeridos; set => PorcentajePasajeroHeridos = value; }
        public int Cant_Pasajeros_Aeronave1 { get => Cant_Pasajeros_Aeronave; set => Cant_Pasajeros_Aeronave = value; }
    }
}
