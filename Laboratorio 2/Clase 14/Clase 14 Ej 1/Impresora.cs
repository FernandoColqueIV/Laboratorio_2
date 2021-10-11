using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_14_Ej_1
{
    class Impresora
    {
        //Lista
        List<Imprimible> Coladeimpresion = new List<Imprimible>();
        //metodos
        public void ImprimirTodo()
        {

            foreach (Imprimible c in Coladeimpresion)
            {
                c.imprimible();
            }


        }
        public void AgregarImprimible ()
        {
            Documento documentoOP = new Documento();
            Coladeimpresion.Add(documentoOP);
            Foto fotoOP = new Foto();
            Coladeimpresion.Add(fotoOP);
            Contrato contratoOP = new Contrato();
            Coladeimpresion.Add(contratoOP);           
        }
        




    }
}
