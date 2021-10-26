using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafioWinForms_FernandoColque
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BotonCalcularPrecioFinal_Click(object sender, EventArgs e)
        {
            if (BottonCamisa.Checked==true)
            {
                Camisa camisaOP = new Camisa();

                camisaOP.Cantidad = Int32.Parse(textBoxCantidad.Text);
                camisaOP.PrecioPrenda = Int32.Parse(textBoxPrecio.Text);

                if (BotonPremium.Checked == true)
                {
                    camisaOP.Calidad = true;
                }
                if (BotonStandar.Checked == true)
                {
                    camisaOP.Calidad = false;
                }
                if (CheckMangaCorta.Checked == true)
                {
                    camisaOP.MangaCorta = true;
                }
                if (CheckMangaCorta.Checked == false)
                {
                    camisaOP.MangaCorta = false;
                }

                MessageBox.Show("El precio final es de: " + camisaOP.ValorTotalCamisa());
            }
            if (BottonPantalon.Checked == true)
            {
                Pantalon pantalonOP = new Pantalon();

                pantalonOP.Cantidad = Int32.Parse(textBoxCantidad.Text);
                pantalonOP.PrecioPrenda = Int32.Parse(textBoxPrecio.Text);

                if (BotonPremium.Checked == true)
                {
                    pantalonOP.Calidad = true;
                }
                if (BotonStandar.Checked == true)
                {
                    pantalonOP.Calidad = false;
                }
                if (CheckBermuda.Checked == true)
                {
                    pantalonOP.Bermuda = true;
                }
                if (CheckBermuda.Checked == false)
                {
                    pantalonOP.Bermuda = false;
                }

                MessageBox.Show("El precio final es de: " + pantalonOP.ValorTotalPantalon());

            }

        }
    }
}
