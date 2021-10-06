using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcular_Propiedad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCalcularPrecioFinal_Click(object sender, EventArgs e)
        {
            

            if (RadioBtmLocal.Checked == true)
            {
                Local LocalOP = new Local();

                LocalOP.Num_Ventanas = Int32.Parse(textNroVentanas.Text);
                LocalOP.Edad_propiedad= Int32.Parse(textAntiguedad.Text);
                LocalOP.Precio= Int32.Parse(textPrecioBase.Text);
                LocalOP.Metros_cuadrados = Int32.Parse(textSuperficie.Text);
                LocalOP.Valor_Total_Inmueble();

                if (LocalOP.Num_Ventanas<0 || LocalOP.Edad_propiedad<0 || LocalOP.Precio<0 || LocalOP.Metros_cuadrados<0)
                {
                    MostrarPrecioFinal.Text = "Ingrese Numeros Positivos para mostrar el precio del Local";
                }
                else
                {
                    MostrarPrecioFinal.Text = "el precio final es del Local: " + LocalOP.Valor_Total_Inmueble().ToString();
                }
            }
            if(RadioBtmPiso.Checked == true)
            {
                Piso PisoOP = new Piso();

                PisoOP.Piso_Vivenda_Plantas = Int32.Parse(textNroPiso.Text);
                PisoOP.Edad_propiedad = Int32.Parse(textAntiguedad.Text);
                PisoOP.Precio = Int32.Parse(textPrecioBase.Text);
                //PisoOP.Metros_cuadrados = Int32.Parse(textSuperficie.Text);
                PisoOP.Valor_Total_Inmueble();

                if (PisoOP.Piso_Vivenda_Plantas<0 || PisoOP.Edad_propiedad<0 || PisoOP.Precio<0 )
                {
                    MostrarPrecioFinal.Text = "Ingrese Numeros Positivos para mostrar el precio del Piso";
                }
                else
                {
                    MostrarPrecioFinal.Text = "el precio final es del Piso: " + PisoOP.Valor_Total_Inmueble().ToString();
                }


            }
        }

       
    }
}
