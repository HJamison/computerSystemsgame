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
    public partial class EndGameScreen : Form
    {
        
        public EndGameScreen()
        {
            InitializeComponent();
        }

        private void EndGameScreen_Load(object sender, EventArgs e)
        {

        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            var newForm = new Game();
            newForm.Show();
            this.Hide();
        }
    }
}
