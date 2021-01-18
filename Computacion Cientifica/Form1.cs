using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computacion_Cientifica
{
    public partial class Form1 : Form
    {
        Bitmap Pixel = new Bitmap(640, 480);
        ClaseVector V = new ClaseVector();
        ClaseSegmento s = new ClaseSegmento();
        public Form1()
        {
            InitializeComponent();
        }

        private void encenderPixel_Click(object sender, EventArgs e)
        {
            Pixel.SetPixel(200, 200, Color.Black); //Asignar propiedades del pixel
            Plano.Image = Pixel; //Coloca pixel en pantalla
        }

        private void Prueba_Click(object sender, EventArgs e) //Franjas
        {
            for (int i = 0; i < 600; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    if (j <= 180)
                    {
                        Pixel.SetPixel(i, j, Color.FromArgb(255, 0, 0));
                        Plano.Image = Pixel;
                    }
                    if (j > 180 && j <= 280)
                    {
                        Pixel.SetPixel(i, j, Color.FromArgb(0, 255, 0));
                        Plano.Image = Pixel;
                    }
                    if (j > 280 && j <= 460)
                    {
                        Pixel.SetPixel(i, j, Color.FromArgb(0, 0, 255));
                        Plano.Image = Pixel;
                    }
                }
            }
        }

        private void Prueba2_Click(object sender, EventArgs e) //Puntos
        {
            float t = -4;
            V.color0 = Color.Green;
            V.x0 = 0;
            V.y0 = 0;
            V.Encender(Pixel);
            Plano.Image = Pixel;
            V.x0 = 1;
            V.Encender(Pixel);
            Plano.Image = Pixel;
            V.x0 = 0.3;
            V.Encender(Pixel);
            Plano.Image = Pixel;
            V.y0 = 1.5;
            V.Encender(Pixel);
            Plano.Image = Pixel;

            do //linea
            {
                V.color0 = Color.Green;
                V.x0 = (-2) + (t)*(6);
                V.y0 = (-4) + (t)*(3);
                t = (float)(0.005) + (t);
                V.Encender(Pixel);
                Plano.Image = Pixel;
            } while (t <= 1);

            do //parabola
            {
                V.color0 = Color.Green;
                V.x0 = t;
                V.y0 = ((t)*(t)) / (4);
                t = (float)(0.005) + (t);
                V.Encender(Pixel);
                Plano.Image = Pixel;
            } while (t <= 4);

        }

        private void Segmento(object sender, EventArgs e)
        {
            //Segmento
            s.x0 = -5;
            s.y0 = -6;
            s.xf = -5;
            s.yf = 5;
            s.color0 = Color.Red;
            s.Encender(Pixel);
            Plano.Image = Pixel;
        }

        private void Plano_Click(object sender, EventArgs e)
        {

        }

        private void SegmentosTarea(object sender, EventArgs e)
        {

           //Vector
            V.color0 = Color.Black;
            double x = -10;
            do
            {
                V.x0 = x;
                V.y0 = 2 * x + 5;
                V.Encender(Pixel);
                Plano.Image = Pixel;
                x = x + 0.01;
            }
            while (x <= 10);

            //Vector
            V.color0 = Color.Blue;
            double x2 = -10;
            do
            {
                V.x0 = x2;
                V.y0 = -2 + x2 * -2.4 * 0.3;
                V.Encender(Pixel);
                Plano.Image = Pixel;
                x2 = x2 + 0.01;
            } while (x2 <= 10);

            //Vector
            V.color0 = Color.Purple;
            double x3 = -10;
            do
            {
                V.x0 = x3;
                V.y0 = x3 / 4 + 6;
                V.Encender(Pixel);
                Plano.Image = Pixel;
                x3 = x3 + 0.01;
            } while (x3 <= 10);

            //Vector
            V.color0 = Color.Green;
            double x4 = -10;
            do
            {
                V.x0 = x4;
                V.y0 = x4 / -10 - 4;
                V.Encender(Pixel);
                Plano.Image = Pixel;
                x4 = x4 + 0.01;
            } while (x4 <= 10);
        }
    }
}




        private void limpiar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 600; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    Pixel.SetPixel(i, j, Plano.BackColor);
                }
            }
            Plano.Image = Pixel;
            //Elimina cualquier elemento del plano
        }
