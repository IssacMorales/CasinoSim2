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

        public Roulette()
        {
            InitializeComponent();
        }

        private void custom_Click(object sender, EventArgs e)
        {
            CB.Text = "Bet Square: " + num.Text;
        }
    }
}
