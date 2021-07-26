using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Mines
{
    public static class Tools
    {
        /* x = given square, s = returned (nearby) squares 
         * sss
         * sxs
         * sss
         */
        /// <summary>
        /// Returns a list with the nearby squares of the specified square
        /// </summary>
        /// <param name="squareList"> List of squares to search from.</param>
        /// <param name="square"> Central square.</param>
        /// <returns>List of nearby squares.</returns>
        public static IEnumerable<Square> NearbySquares(IEnumerable<Square> squareList, Square square)
        {
            try
            {
                var near = squareList.Where(x =>
                    x.Location == new Point(square.Location.X + square.Width, square.Location.Y) ||
                    x.Location == new Point(square.Location.X - square.Width, square.Location.Y) ||
                    x.Location == new Point(square.Location.X, square.Location.Y + square.Height) ||
                    x.Location == new Point(square.Location.X, square.Location.Y - square.Height) ||
                    x.Location == new Point(square.Location.X + square.Width, square.Location.Y - square.Height) ||
                    x.Location == new Point(square.Location.X - square.Width, square.Location.Y - square.Height) ||
                    x.Location == new Point(square.Location.X + square.Width, square.Location.Y + square.Height) ||
                    x.Location == new Point(square.Location.X - square.Width, square.Location.Y + square.Height)
                );
                return near;
            }
            catch (Exception)
            {
                return new List<Square>().AsEnumerable();
            }
        }
        
    }
}
