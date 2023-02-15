using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasinoSim
{
    public partial class Roulette : Form
    {
        Random r = new Random();
        int a = 0;
        int randomMax = 36;
        public Roulette()
        {
            InitializeComponent();
            num.PlaceholderText = "# here";
        }

        private void custom_Click(object sender, EventArgs e)
        {
            CB.Text = "Bet Square: " + num.Text;
            startGame();
            if(int.Parse(num.Text) == a)
            {
                WL.Text = "WINNER!";
            }
            else
            {
                WL.Text = "LOSER! Winning Number: " + a;
            }
            num.Text = "";

        }

        public void startGame()
        {
            a = r.Next(1, randomMax + 1);
        }

        private void black_Click(object sender, EventArgs e)
        {
            startGame();
            if(a%2 == 1)
            {
                WL.Text = "WINNER!!!";
            }
            else
            {
                WL.Text = "LOSER! Winning Number: " + a;
            }
        }

        private void Red_Click(object sender, EventArgs e)
        {
            startGame();
            if (a % 2 == 0)
            {
                WL.Text = "WINNER!!!";
            }
            else
            {
                WL.Text = "LOSER! Winning Number: " + a;
            }
        }
    }
}
