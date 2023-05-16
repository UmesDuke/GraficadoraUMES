using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficadoraUMES.Umes
{
    internal abstract class Grafica
    {
        protected Matriz m;
        protected float width;
        protected float height;
        protected float angulo;

        public Matriz M { get => m; set => m = value; }

        public Grafica(float width, float height)
        {
            this.m = new Matriz();
            this.width = width;
            this.height = height;

            m.SetPuntos(width / 2, height / 2, width / 2, height / 2);
        }

        public void Traslacion(float[,]m)
        {
            this.m.Calcular(m);
        }

        public void Rotar(float a)
        {
            this.angulo = a;
        }

        public void Plano(Graphics g)
        {
            g.DrawLine(Pens.Gray, 0, height / 2, width, height / 2);
            g.DrawLine(Pens.Gray, width / 2, 0, width / 2, height);
        }
    }
}
