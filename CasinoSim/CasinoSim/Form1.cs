namespace CasinoSim
{
    public partial class Form1 : Form
    {
        private static int buck;
        public Form1()
        {
            InitializeComponent();
        }

        private void Roulettebtn_Click(object sender, EventArgs e)
        {
            Roulette r = new Roulette();
            r.Show();
            this.Hide();
        }
        private static void calc()
        {
            buck = Money.buck;
        }
      
    }
}