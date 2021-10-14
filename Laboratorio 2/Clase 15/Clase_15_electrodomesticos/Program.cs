using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            float total_todo=0;
            //lista
            List<Electrodomestico> electrodomesticos = new List<Electrodomestico>();

            Electrodomestico television1 = new Television(20f, true, 1200, 50, "gris", 'B');
            Electrodomestico television2 = new Television(50f, false, 1240, 5, "gris", 'B');
            Electrodomestico television3 = new Television(15f, true, 1500, 60, "amarrillo", 'F');
            Electrodomestico lavadora1 = new Lavadora(10f, 3000, 15, "negro", 'P');
            Electrodomestico lavadora2 = new Lavadora(5f, 6500, 25, "blanco", 'F');

            electrodomesticos.Add(television1);
            electrodomesticos.Add(television2);
            electrodomesticos.Add(television3);
            electrodomesticos.Add(lavadora1);
            electrodomesticos.Add(lavadora2);

            Console.WriteLine("-------------------------------");
            foreach (Electrodomestico electrodomestico in electrodomesticos)
            {               
                Console.WriteLine(electrodomestico.GetType().Name);
                electrodomestico.precioFinal();
                total_todo += electrodomestico.Precio;
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine("");
            Console.WriteLine("El Total a Pagar por todos los electrodomesticos es: {0}", total_todo);
            Console.ReadLine();
        }
    }
}