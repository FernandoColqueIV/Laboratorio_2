using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2_PARCIAL
{
    class Aerea_Helicoptero : Variables_Aereas
    {
        public void AvionDeUnPasajero()
        {
            PorcentajeMuertoPiloto1 = 30;
            PorcentajeDanoAvionDanado1 = 40;
            PorcentajeDanoAvionFueraCombate1 = 65;
            PorcentajeDanoAvionPerdido1 = 100;
            Aviones_Intactos1 = 20;
            Cant_Pasajeros_Aeronave1 = 15;
            PorcentajePasajeroHeridos1=25;
            PorcentajePasajeroMuertos1=50;

            Calcular_Bajas_Todas_Unidades calcular_Bajas_Todas_UnidadesOP = new Calcular_Bajas_Todas_Unidades();

            calcular_Bajas_Todas_UnidadesOP.AvionesAtacadosForm1 = AvionesAtacadosForm1;

            calcular_Bajas_Todas_UnidadesOP.PorcentajeDanoAvionDanado1 = PorcentajeDanoAvionDanado1;
            calcular_Bajas_Todas_UnidadesOP.PorcentajeDanoAvionFueraCombate1 = PorcentajeDanoAvionFueraCombate1;
            calcular_Bajas_Todas_UnidadesOP.PorcentajeDanoAvionPerdido1 = PorcentajeDanoAvionPerdido1;

            calcular_Bajas_Todas_UnidadesOP.PorcentajeMuertoPiloto1 = PorcentajeMuertoPiloto1;

            calcular_Bajas_Todas_UnidadesOP.PorcentajePasajeroHeridos1 = PorcentajePasajeroHeridos1;
            calcular_Bajas_Todas_UnidadesOP.PorcentajePasajeroMuertos1 = PorcentajePasajeroMuertos1;

            calcular_Bajas_Todas_UnidadesOP.Cant_Pasajeros_Aeronave1 = Cant_Pasajeros_Aeronave1;
            calcular_Bajas_Todas_UnidadesOP.Aviones_Intactos1 = Aviones_Intactos1;

            calcular_Bajas_Todas_UnidadesOP.CalcularDatosAvionesConPilotosYPasajerosAerea();

            Piloto_Herido1 = calcular_Bajas_Todas_UnidadesOP.Piloto_Herido1;
            Piloto_Muerto1 = calcular_Bajas_Todas_UnidadesOP.Piloto_Muerto1;

            Pasajeros_Heridos1 = calcular_Bajas_Todas_UnidadesOP.Pasajeros_Heridos1;
            Pasajeros_Muertos1 = calcular_Bajas_Todas_UnidadesOP.Pasajeros_Muertos1;

            Aviones_Intactos1 = calcular_Bajas_Todas_UnidadesOP.Aviones_Intactos1;
            Aviones_Perdidos1 = calcular_Bajas_Todas_UnidadesOP.Aviones_Perdidos1;
            Aviones_Danados1 = calcular_Bajas_Todas_UnidadesOP.Aviones_Danados1;
            Aviones_FueraDeCombate1 = calcular_Bajas_Todas_UnidadesOP.Aviones_FueraDeCombate1;
        }

    }
}
