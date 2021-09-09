using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleChess
{
    class Pawn : Piece
    {
        public bool IsFirst;

        public Pawn() : base("PWN")
        {
            IsFirst = true;
        }

        public override bool Move(string fromPosition, string toPosition)
        {
            var diffCol = fromPosition[0] - toPosition[0];
            var diffRow = fromPosition[1] - toPosition[1];

            if (diffRow == -2 && diffCol == 0 && IsFirst == true)
            {
                IsFirst = false;
                return true;
            }
            if (diffRow == -1 && diffCol == 0)
            {
                IsFirst = false;
                return true;
            }
            if (diffRow == -1 && (diffCol == -1 || diffCol == 1))
            {
                // only for pawn taking out other pieces

                // check for occupied spot missing
                // currently NOT possible to take out other pieces

                //IsFirst = false;
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
// negative numbers to move up the board.

//diffRow  diffCol   ja/nei
//1          -1       nei 
//1           0       nei
//1           1       nei

//0          -1       nei 
//0           0       nei
//0           1       nei

//-1         -1       ja - hvis det står en brikke der
//-1          0       ja 
//-1          1       ja - hvis det står en brikke der   

//-2          0       ja - hvis første trekk


