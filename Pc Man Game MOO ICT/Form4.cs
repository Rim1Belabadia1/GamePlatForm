using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pc_Man_Game_MOO_ICT
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Rediriger vers Form1
            Form11 form11 = new Form11();
            form11.Show();
            this.Close(); // Fermer le formulaire actuel
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form0 form0 = new Form0();
            form0.Show();
            this.Close(); // Fermer le formulaire actuel
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
