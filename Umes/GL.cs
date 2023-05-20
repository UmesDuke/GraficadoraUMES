using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraficadoraUMES.Umes
{
    internal class GL
    {
        private Dictionary<string, Renderer> gl;
        private Renderer current;
        private Graphics g;

        public GL() {
            gl = new Dictionary<string, Renderer>();
        }

        public GL(Graphics g)
        {
            gl = new Dictionary<string, Renderer>();
            this.g = g;
        }

        public void Reset()
        {
            Traslacion(0, 0);
            Rotar(0);
            Sizallar(0, 0);
        }

        public void Traslacion(float x, float y)
        {
            foreach (Renderer r in this.gl.Values)
            {
                if (r is Grafica)
                {
                    ((Grafica)r).Traslacion(x, y);
                }
            }
            draw();
        }

        public void Sizallar(float x, float y)
        {
            foreach (Renderer r in this.gl.Values)
            {
                if (r is Grafica)
                {
                    ((Grafica)r).Cizallamineto(x, y);
                }
            }
            draw();
        }

        public void Rotar(float a)
        {
            foreach (Renderer r in this.gl.Values)
            {
                if (r is Grafica)
                {
                    ((Grafica)r).Rotar(a);
                }
            }
            draw();
        }
        public void setup(PictureBox picture)
        {
            if (picture != null)
            {
                g = picture.CreateGraphics();
            }
        }

        public void addRenderer(string name, Renderer renderer)
        {
            if (!gl.ContainsKey(name))
            {
                this.gl.Add(name, renderer);
            }
        }

        public Grafica GetG(string key)
        {
            Renderer r = gl[key];
            if (r is Grafica)
            {
                return (Grafica)r;
            }
            return null;
        }

        public void draw(String key)
        {
            this.current = this.gl[key];
            this.draw();
        }

        public void draw()
        {
            if (current != null)
            {
                current.draw(g);
            }
        }

        public void update()
        {
            if (current != null)
            {
                current.update();
            }
        }
    }
}
