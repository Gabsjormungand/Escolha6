using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escolha6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxSerpente1.Visible = true;
            radioButtonSerpe1.Visible = true;
            pictureBoxSerpente2.Visible = true;
            radioButtonSerpen2.Visible = true;
            pictureBoxSerpente3.Visible = true;
            radioButtonSerpen3.Visible = true;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxLagarto1.Visible = true;
            radioButtonLagar1.Visible = true;
            pictureBoxLagarto2.Visible = true;
            radioButtonLagar2.Visible = true;
            pictureBoxLatarto3.Visible = true;
            radioButtonLagar3.Visible = true;
        }
    }
}
