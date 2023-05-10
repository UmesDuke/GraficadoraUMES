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
        private float x;
        private float y;
        private float angulo;

        public Grafica()
        {
        }

        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }
        public float Angulo { get => angulo; set => angulo = value; }
    }
}
