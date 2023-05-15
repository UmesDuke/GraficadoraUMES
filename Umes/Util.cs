using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficadoraUMES.Umes
{
    internal class Util
    {
        public static string POLINOMIAL  = "Polinomial";
        public static string EXPONENCIAL = "Exponencial";
        public static string SENOIDAL    = "Senoidal";

        public static int Map(int val, int med, int max, int min)
        {
            if (val == med)
            {
                return 0;
            }
            if (val < med)
            {
                return -(med - val);
            }
            if (val > med)
            {
                return (val - med) ;
            }
            return val;
        }

        public static float[,] multiply(float[,] a, float[,] b)
        {
            float[,] c = new float[3,3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }

            return c;
        }
    }
}
