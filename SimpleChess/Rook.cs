using System.Text;
using System.Threading.Tasks;

namespace SimpleChess
{
    class Rook : Piece // Rook arver alt fra Class Piece
    {

        public Rook() : base("TRN") { } // Arver symbol fra Piece. Setter symbolet til Rook.



        public override bool Move(string fromPosition, string toPosition) // flytte funksjonen til Rook.
        {
            return fromPosition[0] == toPosition[0] || fromPosition[1] == toPosition[1];
        }
    }
}