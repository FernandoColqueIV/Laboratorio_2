using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2_PARCIAL
{
    class Terrestre_hija_Asalto : Variables_Terrestres
    {
        public void Asalto()
        {
            Calcular_Bajas_Todas_Unidades terrestre_Calcular_BajasOP = new Calcular_Bajas_Todas_Unidades();

            Veteranos_cantidad = 1000;
            Veteranos_porcentaje_heridos_muerto = 75;
            Novatos_cantidad = 30000;
            Novatos_porcentaje_heridos_muerto = 25;
            Porcentaje_dividir_tipo_soldado = 5;

            terrestre_Calcular_BajasOP.Atacados_Form = Atacados_Form;

            terrestre_Calcular_BajasOP.Veteranos_cantidad = Veteranos_cantidad;
            terrestre_Calcular_BajasOP.Novatos_cantidad = Novatos_cantidad;
            terrestre_Calcular_BajasOP.Porcentaje_dividir_tipo_soldado = Porcentaje_dividir_tipo_soldado;
            terrestre_Calcular_BajasOP.Veteranos_porcentaje_heridos_muerto = Veteranos_porcentaje_heridos_muerto;
            terrestre_Calcular_BajasOP.Novatos_porcentaje_heridos_muerto = Novatos_porcentaje_heridos_muerto;

            terrestre_Calcular_BajasOP.CalcularDatosSoldadosInfanteria();

            Veteranos_cantidad = terrestre_Calcular_BajasOP.Veteranos_cantidad;
            Veteranos_muertos = terrestre_Calcular_BajasOP.Veteranos_muertos;
            Veteranos_heridos = terrestre_Calcular_BajasOP.Veteranos_heridos;
            
            Novatos_cantidad = terrestre_Calcular_BajasOP.Novatos_cantidad;
            Novatos_muertos = terrestre_Calcular_BajasOP.Novatos_muertos;
            Novatos_heridos = terrestre_Calcular_BajasOP.Novatos_heridos;



        }
    }
}




