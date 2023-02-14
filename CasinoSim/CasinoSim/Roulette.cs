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
        int randomMax = 9;
        public Roulette()
        {
            InitializeComponent();
        }

        private void custom_Click(object sender, EventArgs e)
        {
            CB.Text = "Bet Square: " + num.Text;
            startGame();

        }

        public void startGame()
        {
            a = r.Next(1, randomMax + 1);
        }
    }
}
