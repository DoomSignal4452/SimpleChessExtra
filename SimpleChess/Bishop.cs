using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleChess
{
    class Bishop : Piece  // Bishop arver alt fra klassen Piece
    {
        public Bishop() : base("LØP") { } // Denne linjen arver Symbol fra class Piece. Og setter symbolet til Class Bishop.



        public override bool Move(string fromPosition, string toPosition) //flytte funksjonen til Bishop
        {
            var diffCol = fromPosition[0] - toPosition[0];
            var diffRow = fromPosition[1] - toPosition[1];
            return Math.Abs(diffRow) == Math.Abs(diffCol);
        }
    }
}
