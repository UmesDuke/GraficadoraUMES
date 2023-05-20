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
    public partial class EcuacionSenoidal : Form
    {
        List<int> coeficionetes = new List<int>();

        public List<int> Coeficionetes { get => coeficionetes; set => coeficionetes = value; }

        public EcuacionSenoidal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            coeficionetes.Add(Convert.ToInt32(textBox1.Text));
            coeficionetes.Add(Convert.ToInt32(textBox2.Text));
            Close();
        }
    }
}
