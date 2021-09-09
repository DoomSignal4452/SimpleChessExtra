using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleChess
{
    class Queen : Piece
    {
        public Queen() : base("QEN") { } // Arver symbol fra Piece. Setter symbolet til Queen.



        public override bool Move(string fromPosition, string toPosition) // flytte funksjonen til Queen.
        {
            var diffCol = fromPosition[0] - toPosition[0];
            var diffRow = fromPosition[1] - toPosition[1];
            var horAndVer = fromPosition[0] == toPosition[0] || fromPosition[1] == toPosition[1];
            if (horAndVer) //Vertical and Horizontal movement
            {
                return fromPosition[0] == toPosition[0] || fromPosition[1] == toPosition[1];
            }
            else
            {
                return Math.Abs(diffRow) == Math.Abs(diffCol); // Diagonal movement
            }
        }
    }
}