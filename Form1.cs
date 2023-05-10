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
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int angulo = this.trackBarAngulo.Value;

        }

        private void trackBarPosX_Scroll(object sender, EventArgs e)
        {
            int posX = this.trackBarPosX.Value;

        }

        private void trackBarPosY_Scroll(object sender, EventArgs e)
        {
            int posY = this.trackBarPosY.Value;

        }
    }
}
