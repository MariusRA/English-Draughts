using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draughts
{
    class Game
    {
        public static Board gameboard;
        public PieceColor turn;

        public List<List<int>> availableMovesRed;
        public List<List<int>> availableMovesBlue;
        public List<List<int>> takeMovesRed;
        public List<List<int>> takeMovesBlue;
        public List<List<int>> availableMovesKing;
        public List<List<int>> takeMovesKing;

        public Game()
        {
            gameboard = new Board();
            turn = PieceColor.bluePiece;

        }
        public void getAvailableMovesNormalPieces()
        {
            availableMovesRed = new List<List<int>>();
            availableMovesBlue = new List<List<int>>();
            takeMovesRed = new List<List<int>>();
            takeMovesBlue = new List<List<int>>();

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (Game.gameboard.cells[i, j].piece != null && Game.gameboard.cells[i, j].piece.color == PieceColor.redPiece && Game.gameboard.cells[i, j].piece.type == PieceType.normalPiece)
                    {
                        if (i + 1 < 8 && j + 1 < 8)
                        {
                            if (Game.gameboard.cells[i + 1, j + 1].piece == null)
                            {
                                List<int> movesForPiece = new List<int>();
                                movesForPiece.Add(i);
                                movesForPiece.Add(j);
                                movesForPiece.Add(i + 1);
                                movesForPiece.Add(j + 1);
                                availableMovesRed.Add(movesForPiece);

                            }
                        }
                        if (i + 1 < 8 && j - 1 >= 0)
                        {
                            if (Game.gameboard.cells[i + 1, j - 1].piece == null)
                            {
                                List<int> movesForPiece = new List<int>();
                                movesForPiece.Add(i);
                                movesForPiece.Add(j);
                                movesForPiece.Add(i + 1);
                                movesForPiece.Add(j - 1);
                                availableMovesRed.Add(movesForPiece);
                            }
                        }
                    }

                    if (Game.gameboard.cells[i, j].piece != null && Game.gameboard.cells[i, j].piece.color == PieceColor.bluePiece && Game.gameboard.cells[i, j].piece.type == PieceType.normalPiece)
                    {
                        if (i - 1 >= 0 && j + 1 < 8)
                        {

                            if (Game.gameboard.cells[i - 1, j + 1].piece == null)
                            {
                                List<int> movesForPiece = new List<int>();
                                movesForPiece.Add(i);
                                movesForPiece.Add(j);
                                movesForPiece.Add(i - 1);
                                movesForPiece.Add(j + 1);
                                availableMovesBlue.Add(movesForPiece);

                            }
                        }

                        if (i - 1 >= 0 && j - 1 >= 0)
                        {

                            if (Game.gameboard.cells[i - 1, j - 1].piece == null)
                            {
                                List<int> movesForPiece = new List<int>();
                                movesForPiece.Add(i);
                                movesForPiece.Add(j);
                                movesForPiece.Add(i - 1);
                                movesForPiece.Add(j - 1);
                                availableMovesBlue.Add(movesForPiece);

                            }
                        }
                    }

                    if (Game.gameboard.cells[i, j].piece != null && Game.gameboard.cells[i, j].piece.color == PieceColor.redPiece && Game.gameboard.cells[i, j].piece.type == PieceType.normalPiece)
                    {
                        if ((i + 2 < 8) && (j + 2 < 8) && gameboard.cells[i + 1, j + 1].piece != null && gameboard.cells[i + 1, j + 1].piece.color == PieceColor.bluePiece)
                        {
                            if (Game.gameboard.cells[i + 2, j + 2].piece == null)
                            {
                                List<int> takeMovesForPiece = new List<int>();
                                takeMovesForPiece.Add(i);
                                takeMovesForPiece.Add(j);
                                takeMovesForPiece.Add(i + 2);
                                takeMovesForPiece.Add(j + 2);
                                takeMovesRed.Add(takeMovesForPiece);

                            }
                        }
                        if ((i + 2 < 8) && (j - 2 >= 0) && gameboard.cells[i + 1, j - 1].piece != null && gameboard.cells[i + 1, j - 1].piece.color == PieceColor.bluePiece)
                        {
                            if (Game.gameboard.cells[i + 2, j - 2].piece == null)
                            {
                                List<int> takeMovesForPiece = new List<int>();
                                takeMovesForPiece.Add(i);
                                takeMovesForPiece.Add(j);
                                takeMovesForPiece.Add(i + 2);
                                takeMovesForPiece.Add(j - 2);
                                takeMovesRed.Add(takeMovesForPiece);
                            }
                        }
                    }

                    if (Game.gameboard.cells[i, j].piece != null && Game.gameboard.cells[i, j].piece.color == PieceColor.bluePiece && Game.gameboard.cells[i, j].piece.type == PieceType.normalPiece)
                    {
                        if ((i - 2 >= 0) && (j + 2 < 8) && gameboard.cells[i - 1, j + 1].piece != null && gameboard.cells[i - 1, j + 1].piece.color == PieceColor.redPiece)
                        {
                            if (Game.gameboard.cells[i - 2, j + 2].piece == null)
                            {
                                List<int> takeMovesForPiece = new List<int>();
                                takeMovesForPiece.Add(i);
                                takeMovesForPiece.Add(j);
                                takeMovesForPiece.Add(i - 2);
                                takeMovesForPiece.Add(j + 2);
                                takeMovesBlue.Add(takeMovesForPiece);

                            }
                        }
                        if ((i - 2 >= 0) && (j - 2 >= 0) && gameboard.cells[i - 1, j - 1].piece != null && gameboard.cells[i - 1, j - 1].piece.color == PieceColor.redPiece)
                        {
                            if (Game.gameboard.cells[i - 2, j - 2].piece == null)
                            {
                                List<int> takeMovesForPiece = new List<int>();
                                takeMovesForPiece.Add(i);
                                takeMovesForPiece.Add(j);
                                takeMovesForPiece.Add(i - 2);
                                takeMovesForPiece.Add(j - 2);
                                takeMovesBlue.Add(takeMovesForPiece);
                            }
                        }
                    }
                }
            }
        }
        public void getAvailableMovesKingPieces()
        {
            availableMovesKing = new List<List<int>>();
            takeMovesKing = new List<List<int>>();

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (Game.gameboard.cells[i, j].piece != null && Game.gameboard.cells[i, j].piece.type == PieceType.kingPiece)
                    {
                        if (i + 1 < 8 && j + 1 < 8)
                        {
                            if (Game.gameboard.cells[i + 1, j + 1].piece == null)
                            {
                                List<int> movesForPiece = new List<int>();
                                movesForPiece.Add(i);
                                movesForPiece.Add(j);
                                movesForPiece.Add(i + 1);
                                movesForPiece.Add(j + 1);
                                availableMovesKing.Add(movesForPiece);

                            }
                        }
                        if (i + 1 < 8 && j - 1 >= 0)
                        {
                            if (Game.gameboard.cells[i + 1, j - 1].piece == null)
                            {
                                List<int> movesForPiece = new List<int>();
                                movesForPiece.Add(i);
                                movesForPiece.Add(j);
                                movesForPiece.Add(i + 1);
                                movesForPiece.Add(j - 1);
                                availableMovesKing.Add(movesForPiece);
                            }
                        }
                        if (i - 1 >= 0 && j + 1 < 8)
                        {

                            if (Game.gameboard.cells[i - 1, j + 1].piece == null)
                            {
                                List<int> movesForPiece = new List<int>();
                                movesForPiece.Add(i);
                                movesForPiece.Add(j);
                                movesForPiece.Add(i - 1);
                                movesForPiece.Add(j + 1);
                                availableMovesKing.Add(movesForPiece);

                            }
                        }

                        if (i - 1 >= 0 && j - 1 >= 0)
                        {

                            if (Game.gameboard.cells[i - 1, j - 1].piece == null)
                            {
                                List<int> movesForPiece = new List<int>();
                                movesForPiece.Add(i);
                                movesForPiece.Add(j);
                                movesForPiece.Add(i - 1);
                                movesForPiece.Add(j - 1);
                                availableMovesKing.Add(movesForPiece);

                            }
                        }

                    }

                    if (Game.gameboard.cells[i, j].piece != null && Game.gameboard.cells[i, j].piece.type == PieceType.kingPiece)
                    {
                        if ((i + 2 < 8) && (j + 2 < 8) && gameboard.cells[i + 1, j + 1].piece != null && gameboard.cells[i + 1, j + 1].piece.color != Game.gameboard.cells[i, j].piece.color)
                        {
                            if (Game.gameboard.cells[i + 2, j + 2].piece == null)
                            {
                                List<int> takeMovesForPiece = new List<int>();
                                takeMovesForPiece.Add(i);
                                takeMovesForPiece.Add(j);
                                takeMovesForPiece.Add(i + 2);
                                takeMovesForPiece.Add(j + 2);
                                takeMovesKing.Add(takeMovesForPiece);

                            }
                        }
                        if ((i + 2 < 8) && (j - 2 >= 0) && gameboard.cells[i + 1, j - 1].piece != null && gameboard.cells[i + 1, j - 1].piece.color != Game.gameboard.cells[i, j].piece.color)
                        {
                            if (Game.gameboard.cells[i + 2, j - 2].piece == null)
                            {
                                List<int> takeMovesForPiece = new List<int>();
                                takeMovesForPiece.Add(i);
                                takeMovesForPiece.Add(j);
                                takeMovesForPiece.Add(i + 2);
                                takeMovesForPiece.Add(j - 2);
                                takeMovesKing.Add(takeMovesForPiece);
                            }
                        }

                        if ((i - 2 >= 0) && (j + 2 < 8) && gameboard.cells[i - 1, j + 1].piece != null && gameboard.cells[i - 1, j + 1].piece.color != Game.gameboard.cells[i, j].piece.color)
                        {
                            if (Game.gameboard.cells[i - 2, j + 2].piece == null)
                            {
                                List<int> takeMovesForPiece = new List<int>();
                                takeMovesForPiece.Add(i);
                                takeMovesForPiece.Add(j);
                                takeMovesForPiece.Add(i - 2);
                                takeMovesForPiece.Add(j + 2);
                                takeMovesKing.Add(takeMovesForPiece);

                            }
                        }
                        if ((i - 2 >= 0) && (j - 2 >= 0) && gameboard.cells[i - 1, j - 1].piece != null && gameboard.cells[i - 1, j - 1].piece.color != Game.gameboard.cells[i, j].piece.color)
                        {
                            if (Game.gameboard.cells[i - 2, j - 2].piece == null)
                            {
                                List<int> takeMovesForPiece = new List<int>();
                                takeMovesForPiece.Add(i);
                                takeMovesForPiece.Add(j);
                                takeMovesForPiece.Add(i - 2);
                                takeMovesForPiece.Add(j - 2);
                                takeMovesKing.Add(takeMovesForPiece);
                            }
                        }
                    }
                }
            }
        }
        public List<Tuple<int, int>> movesForNormalPiece(int line, int column, PieceColor color)
        {
            List<Tuple<int, int>> moves = new List<Tuple<int, int>>();
            if (color == PieceColor.redPiece && Game.gameboard.cells[line, column].piece.type == PieceType.normalPiece)
            {
                foreach (var listOfMoves in availableMovesRed)
                {
                    if (listOfMoves[0] == line && listOfMoves[1] == column)
                    {
                        Tuple<int, int> to = new Tuple<int, int>(listOfMoves[2], listOfMoves[3]);
                        moves.Add(to);
                    }
                }
            }
            if (color == PieceColor.bluePiece && Game.gameboard.cells[line, column].piece.type == PieceType.normalPiece)
            {
                foreach (var listOfMoves in availableMovesBlue)
                {
                    if (listOfMoves[0] == line && listOfMoves[1] == column)
                    {
                        Tuple<int, int> to = new Tuple<int, int>(listOfMoves[2], listOfMoves[3]);
                        moves.Add(to);
                    }
                }
            }

            return moves;
        }
        public List<Tuple<int, int>> movesForKing(int line, int column, PieceColor color)
        {
            List<Tuple<int, int>> moves = new List<Tuple<int, int>>();

            foreach (var listOfMoves in availableMovesKing)
            {
                if (listOfMoves[0] == line && listOfMoves[1] == column)
                {
                    Tuple<int, int> to = new Tuple<int, int>(listOfMoves[2], listOfMoves[3]);
                    moves.Add(to);
                }
            }

            return moves;
        }
        public List<Tuple<int, int>> takeMovesForCurrentPiece(int line, int column, PieceColor color)
        {
            List<Tuple<int, int>> moves = new List<Tuple<int, int>>();
            if (color == PieceColor.redPiece)
            {
                foreach (var listOfMoves in takeMovesRed)
                {
                    if (listOfMoves[0] == line && listOfMoves[1] == column)
                    {
                        Tuple<int, int> to = new Tuple<int, int>(listOfMoves[2], listOfMoves[3]);
                        moves.Add(to);
                    }
                }
            }
            if (color == PieceColor.bluePiece)
            {
                foreach (var listOfMoves in takeMovesBlue)
                {
                    if (listOfMoves[0] == line && listOfMoves[1] == column)
                    {
                        Tuple<int, int> to = new Tuple<int, int>(listOfMoves[2], listOfMoves[3]);
                        moves.Add(to);
                    }
                }
            }

            return moves;
        }
        public List<Tuple<int, int>> takeMovesForKing(int line, int column, PieceColor color)
        {
            List<Tuple<int, int>> moves = new List<Tuple<int, int>>();
            foreach (var listOfMoves in takeMovesKing)
            {
                if (listOfMoves[0] == line && listOfMoves[1] == column)
                {
                    Tuple<int, int> to = new Tuple<int, int>(listOfMoves[2], listOfMoves[3]);
                    moves.Add(to);
                }
            }
            return moves;
        }
        public List<Tuple<int, int>> getPiecesCoordinates(PieceColor color)
        {
            List<Tuple<int, int>> pieces = new List<Tuple<int, int>>();

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (Game.gameboard.cells[i, j].piece != null && Game.gameboard.cells[i, j].piece.color == color)
                    {
                        Tuple<int, int> pieceCoordinates = new Tuple<int, int>(i, j);
                        pieces.Add(pieceCoordinates);
                    }
                }
            }

            return pieces;
        }
        public void movePiece(int oldrow, int oldcolumn, int newrow, int newcolumn, Board gameboard)
        {
            gameboard.cells[newrow, newcolumn].piece = new Piece();
            gameboard.cells[newrow, newcolumn].piece.lineposition = newrow;
            gameboard.cells[newrow, newcolumn].piece.columnposition = newcolumn;
            gameboard.cells[newrow, newcolumn].piece.color = gameboard.cells[oldrow, oldcolumn].piece.color;
            gameboard.cells[newrow, newcolumn].piece.type = gameboard.cells[oldrow, oldcolumn].piece.type;
            gameboard.cells[newrow, newcolumn].Image = gameboard.cells[oldrow, oldcolumn].Image;

            //gameboard.cells[oldrow, oldcolumn].piece.lineposition = -1;
            //gameboard.cells[oldrow, oldcolumn].piece.columnposition = -1;
            gameboard.cells[oldrow, oldcolumn].piece = null;
            gameboard.cells[oldrow, oldcolumn].Image = null;

        }
        public List<int> randomNormalMoveAI(Board gameboard)
        {
            List<List<int>> allMovesForReds = new List<List<int>>();
            List<int> pieceToBeMoved = new List<int>();

            foreach (var list in availableMovesRed)
            {
                allMovesForReds.Add(list);
            }

            foreach (var list in availableMovesKing)
            {
                if (gameboard.cells[list[0], list[1]].piece.color == PieceColor.redPiece)
                {
                    allMovesForReds.Add(list);
                }

            }

            Random rand = new Random();
            int index = rand.Next(allMovesForReds.Count() - 1);
            pieceToBeMoved = allMovesForReds[index];

            return pieceToBeMoved;
        }
        public List<int> randomTakeMoveAI(Board gameboard)
        {
            List<List<int>> allTakeMovesForReds = new List<List<int>>();
            List<int> pieceToBeMoved = new List<int>();

            foreach (var list in takeMovesRed)
            {
                allTakeMovesForReds.Add(list);
            }

            foreach (var list in takeMovesKing)
            {
                if (gameboard.cells[list[0], list[1]].piece.color == PieceColor.redPiece)
                {
                    allTakeMovesForReds.Add(list);
                }

            }
            Random rand = new Random();
            if (allTakeMovesForReds.Count() != 0)
            {
                int index = rand.Next(allTakeMovesForReds.Count() - 1);
                pieceToBeMoved = allTakeMovesForReds[index];
            }
            return pieceToBeMoved;
        }
        public void takePiece(int oldrow, int oldcolumn, int newrow, int newcolumn, Board gameboard)
        {
            if (gameboard.cells[oldrow, oldcolumn].piece != null && gameboard.cells[oldrow, oldcolumn].piece.color == PieceColor.redPiece && Game.gameboard.cells[oldrow, oldcolumn].piece.type == PieceType.normalPiece)
            {
                gameboard.cells[newrow, newcolumn].piece = new Piece();
                gameboard.cells[newrow, newcolumn].piece.lineposition = newrow;
                gameboard.cells[newrow, newcolumn].piece.columnposition = newcolumn;
                gameboard.cells[newrow, newcolumn].piece.color = gameboard.cells[oldrow, oldcolumn].piece.color;
                gameboard.cells[newrow, newcolumn].piece.type = gameboard.cells[oldrow, oldcolumn].piece.type;
                gameboard.cells[newrow, newcolumn].Image = gameboard.cells[oldrow, oldcolumn].Image;

                gameboard.cells[oldrow, oldcolumn].piece = null;
                gameboard.cells[oldrow, oldcolumn].Image = null;

                if (oldcolumn - newcolumn > 0)
                {
                    gameboard.cells[oldrow + 1, oldcolumn - 1].piece = null;
                    gameboard.cells[oldrow + 1, oldcolumn - 1].Image = null;
                }
                else
                {
                    gameboard.cells[oldrow + 1, oldcolumn + 1].piece = null;
                    gameboard.cells[oldrow + 1, oldcolumn + 1].Image = null;
                }
            }
            if (gameboard.cells[oldrow, oldcolumn].piece != null && gameboard.cells[oldrow, oldcolumn].piece.color == PieceColor.bluePiece && Game.gameboard.cells[oldrow, oldcolumn].piece.type == PieceType.normalPiece)
            {
                gameboard.cells[newrow, newcolumn].piece = new Piece();
                gameboard.cells[newrow, newcolumn].piece.lineposition = newrow;
                gameboard.cells[newrow, newcolumn].piece.columnposition = newcolumn;
                gameboard.cells[newrow, newcolumn].piece.color = gameboard.cells[oldrow, oldcolumn].piece.color;
                gameboard.cells[newrow, newcolumn].Image = gameboard.cells[oldrow, oldcolumn].Image;

                gameboard.cells[oldrow, oldcolumn].piece = null;
                gameboard.cells[oldrow, oldcolumn].Image = null;

                if (oldcolumn - newcolumn > 0)
                {
                    gameboard.cells[oldrow - 1, oldcolumn - 1].piece = null;
                    gameboard.cells[oldrow - 1, oldcolumn - 1].Image = null;
                }
                else
                {
                    gameboard.cells[oldrow - 1, oldcolumn + 1].piece = null;
                    gameboard.cells[oldrow - 1, oldcolumn + 1].Image = null;
                }
            }

            if (gameboard.cells[oldrow, oldcolumn].piece != null && Game.gameboard.cells[oldrow, oldcolumn].piece.type == PieceType.kingPiece)
            {
                gameboard.cells[newrow, newcolumn].piece = new Piece();
                gameboard.cells[newrow, newcolumn].piece.lineposition = newrow;
                gameboard.cells[newrow, newcolumn].piece.columnposition = newcolumn;
                gameboard.cells[newrow, newcolumn].piece.color = gameboard.cells[oldrow, oldcolumn].piece.color;
                gameboard.cells[newrow, newcolumn].piece.type = gameboard.cells[oldrow, oldcolumn].piece.type;
                gameboard.cells[newrow, newcolumn].Image = gameboard.cells[oldrow, oldcolumn].Image;

                gameboard.cells[oldrow, oldcolumn].piece = null;
                gameboard.cells[oldrow, oldcolumn].Image = null;

                if (oldcolumn - newcolumn > 0 && oldrow - newrow < 0)
                {
                    gameboard.cells[oldrow + 1, oldcolumn - 1].piece = null;
                    gameboard.cells[oldrow + 1, oldcolumn - 1].Image = null;
                }
                if (oldcolumn - newcolumn < 0 && oldrow - newrow < 0)
                {
                    gameboard.cells[oldrow + 1, oldcolumn + 1].piece = null;
                    gameboard.cells[oldrow + 1, oldcolumn + 1].Image = null;
                }
                if (oldcolumn - newcolumn > 0 && oldrow - newrow > 0)
                {
                    gameboard.cells[oldrow - 1, oldcolumn - 1].piece = null;
                    gameboard.cells[oldrow - 1, oldcolumn - 1].Image = null;
                }
                if (oldcolumn - newcolumn < 0 && oldrow - newrow > 0)
                {
                    gameboard.cells[oldrow - 1, oldcolumn + 1].piece = null;
                    gameboard.cells[oldrow - 1, oldcolumn + 1].Image = null;
                }

            }

        }
        public void showAvailableMovesToUser(List<Tuple<int, int>> moves, PieceColor turn, Board gameboard)
        {
            foreach (var pair in moves)
            {
                var line = pair.Item1;
                var column = pair.Item2;

                if (turn == PieceColor.redPiece)
                {
                    gameboard.cells[line, column].BorderStyle = BorderStyle.Fixed3D;
                    gameboard.cells[line, column].BackColor = Color.Red;
                }
                else
                {
                    gameboard.cells[line, column].BorderStyle = BorderStyle.Fixed3D;
                    gameboard.cells[line, column].BackColor = Color.Blue;
                }
            }
        }
        public void clearAvailableMovesAfterClick(List<Tuple<int, int>> moves, Board gameboard)
        {
            foreach (var pair in moves)
            {
                int line = pair.Item1;
                int column = pair.Item2;
                gameboard.cells[line, column].BorderStyle = BorderStyle.None;
                gameboard.cells[line, column].BackColor = Color.Black;
            }
        }
        public void promotePiece(Board gameboard)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (gameboard.cells[i, j].piece != null)
                    {
                        if (gameboard.cells[i, j].piece.type == PieceType.normalPiece && gameboard.cells[i, j].piece.color == PieceColor.bluePiece && i == 0)
                        {
                            gameboard.cells[i, j].piece.type = PieceType.kingPiece;
                            gameboard.cells[i, j].Image = Properties.Resources.blueKingTransparent;
                        }
                        if (gameboard.cells[i, j].piece.type == PieceType.normalPiece && gameboard.cells[i, j].piece.color == PieceColor.redPiece && i == 7)
                        {
                            gameboard.cells[i, j].piece.type = PieceType.kingPiece;
                            gameboard.cells[i, j].Image = Properties.Resources.redKingTransparent;
                        }
                    }
                }
            }
        }

    }
}
