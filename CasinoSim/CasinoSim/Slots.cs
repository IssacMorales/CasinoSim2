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
    public partial class Slots : Form
    {
        public Slots()
        {
            InitializeComponent();
        }

        private void Pullbar_Scroll(object sender, EventArgs e)
        {
            if (Pullbar.Value <= 2)
            {
                Spin();
            }
        }
        public void Spin()
        {
            Random ran = new Random();
           int img= ran.Next(1, 10);
            switch (img)
            {
                case 1:
                    if(pictureBox1.Image!= null)
                    {
                        pictureBox1.Dispose();
                        pictureBox1.Image = null;
                    }
                    else
                    {
                        pictureBox1.Image=Image.FromFile("resource/slot options/r.jpg");
                        pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;   
                    }
                    break;
            }

        }
    }
}
