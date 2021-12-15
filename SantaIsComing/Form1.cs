using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SantaIsComing
{
    public partial class Form1 : Form
    {
        int gravity = 10;
        int pipeSpeed = 6;
        int backroundSpeed = 3;
        int playScore = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void santa_Click(object sender, EventArgs e)
        {
            
        }

        private void tree_Click(object sender, EventArgs e)
        {

        }

        private void snowflake_Click(object sender, EventArgs e)
        {

        }

        private void moon_Click(object sender, EventArgs e)
        {

        }

        private void house_Click(object sender, EventArgs e)
        {

        }

        private void ground_Click(object sender, EventArgs e)
        {

        }
        private void Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void Keyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            santa.Top += gravity;
            snowflake.Left -= pipeSpeed;
            tree.Left -= pipeSpeed;
            moon.Left -= backroundSpeed;
            house.Left -= backroundSpeed;
            score.Text = $"score: {score}";

            if (snowflake.Left < -100)
            {
                snowflake.Left = 1000;
            }
            if (tree.Left < -100)
            {
                tree.Left = 900;
                playScore++;
            }
            if (moon.Left < -100)
            {
                moon.Left = 800;
            }
            if (house.Left < -100)
            {
                house.Left = 900;
            }
            if (santa.Top < -25)
            {
                gameOver();
            }
            if (santa.Bounds.IntersectsWith(snowflake.Bounds) || santa.Bounds.IntersectsWith(tree.Bounds) || santa.Bounds.IntersectsWith(ground.Bounds))
            {
                gameOver();
            }



        }

        
        private void gameOver()
        {
            timer1.Stop();
            Label1.Text = $"Game Over";
            playAgain.Visible = true;
        }

        private void playAgain_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
