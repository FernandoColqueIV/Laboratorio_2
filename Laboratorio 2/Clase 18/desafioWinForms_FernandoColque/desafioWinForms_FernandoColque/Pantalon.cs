using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioWinForms_FernandoColque
{
    class Pantalon : Ropa
    {
        private bool bermuda=false;

        public Pantalon(bool bermuda)
        {
            this.Bermuda = bermuda;
        }
        public Pantalon()
        {

        }
        public bool Bermuda { get => bermuda; set => bermuda = value; }

        public double ValorTotalPantalon()
        {
            PrecioPrendaTotal = PrecioPrenda * Cantidad;
            
            if (bermuda == true)
            {
                PrecioPrendaTotal = PrecioPrendaTotal - ((PrecioPrenda*Cantidad) * 0.20);
            }
            if (Calidad == true)
            {
                PrecioPrendaTotal = PrecioPrendaTotal + ((PrecioPrenda * Cantidad) * 0.3);
            }





            return PrecioPrendaTotal;
        }









    }
}
