using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficadoraUMES.Umes
{
    internal class Matriz
    {
        private float[,] matriz = {
            { 1, 0, 0},
            { 0, 1, 0},
            { 0, 0, 1}
        };

        private float[,] m = {
            { 1, 0, 0},
            { 0, 1, 0},
            { 0, 0, 1}
        };

        public Matriz()
        {
        }

        public void SetPuntos(float x1, float y1, float x2, float y2)
        {
            matriz[0, 2] = x2;
            matriz[1, 2] = y2;

            matriz[0, 0] = x1;
            matriz[1, 1] = y1;

            m[0, 2] = x2;
            m[1, 2] = y2;

            m[0, 0] = x1;
            m[1, 1] = y1;
        }

        public float GetX2()
        {
            return matriz[0,2];
        }

        public float GetX1()
        {
            return matriz[0,0];
        }

        public float GetY2()
        {
            return matriz[1,2];
        }

        public float GetY1()
        {
            return matriz[1,1];
        }

        public void Calcular(float[,] m)
        {
            matriz = Util.multiply(this.m, m);
        }
    }
}
