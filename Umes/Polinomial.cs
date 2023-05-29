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

        private float fun(float x)
        {
            float y = 0;
            List<float> v = Val;

            for (int i = 0; i < v.Count; i++)
            {
                y += (v[i] * (float)Math.Pow(x, i));
            }

            return y;
        }

        public void draw(Graphics g)
        {

            g.Clear(Color.White);

            Plano(g);

            Matrix m = new Matrix();
            m.Shear(xRecorte, yRecorte);
            g.MultiplyTransform(m);

            g.TranslateTransform(xPos, yPos);
            g.RotateTransform(angulo);

            List<PointF> points = new List<PointF>();
            for (int x = -50; x < 50; x++)
            {
                float px = OffSetX() + (x * 20),
                      py = OffSetY() - fun(x);
                PointF p = new PointF(px, py);
                points.Add(p);
            }

            if (points.Count > 1)
            {
                g.DrawCurve(Pens.Blue, points.ToArray());
            }

            g.ResetTransform();
        }

        public void update()
        { }
    }
}
