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
        public static bool click = false;

        public static List<List<int>> availableMovesRed = new List<List<int>>();
        public static List<List<int>> availableMovesBlue = new List<List<int>>();

        public Game()
        {
            gameboard = new Board();
            hoverOnPiece(gameboard);
        }

        public void hoverOnPiece(Board gameboard)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    gameboard.cells[i, j].MouseHover += (sender2, e2) =>
                    {
                        showAvailableMoves();
                        Tablesquare p = sender2 as Tablesquare;
                        if (p.Image != null && p.piece.color == PieceColor.redPiece)
                        {
                            p.BackColor = Color.FromArgb(255, 64, 64, 64);
                            foreach (var list in Game.availableMovesRed)
                            {
                                if (list[0] == p.piece.lineposition && list[1] == p.piece.columnposition)
                                {
                                    Game.gameboard.cells[list[2], list[3]].BorderStyle = BorderStyle.Fixed3D;
                                    Game.gameboard.cells[list[2], list[3]].BackColor = Color.Red;
                                }
                            }

                        }
                        else if (p.Image != null && p.piece.color == PieceColor.bluePiece)
                        {
                            foreach (var list in Game.availableMovesBlue)
                            {
                                p.BackColor = Color.FromArgb(255, 64, 64, 64);
                                if (list[0] == p.piece.lineposition && list[1] == p.piece.columnposition)
                                {
                                    Game.gameboard.cells[list[2], list[3]].BorderStyle = BorderStyle.Fixed3D;
                                    Game.gameboard.cells[list[2], list[3]].BackColor = Color.Blue;
                                }
                            }
                        }


                    };

                    gameboard.cells[i, j].MouseLeave += (sender2, e2) =>
                    {
                        showAvailableMoves();
                        Tablesquare p = sender2 as Tablesquare;
                       
                        if (p.Image != null && p.piece.color == PieceColor.redPiece)
                        {
                            p.BackColor = Color.Black;
                            foreach (var list in Game.availableMovesRed)
                            {
                                if (list[0] == p.piece.lineposition && list[1] == p.piece.columnposition)
                                {
                                    Game.gameboard.cells[list[2], list[3]].BorderStyle = BorderStyle.None;
                                    Game.gameboard.cells[list[2], list[3]].BackColor = Color.Black;
                                }
                            }

                        }
                        else if (p.Image != null && p.piece.color == PieceColor.bluePiece)
                        {
                            foreach (var list in Game.availableMovesBlue)
                            {
                                p.BackColor = Color.Black;
                                if (list[0] == p.piece.lineposition && list[1] == p.piece.columnposition)
                                {
                                    Game.gameboard.cells[list[2], list[3]].BorderStyle = BorderStyle.None;
                                    Game.gameboard.cells[list[2], list[3]].BackColor = Color.Black;
                                }
                            }
                        }

                    };
                }
            }
        }

        public void showAvailableMoves()
        {
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
                                Game.availableMovesRed.Add(movesForPiece);

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
                                Game.availableMovesRed.Add(movesForPiece);
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
                                Game.availableMovesBlue.Add(movesForPiece);

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
                                Game.availableMovesBlue.Add(movesForPiece);

                            }
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
