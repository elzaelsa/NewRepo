using System;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace _5Laba
{
    public partial class Form1 : Form
    {
        private Animator animator;
        public Form1()
        {
            InitializeComponent();
            animator = new Animator(panel1.CreateGraphics());
            animator.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Ball ball in animator.Balls)
            {
                ball.onPause = true;
            }
        }

        private void continue_button_Click(object sender, EventArgs e)
        {
            foreach (Ball ball in animator.Balls)
            {
                ball.onPause = false;
            }
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            foreach (Ball ball in animator.Balls)
            {
                ball._stop = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void continue_button_Click_1(object sender, EventArgs e)
        {
            foreach (Ball ball in animator.Balls)
            {
                ball.onPause = false;
            }
        }

        private void pause_button_Click(object sender, EventArgs e)
        {
            foreach (Ball ball in animator.Balls)
            {
                ball.onPause = true;
            }
        }

        private void stop_button_Click_1(object sender, EventArgs e)
        {
            foreach (Ball ball in animator.Balls)
            {
                ball._stop = true;
            }
        }
    }
}