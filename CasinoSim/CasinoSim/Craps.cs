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
                point++;
            }
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
                point++;
            }
        }

        private void CB_Click(object sender, EventArgs e)
        {
            if(point <= 0)
            {
                lblRoll.Text = "No points";
            }
            else
            {
                DoRoll();
                if (roll == 7 || roll == 11)
                {
                    lblRoll.Text = "Winner";
                }
                else if (roll == 2 || roll == 3 || roll == 12)
                {
                    lblRoll.Text = "Loss";
                    point--;
                }
                else
                {
                    lblRoll.Text = roll.ToString();
                    point--;
                }
            }
        }

        private void DCB_Click(object sender, EventArgs e)
        {
            if (point <= 0)
            {
                lblRoll.Text = "No points";
            }
            else
            {
                DoRoll();
                if (roll == 7 || roll == 11)
                {
                    lblRoll.Text = "Loss";
                    point--;
                }
                else if (roll == 2 || roll == 3 || roll == 12)
                {
                    lblRoll.Text = "Winner";
                    point--;
                }
                else
                {
                    lblRoll.Text = roll.ToString();
                    point--;
                }
            }
        }
    }
}
