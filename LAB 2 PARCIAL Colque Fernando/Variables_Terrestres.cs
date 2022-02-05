using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2_PARCIAL
{
    class Variables_Terrestres : Variables_Aereas
    {
        private int atacados_Form = 0;
        private int porcentaje_dividir_tipo_soldado = 0;

        private int veteranos_atacados = 0;
        private int veteranos_heridos = 0;
        private int veteranos_muertos = 0;
        private int veteranos_cantidad = 0;
        private int veteranos_porcentaje_heridos_muerto = 0;

        private int novatos_atacados = 0;
        private int novatos_heridos = 0;
        private int novatos_muertos = 0;
        private int novatos_cantidad = 0;
        private int novatos_porcentaje_heridos_muerto = 0;
        public Variables_Terrestres()
        {

        }

        public Variables_Terrestres(int atacados_Form, int porcentaje_dividir_tipo_soldado, int veteranos_atacados, int veteranos_heridos, int veteranos_muertos, int veteranos_cantidad, int veteranos_porcentaje_heridos_muerto, int novatos_atacados, int novatos_heridos, int novatos_muertos, int novatos_cantidad, int novatos_porcentaje_heridos_muerto)
        {
            this.atacados_Form = atacados_Form;
            this.porcentaje_dividir_tipo_soldado = porcentaje_dividir_tipo_soldado;
            this.veteranos_atacados = veteranos_atacados;
            this.veteranos_heridos = veteranos_heridos;
            this.veteranos_muertos = veteranos_muertos;
            this.veteranos_cantidad = veteranos_cantidad;
            this.veteranos_porcentaje_heridos_muerto = veteranos_porcentaje_heridos_muerto;
            this.novatos_atacados = novatos_atacados;
            this.novatos_heridos = novatos_heridos;
            this.novatos_muertos = novatos_muertos;
            this.novatos_cantidad = novatos_cantidad;
            this.novatos_porcentaje_heridos_muerto = novatos_porcentaje_heridos_muerto;
        }

        public int Atacados_Form { get => atacados_Form; set => atacados_Form = value; }
        public int Porcentaje_dividir_tipo_soldado { get => porcentaje_dividir_tipo_soldado; set => porcentaje_dividir_tipo_soldado = value; }
        public int Veteranos_atacados { get => veteranos_atacados; set => veteranos_atacados = value; }
        public int Veteranos_heridos { get => veteranos_heridos; set => veteranos_heridos = value; }
        public int Veteranos_muertos { get => veteranos_muertos; set => veteranos_muertos = value; }
        public int Veteranos_cantidad { get => veteranos_cantidad; set => veteranos_cantidad = value; }
        public int Veteranos_porcentaje_heridos_muerto { get => veteranos_porcentaje_heridos_muerto; set => veteranos_porcentaje_heridos_muerto = value; }
        public int Novatos_atacados { get => novatos_atacados; set => novatos_atacados = value; }
        public int Novatos_heridos { get => novatos_heridos; set => novatos_heridos = value; }
        public int Novatos_muertos { get => novatos_muertos; set => novatos_muertos = value; }
        public int Novatos_cantidad { get => novatos_cantidad; set => novatos_cantidad = value; }
        public int Novatos_porcentaje_heridos_muerto { get => novatos_porcentaje_heridos_muerto; set => novatos_porcentaje_heridos_muerto = value; }
    }
}
