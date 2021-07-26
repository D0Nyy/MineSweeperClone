using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mines
{
    public partial class Game : Form
    {
        private Board board;
        private int time;
        private Size originalSize;
        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            originalSize = this.Size;
            time = 0;
            comboBoxDiff.SelectedIndex = 1;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelTime.Text = (++time).ToString();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            panelSettings.Enabled = false;
            panelSettings.Visible = false;
            timer.Start();

            if (comboBoxDiff.SelectedIndex == 0) // Easy
            {
                board = new Board(this, boardPanel, 15, 10);
            }
            else if (comboBoxDiff.SelectedIndex == 1) // Medium
            {
                board = new Board(this, boardPanel, 60, 20);
            }
            else if (comboBoxDiff.SelectedIndex == 2) // Hard
            {
                boardPanel.Size = new Size(600, 600);
                this.Width = this.Width + 100;
                this.Height = this.Height + 100;

                board = new Board(this, boardPanel, 120, 30);
            }

            buttonRestart.Enabled = true;
        }

        public void EndGame(bool won)
        {
            timer.Stop();
            time = 0;
            boardPanel.Enabled = false;
            if (won) MessageBox.Show("You Won!!", "Congratulations!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else boardPanel.Controls.OfType<Square>().Where(x => x.IsBomb).ToList().ForEach(x => x.ShowSquare());
        }

        private void comboBoxDiff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDiff.SelectedIndex == 0) // Easy
            {
                labelBombs.Text = "15";
                labelBombCount.Text = "20";
                labelSize.Text = "10x10";
            }
            else if (comboBoxDiff.SelectedIndex == 1) // Medium
            {
                labelBombs.Text = "60";
                labelBombCount.Text = "60";
                labelSize.Text = "20x20";
            }
            else // Hard
            {
                labelBombs.Text = "120";
                labelBombCount.Text = "120";
                labelSize.Text = "30x30";
            }
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            timer.Stop();
            time = 0;
            labelTime.Text = "0";

            boardPanel.Size = new Size(500, 500);
            this.Size = originalSize;
            boardPanel.Controls.Clear();

            panelSettings.Enabled = true;
            panelSettings.Visible = true;
            buttonRestart.Enabled = false;
        }
    }
}
