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
        int bet;
        int start = Money.buck;
        public Slots()
        {
            InitializeComponent();
            Mons.Text = start.ToString();
        }

        private void Pullbar_Scroll(object sender, EventArgs e)
        {
            if (Pullbar.Value <=1)
            {
                int.TryParse(BetBox.Text, out bet);

                Spin();
                Pullbar.Value = 10;
               
            }
        }
        public void Spin()
        {
            Random ran = new Random();
           int img= ran.Next(1, 10);
            int imgr = ran.Next(1, 10);
            int imgrr = ran.Next(1, 10);

            switch (img)
            {
                case 1:
                    if (pictureBox1.Image != null)
                    {
                        
                        ;
                        img1 = 1;
                    }


                    pictureBox1.Image = Image.FromFile("resource/slot options/r.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    img1 = 1;


                    break;
                case 2:
                    if (pictureBox1.Image != null)
                    {
                        
                        ;
                        img1 = 2;

                    }


                    pictureBox1.Image = Image.FromFile("resource/slot options/Reeeeeeeeeeeeeee.png");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    img1 = 2;


                    break;
                case 3:
                    if (pictureBox1.Image != null)
                    {
                        
                        ;
                        img1 = 3;

                    }


                    pictureBox1.Image = Image.FromFile("resource/slot options/the-rock-sus.gif");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    img1 = 3;


                    break;
                case 4:
                    if (pictureBox1.Image != null)
                    {
                        
                        ;
                        img1 = 4;

                    }


                    pictureBox1.Image = Image.FromFile("resource/slot options/chad.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    img1 = 4;


                    break;
                case 5:
                    if (pictureBox1.Image != null)
                    {
                        
                        ;
                        img1 = 5;

                    }


                    pictureBox1.Image = Image.FromFile("resource/slot options/20220916_235217.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    img1 = 5;


                    break;
                case 6:
                    if (pictureBox1.Image != null)
                    {
                        
                        ;
                        img1 = 6;

                    }


                    pictureBox1.Image = Image.FromFile("resource/slot options/45zlnq.png");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    img1 = 6;


                    break;
                case 7:
                    if (pictureBox1.Image != null)
                    {
                        
                        ;
                        img1 = 7;

                    }


                    pictureBox1.Image = Image.FromFile("resource/slot options/Shaq.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    img1 = 7;


                    break;
                case 8:
                    if (pictureBox1.Image != null)
                    {
                        
                        ;
                        img1 = 8;

                    }


                    pictureBox1.Image = Image.FromFile("resource/slot options/americanpsycho.png");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    img1 = 8;


                    break;
                case 9:
                    if (pictureBox1.Image != null)
                    {
                        
                        ;
                        img1 = 9;

                    }


                    pictureBox1.Image = Image.FromFile("resource/slot options/chad.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    img1 = 9;


                    break;
            }
                        switch (imgr)
            {
                case 1:
                    if(pictureBox2.Image!= null)
                    {
                        
                        ;
                        img2= 1;
                    }
                    
                    
                        pictureBox2.Image=Image.FromFile("resource/slot options/r.jpg");
                        pictureBox2.SizeMode=PictureBoxSizeMode.StretchImage;
                        img2 = 1;

                    
                    break;
                case 2:
                    if (pictureBox2.Image != null)
                    {
                        
                        ;
                        img2 = 2;

                    }
                    
                    
                        pictureBox2.Image = Image.FromFile("resource/slot options/Reeeeeeeeeeeeeee.png");
                        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                        img2 = 2;

                    
                    break;
                case 3:
                    if (pictureBox2.Image != null)
                    {
                        
                        ;
                        img2 = 3;

                    }
                    
                    
                        pictureBox2.Image = Image.FromFile("resource/slot options/the-rock-sus.gif");
                        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                        img2 = 3;

                    
                    break;
                case 4:
                    if (pictureBox2.Image != null)
                    {
                        
                        ;
                        img2 = 4;

                    }
                    
                    
                        pictureBox2.Image = Image.FromFile("resource/slot options/chad.jpg");
                        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                        img2 = 4;

                    
                    break;
                case 5:
                    if (pictureBox2.Image != null)
                    {
                        
                        ;
                        img2 = 5;

                    }
                    
                    
                        pictureBox2.Image = Image.FromFile("resource/slot options/20220916_235217.jpg");
                        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                        img2 = 5;

                    
                    break;
                case 6:
                    if (pictureBox2.Image != null)
                    {
                        
                        ;
                        img2 = 6;

                    }
                    
                    
                        pictureBox2.Image = Image.FromFile("resource/slot options/45zlnq.png");
                        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                        img2 = 6;

                    
                    break;
                case 7:
                    if (pictureBox2.Image != null)
                    {
                        
                        ;
                        img2 = 7;

                    }
                    
                    
                        pictureBox2.Image = Image.FromFile("resource/slot options/Shaq.jpg");
                        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                        img2 = 7;

                    
                    break;
                case 8:
                    if (pictureBox2.Image != null)
                    {
                        
                        ;
                        img2 = 8;

                    }
                    
                    
                        pictureBox2.Image = Image.FromFile("resource/slot options/americanpsycho.png");
                        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                        img2 = 8;

                    
                    break;
                case 9:
                    if (pictureBox2.Image != null)
                    {
                        
                        ;
                        img2 = 9;

                    }
                    
                    
                        pictureBox2.Image = Image.FromFile("resource/slot options/chad.jpg");
                        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    img2 = 9;

                    
                    break;
            }
                        switch (imgrr)
            {
                case 1:
                    if(pictureBox3.Image!= null)
                    {
                        
                        pictureBox3.Image = null;
                        img3= 1;
                    }
                    
                    
                        pictureBox3.Image=Image.FromFile("resource/slot options/r.jpg");
                        pictureBox3.SizeMode=PictureBoxSizeMode.StretchImage;
                        img3 = 1;

                    
                    break;
                case 2:
                    if (pictureBox3.Image != null)
                    {
                        
                        pictureBox3.Image = null;
                        img3 = 2;

                    }
                    
                    
                        pictureBox3.Image = Image.FromFile("resource/slot options/Reeeeeeeeeeeeeee.png");
                        pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                        img3 = 2;

                    
                    break;
                case 3:
                    if (pictureBox3.Image != null)
                    {
                        
                        pictureBox3.Image = null;
                        img3 = 3;

                    }
                    
                    
                        pictureBox3.Image = Image.FromFile("resource/slot options/the-rock-sus.gif");
                        pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                        img3 = 3;

                    
                    break;
                case 4:
                    if (pictureBox3.Image != null)
                    {
                        
                        pictureBox3.Image = null;
                        img3 = 4;

                    }
                    
                    
                        pictureBox3.Image = Image.FromFile("resource/slot options/chad.jpg");
                        pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                        img3 = 4;

                    
                    break;
                case 5:
                    if (pictureBox3.Image != null)
                    {
                        
                        pictureBox3.Image = null;
                        img3 = 5;

                    }
                    
                    
                        pictureBox3.Image = Image.FromFile("resource/slot options/20220916_235217.jpg");
                        pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                        img3 = 5;

                    
                    break;
                case 6:
                    if (pictureBox3.Image != null)
                    {
                        
                        pictureBox3.Image = null;
                        img3 = 6;

                    }
                    
                    
                        pictureBox3.Image = Image.FromFile("resource/slot options/45zlnq.png");
                        pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                        img3 = 6;

                    
                    break;
                case 7:
                    if (pictureBox3.Image != null)
                    {
                        
                        pictureBox3.Image = null;
                        img3 = 7;

                    }
                    
                    
                        pictureBox3.Image = Image.FromFile("resource/slot options/Shaq.jpg");
                        pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                        img3 = 7;

                    
                    break;
                case 8:
                    if (pictureBox3.Image != null)
                    {
                        
                        pictureBox3.Image = null;
                        img3 = 8;

                    }
                    
                    
                        pictureBox3.Image = Image.FromFile("resource/slot options/americanpsycho.png");
                        pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                        img3 = 8;

                    
                    break;
                case 9:
                    if (pictureBox3.Image != null)
                    {
                        
                        pictureBox3.Image = null;
                        img3 = 9;

                    }
                    
                    
                        pictureBox3.Image = Image.FromFile("resource/slot options/chad.jpg");
                        pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    img3 = 9;

                    
                    break;
            }
            if (img3==img2&&img2==img1) {
                Money.buck += bet*img1 * 10;
                Mons.Text = Money.buck.ToString();

            }
            else
            {
                Money.buck -= bet;
                Mons.Text = Money.buck.ToString();

            }
        }

        private void Keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                BetBox.Text += e.KeyChar;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 f=new Form1();
            f.Show();
            this.Dispose();
        }
    }
}
