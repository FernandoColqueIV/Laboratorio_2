using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_14_Ej_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Impresora op = new Impresora();

            op.AgregarImprimible();
            op.ImprimirTodo();
            Console.ReadKey();

        }
    }
}
