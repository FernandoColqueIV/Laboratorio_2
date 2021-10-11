using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_14_Ej2
{
    class Superman: Volador
    {
        private int experiencia = 0;
        public void volador()
        {
            Console.WriteLine("Experiencia: " + (experiencia + 3));
            Console.WriteLine("Estoy Volando Como un campeon");
        }
    }
}
