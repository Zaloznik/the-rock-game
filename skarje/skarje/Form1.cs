using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace skarje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int ZASCITA = 0;
        Game igra = new Game();

        public int izbira1;
        public int izbira2;
        public int rezultat;

        private void resetButton_Click(object sender, EventArgs e)
        {
            ZASCITA++;
            if (ZASCITA == 1)
            {
                igra.Player1Score = 0;
                igra.Player2Score = 0;

                scoreLabel1.Text = "0";
                scoreLabel2.Text = "0";

                pictureBox1.Image = null;
                pictureBox2.Image = null;

                highScoreNaNicBtn.Visible = true;
            }
            else if(ZASCITA > 1)
            {
                MessageBox.Show("Si mislu da bo resetiralo high score? heheh", "Lejga lejga...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            ZASCITA = 0;
            highScoreNaNicBtn.Visible = false;
            rezultat = igra.Play();
            izbira1 = igra.Player1State;
            izbira2 = igra.Player2State;

            switch (izbira1)
            {
                case 0:
                    pictureBox1.Image = skarje.Properties.Resources.papir;
                    break;
                case 1:
                    pictureBox1.Image = skarje.Properties.Resources.kamen;
                    break;
                case 2:
                    pictureBox1.Image = skarje.Properties.Resources.noz;
                    break;
            }
            switch (izbira2)
            {
                case 0:
                    pictureBox2.Image = skarje.Properties.Resources.papir;
                    break;
                case 1:
                    pictureBox2.Image = skarje.Properties.Resources.kamen;
                    break;
                case 2:
                    pictureBox2.Image = skarje.Properties.Resources.noz;
                    break;
            }

            if (rezultat == 1)
            {
                igra.Player1Score++;
                scoreLabel1.Text = Convert.ToString(igra.Player1Score);

                if(igra.Player1Score>Game.Player1HighScore)
                {
                    highScoreLabel1.Text = Convert.ToString(igra.Player1Score);
                    Game.Player1HighScore = igra.Player1Score;
                }
            }

            if (rezultat == 2)
            {
                igra.Player2Score++;
                scoreLabel2.Text = Convert.ToString(igra.Player2Score);

                if (igra.Player2Score > Game.Player2HighScore)
                {
                    highScoreLabel2.Text = Convert.ToString(igra.Player2Score);
                    Game.Player2HighScore = igra.Player2Score;
                }
            }
        }

        private void highScoreNaNicBtn_Click(object sender, EventArgs e)
        {
            Game.Player1HighScore = 0;
            Game.Player2HighScore = 0;
            highScoreLabel1.Text = "0";
            highScoreLabel2.Text = "0";
        }
    }
}
