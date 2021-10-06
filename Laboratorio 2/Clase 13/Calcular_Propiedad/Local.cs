using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_Propiedad
{
    class Local : Inmueble
    {
        private int num_Ventanas = 0;
        //constructor
        public Local(int num_Ventanas)
        {
            this.Num_Ventanas = num_Ventanas;
        }
        public Local()
        {
           
        }
        //Getter and Setters
        public int Num_Ventanas { get => num_Ventanas; set => num_Ventanas = value; }
        
        public double Valor_Total_Inmueble()
        {

            if (Edad_propiedad < 15)
            {
                Valor_Inmueble = (precio - (precio * 0.01));
            }
            else
            {
                Valor_Inmueble = precio - ((precio) * 0.02);
            }

            if (metros_cuadrados > 50)
            {
                Valor_Inmueble += (precio * 0.01);
            }
            else
            {

            }

            if (num_Ventanas < 2)
            {
                Valor_Inmueble -= (precio * 0.02);
            }
            if (num_Ventanas >= 4)
            {
                Valor_Inmueble += (precio * 0.02);
            }
            return Valor_Inmueble;
        }
    }
}
