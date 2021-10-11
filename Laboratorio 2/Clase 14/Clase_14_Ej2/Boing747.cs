using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_14_Ej2
{
    class Boing747 : Volador
    {
        private int hr_vuelo = 0;
        public void volador()
        {
            
            Console.WriteLine("Horas de Vuelo: " + (hr_vuelo+13));
            Console.WriteLine("Estoy Volando como un avion");

        }
    }
}
