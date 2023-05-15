﻿using System;
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
            g.DrawLine(Pens.Red, m.GetX1(), m.GetY1(), m.GetX2(), m.GetY2());
        }

        public void update()
        { }
    }
}
