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
      
    public partial class Poker : Form
    {
        private bool Card1 = true;
        private bool Card2 = true; 
        private bool Card3 = true;
        private bool Card4 = true;
        private bool Card5 = true;
        private string[] cards = Directory.GetFiles("CARDS").OrderBy(f => f).ToArray();

        public Poker()
        {
            InitializeComponent();

            pictureBox3.Image = Image.FromFile(cards[0]);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Card1= false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Card2= false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        
            Card3 = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Card4= false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Card5= false;
        }
    }
}
