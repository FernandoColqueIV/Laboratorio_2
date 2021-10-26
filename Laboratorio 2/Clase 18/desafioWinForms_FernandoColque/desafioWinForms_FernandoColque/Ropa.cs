using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioWinForms_FernandoColque
{
    class Ropa
    {
        private int precioPrenda;
        private double precioPrendaTotal;
        private bool calidad;//1=premiun, 0=standar
        private int cantidad;

        public int PrecioPrenda { get => precioPrenda; set => precioPrenda = value; }
        public bool Calidad { get => calidad; set => calidad = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double PrecioPrendaTotal { get => precioPrendaTotal; set => precioPrendaTotal = value; }

        public Ropa(int precioPrenda, double precioPrendaTotal, bool calidad, int cantidad)
        {
            this.precioPrendaTotal = precioPrendaTotal;
            this.precioPrenda = precioPrenda;
            this.Calidad = calidad;
            this.Cantidad = cantidad;
        }
        public Ropa()
        {

        }





    }
}
