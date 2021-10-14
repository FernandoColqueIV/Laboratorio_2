using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioHerencia
{
    class Lavadora : Electrodomestico
    {
        //atributo
        float carga = 5;
        //constructor
        public Lavadora()
        {

        }
        public Lavadora(float precio, float peso) : base(precio, peso)
        {

        }
        public Lavadora(float carga, float precio, float peso, string color, char consumoEnergetico) : base(precio, peso, color, consumoEnergetico)
        {
            this.carga = carga;
        }
        //metodo
        public override void precioFinal()
        {
            if (this.carga > 30) 
            {
                base.Precio += 50; 
            }           
            base.precioFinal();
        }
        //getter
        public float Carga { get => carga; }
    }
}