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
        int theBet;
        int thePayOut;

        private static int staticMoney()
        {
            return Money.buck;
        }


        int money = staticMoney();
        private void moneyEqual(int money)
        {
            Money.buck = money;
            cMoney.Text = "Money: " + money.ToString();
            
        }
        private void addMoney(int money)
        {
            Money.buck = +money;
        }
        private void loseMoney(int money)
        {
            Money.buck = +money;
        }

        Random r = new Random();
        int a = 0;
        int randomMax = 36;
        public Roulette()
        {
            InitializeComponent();
            num.PlaceholderText = "# here";
            moneyEqual();
        }

        private void custom_Click(object sender, EventArgs e)
        {


            CB.Text = "Bet Square: " + num.Text;
            startGame();
            int.TryParse(BetAmount.Text, out theBet);
            if (int.Parse(num.Text) == a)
            {

                

                int thePayOut = theBet * 35;
                addMoney(thePayOut);
                BetAmount.Text.ToString();

                WL.Text = "WINNER! You won $" + (theBet + thePayOut);
            }
            else
            {
                loseMoney(theBet);
                WL.Text = "LOSER! Winning Number: " + a;
            }
            num.Text = "";
            moneyEqual(theBet);
        }

        public void startGame()
        {
            a = r.Next(1, randomMax + 1);
        }

        private void black_Click(object sender, EventArgs e)
        {
            startGame();
            int.TryParse(BetAmount.Text, out theBet);

            if (a % 2 == 1 && a != 0)
            {
                int thePayOut = theBet * 35;
                addMoney(thePayOut);
                BetAmount.Text.ToString();
                WL.Text = "WINNER!!! ";
            }
            else
            {
                loseMoney(theBet);

                WL.Text = "LOSER! Winning Number: " + a;
            }
            moneyEqual(theBet);
        }

        private void Red_Click(object sender, EventArgs e)
        {
            startGame();
            int.TryParse(BetAmount.Text, out theBet);

            if (a % 2 == 0 && a != 0)
            {
                int thePayOut = theBet * 35;
                addMoney(thePayOut);
                BetAmount.Text.ToString();
                WL.Text = "WINNER!!!";
            }
            else
            {
                loseMoney(theBet);

                WL.Text = "LOSER! Winning Number: " + a;
            }
            moneyEqual(theBet);
        }

        private void twelve_Click(object sender, EventArgs e)
        {
            startGame();
            int.TryParse(BetAmount.Text, out theBet);

            if (a < 13 && a != 0)
            {
                int thePayOut = theBet * 35;
                addMoney(thePayOut);
                BetAmount.Text.ToString();
                WL.Text = "WIINNER!";
            }
            else
            {
                loseMoney(theBet);

                WL.Text = "LOSER! Winning Number: " + a;
            }
            moneyEqual(theBet);
        }

        private void thirty_Click(object sender, EventArgs e)
        {
            startGame();
            int.TryParse(BetAmount.Text, out theBet);

            if (a > 24 && a != 0)
            {
                int thePayOut = theBet * 35;
                addMoney(thePayOut);
                BetAmount.Text.ToString();
                WL.Text = "WIINNER!";
            }
            else
            {
                loseMoney(theBet);

                WL.Text = "LOSER! Winning Number: " + a;
            }
            moneyEqual(theBet);
        }

        private void twenty_Click(object sender, EventArgs e)
        {
            startGame();
            int.TryParse(BetAmount.Text, out theBet);
            if (a > 12 && a < 25 && a != 0)
            {
                int thePayOut = theBet * 35;
                addMoney(thePayOut);
                BetAmount.Text.ToString();
                WL.Text = "WIINNER!";
            }
            else
            {
                loseMoney(theBet);

                WL.Text = "LOSER! Winning Number: " + a;
            }
            moneyEqual(theBet);
        }

        private void High_Click(object sender, EventArgs e)
        {
            startGame();
            int.TryParse(BetAmount.Text, out theBet);

            if (a > 18 && a != 0)
            {
                int thePayOut = theBet * 35;
                addMoney(thePayOut);
                BetAmount.Text.ToString();
                WL.Text = "WINNER!!! Winning Number: " + a;
            }
            else
            {
                loseMoney(theBet);

                WL.Text = "LOSER! Winning Number: " + a;
            }
            moneyEqual(theBet);
        }

        private void low_Click(object sender, EventArgs e)
        {
            startGame();
            int.TryParse(BetAmount.Text, out theBet);

            if (a < 19 && a != 0)
            {
                int thePayOut = theBet * 35;
                addMoney(thePayOut);
                BetAmount.Text.ToString();
                WL.Text = "WINNER!!!  Winning Number: " + a;
            }
            else
            {
                loseMoney(theBet);
                WL.Text = "LOSER! Winning Number: " + a;
            }
            moneyEqual(theBet);
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

    }
}
