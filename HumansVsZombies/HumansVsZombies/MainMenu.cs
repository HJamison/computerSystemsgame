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
       // public Player newPlayer = new Player();
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

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void highscoreBtn_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Use WASD to move, The black dote is you! You have to collect as many gold items before the zombies eat you!");
        }
    }
}
