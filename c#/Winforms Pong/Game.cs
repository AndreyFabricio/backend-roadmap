using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Winforms_Pong
{
    public partial class Game : Form
    {

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    if (pictureBox1.Top + 110 > panel1.Bounds.Top -  pictureBox1.Top)
                    {
                        pictureBox1.Top -= 10;
                    }
                    break;
                case Keys.S:
                    if (pictureBox1.Bottom - 310 <  panel1.Bounds.Bottom - pictureBox1.Bottom)
                    {
                        pictureBox1.Top += 10;
                    }
                    break;
                case Keys.Up:
                    if (pictureBox2.Top + 110 > panel1.Bounds.Top - pictureBox2.Top)
                    {
                        pictureBox2.Top -= 10;
                    }
                    break;
                case Keys.Down:
                    if (pictureBox2.Bottom - 310 < panel1.Bounds.Bottom - pictureBox2.Bottom)
                    {
                        pictureBox2.Top += 10;
                    }
                    break;
            }
        }

        public Game()
        {
            InitializeComponent();
        }

        private void playball_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
