using System;
using System.Windows.Forms;
using System.Drawing;

/// <summary>
/// basic info for game
/// </summary>
namespace Flappy_bird
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 3;
        int gravity = 5;
        int score = 0;
        int lives = 3;
        int totalscore = 0;

        public Form1()
        {
            InitializeComponent();
            button2.Hide();
            button2.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// regulates location and variety of pipes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappybird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = "Score: " + score;

            if (pipeBottom.Left < -150)

            {
                pipeBottom.Left = 800;
                score++;
            }

            if (pipeTop.Left < -180)
             {
                    Random rd = new Random();
                    int rand_num = rd.Next(290, 384);
                    pipeTop.Left = rand_num;
                Random rd1 = new Random();
                int rand_num1 = rd.Next(-5, 0);
                pipeTop.Top = rand_num1;
                    score++;
             }
            
            //sets bounderies that flappy cannot exceed

            if (flappybird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappybird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappybird.Bounds.IntersectsWith(ground.Bounds)
                )
            {

                //endGame();
                endLive();
                gameTimer.Stop();

                button1.Visible = true;
                button2.Visible = true;
                button2.Enabled = true;

                totalscore = totalscore + score;
                lblTotalScore.Text = totalscore.ToString();

                if (lives == 0)
                {
                    endGame();
                    Close();
                }

            }
            gamespeed();
        }
        
        /// <summary>
        /// shows gui when flappy collided with something
        /// </summary>
        private void endLive()
        {
            lives = lives - 1;
            lblLives.Text = lives.ToString();
            gameTimer.Stop();
            button1.Visible = true;
            button1.Enabled = true;
            button2.Visible = true;
            button2.Visible = true;
        }

        /// <summary>
        /// speeds up game if score is above 5
        /// </summary>
        private void gamespeed()
        {
            if (score > 5)
            {
                pipeSpeed = 4;
            }

            if (score > 10)
            {
                pipeSpeed = 6;
            }

            if (score > 15)
            {
                pipeSpeed = 8;
            }

            if (score > 20)
            {
                pipeSpeed = 10;
            }

            if (score > 25)
            {
                pipeSpeed = 12;
            }

            if (score > 30)
            {
                pipeSpeed = 14;
            }

            if (score > 35)
            {
                pipeSpeed = 16;
            }

            if (score > 40)
            {
                pipeSpeed = 18;
            }

            //menu to retry or go to leaderboard

            if (flappybird.Top < -25)
            {
                endGame();
                gameTimer.Stop();
                button1.Visible = true;
                button1.Enabled = true;
                button2.Visible = true;
                button2.Enabled = true;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// makes flappy go up when pressing the spacebar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        /// <summary>
        /// makes flappy go down when the spacebar is depressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

        /// <summary>
        /// ends game when out of lives
        /// </summary>
        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += " Game over";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// reset button, resets game when colliding with pipe, ground or top
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            gameTimer.Start();
            button1.Hide();
            button1.Enabled = false;
            button2.Hide();
            button2.Enabled = false;
            flappybird.Location = new Point(53, 170);
            pipeBottom.Location = new Point(347, 256);
            pipeTop.Location = new Point(402, -3);
        }

        /// <summary>
        /// leaderboard button, referes to highscores achieved by players
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 leaderboard = new Form2();

            leaderboard.Show();

        }
    }
}
