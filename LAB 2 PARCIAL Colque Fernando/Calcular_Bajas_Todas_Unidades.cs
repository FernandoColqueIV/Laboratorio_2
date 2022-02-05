using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2_PARCIAL
{
    class Calcular_Bajas_Todas_Unidades : Variables_Terrestres
    {
        public void CalcularDatosSoldadosInfanteria()
        {
            Random RandomNum = new Random();

            for (int i = 0; i < Atacados_Form; i++)
            {
                int RandomNumAux = RandomNum.Next(1, 101);

                if (Veteranos_cantidad > 0 && RandomNumAux <= Porcentaje_dividir_tipo_soldado)
                {
                    int RandonHeridosMuertosAux = RandomNum.Next(1, 101);

                    if (RandonHeridosMuertosAux >= Veteranos_porcentaje_heridos_muerto)
                    {
                         Veteranos_muertos += 1;
                    }
                    if (RandonHeridosMuertosAux < Veteranos_porcentaje_heridos_muerto)
                    {
                         Veteranos_heridos += 1;
                    }
                     Veteranos_cantidad -= 1;
                }
                if (Veteranos_cantidad == 0 && RandomNumAux <= Porcentaje_dividir_tipo_soldado)
                {
                    RandomNumAux = Veteranos_porcentaje_heridos_muerto;
                }
                if (Novatos_cantidad > 0 && RandomNumAux > Porcentaje_dividir_tipo_soldado)
                {
                    int RandonHeridosMuertosAux2 = RandomNum.Next(1, 101);

                    if (RandonHeridosMuertosAux2 <= Novatos_porcentaje_heridos_muerto)
                    {
                         Novatos_muertos += 1;
                    }
                    if (RandonHeridosMuertosAux2 > Novatos_porcentaje_heridos_muerto)
                    {
                         Novatos_heridos += 1;
                    }

                     Novatos_cantidad -= 1;
                }
            }
             
        }


        public void CalcularDatosAvionesConPilotosYPasajerosAerea()
        {
            Random RandomNum = new Random();

            for (int i = 0; i < AvionesAtacadosForm1; i++)
            {
                int RandomNumPiloto = RandomNum.Next(1, 101);

                if (RandomNumPiloto > PorcentajeMuertoPiloto1)
                {
                    Piloto_Muerto1 += 1;
                    Aviones_Intactos1 -= 1;
                    Aviones_Perdidos1 += 1;
                    Pasajeros_Muertos1 += Cant_Pasajeros_Aeronave1;
                }
                if (RandomNumPiloto <= PorcentajeMuertoPiloto1)
                {
                    int RandomNumPilotoHerido = RandomNum.Next(1, 101);

                    if (RandomNumPilotoHerido < PorcentajeDanoAvionDanado1)
                    {
                        Aviones_Danados1 += 1;
                        Aviones_Intactos1 -= 1;
                        Piloto_Herido1 += 1;

                        Pasajeros_Muertos_Heridos();
                    }
                    if (RandomNumPilotoHerido >= PorcentajeDanoAvionDanado1 && RandomNumPilotoHerido <= PorcentajeDanoAvionFueraCombate1)
                    {
                        Aviones_FueraDeCombate1 += 1;
                        Aviones_Intactos1 -= 1;
                        Piloto_Herido1 += 1;

                        Pasajeros_Muertos_Heridos();
                    }
                    if (RandomNumPilotoHerido > PorcentajeDanoAvionFueraCombate1 && RandomNumPilotoHerido <= PorcentajeDanoAvionPerdido1)
                    {
                        Aviones_Perdidos1 += 1;
                        Aviones_Intactos1 -= 1;

                        int RandomNumPilotoHeridoMuerto = RandomNum.Next(1, 101);

                        if (RandomNumPilotoHeridoMuerto > 75)
                        {
                            Piloto_Herido1 += 1;
                            Pasajeros_Muertos_Heridos();
                        }
                        else
                        {
                            Piloto_Muerto1 += 1;
                            Pasajeros_Muertos1 += Cant_Pasajeros_Aeronave1;
                        }
                    }
                }
            }
        }
        public void Pasajeros_Muertos_Heridos()
        {
            Random RandomNum = new Random();

            for (int j = 0; j < Cant_Pasajeros_Aeronave1; j++)
            {
                int RandomNumPasajerosHeridoMuerto = RandomNum.Next(1, 101);

                if (RandomNumPasajerosHeridoMuerto <= PorcentajePasajeroHeridos1)
                {
                    Pasajeros_Heridos1 += 1;
                }
                if (RandomNumPasajerosHeridoMuerto > PorcentajePasajeroHeridos1 && RandomNumPasajerosHeridoMuerto < PorcentajePasajeroMuertos1)
                {
                    Pasajeros_Muertos1 += 1;
                }
            }
        }

        public void CalcularDatosAvionesDeUnSoloPiloto()
        {
            Random RandomNum = new Random();

            for (int i = 0; i < AvionesAtacadosForm1; i++)
            {
                int RandomNumPiloto = RandomNum.Next(1, 101);

                if (RandomNumPiloto > PorcentajeMuertoPiloto1)
                {
                    Piloto_Muerto1 += 1;
                    Aviones_Intactos1 -= 1;
                    Aviones_Perdidos1 += 1;
                }
                if (RandomNumPiloto <= PorcentajeMuertoPiloto1)
                {

                    int RandomNumPilotoHerido = RandomNum.Next(1, 101);

                    if (RandomNumPilotoHerido < PorcentajeDanoAvionDanado1)
                    {
                        Aviones_Danados1 += 1;
                        Aviones_Intactos1 -= 1;
                        Piloto_Herido1 += 1;
                    }
                    if (RandomNumPilotoHerido >= PorcentajeDanoAvionDanado1 && RandomNumPilotoHerido <= PorcentajeDanoAvionFueraCombate1)
                    {
                        Aviones_FueraDeCombate1 += 1;
                        Aviones_Intactos1 -= 1;
                        Piloto_Herido1 += 1;
                    }
                    if (RandomNumPilotoHerido > PorcentajeDanoAvionFueraCombate1 && RandomNumPilotoHerido <= PorcentajeDanoAvionPerdido1)
                    {
                        Aviones_Perdidos1 += 1;
                        Aviones_Intactos1 -= 1;


                        int RandomNumPilotoHeridoMuerto = RandomNum.Next(1, 101);

                        if (RandomNumPilotoHeridoMuerto > 75)
                        {
                            Piloto_Herido1 += 1;
                        }
                        else
                        {
                            Piloto_Muerto1 += 1;
                        }
                    }
                }
            }
        }

        public void CalcularDatosBarcos()
        {
            Random RandomNum = new Random();

            for (int i = 0; i < Barcos_AtacadosForm1; i++)
            {
                int RandomNumPiloto = RandomNum.Next(1, 101);

                if (RandomNumPiloto > Porcentaje_Muerto_Capitan1)
                {
                    Capitan_Muerto1 += 1;
                    Barcos_Intactos1 -= 1;
                    Barcos_Perdidos1 += 1;
                    Marinero_Muerto1 += Cant_Marineros_Barcos1;
                }
                if (RandomNumPiloto <= Porcentaje_Muerto_Capitan1)
                {
                    int RandomNumPilotoHerido = RandomNum.Next(1, 101);

                    if (RandomNumPilotoHerido < Porcentaje_Dano_Barco_Danado1)
                    {
                        Barcos_Danados1 += 1;
                        Barcos_Intactos1 -= 1;
                        Capitan_Herido1 += 1;

                        Marineros_Muertos_Heridos();
                    }
                    if (RandomNumPilotoHerido >= Porcentaje_Dano_Barco_Danado1 && RandomNumPilotoHerido <= Porcentaje_Dano_Barco_Fuera_Combate1)
                    {
                        Barcos_FueraDeCombate1+= 1;
                        Barcos_Intactos1 -= 1;
                        Marinero_Herido1 += 1;

                        Marineros_Muertos_Heridos();
                    }
                    if (RandomNumPilotoHerido > Porcentaje_Dano_Barco_Fuera_Combate1 && RandomNumPilotoHerido <= Porcentaje_Dano_Barco_Perdido1)
                    {
                        Barcos_Perdidos1 += 1;
                        Barcos_Intactos1 -= 1;

                        int RandomNumPilotoHeridoMuerto = RandomNum.Next(1, 101);

                        if (RandomNumPilotoHeridoMuerto > 75)
                        {
                            Capitan_Herido1 += 1;
                            Marineros_Muertos_Heridos();
                        }
                        else
                        {
                            Capitan_Muerto1 += 1;
                            Marinero_Muerto1 += Cant_Marineros_Barcos1;
                        }
                    }
                }

            }
        }
        public void Marineros_Muertos_Heridos()
        {
            Random RandomNum = new Random();

            for (int j = 0; j < Cant_Marineros_Barcos1; j++)
            {
                int RandomNumMArineroHeridoMuerto = RandomNum.Next(1, 101);

                if (RandomNumMArineroHeridoMuerto <= Porcentaje_Herido_Marinero1)
                {
                    Marinero_Herido1 += 1;
                }
                if (RandomNumMArineroHeridoMuerto > Porcentaje_Herido_Marinero1 && RandomNumMArineroHeridoMuerto < Porcentaje_Muerto_Marinero1)
                {
                    Marinero_Muerto1 += 1;
                }
            }
        }
    }
}
