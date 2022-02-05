using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2_PARCIAL
{
    public abstract class  Variables_Naval
    {
        private int Marinero_Herido = 0;
        private int Marinero_Muerto = 0;
        private int Capitan_Herido = 0;
        private int Capitan_Muerto = 0;

        private int Barcos_AtacadosForm = 0;

        private int Barcos_Intactos = 0;
        private int Barcos_Perdidos = 0;
        private int Barcos_Danados = 0;
        private int Barcos_FueraDeCombate = 0;

        private int Porcentaje_Muerto_Capitan = 0;
        private int Porcentaje_Muerto_Marinero = 0;
        private int Porcentaje_Herido_Marinero = 0;
        private int Porcentaje_Dano_Barco_Danado = 0;
        private int Porcentaje_Dano_Barco_Fuera_Combate = 0;
        private int Porcentaje_Dano_Barco_Perdido = 0;
        
        private int Cant_Marineros_Barcos = 0;

        public int Marinero_Herido1 { get => Marinero_Herido; set => Marinero_Herido = value; }
        public int Marinero_Muerto1 { get => Marinero_Muerto; set => Marinero_Muerto = value; }
        public int Capitan_Herido1 { get => Capitan_Herido; set => Capitan_Herido = value; }
        public int Capitan_Muerto1 { get => Capitan_Herido; set => Capitan_Muerto = value; }
        public int Barcos_AtacadosForm1 { get => Barcos_AtacadosForm; set => Barcos_AtacadosForm = value; }
        public int Barcos_Intactos1 { get => Barcos_Intactos; set => Barcos_Intactos = value; }
        public int Barcos_Perdidos1 { get => Barcos_Perdidos; set => Barcos_Perdidos = value; }
        public int Barcos_Danados1 { get => Barcos_Danados; set => Barcos_Danados = value; }
        public int Barcos_FueraDeCombate1 { get => Barcos_FueraDeCombate; set => Barcos_FueraDeCombate = value; }
        public int Porcentaje_Muerto_Capitan1 { get => Porcentaje_Muerto_Capitan; set => Porcentaje_Muerto_Capitan = value; }
        public int Porcentaje_Muerto_Marinero1 { get => Porcentaje_Muerto_Marinero; set => Porcentaje_Muerto_Marinero = value; }
        public int Porcentaje_Herido_Marinero1 { get => Porcentaje_Herido_Marinero; set => Porcentaje_Herido_Marinero = value; }
        public int Porcentaje_Dano_Barco_Danado1 { get => Porcentaje_Dano_Barco_Danado; set => Porcentaje_Dano_Barco_Danado = value; }
        public int Porcentaje_Dano_Barco_Fuera_Combate1 { get => Porcentaje_Dano_Barco_Fuera_Combate; set => Porcentaje_Dano_Barco_Fuera_Combate = value; }
        public int Porcentaje_Dano_Barco_Perdido1 { get => Porcentaje_Dano_Barco_Perdido; set => Porcentaje_Dano_Barco_Perdido = value; }
        public int Cant_Marineros_Barcos1 { get => Cant_Marineros_Barcos; set => Cant_Marineros_Barcos = value; }

        protected Variables_Naval(int marinero_Herido, int marinero_Muerto, int capitan_Herido, int capitan_Muerto, int barcos_AtacadosForm, int barcos_Intactos, int barcos_Perdidos, int barcos_Danados, int barcos_FueraDeCombate, int porcentaje_Muerto_Capitan, int porcentaje_Muerto_Marinero, int porcentaje_Herido_Marinero, int porcentaje_Dano_Barco_Danado, int porcentaje_Dano_Barco_Fuera_Combate, int porcentaje_Dano_Barco_Perdido, int cant_Marineros_Barcos)
        {
            Marinero_Herido = marinero_Herido;
            Marinero_Muerto = marinero_Muerto;
            Capitan_Herido = capitan_Herido;
            Capitan_Muerto = capitan_Muerto;
            Barcos_AtacadosForm = barcos_AtacadosForm;
            Barcos_Intactos = barcos_Intactos;
            Barcos_Perdidos = barcos_Perdidos;
            Barcos_Danados = barcos_Danados;
            Barcos_FueraDeCombate = barcos_FueraDeCombate;
            Porcentaje_Muerto_Capitan = porcentaje_Muerto_Capitan;
            Porcentaje_Muerto_Marinero = porcentaje_Muerto_Marinero;
            Porcentaje_Herido_Marinero = porcentaje_Herido_Marinero;
            Porcentaje_Dano_Barco_Danado = porcentaje_Dano_Barco_Danado;
            Porcentaje_Dano_Barco_Fuera_Combate = porcentaje_Dano_Barco_Fuera_Combate;
            Porcentaje_Dano_Barco_Perdido = porcentaje_Dano_Barco_Perdido;
            Cant_Marineros_Barcos = cant_Marineros_Barcos;
        }

        public Variables_Naval()
        {

        }



    }
}
