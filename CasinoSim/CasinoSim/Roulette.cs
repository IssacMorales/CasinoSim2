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
        private void moneyEqual(int money)
        {
            Money.buck = money;
        }
        private void addMoney(int money)
        {
            Money.buck =+ money;
        }
        private void loseMoney(int money)
        {
            Money.buck =+ money;
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
            int theBet;
            int.TryParse(BetAmount.Text, out theBet);
            if (int.Parse(num.Text) == a)
            {
               


                int thePayOut = theBet * 35;
                addMoney(thePayOut);
                BetAmount.Text.ToString();

                WL.Text = "WINNER! You won $"+(theBet+thePayOut);
            }
            else
            {
                loseMoney(theBet);
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

        private void Roulette_Load(object sender, EventArgs e)
        {

        }

        private void BetAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
