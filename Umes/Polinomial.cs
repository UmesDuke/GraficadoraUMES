using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficadoraUMES.Umes
{
    internal class Polinomial : Grafica, Renderer
    {
        public Polinomial(float width, float height) : base(width, height)
        {
        }

        public void draw(Graphics g)
        {
            g.Clear(Color.White);

            Plano(g);

            g.RotateTransform(angulo);

            List<PointF> points = new List<PointF>();
            for (int x = -200; x < 200; x++)
            {
                float px = m.GetX2() + (5 * x), 
                      py = m.GetY2() - (float)(Math.Pow(x, 2) + Math.Pow(x, 2) + 2);

                PointF p = new PointF(px, py); 
                points.Add(p);
            }

            if (points.Count > 1)
            {
                g.DrawCurve(Pens.Blue, points.ToArray());
            }

            g.RotateTransform(-angulo);
        }

        public void update()
        { }
    }
}
