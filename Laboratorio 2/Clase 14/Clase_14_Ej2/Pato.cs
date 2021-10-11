using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_14_Ej2
{
    class Pato : Volador
    {
        private int energia = 100;
        public void volador()
        {
            Console.WriteLine("Energia del pato: " + (energia - 5));
            Console.WriteLine("¡Cuak!");
        }


    }
}
