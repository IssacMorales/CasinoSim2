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
        //int money; 


        private static int staticMoney()
        {
            return Money.buck;
        }


        int money = staticMoney();
        private void moneyEqual()
        {
            Money.buck = money;
        }

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
            if (int.Parse(num.Text) == a)
            {

                BetAmount.Text.ToString();

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
            if (a % 2 == 1 && a != 0)
            {
                WL.Text = "WINNER!!! ";
            }
            else
            {
                WL.Text = "LOSER! Winning Number: " + a;
            }
        }

        private void Red_Click(object sender, EventArgs e)
        {
            startGame();
            if (a % 2 == 0 && a != 0)
            {
                WL.Text = "WINNER!!!";
            }
            else
            {
                WL.Text = "LOSER! Winning Number: " + a;
            }
        }

        private void twelve_Click(object sender, EventArgs e)
        {
            startGame();
            if (a < 13 && a != 0)
            {
                WL.Text = "WIINNER!";
            }
            else
            {
                WL.Text = "LOSER! Winning Number: " + a;
            }
        }

        private void thirty_Click(object sender, EventArgs e)
        {
            startGame();
            if (a > 24 && a != 0)
            {
                WL.Text = "WIINNER!";
            }
            else
            {
                WL.Text = "LOSER! Winning Number: " + a;
            }
        }

        private void twenty_Click(object sender, EventArgs e)
        {
            startGame();

            if (a > 12 && a < 25 && a != 0)
            {
                WL.Text = "WIINNER!";
            }
            else
            {
                WL.Text = "LOSER! Winning Number: " + a;
            }
        }

        private void High_Click(object sender, EventArgs e)
        {
            startGame();

            if (a > 18 && a != 0)
            {
                WL.Text = "WINNER!!! Winning Number: " + a;
            }
            else
            {
                WL.Text = "LOSER! Winning Number: " + a;
            }

        }

        private void low_Click(object sender, EventArgs e)
        {
            startGame();

            if (a < 19 && a != 0)
            {
                WL.Text = "WINNER!!!  Winning Number: " + a;
            }
            else
            {
                WL.Text = "LOSER! Winning Number: " + a;
            }
        }

        private void num_TextChanged(object sender, EventArgs e)
        {

        }

        private void BetAmount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
