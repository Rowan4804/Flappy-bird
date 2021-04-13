using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_bird
{
    public partial class main_menu : Form
    {
        public main_menu()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoadGame(object sender, EventArgs e)
        {
            Form1 gameWindow = new Form1();

            gameWindow.Show();
        }

        private void LeaderBoard(object sender, EventArgs e)
        {
            Form2 leaderboard = new Form2();

            leaderboard.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 leaderboard = new Form2();

            leaderboard.Show();
        }
    }
}
