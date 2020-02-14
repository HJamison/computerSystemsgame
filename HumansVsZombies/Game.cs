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

    public partial class Game : Form
    {
        public int diff;

        public Game()
        {
            if (diff == 0)
            {
                Button[,] btn = new Button[50, 50];
                InitializeComponent();
                // grid generator 
                for (int x = 0; x < btn.GetLength(0); x++)         // Loop for x
                {
                    for (int y = 0; y < btn.GetLength(1); y++)     // Loop for y
                    {

                        btn[x, y] = new Button();
                        btn[x, y].SetBounds((7 * x) + 220, (7 * y) + 50, 7, 7);
                        btn[x, y].BackColor = Color.White;
                        Controls.Add(btn[x, y]);
                    }
                }

            }
            else
            {
                Button[,] btn = new Button[80, 80];
                InitializeComponent();
                // grid generator 
                for (int x = 0; x < btn.GetLength(0); x++)         // Loop for x
                {
                    for (int y = 0; y < btn.GetLength(1); y++)     // Loop for y
                    {

                        btn[x, y] = new Button();
                        btn[x, y].SetBounds((7 * x) + 220, (7 * y) + 50, 7, 7);
                        btn[x, y].BackColor = Color.White;
                        Controls.Add(btn[x, y]);
                    }
                }
            }

        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void gamePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Game_KeyDown(object sender, KeyEventArgs w)
        {
            if (w.KeyCode == Keys.Left)
            {
                MessageBox.Show("Success");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new Game();
            newForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newForm = new MainMenu();
            newForm.Show();
            this.Hide();
        }
    }
}
