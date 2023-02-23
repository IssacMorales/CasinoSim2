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

    }
}
