using System;
using System.Windows.Forms;

namespace Pc_Man_Game_MOO_ICT
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            // Cette méthode reste vide, car la vérification sera effectuée dans button1_Click
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Code associé à l'événement label1_Click
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Code associé à l'événement textBox1_TextChanged
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Code associé à l'événement Form3_Load
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            // Code associé à l'événement maskedTextBox1_MaskInputRejected
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Vérifier si les deux champs contiennent "gaming"
            if (maskedTextBox1.Text.ToLower() == "gaming" && textBox1.Text.ToLower() == "gaming")
            {
                // Rediriger vers Form4
                Form4 form4 = new Form4();
                form4.Show();
                this.Hide(); // Cacher le formulaire actuel si nécessaire
            }
            else
            {
                // Afficher un message d'erreur ou prendre d'autres mesures
                MessageBox.Show("Les valeurs des champs ne correspondent pas à 'gaming'.");
            }
        }
    }
}
