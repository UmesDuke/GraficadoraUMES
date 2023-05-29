using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraficadoraUMES.Umes.Forms
{
    public partial class EcuacionPolinomica : Form
    {
        List<float> coeficionetes = new List<float>();

        public List<float> Coeficionetes { get => coeficionetes; set => coeficionetes = value; }

        public EcuacionPolinomica()
        {
            InitializeComponent();
        }

        private void MostarExp()
        {
            StringBuilder b = new StringBuilder();
            for (int i = 0; i < coeficionetes.Count; i++)
            {
                if (i > 0)
                {
                    if (coeficionetes[i] >= 0)
                    {
                        b.Append("+ ");
                    }
                }

                b.Append(coeficionetes[i] + "x^" + i + " ");
            }

            Console.WriteLine(coeficionetes.Count);
            label2.Text = "Expreción:   " + b.ToString();
            label1.Text = "Agregar: x^" + coeficionetes.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            coeficionetes.Add((float)Convert.ToDecimal(textBox1.Text));
            MostarExp();

            textBox1.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
