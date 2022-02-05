using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2_PARCIAL
{
    class Terrestre_hija_Medico:Variables_Terrestres
    {
        public void DeterminarCantidadSoldados()
        {
            Novatos_cantidad = 1500;
            Veteranos_cantidad = 501;
            Veteranos_porcentaje_heridos_muerto = 80;
            Novatos_porcentaje_heridos_muerto = 50;
            Porcentaje_dividir_tipo_soldado = 75;

            Calcular_Bajas_Todas_Unidades Calcular_Bajas_Todas_UnidadesOP = new Calcular_Bajas_Todas_Unidades();

            Calcular_Bajas_Todas_UnidadesOP.Atacados_Form = Atacados_Form;

            Calcular_Bajas_Todas_UnidadesOP.Veteranos_cantidad = Veteranos_cantidad;
            Calcular_Bajas_Todas_UnidadesOP.Novatos_cantidad = Novatos_cantidad;
            Calcular_Bajas_Todas_UnidadesOP.Porcentaje_dividir_tipo_soldado = Porcentaje_dividir_tipo_soldado;
            Calcular_Bajas_Todas_UnidadesOP.Veteranos_porcentaje_heridos_muerto = Veteranos_porcentaje_heridos_muerto;
            Calcular_Bajas_Todas_UnidadesOP.Novatos_porcentaje_heridos_muerto = Novatos_porcentaje_heridos_muerto;

            Calcular_Bajas_Todas_UnidadesOP.CalcularDatosSoldadosInfanteria();

            Veteranos_cantidad = Calcular_Bajas_Todas_UnidadesOP.Veteranos_cantidad;
            Veteranos_muertos = Calcular_Bajas_Todas_UnidadesOP.Veteranos_muertos;
            Veteranos_heridos = Calcular_Bajas_Todas_UnidadesOP.Veteranos_heridos;

            Novatos_cantidad = Calcular_Bajas_Todas_UnidadesOP.Novatos_cantidad;
            Novatos_muertos = Calcular_Bajas_Todas_UnidadesOP.Novatos_muertos;
            Novatos_heridos = Calcular_Bajas_Todas_UnidadesOP.Novatos_heridos;
        }
    }
}
