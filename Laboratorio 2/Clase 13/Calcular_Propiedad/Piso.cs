using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_Propiedad
{
    public class Piso : Inmueble
    {
        private int piso_Vivenda_Plantas = 0;
        //constructor
        public Piso(int piso_Vivenda_Plantas )
        {
            this.piso_Vivenda_Plantas = piso_Vivenda_Plantas;
        }
        public Piso()
        {
         
        }
        //Getter and Setters
        public int Piso_Vivenda_Plantas { get => piso_Vivenda_Plantas; set => piso_Vivenda_Plantas = value; }

        public double Valor_Total_Inmueble()
        {
            if (edad_propiedad<15)
            {
                Valor_Inmueble = precio - (precio * 0.01);
            }
            else
            {
                Valor_Inmueble = precio - (precio * 0.02);
            }

            if (piso_Vivenda_Plantas>=3)
            {
                Valor_Inmueble += precio * 0.03;
            }

            return Valor_Inmueble;
        }


    }
}
