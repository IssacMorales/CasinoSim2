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
        int img1;
        int img2;
        int img3;
        public Slots()
        {
            InitializeComponent();
        }

        private void Pullbar_Scroll(object sender, EventArgs e)
        {
            if (Pullbar.Value ==1)
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
                        img1= 1;
                    }
                    else
                    {
                        pictureBox1.Image=Image.FromFile("resource/slot options/r.jpg");
                        pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
                        img1 = 1;

                    }
                    break;
                case 2:
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Dispose();
                        pictureBox1.Image = null;
                        img1 = 1;

                    }
                    else
                    {
                        pictureBox1.Image = Image.FromFile("resource/slot options/r.jpg");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        img1 = 1;

                    }
                    break;
                case 3:
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Dispose();
                        pictureBox1.Image = null;
                        img1 = 1;

                    }
                    else
                    {
                        pictureBox1.Image = Image.FromFile("resource/slot options/r.jpg");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        img1 = 1;

                    }
                    break;
                case 4:
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Dispose();
                        pictureBox1.Image = null;
                        img1 = 1;

                    }
                    else
                    {
                        pictureBox1.Image = Image.FromFile("resource/slot options/r.jpg");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        img1 = 1;

                    }
                    break;
                case 5:
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Dispose();
                        pictureBox1.Image = null;
                        img1 = 1;

                    }
                    else
                    {
                        pictureBox1.Image = Image.FromFile("resource/slot options/r.jpg");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        img1 = 1;

                    }
                    break;
                case 6:
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Dispose();
                        pictureBox1.Image = null;
                        img1 = 1;

                    }
                    else
                    {
                        pictureBox1.Image = Image.FromFile("resource/slot options/r.jpg");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        img1 = 1;

                    }
                    break;
                case 7:
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Dispose();
                        pictureBox1.Image = null;
                        img1 = 1;

                    }
                    else
                    {
                        pictureBox1.Image = Image.FromFile("resource/slot options/r.jpg");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        img1 = 1;

                    }
                    break;
                case 8:
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Dispose();
                        pictureBox1.Image = null;
                        img1 = 1;

                    }
                    else
                    {
                        pictureBox1.Image = Image.FromFile("resource/slot options/r.jpg");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        img1 = 1;

                    }
                    break;
                case 9:
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Dispose();
                        pictureBox1.Image = null;
                        img1 = 1;

                    }
                    else
                    {
                        pictureBox1.Image = Image.FromFile("resource/slot options/chad.jpg");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        img1 = 1;

                    }
                    break;
            }

        }
    }
}
