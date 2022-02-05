using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2_PARCIAL
{
    class Naval_hija_Destructor : Variables_Naval
    {
        public void DeterminarParametros()
        {
            Porcentaje_Muerto_Capitan1 = 50;
            Porcentaje_Dano_Barco_Danado1 = 30;
            Porcentaje_Dano_Barco_Fuera_Combate1 = 75;
            Porcentaje_Dano_Barco_Perdido1 = 100;
            Barcos_Intactos1 = 20;
            Cant_Marineros_Barcos1 = 700;
            Porcentaje_Herido_Marinero1 = 20;
            Porcentaje_Muerto_Marinero1 = 35;

            Calcular_Bajas_Todas_Unidades calcular_Bajas_Todas_UnidadesOP = new Calcular_Bajas_Todas_Unidades();

            calcular_Bajas_Todas_UnidadesOP.Barcos_AtacadosForm1 = Barcos_AtacadosForm1;

            calcular_Bajas_Todas_UnidadesOP.Porcentaje_Dano_Barco_Danado1 = Porcentaje_Dano_Barco_Danado1;
            calcular_Bajas_Todas_UnidadesOP.Porcentaje_Dano_Barco_Fuera_Combate1 = Porcentaje_Dano_Barco_Fuera_Combate1;
            calcular_Bajas_Todas_UnidadesOP.Porcentaje_Dano_Barco_Perdido1 = Porcentaje_Dano_Barco_Perdido1;

            calcular_Bajas_Todas_UnidadesOP.Porcentaje_Muerto_Capitan1 = Porcentaje_Muerto_Capitan1;

            calcular_Bajas_Todas_UnidadesOP.Porcentaje_Muerto_Marinero1 = Porcentaje_Muerto_Marinero1;
            calcular_Bajas_Todas_UnidadesOP.Porcentaje_Herido_Marinero1 = Porcentaje_Herido_Marinero1;

            calcular_Bajas_Todas_UnidadesOP.Cant_Marineros_Barcos1 = Cant_Marineros_Barcos1;
            calcular_Bajas_Todas_UnidadesOP.Barcos_Intactos1 = Barcos_Intactos1;

            calcular_Bajas_Todas_UnidadesOP.CalcularDatosBarcos();

            Capitan_Herido1 = calcular_Bajas_Todas_UnidadesOP.Capitan_Herido1;
            Capitan_Muerto1 = calcular_Bajas_Todas_UnidadesOP.Capitan_Muerto1;

            Marinero_Herido1 = calcular_Bajas_Todas_UnidadesOP.Marinero_Herido1;
            Marinero_Muerto1 = calcular_Bajas_Todas_UnidadesOP.Marinero_Muerto1;

            Barcos_Intactos1 = calcular_Bajas_Todas_UnidadesOP.Barcos_Intactos1;
            Barcos_Perdidos1 = calcular_Bajas_Todas_UnidadesOP.Barcos_Perdidos1;
            Barcos_Danados1 = calcular_Bajas_Todas_UnidadesOP.Barcos_Danados1;
            Barcos_FueraDeCombate1 = calcular_Bajas_Todas_UnidadesOP.Barcos_FueraDeCombate1;


        }


    }
}
