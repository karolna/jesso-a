using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Computacion_Cientifica
{
    class ClaseSegmento : ClaseVector
    {
        public double xf, yf;
        public override void Encender(Bitmap Pixel)
        {
            float t = 0;
            float dt = 0.001f;
            ClaseVector v = new ClaseVector();
            do
            {
                v.x0 = (x0 * (1 - t)) + (xf * t);
                v.y0 = (y0 * (1 - t)) + (yf * t);
                v.color0 = color0;
                v.Encender(Pixel);
                t = t + dt;
            } while (t <= 1);
        }
    }
}
