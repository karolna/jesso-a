using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Computacion_Cientifica
{
    class ClaseVector
    {
        public double x0 = 0, y0 = 0;
        public Color color0;

        public int Sx, Sy;

        public virtual void Encender(Bitmap Pixel)
        {
            LibMat.PPantalla(this.x0, this.y0, out Sx, out Sy);
            if (Sx >= 0 && Sx < 640 && Sy >= 0 && Sy < 480)
            {
                Pixel.SetPixel(Sx, Sy, color0);
                
            }

        }
    }
}
