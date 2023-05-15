using System;
using System.Collections.Generic;
using System.Drawing;
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

            List<Point> points = new List<Point>();

            Console.WriteLine(new Point((int)m.GetX1(), (int)m.GetY2()));

            for (int x = -200; x < 20; x++)
            {
                Point p = new Point((int)m.GetX2() + (5*x), (int) (m.GetY2() - Math.Pow(2, x)));
                points.Add(p);

                Console.WriteLine(p.ToString());
            }

            if (points.Count > 1)
            {
                g.DrawCurve(Pens.Blue, points.ToArray());
            }
        }

        public void update()
        { }
    }
}
