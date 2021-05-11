using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;
        int gravity = 15;//kuşun yerden yüksekliği
        int score = 0;

        public Form1()
        {
            
            InitializeComponent();
        }

        private void pictureBox_bird_Click(object sender, EventArgs e)
        {

        }

        private void gameTimer(object sender, EventArgs e)
        {
            //kuşun olduğu kısımdaki kodları ve hızları
            pictureBox_bird.Top += gravity;
            pictureBox_down.Left -= pipeSpeed;
            pictureBox_top.Left -= pipeSpeed;
            label1.Text = "SCORE: " + score;
            //engellerin konumuna göre kuşun hareketi
            if(pictureBox_down.Left< -150)
            {
                pictureBox_down.Left = 800;
                score++;
            }
            if (pictureBox_top.Left < -180)
            {
                pictureBox_top.Left = 950;
                score++;
            }
            //kuşun konumunun engellere,yukarıya,zemine değip değmediği
            if(pictureBox_bird.Bounds.IntersectsWith(pictureBox_down.Bounds) ||
                pictureBox_bird.Bounds.IntersectsWith(pictureBox_top.Bounds)||
                pictureBox_bird.Bounds.IntersectsWith(pictureBox_floor.Bounds)||
                pictureBox_bird.Top<-25)
            {
                EndGame();
                label2.Enabled = true;
                label2.Text = "OYUN BİTTİ SKORUNUZ: " + score +"\n"+"Tekrar Deneyin..";
            }
        }
        public void EndGame()
        {
            timer_control.Stop();
            label1.Text = "Game Over!";
        }

        private void game_Down(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Space)
            {
                gravity = -15;
            }
        }

        private void game_Up(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Space)
            {
                gravity = 15;
            }
        }
    }
}
