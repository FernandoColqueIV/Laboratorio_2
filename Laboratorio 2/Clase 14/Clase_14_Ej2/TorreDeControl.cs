using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_14_Ej2
{
    class TorreDeControl
    {
        //Lista
        List<Volador> voladorList = new List<Volador>();
        //metodos
        public void VuelenTodos()
        {
            foreach (Volador c in voladorList)
            {
                c.volador();
            }
        }
        public void agregarVolador()
        {
            Superman supermanOP = new Superman();
            voladorList.Add(supermanOP);
            Boing747 boing747OP = new Boing747();
            voladorList.Add(boing747OP);
            Pato patoOP = new Pato();
            voladorList.Add(patoOP);
        }


    }
}
