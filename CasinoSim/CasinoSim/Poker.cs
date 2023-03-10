using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        private string[] hands = new string[5];
     
        private bool FirstDraw=true;
        public Poker()
        {
            InitializeComponent();





        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Card1 = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Card2 = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            Card3 = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Card4 = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Card5 = false;
        }
        private void Randomizer(PictureBox p,int t)
        {
            Random r = new Random();
            int ran = r.Next(0, 52);
            while (hands.Contains(cards[ran]))
            {

                ran = r.Next(0, 52);

            }
            hands[t-1] = cards[ran];
            p.Image = Image.FromFile(cards[ran]);
            p.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FirstDraw == false)
            {
               
                checkHand();
                FirstDraw = !FirstDraw;
            }
            else
            {
                if (Card1 == true)
                {
                    Randomizer(pictureBox1, 1);
                }
                if (Card2 == true)
                {
                    Randomizer(pictureBox2, 2);
                }
                if (Card3 == true)
                {
                    Randomizer(pictureBox3, 3);
                }
                if (Card4 == true)
                {
                    Randomizer(pictureBox4, 4);
                }
                if (Card5 == true)
                {
                    Randomizer(pictureBox5, 5);
                }
                FirstDraw = !FirstDraw;


            }

        }
        private void checkHand() {
            string newCardNum="";
            string newCardSuit="";
            int[] value= new int[5];
            string[] values=new string[5];
           
                for (int i = 0; i < hands.Length; i++)
                {
                    string testcard = hands[i];

                    switch (testcard)
                    {
                        case var _ when testcard.Contains("10"):
                            newCardNum = "10";
                            break;
                        case var _ when testcard.Contains("2"):
                            newCardNum = "2";
                            break;
                        case var _ when testcard.Contains("3"):
                            newCardNum = "3";
                            break;
                        case var _ when testcard.Contains("4"):
                            newCardNum = "4";
                            break;
                        case var _ when testcard.Contains("5"):
                            newCardNum = "5";
                            break;
                        case var _ when testcard.Contains("6"):
                            newCardNum = "6";
                            break;
                        case var _ when testcard.Contains("7"):
                            newCardNum = "7";
                            break;
                        case var _ when testcard.Contains("8"):
                            newCardNum = "8";
                            break;
                        case var _ when testcard.Contains("9"):
                            newCardNum = "9";
                            break;
                        case var _ when testcard.Contains("jack"):
                            newCardNum = "11";
                            break;
                        case var _ when testcard.Contains("queen"):
                            newCardNum = "12";
                            break;
                        case var _ when testcard.Contains("king"):
                            newCardNum = "13";
                            break;
                        case var _ when testcard.Contains("ace"):
                            newCardNum = "1";
                            break;
                        default:
                            newCardNum = "MISTAKE";
                            break;
                    }

                switch (testcard)
                {
                    case var _ when testcard.Contains("heart"):
                        newCardSuit = "h";
                        break;
                    case var _ when testcard.Contains("spade"):
                        newCardSuit = "s";
                        break;
                    case var _ when testcard.Contains("club"):
                        newCardSuit = "c";
                        break;
                    case var _ when testcard.Contains("diam"):
                        newCardSuit = "d";
                        break;
                }
                value[i] = int.Parse(newCardNum);

                values[i] = newCardSuit;
                }
            Straight(value[0], values[0], value[1], values[1], value[2], values[2], value[3], values[3], value[4], values[4]);
            }
        private void Straight(int one, string ones, int two,string twos,int three, string threes,int four,string fours,int five,string fives )
        {
            if ((one-- == two || one++ == two) && (one-- == two || one++ == two)&& (one-- == two || one++ == two)&& (one-- == two || one++ == two))
            {

            }

        }
        } 
}
