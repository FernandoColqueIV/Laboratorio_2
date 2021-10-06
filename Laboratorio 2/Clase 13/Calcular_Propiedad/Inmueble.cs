using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_Propiedad
{
    public class Inmueble
    {
        //atributos
        protected string direccion_inmueble;
        protected int metros_cuadrados = 0;
        protected int precio = 0;
        protected int edad_propiedad = 0;
        private double valor_Inmueble = 0;
        //constructor
        public Inmueble(string direccion_inmueble, int metros_cuadrados, int precio, int edad_propiedad, int valor_Inmueble)
        {
            this.direccion_inmueble = direccion_inmueble;
            this.metros_cuadrados = metros_cuadrados;
            this.precio = precio;
            this.edad_propiedad = edad_propiedad;
            this.Valor_Inmueble = valor_Inmueble;
        }
        public Inmueble()
        {

        }
        //Getter and Setters
        public int Precio { get => precio; set => precio = value; }
        public int Edad_propiedad { get => edad_propiedad; set => edad_propiedad = value; }
        public int Metros_cuadrados { get => metros_cuadrados; set => metros_cuadrados = value; }
        public string Direccion_inmueble { get => direccion_inmueble; set => direccion_inmueble = value; }
        protected double Valor_Inmueble { get => valor_Inmueble; set => valor_Inmueble = value; }
    }
}
