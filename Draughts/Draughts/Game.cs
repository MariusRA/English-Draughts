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
        public static Tablesquare temporarySquare;
        public static PieceColor selectedPieceColor;

        public List<List<int>> availableMovesRed = new List<List<int>>();
        public List<List<int>> availableMovesBlue = new List<List<int>>();
        //lista pt mutari la fiecare piesa

        public Game()
        {
            gameboard = new Board();
            turn = PieceColor.bluePiece;

        }
        public void getAvailableMoves()
        {
            availableMovesRed = new List<List<int>>();
            availableMovesBlue = new List<List<int>>();

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (Game.gameboard.cells[i, j].piece != null && Game.gameboard.cells[i, j].piece.color == PieceColor.redPiece)
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

                    if (Game.gameboard.cells[i, j].piece != null && Game.gameboard.cells[i, j].piece.color == PieceColor.bluePiece)
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


                }
            }
        }
        public List<Tuple<int, int>> movesForCurrentPiece(int line, int column, PieceColor color)
        {
            List<Tuple<int, int>> moves = new List<Tuple<int, int>>();
            if (color == PieceColor.redPiece)
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
            if (color == PieceColor.bluePiece)
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
            gameboard.cells[newrow, newcolumn].Image = gameboard.cells[oldrow, oldcolumn].Image;

            //gameboard.cells[oldrow, oldcolumn].piece.lineposition = -1;
            //gameboard.cells[oldrow, oldcolumn].piece.columnposition = -1;
            gameboard.cells[oldrow, oldcolumn].piece = null;
            gameboard.cells[oldrow, oldcolumn].Image = null;

        }
        public void showAvailableMovesToUser(List<Tuple<int,int>>moves, PieceColor turn, Board gameboard)
        {
            foreach(var pair in moves)
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
            foreach(var pair in moves)
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

        //metoda mutare pentru piese normale 
        //metoda capturare piesa pentru piesa normala
        //metoda mutare king
        //metoda capturare king
    }
}
