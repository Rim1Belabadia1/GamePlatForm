using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pc_Man_Game_MOO_ICT
{
    public partial class Form5 : Form
    {
        bool goLeft, goRight, shooting, isGameOver;
        int score;
        int playerSpeed = 12;
        int enemySpeed;
        int bulletSpeed;
        Random rnd = new Random();

        public Form5()
        {
            InitializeComponent();
            resetGame();
         
    }
     

        private void mainGameTimerEvent(object sender, EventArgs e)
        {

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void player_Click(object sender, EventArgs e)
        {

        }

        private void enemyTwo_Click(object sender, EventArgs e)
        {

        }

        private void enemyThree_Click(object sender, EventArgs e)
        {

        }

        private void enemyOne_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Space && shooting == false)
            {
                shooting = true;

                bullet.Top = player.Top - 30;
                bullet.Left = player.Left + (player.Width / 2);

            }
            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                resetGame();
            }
        }

        private void resetGame()
        {
            gameTimer.Start();
            enemySpeed = 6;


            enemyOne.Left = rnd.Next(20, 600);
            enemyTwo.Left = rnd.Next(20, 600);
            enemyThree.Left = rnd.Next(20, 600);

            enemyOne.Top = rnd.Next(0, 200) * -1;
            enemyTwo.Top = rnd.Next(0, 500) * -1;
            enemyThree.Top = rnd.Next(0, 900) * -1;

            score = 0;
            bulletSpeed = 0;
            bullet.Left = -300;
            shooting = false;


            txtScore.Text = score.ToString();

        }

        private void gameOver()
        {
            isGameOver = true;
            gameTimer.Stop();
            txtScore.Text += Environment.NewLine + "Game Over!!" + Environment.NewLine + "Press Enter to try again.";

        }
    }
}
