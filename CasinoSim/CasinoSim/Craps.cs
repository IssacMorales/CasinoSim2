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
    public partial class Craps : Form
    {

        Random r = new Random();
        int a = 0;
        int a2 = 0;
        int randomMax = 6;
        int roll;
        int point = 1000;
        int bet = 0;
        bool hasbet = false;

        public Craps()
        {
            InitializeComponent();
        }

        private void PL_Click(object sender, EventArgs e)
        {
            DoRoll();
            if(roll == 7 || roll == 11)
            {
                lblRoll.Text = "Continue";
                PL.Enabled = false;
                DPL.Enabled = false;
                CB.Enabled = true;
                DCB.Enabled = true;
                OddsBTN.Enabled = true;
                pb.Enabled = true;
            }
            else if (roll == 2 || roll == 3 || roll == 12)
            {
                lblRoll.Text = "Loss";
                PL.Enabled = false;
                DPL.Enabled = false;
                CB.Enabled = true;
                DCB.Enabled = true;
                OddsBTN.Enabled = true;
                pb.Enabled = true;
            }
            else
            {
                lblRoll.Text = roll.ToString();
            }
            point = point - 10;
            Points.Text = "Money: " + point;
        }

        public void DoRoll()
        {
            a = r.Next(1, randomMax + 1);
            a2 = r.Next(1, randomMax + 1);
            roll = a + a2;
        }

        private void DPL_Click(object sender, EventArgs e)
        {
            DoRoll();

            if (roll == 7 || roll == 11)
            {
                lblRoll.Text = "Loss";
                PL.Enabled = false;
                DPL.Enabled = false;
                CB.Enabled = true;
                DCB.Enabled = true;
                OddsBTN.Enabled = true;
                pb.Enabled = true;
            }
            else if (roll == 2 || roll == 3 || roll == 12)
            {
                lblRoll.Text = "Continue";
                PL.Enabled = false;
                DPL.Enabled = false;
                CB.Enabled = true;
                DCB.Enabled = true;
                OddsBTN.Enabled = true;
                pb.Enabled = true;
            }
            else
            {
                lblRoll.Text = roll.ToString();
            }
            point = point - 10;
            Points.Text = "Money: " + point;
        }

        private void CB_Click(object sender, EventArgs e)
        {
            DoRoll();
            if (roll == 7 || roll == 11)
            {
                lblRoll.Text = "Continue";
            }
            else if (roll == 2 || roll == 3 || roll == 12)
            {
                lblRoll.Text = "Loss";
            }
            else
            {
                lblRoll.Text = roll.ToString();
            }
            point = point - 10;
            Points.Text = "Money: " + point;
        }

        private void DCB_Click(object sender, EventArgs e)
        {
            DoRoll();
            if (roll == 7 || roll == 11)
            {
                lblRoll.Text = "Loss";
            }
            else if (roll == 2 || roll == 3 || roll == 12)
            {
                lblRoll.Text = "Continue";
            }
            else
            {
                lblRoll.Text = roll.ToString();
            }
            point = point - 10;
            Points.Text = "Money: " + point;
        }

        private void OddsBTN_Click(object sender, EventArgs e)
        {
            DoRoll();
            double payoff = 0;


            if(hasbet == false)
            {
                if (roll == 4 || roll == 10)
                {
                    payoff = 2.8f;
                    lblRoll.Text = "Money: " + (payoff * point);
                }
                else if (roll == 5 || roll == 9)
                {
                    payoff = 1.5f;
                    lblRoll.Text = "Money: " + (payoff * point);
                }
                else if (roll == 6 || roll == 8)
                {
                    payoff = 1.2f;
                    lblRoll.Text = "Money: " + (payoff * point);
                }
                else if (roll == 7)
                {
                    lblRoll.Text = "7 game over";
                    seven();
                }
                else
                {
                    lblRoll.Text = roll.ToString();
                }
            }
            else
            {
                if (roll == 4 || roll == 10)
                {
                    payoff = 2.8f;
                    lblRoll.Text = "Money: " + (payoff * point);
                    placedBet();
                }
                else if (roll == 5 || roll == 9)
                {
                    payoff = 1.5f;
                    lblRoll.Text = "Money: " + (payoff * point);
                    placedBet();
                }
                else if (roll == 6 || roll == 8)
                {
                    payoff = 1.2f;
                    lblRoll.Text = "Money: " + (payoff * point);
                    placedBet();
                }
                else if (roll == 7)
                {
                    lblRoll.Text = "7 game over";
                    seven();
                }
                else
                {
                    lblRoll.Text = roll.ToString();
                    placedBet();
                }
                hasbet = false;
                pb.Enabled = true;
            }
        }

        private void pb_Click(object sender, EventArgs e)
        {

            
            if (pbNum.Text == "4" || pbNum.Text == "10" || pbNum.Text == "5" || pbNum.Text == "9" || pbNum.Text == "6" || pbNum.Text == "8")
            {
                lblRoll.Text = "Bet placed";
                bet = int.Parse(pbNum.Text);
                hasbet = true;
                pbNum.Text = "";
                pb.Enabled= false;
            }
            else
            {
                lblRoll.Text = "enter a valid bet: 4, 5, 6, 8, 9, 10";
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        public void seven()
        {
            PL.Enabled = true;
            DPL.Enabled = true;
            CB.Enabled = false;
            DCB.Enabled = false;
            OddsBTN.Enabled = false;
            pb.Enabled = false;
            point = 1000;
            Points.Text = "Money: " + point;
        }

        public void placedBet()
        {
            if (roll == 4 && roll == bet || roll == 10 && roll == bet)
            {
                lblRoll.Text = "9-5 win, " + (point * 9 - point * 5);
            }
            else if (roll == 5 && roll == bet || roll == 9 && roll == bet)
            {
                lblRoll.Text = "7-5 win, " + (point * 7 - point * 5);
            }
            else if (roll == 6 && roll == bet || roll == 8 && roll == bet)
            {
                lblRoll.Text = "7-6 win, " + (point * 7 - point * 6);
            }
            else if (roll == 7)
            {
                lblRoll.Text = "7 game over";
                seven();
            }
            else
            {
                lblRoll.Text = "Loss";
            }
        }
    }
}
