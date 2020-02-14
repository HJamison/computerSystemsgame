using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumansVsZombies
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            var newForm = new Game();
            newForm.Show();
            this.Hide();
        }

        private void highscore_Click(object sender, EventArgs e)
        {
            var newForm = new highScoreScreen();
            newForm.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            var newForm = new highScoreScreen();
            newForm.Show();
            this.Hide();
        }
    }
}
