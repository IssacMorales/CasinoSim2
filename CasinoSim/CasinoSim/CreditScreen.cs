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
    public partial class CreditScreen : Form
    {
        public CreditScreen()
        {
            InitializeComponent();
        }

        private void CreditScreen_Load(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
                        
               Form1 mm = new Form1();
                mm.Show();
                this.Hide();
 
        }
    }
}
