using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCommonSubsequence
{
    public class Cell
    {
        public enum Directions
        {
            None,
            Up,
            Left,
            /// <summary>
            /// Refers to Top,Left
            /// </summary>
            Diagonal
        }

        public int LCS { get; set; }
        public Directions Direction { get; set; }
        //backward reference so that we can backtrack
        public Cell From { get; set; }
        /// <summary>
        /// C will only have values for row 0 and column 0
        /// </summary>
        public char C { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Directions GetDirection(Cell c)
        {
            if(c.X == this.X-1 && c.Y == this.Y-1)
            {
                return Directions.Diagonal;
            }
            else if(c.X == this.X && c.Y ==  this.Y-1)
            {
                return Directions.Up;
            }
            else if (c.X == this.X-1 && c.Y == this.Y)
            {
                return Directions.Left;
            }
            else
            {
                return Directions.None;
            }
        }
    }
}
