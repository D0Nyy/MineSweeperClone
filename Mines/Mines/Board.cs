using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mines
{
    public class Board
    {
        private Random Random { get; }
        private int MaxBombs { get;}
        private Panel BoardPanel { get; }
        private Game GameForm { get; }
        private int squareSize { get; }
        private int SizeX { get; }
        private int SizeY { get; }
        private bool Started { get; set; }
        public Board(Game game, Panel boardPanel, int maxBombs, int size)
        {
            GameForm = game;
            Random = new Random((int)DateTime.Now.Ticks);
            BoardPanel = boardPanel;
            MaxBombs = maxBombs;
            SizeX = size;
            SizeY = size;
            Started = false;

            if (size == 10) squareSize = 50;
            else if (size == 20) squareSize = 25;
            else if (size == 30) squareSize = 20;
            else squareSize = 500 / size;

            BoardPanel.Enabled = false;
            Task.Run(InitializeSquares);
            BoardPanel.Enabled = true;
        }

        private void InitializeSquares()
        {
            // Create Squares
            for (int i = 0; i < SizeY; i++)
            {
                for (int j = 0; j < SizeX; j++)
                {
                    var newSquare = new Square()
                    {
                        Size = new Size(squareSize, squareSize),
                        Location = new Point(squareSize * i, squareSize * j),
                        BorderStyle = BorderStyle.FixedSingle,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        BackColor = Color.Gray,
                    };

                    newSquare.MouseClick += Square_MouseClick;

                    BoardPanel.Invoke(new Action(() =>
                    {
                        BoardPanel.Controls.Add(newSquare);
                    }));
                }
            }
        }

        private void Square_MouseClick(object sender, MouseEventArgs e)
        {
            var square = (Square)sender;
            if (!Started)
            {
                // Create Bombs
                for (int i = 0; i < MaxBombs; i++)
                {
                    /*
                     * We place the bombs randomly in the board but not near the clicked square (5x5 area around the clicked square)
                     * We do this so the first click the user makes is never a bomb.
                     */
                    var squares = BoardPanel.Controls.OfType<Square>().Where(x => x.IsBomb == false &&
                        !x.Bounds.IntersectsWith(new Rectangle(new Point(square.Location.X - 2 * squareSize, square.Location.Y - 2 * squareSize), new Size(5 * squareSize, 5 * squareSize)))).ToList(); // get all no bomb squares
                    var bomb = squares[Random.Next(0, squares.Count)];
                    bomb.IsBomb = true;
                }

                // Runs setTouching method for all squares
                BoardPanel.Controls.OfType<Square>().ToList().ForEach(item => item.SetTouching());

                // Create empty space around the clicked square
                SearchNearEmpty(square);
                Started = true;
            }
            else
            {
                // If its a right click flag it instead
                if (e.Button == MouseButtons.Right) // flag it
                {
                    square.Flag();
                    return;
                }

                // If flagged or shown don't allow click.
                if (square.Flagged) return;
                if (square.Shown) return;

                // If its a bomb then game over.
                if (square.IsBomb)
                {
                    square.Explode();
                    GameForm.EndGame(false);
                    return;
                }

                // If its a safe square search for nearby safe squares to show.
                if (square.Touching == 0)
                {
                    SearchNearEmpty(square);
                    return;
                }

                // ShowSquare square
                square.ShowSquare();

                // Check win condition
                if (BoardPanel.Controls.OfType<Square>().Where(x => x.IsBomb == false).All(y => y.Shown)) GameForm.EndGame(true);
            }

        }

        private void SearchNearEmpty(Square around)
        {
            around.ShowSquare();
            try
            {
                // Get all squares that are not shown.
                var empty = BoardPanel.Controls.OfType<Square>().Where(x => x.Shown == false);

                // Get all squares that are near around square.
                var near = Tools.NearbySquares(empty, around).ToList();

                // Show all squares around the given that have a number.
                near.Where(x => x.Touching != 0).ToList().ForEach(x => x.ShowSquare());

                // For every square that doesn't have a number run the same thing again.
                foreach (var square in near.Where(x => x.Touching == 0))
                {
                    SearchNearEmpty(square);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
        }
    }
}
