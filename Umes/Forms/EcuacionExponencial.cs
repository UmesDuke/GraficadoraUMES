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
    public partial class EcuacionExponencial : Form
    {
        List<float> coeficionetes = new List<float>();

        public List<float> Coeficionetes { get => coeficionetes; set => coeficionetes = value; }
        public EcuacionExponencial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            coeficionetes.Clear();
            coeficionetes.Add((float)Convert.ToDecimal(textBox1.Text));
            Close();
        }
    }
}
