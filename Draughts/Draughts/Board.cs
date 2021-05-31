using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draughts
{
    class Board
    {
        public static int[,] boardInitialPiecesPositions = new int[,]{
                {1,-1,1,-1,1,-1,1,-1 },
                {-1,1,-1,1,-1,1,-1,1 },
                {1,-1,1,-1,1,-1,1,-1 },
                {-1,-1,-1,-1,-1,-1,-1,-1 },
                {-1,-1,-1,-1,-1,-1,-1,-1 },
                {-1,1,-1,1,-1,1,-1,1 },
                {1,-1,1,-1,1,-1,1,-1 },
                {-1,1,-1,1,-1,1,-1,1 }
       };
        public static int dimensXxY = 8;
        public Tablesquare[,] cells;    
        public Panel boardPanel;

        public Board()
        {
            this.cells = new Tablesquare[dimensXxY, dimensXxY];

            this.boardPanel = new Panel();
            this.boardPanel.SetBounds(100, 25, 480, 480);
            this.boardPanel.Visible = true;
            this.boardPanel.BackgroundImage = Properties.Resources.draughtsBoard;

            int top = 0, left = 0;

            for (int i = 0; i < 8; i++)
            {
                left = 0;

                for (int j = 0; j < 8; j++)
                {
                    cells[i, j] = new Tablesquare();                  
                    cells[i, j].Image = null;
                    cells[i, j].BackColor = Color.Transparent;
                    cells[i, j].SizeMode = PictureBoxSizeMode.CenterImage;
                    cells[i, j].Location = new Point(left, top);
                    cells[i, j].Size = new Size(60, 60);
                    cells[i, j].Visible = true;

                    if (boardInitialPiecesPositions[i, j] == 1 && i < 4)
                    {
                        cells[i, j].piece = new Piece();
                        cells[i, j].piece.color = PieceColor.redPiece;
                        cells[i, j].piece.lineposition = top / 60;
                        cells[i, j].piece.columnposition = left / 60;
                        cells[i, j].piece.type = PieceType.normalPiece;
                        cells[i, j].Image = Properties.Resources.redTransparent;                                              
                        left += 60;                       
                    }
                    else if (boardInitialPiecesPositions[i, j] == 1 && i > 4)
                    {
                        cells[i, j].piece = new Piece();
                        cells[i, j].piece.color = PieceColor.bluePiece;
                        cells[i, j].piece.lineposition = top / 60;
                        cells[i, j].piece.columnposition = left / 60;
                        cells[i, j].piece.type = PieceType.normalPiece;
                        cells[i, j].Image = Properties.Resources.blueTransparent;
                        left += 60;
                    }
                    else
                    {
                        left += 60;
                    }
                    boardPanel.Controls.Add(cells[i, j]);

                }
                top += 60;
            }
        }
    }
}
