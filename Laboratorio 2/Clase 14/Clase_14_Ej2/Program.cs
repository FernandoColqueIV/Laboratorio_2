using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_14_Ej2
{
    class Program
    {
        static void Main(string[] args)
        {

            TorreDeControl OP = new TorreDeControl(); 

                OP.agregarVolador();
                OP.VuelenTodos();
                Console.ReadKey();



        }
    }
}
