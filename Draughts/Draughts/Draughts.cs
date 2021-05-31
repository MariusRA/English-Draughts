using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draughts
{

    public partial class Form1 : Form
    {
        Game draughtsGame = new Game();
        public bool click = false;
        public bool flag = false;
        static int oldr, oldc;
        static int newr, newc;
        static List<Tuple<int, int>> currentPossibleMoves;

        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            redP.SizeMode = PictureBoxSizeMode.CenterImage;
            redP.Location = new Point(600, 90);
            redCaptured.Location = new Point(670, 105);

            blueP.SizeMode = PictureBoxSizeMode.CenterImage;
            blueP.Location = new Point(600, 390);
            blueCaptured.Location = new Point(670, 405);

            button1.Location = new Point(600, 575);
            lTurn.Location = new Point(650, 240);

            this.Controls.Add(Game.gameboard.boardPanel);

            if (draughtsGame.turn == PieceColor.redPiece)
            {
                lTurn.Text = "Red";
            }
            else
            {
                lTurn.Text = "Blue";
            }

            draughtsGame.getAvailableMoves();
            enableClick(draughtsGame.getPiecesCoordinates(draughtsGame.turn), true);
            disableClickWhiteSquares();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form newform = new Form();
            newform.SetBounds(100, 10, 600, 600);
            TextBox tb = new TextBox();
            tb.SetBounds(110, 30, 400, 400);
            tb.Multiline = true;
            newform.Controls.Add(tb);

            List<Tuple<int, int>> rrr = new List<Tuple<int, int>>();
            rrr = draughtsGame.getPiecesCoordinates(PieceColor.redPiece);

            List<Tuple<int, int>> rr = new List<Tuple<int, int>>();
            rr = draughtsGame.getPiecesCoordinates(PieceColor.bluePiece);

            foreach (var elem in rrr)
            {
                tb.Text += elem + Environment.NewLine;

            }
            tb.Text += Environment.NewLine;

            foreach (var elem in rr)
            {
                tb.Text += elem + Environment.NewLine;

            }
            newform.Show();

        }

        private void disableClickWhiteSquares()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if ((i + j) % 2 != 0)
                    {
                        Game.gameboard.cells[i, j].Enabled = false;
                    }

                }
            }
        }

        private void enableClick(List<Tuple<int, int>> pieces, bool enable)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Game.gameboard.cells[i, j].MouseClick += onTableClick;
                }
            }
        }

        private void onTableClick(object sender, EventArgs e)
        {

            Tablesquare t = sender as Tablesquare;

            draughtsGame.getAvailableMoves();

            if (!click)
            {
                if (t.piece != null)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (Game.gameboard.cells[i, j].Equals(sender))
                            {
                                oldr = i;
                                oldc = j;
                            }
                        }
                    }
                    t.piece.possiblePieceMoves = draughtsGame.movesForCurrentPiece(t.piece.lineposition, t.piece.columnposition, draughtsGame.turn);
                    t.piece.takeMoves = draughtsGame.takeMovesForCurrentPiece(t.piece.lineposition, t.piece.columnposition, draughtsGame.turn);
                    if (t.piece.takeMoves.Count() != 0)
                    {
                        flag = true;
                        currentPossibleMoves = draughtsGame.takeMovesForCurrentPiece(t.piece.lineposition, t.piece.columnposition, draughtsGame.turn);
                        draughtsGame.showAvailableMovesToUser(t.piece.takeMoves, draughtsGame.turn, Game.gameboard);
                    }
                    else
                    {
                        flag = false;
                        currentPossibleMoves = draughtsGame.movesForCurrentPiece(t.piece.lineposition, t.piece.columnposition, draughtsGame.turn);
                        draughtsGame.showAvailableMovesToUser(t.piece.possiblePieceMoves, draughtsGame.turn, Game.gameboard);
                    }
                                    
                    if (currentPossibleMoves.Count() != 0)
                    {
                        click = true;
                    }

                }
                else
                {
                    click = false;
                }

            }
            else
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (Game.gameboard.cells[i, j].Equals(sender))
                        {
                            newr = i;
                            newc = j;
                        }
                    }
                }
                if (Game.gameboard.cells[newr, newc].piece != null)
                {
                    click = false;
                    draughtsGame.clearAvailableMovesAfterClick(currentPossibleMoves, Game.gameboard);
                }
                else
                {
                    Tuple<int, int> destination = new Tuple<int, int>(newr, newc);
                    if (Game.gameboard.cells[newr, newc].piece == null)
                    {
                        if (currentPossibleMoves.Contains(destination))
                        {
                            if (flag == true)
                            {
                                draughtsGame.takePiece(oldr, oldc, newr, newc, Game.gameboard);
                                if (draughtsGame.turn == PieceColor.redPiece)
                                {
                                    redCaptured.Text = (Int16.Parse(redCaptured.Text) + 1).ToString();
                                }
                                else
                                {
                                    blueCaptured.Text = (Int16.Parse(blueCaptured.Text) + 1).ToString();
                                }
                                draughtsGame.clearAvailableMovesAfterClick(currentPossibleMoves, Game.gameboard);
                                click = false;
                                draughtsGame.turn = draughtsGame.turn == PieceColor.bluePiece ? PieceColor.redPiece : PieceColor.bluePiece;
                                flag = false;
                            }
                            else
                            {
                                draughtsGame.movePiece(oldr, oldc, newr, newc, Game.gameboard);
                                draughtsGame.clearAvailableMovesAfterClick(currentPossibleMoves, Game.gameboard);
                                click = false;
                                draughtsGame.turn = draughtsGame.turn == PieceColor.bluePiece ? PieceColor.redPiece : PieceColor.bluePiece;
                                
                            }
                            

                            if (draughtsGame.turn == PieceColor.redPiece)
                            {
                                lTurn.Text = "Red";
                            }
                            else
                            {
                                lTurn.Text = "Blue";
                            }
                        }

                    }
                }

            }
            draughtsGame.promotePiece(Game.gameboard);
        }
    }
}
