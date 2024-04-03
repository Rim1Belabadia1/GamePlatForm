using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace Pc_Man_Game_MOO_ICT
{
    public partial class Form2 : Form
    {
        private readonly Random random = new Random();
        private readonly System.Timers.Timer timer = new System.Timers.Timer(1000 / 60);
        private bool isGameActive = false;
        private int ballX, ballY, ballSpeedX, ballSpeedY, paddleX, paddleY, score = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer.AutoReset = true;
            timer.Start();
            timer.Elapsed += MoveBall;
        }

        private void MoveBall(object sender, ElapsedEventArgs e)
        {
            if (!isGameActive)
                return;

            ballX += ballSpeedX;
            ballY += ballSpeedY;

            if (ballX <= 0 || ballX + 50 >= Width)
                ballSpeedX = -ballSpeedX;

            if (ballY <= 0)
                ballSpeedY = -ballSpeedY;
            else if (ballY + 50 >= paddleY && ballX + 25 >= paddleX && ballX + 25 <= paddleX + 100)
            {
                ballSpeedY = -ballSpeedY;
                IncreaseSpeed();
            }
            else if (ballY + 50 >= Height)
                LoseGame();

            Invalidate();
        }

        private void IncreaseSpeed()
        {
            score++;
            ballSpeedY = ballSpeedY < 0 ? -score : score;
        }

        private void LoseGame()
        {
            isGameActive = false;
            timer.Stop();
            MessageBox.Show("Game Over");
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            if (!isGameActive)
            {
                e.Graphics.DrawString("Click to start", Font, Brushes.Black, new PointF(10, 10));
                return;
            }

            e.Graphics.FillEllipse(Brushes.Red, ballX, ballY, 50, 50);
            e.Graphics.FillRectangle(Brushes.Blue, paddleX, paddleY, 100, 20);
        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
            if (!isGameActive)
            {
                isGameActive = true;
                ballX = Width / 2 - 25;
                ballY = Height / 2 - 25;
                ballSpeedX = (int)(2 * random.NextDouble() - 1);
                ballSpeedY = -2;
                paddleX = Width / 2 - 50;
                paddleY = Height - 50;
                score = 0;
            }
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isGameActive)
                return;

            paddleX = e.X - 50;

            if (paddleX < 0)
                paddleX = 0;
            else if (paddleX + 100 > Width)
                paddleX = Width - 100;

            if (ballY + 50 >= paddleY && ballY + 50 <= paddleY + 20)
            {
                if (ballX + 25 >= paddleX && ballX + 25 <= paddleX + 100)
                {
                    ballSpeedY = -ballSpeedY;
                    IncreaseSpeed();
                }
            }
        }
    }
}
