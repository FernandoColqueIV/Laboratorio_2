using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioHerencia
{
    class Television : Electrodomestico
    {
        //atributos
        private float resolucion = 20;
        private bool sintonizador_TDT = false;
        //constructores
        public Television()
        {
        }
        public Television(float precio, float peso) : base(precio, peso)
        {
        }
        public Television(float resolucion, bool sintonizador, float precio, float peso, string color, char consumoEnergetico) : base(precio, peso, color, consumoEnergetico)
        {
            this.resolucion = resolucion;
            this.sintonizador_TDT = sintonizador;
        }
        //metodos
        public override void precioFinal()
        {
            if (resolucion > 40) 
            { 
                base.Precio += (Precio * 30) / 100; 
            }
            if (sintonizador_TDT)
            {
                base.Precio += (Precio * 50) / 100;
            }
           
            base.precioFinal();
        }
        public float Resolucion { get => resolucion; }
        public bool Sintonizador_TDT { get => sintonizador_TDT; }
    }
}