using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficadoraUMES.Umes
{
    internal abstract class Grafica
    {
        protected float width;
        protected float height;

        protected float xPos;
        protected float yPos;
        protected float xRecorte;
        protected float yRecorte;
        protected float angulo;

        private List<float> val = new List<float>();
        public List<float> Val { get => val; set => val = value; }

        public Grafica(float width, float height)
        {
            this.width = width;
            this.height = height;
        }

        public float OffSetX()
        {
            return width / 2;
        }

        public float OffSetY()
        {
            return height / 2;
        }

        public void Traslacion(float x, float y)
        {
            xPos = x;
            yPos = y;
        }

        public void Cizallamineto(float x, float y)
        {
            xRecorte = x;
            yRecorte = y;
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
