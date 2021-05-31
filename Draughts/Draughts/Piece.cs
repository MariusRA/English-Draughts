using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draughts
{
    public enum PieceType
    {
        normalPiece = 0,
        kingPiece = 1
    };

    public enum PieceColor
    {
        redPiece = 0,
        bluePiece = 1
    };

    class Piece
    {
        public PieceColor color;
        public int lineposition;
        public int columnposition;
        public PieceType type;

        public List<Tuple<int, int>> possiblePieceMoves;

        public Piece()
        {
            possiblePieceMoves = new List<Tuple<int, int>>();
        }
    }
}
