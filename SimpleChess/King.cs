using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleChess
{
    class King : Piece
    {

        public King() : base("KNG")
        {
        }

        public override bool Move(string fromPosition, string toPosition)
        {

            var diffCol = fromPosition[0] - toPosition[0];
            var diffRow = fromPosition[1] - toPosition[1];

            if (Math.Abs(diffCol) > 1 || Math.Abs(diffRow) > 1) return false;
            return Math.Abs(diffCol) == 1 || Math.Abs(diffRow) == 1;

            return diffCol != 0 && diffRow != 0;
        }
    }
}
