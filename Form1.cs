using GraficadoraUMES.Umes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraficadoraUMES
{
    public partial class Form1 : Form
    {
        private float angulo;
        private float posX;
        private float posY;
        private GL gL;

        public Form1()
        {
            InitializeComponent();
            InitComponents();
        }

        private void InitComponents()
        {
            gL = new GL();
            gL.setup(this.pictureBox1);

            comboBox1.Text = "Seleccionar Gráfica...";
            comboBox1.Items.Add(Util.POLINOMIAL);
            comboBox1.Items.Add(Util.EXPONENCIAL);
            comboBox1.Items.Add(Util.SENOIDAL);

            gL.addRenderer(Util.POLINOMIAL, new Polinomial(pictureBox1.Width, pictureBox1.Height));
            gL.addRenderer(Util.EXPONENCIAL, new Exponencial(pictureBox1.Width, pictureBox1.Height));
            gL.addRenderer(Util.SENOIDAL, new Senoidal(pictureBox1.Width, pictureBox1.Height));
        }

        private float GetValueTrack(TrackBar b)
        {
            return this.GetValueTrack(b, true); 
        }

        private float GetValueTrack(TrackBar b, bool scale)
        {
            int val = b.Value;
            if (scale)
            {
                return val * 0.1f;
            }
            return val;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            angulo = this.GetValueTrack(trackBarAngulo, false);

            gL.Rotar(angulo);

            label4.Text = "Ángulo: " + angulo + "°";
            textBox3.Text = (angulo).ToString();
        }

        private void trackBarPosX_Scroll(object sender, EventArgs e)
        {
            posX = this.GetValueTrack(trackBarPosX);
            gL.Traslacion(posX, posY);

            label5.Text = "Posición X: " + posX + "pts";
            textBox1.Text = posX.ToString();
        }

        private void trackBarPosY_Scroll(object sender, EventArgs e)
        {
            posY = -this.GetValueTrack(trackBarPosY);
            gL.Traslacion(posX, posY);

            label6.Text = "Posición Y: " + (-posY) + "pts";
            textBox2.Text = (-posY).ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            if (index != -1)
            {
                gL.draw(comboBox1.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gL.draw();
        }
    }
}
