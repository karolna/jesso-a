using System;
using System.Collections.Generic;
using System.Text;

namespace Computacion_Cientifica
{
    class LibMat
    {
        //Ventana del computador
        public static int Sx1 = 0;
        public static int Sx2 = 640;
        public static int Sy1 = 0;
        public static int Sy2 = 480;

        //Ventana real
        public static double x1 = -10;
        public static double x2 = 10;
        public static double y1 = -7.5;
        public static double y2 = 7.5;

        //Función Pantalla
        public static void PPantalla(double x, double y, out int Sx, out int Sy)
        {
            Sx = (int)(((Sx1 - Sx2) / (x1 - x2)) * (x - x1)) + Sx1;
            Sy = (int)(((Sy1 - Sy2) / (y2 - y1)) * (y - y2)) + Sy1;
        }
    }
}