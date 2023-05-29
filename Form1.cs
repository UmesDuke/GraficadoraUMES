using GraficadoraUMES.Umes;
using GraficadoraUMES.Umes.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TrackBar = System.Windows.Forms.TrackBar;

namespace GraficadoraUMES
{
    public partial class Form1 : Form
    {
        private float angulo;
        private float posX;
        private float posY;
        private float recorteX;
        private float recorteY;
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

        private void Reset()
        {
            gL.Reset();

            trackBarPosX.Value = 0;

            trackBarPosY.Value = 0;
            trackBarAngulo.Value = 0;
            trackBarSizallaminetoX.Value = 0;
            trackBarSizallaminetoY.Value = 0;

            label4.Text = "Ángulo: 0°";
            textBox3.Text = "0";

            label5.Text = "Posición X: 0pts";
            textBox1.Text = "0";

            label6.Text = "Posición Y: 0pts";
            textBox2.Text = "0";

            label13.Text = "Sizallamineto X: 0pts";
            label14.Text = "Sizallamineto Y: 0pts";
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
            posX = this.GetValueTrack(trackBarPosX, false);
            gL.Traslacion(posX, posY);

            label5.Text = "Posición X: " + posX + "pts";
            textBox1.Text = posX.ToString();
        }

        private void trackBarPosY_Scroll(object sender, EventArgs e)
        {
            posY = -this.GetValueTrack(trackBarPosY, false);
            gL.Traslacion(posX, posY);

            label6.Text = "Posición Y: " + (-posY) + "pts";
            textBox2.Text = (-posY).ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            if (index != -1)
            {
                switch (comboBox1.Text)
                {
                    case "Polinomial":
                        EcuacionPolinomica ep = new EcuacionPolinomica();
                        ep.ShowDialog();

                        gL.GetG(Util.POLINOMIAL).Val = ep.Coeficionetes;
                        break;
                    case "Senoidal":
                        EcuacionSenoidal es = new EcuacionSenoidal();
                        es.ShowDialog();

                        gL.GetG(Util.SENOIDAL).Val = es.Coeficionetes;
                        break;
                    case "Exponencial":
                        EcuacionExponencial ex = new EcuacionExponencial();
                        ex.ShowDialog();

                        gL.GetG(Util.EXPONENCIAL).Val = ex.Coeficionetes;
                        break;
                    default:
                        break;
                }
                

                gL.draw(comboBox1.Text);
                Reset();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gL.draw();
        }

        private void trackBarSizallaminetoX_Scroll(object sender, EventArgs e)
        {
            recorteX = this.GetValueTrack(trackBarSizallaminetoX);
            gL.Sizallar(recorteX, recorteY);

            label13.Text = "Sizallamineto X: " + (recorteX) + "pts";
        }

        private void trackBarSizallaminetoY_Scroll(object sender, EventArgs e)
        {
            recorteY = this.GetValueTrack(trackBarSizallaminetoY);
            gL.Sizallar(recorteX, recorteY);

            label14.Text = "Sizallamineto Y: " + (recorteY) + "pts";
        }
    }
}
