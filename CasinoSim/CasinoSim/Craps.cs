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
        int point = 0;
        

        public Craps()
        {
            InitializeComponent();
        }

        private void PL_Click(object sender, EventArgs e)
        {
            DoRoll();
            if(roll == 7 || roll == 11)
            {
                lblRoll.Text = "Winner";
                PL.Enabled = false;
                DPL.Enabled = false;
                CB.Enabled = true;
                DCB.Enabled = true;
            }
            else if (roll == 2 || roll == 3 || roll == 12)
            {
                lblRoll.Text = "Loss";
                PL.Enabled = false;
                DPL.Enabled = false;
                CB.Enabled = true;
                DCB.Enabled = true;
            }
            else
            {
                lblRoll.Text = roll.ToString();
            }
            point++;
            Points.Text = "Points: " + point;
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
            }
            else if (roll == 2 || roll == 3 || roll == 12)
            {
                lblRoll.Text = "Winner";
                PL.Enabled = false;
                DPL.Enabled = false;
                CB.Enabled = true;
                DCB.Enabled = true;
            }
            else
            {
                lblRoll.Text = roll.ToString();
            }
            point++;
            Points.Text = "Points: " + point;
        }

        private void CB_Click(object sender, EventArgs e)
        {
            DoRoll();
            if (roll == 7 || roll == 11)
            {
                lblRoll.Text = "Winner";
            }
            else if (roll == 2 || roll == 3 || roll == 12)
            {
                lblRoll.Text = "Loss";
            }
            else
            {
                lblRoll.Text = roll.ToString();
            }
            point++;
            Points.Text = "Points: " + point;
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
                lblRoll.Text = "Winner";
            }
            else
            {
                lblRoll.Text = roll.ToString();
            }
            point++;
            Points.Text = "Points: " + point;
        }

        private void OddsBTN_Click(object sender, EventArgs e)
        {
            //Once a point is made on the first roll or a come
            //point on a succeeding roll, you may take the odds
            //and win if the point or come points are made
            //before a 7. Payoffs are: 2 to 1 on 4 and 10, 3 to 2
            //for 5 and 9, 6 to 5 on 6 and 8. “Don’t pass” or
            //“don’t come” bets are in reverse: you must lay the
            //odds in order to win.
            DoRoll();
            if(roll%2 == 1 && roll != 7)
            {
                lblRoll.Text = "Winner";
            } 
            else
            {
                lblRoll.Text = roll.ToString();
            }
        }

        private void OddsBTN_Payoffs(/*object sender, EventArgs e*/)
        {
            double payoff = 0;


            if (roll == 4 || roll == 10)
            {
                payoff = 2.8f;
            }
            else if (roll == 5 || roll == 9)
            {
                payoff = 1.5f;
            }
            else if (roll == 6 || roll == 8)
            {
                payoff = 1.2f;
            }

        }

        private void pb_Click(object sender, EventArgs e)
        {
            /*Once a shooter makes a point, you may make a “place bet” on numbers 
             * 4, 5, 6, 8, 9, and 10. If the shooter rolls any of these numbers 
             * before a 7, you win the following payoffs: 9 to 5 on 4 and 10, 7 
             * to 5 on 5 and 9, and 7 to 6 on 6 and 8.*/

            DoRoll();
            if(roll == 4 || roll == 10)
            {
                lblRoll.Text = "9-5 win";
            }
            else if(roll == 5 || roll == 9)
            {
                lblRoll.Text = "7-5 win";
            }
            else if(roll == 6 || roll == 8)
            {
                lblRoll.Text = "7-6 win";
            }
            else if(roll == 7)
            {
                lblRoll.Text = "Winner";
            }
            else
            {
                lblRoll.Text = "Loss";
            }
        }
    }
}
