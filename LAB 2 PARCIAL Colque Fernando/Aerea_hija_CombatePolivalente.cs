using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2_PARCIAL
{
    class Aerea_hija_CombatePolivalente:Aerea_Padre_Clase
    {
        
        public void AvionDeUnPasajero()
        {
            PorcentajeMuertoPiloto1 = 75;
            PorcentajeDanoAvionDanado1 = 60;
            PorcentajeDanoAvionFueraCombate1 = 80;
            PorcentajeDanoAvionPerdido1 = 100;
            Aviones_Intactos1 = 35;

            Random RandomNum = new Random();

            for (int i = 0; i < AvionesAtacadosForm1; i++)
            {
                int RandomNumPiloto = RandomNum.Next(1, 101);

                if (RandomNumPiloto > PorcentajeMuertoPiloto1)
                {
                    Piloto_1_Muerto1 += 1;
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
                        Piloto_1_Herido1 += 1;
                    }
                    if (RandomNumPilotoHerido >= PorcentajeDanoAvionDanado1 && RandomNumPilotoHerido <= PorcentajeDanoAvionFueraCombate1)
                    {
                        Aviones_FueraDeCombate1 += 1;
                        Aviones_Intactos1 -= 1;
                        Piloto_1_Herido1 += 1;
                    }
                    if (RandomNumPilotoHerido > PorcentajeDanoAvionFueraCombate1 && RandomNumPilotoHerido <= PorcentajeDanoAvionPerdido1)
                    {
                        Aviones_Perdidos1 += 1;
                        Aviones_Intactos1 -= 1;

                        int RandomNumPilotoHeridoMuerto = RandomNum.Next(1, 101);

                        if (RandomNumPilotoHeridoMuerto > 75)
                        {
                            Piloto_1_Herido1 += 1;
                        }
                        else
                        {
                            Piloto_1_Muerto1 += 1;
                        }
                    }
                }
            }
        }
    }
}
