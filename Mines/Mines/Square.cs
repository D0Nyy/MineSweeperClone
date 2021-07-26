using System.Drawing;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace Mines
{
    public class Square : PictureBox
    {
        public int Touching { get; set; }
        public bool Flagged { get; set; }
        public bool IsBomb { get; set; }
        public bool Shown { get; set; }
        public Square()
        {
            this.Flagged = false;
            this.Touching = 0;
            this.IsBomb = false;
            this.Shown = false;
        }

        /// <summary>
        /// Explodes the mine.
        /// </summary>
        public void Explode()
        {
            this.Shown = true;
            this.BackColor = Color.Red;
            this.Image = Properties.Resources.bomb;
            var SoundPlayer = new SoundPlayer(Properties.Resources.Explosion_3);
            SoundPlayer.Play();
        }

        /// <summary>
        /// Adds or removes the flag from this square.
        /// </summary>
        public void Flag()
        {
            if (this.Shown) return;

            if (Flagged)
            {
                this.Flagged = false;
                this.Image = null;
                return;
            }

            this.Flagged = true;
            this.Image = Properties.Resources.flag_icon;
        }

        /// <summary>
        /// Sets Touching value.
        /// </summary>
        public void SetTouching()
        {
            Touching = 0;
            var touchingSquares = Tools.NearbySquares(this.Parent.Controls.OfType<Square>(), this);
            Touching = touchingSquares.Count(x => x.IsBomb);
        }

        /// <summary>
        /// Shows the square
        /// </summary>
        public void ShowSquare()
        {
            if (this.Shown) return;

            this.Shown = true;
            this.BackColor = Color.LightGray;

            if (this.IsBomb)
            {
                this.Image = Properties.Resources.bomb;
                return;
            }

            switch (Touching)
            {
                case 1:
                    this.Image = Properties.Resources._1;
                    return;
                case 2:
                    this.Image = Properties.Resources._2;
                    return;
                case 3:
                    this.Image = Properties.Resources._3;
                    return;
                case 4:
                    this.Image = Properties.Resources._4;
                    return;
                case 5:
                    this.Image = Properties.Resources._5;
                    return;
                case 6:
                    this.Image = Properties.Resources._6;
                    return;
                case 7:
                    this.Image = Properties.Resources._7;
                    return;
                case 8:
                    this.Image = Properties.Resources._8;
                    return;
            }
        }
    }
}
