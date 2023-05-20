using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficadoraUMES.Umes
{
    internal class Exponencial : Grafica, Renderer
    {
        public Exponencial(float width, float height) : base(width, height)
        {
        }

        public void draw(Graphics g)
        {
           g.Clear(Color.White);

            Plano(g);

            Matrix m = new Matrix();
            m.Shear(xRecorte, yRecorte);
            g.MultiplyTransform(m);

            g.RotateTransform(angulo);
            g.TranslateTransform(xPos, yPos);
            
            List<PointF> points = new List<PointF>();

            for (int x = -200; x < 20; x++)
            {
                PointF p = new PointF(OffSetX() + (5 * x), (float)(OffSetY() -Math.Pow(2, x)));
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
