using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioWinForms_FernandoColque
{
    class Camisa : Ropa
    {
        private bool mangaCorta = false;

        public Camisa(bool mangaCorta)
        {
            MangaCorta = mangaCorta;   
        }

        public Camisa()
        {

        }
        public bool MangaCorta { get => mangaCorta; set => mangaCorta = value; }

        public double ValorTotalCamisa()
        {

            PrecioPrendaTotal = PrecioPrenda * Cantidad;

            if (mangaCorta==true)
            {
                PrecioPrendaTotal = PrecioPrendaTotal - ((PrecioPrenda * Cantidad) * 0.10);
            }
            if (Calidad == true)
            {
                PrecioPrendaTotal = PrecioPrendaTotal + ((PrecioPrenda * Cantidad) * 0.30);
            }

            return PrecioPrendaTotal;
        }







    }
}
