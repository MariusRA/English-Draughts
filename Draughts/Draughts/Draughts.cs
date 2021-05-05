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
        PictureBox[,] board;
        int dimensXxY = 8;
        int[,] boardPositions;

        static bool pieceClicked=false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            boardPositions = new int[,]{
                {1,-1,1,-1,1,-1,1,-1 },
                {-1,1,-1,1,-1,1,-1,1 },
                {1,-1,1,-1,1,-1,1,-1 },
                {-1,-1,-1,-1,-1,-1,-1,-1 },
                {-1,-1,-1,-1,-1,-1,-1,-1 },
                {-1,1,-1,1,-1,1,-1,1 },
                {1,-1,1,-1,1,-1,1,-1 },
                {-1,1,-1,1,-1,1,-1,1 }
            };

            board = new PictureBox[dimensXxY, dimensXxY];
            boardPanel.SetBounds(100, 25, 480, 480);
            boardPanel.BackgroundImage = Properties.Resources.draughtsBoard;

            int top = 0, left = 0;

            for (int i = 0; i < 8; i++)
            {
                left = 0;

                for (int j = 0; j < 8; j++)
                {
                    if (boardPositions[i, j] == 1 && i < 4)
                    {
                        board[i, j] = new PictureBox();

                        board[i, j].Location = new Point(left, top);
                        board[i, j].Size = new Size(60, 60);
                        board[i, j].BackColor = Color.Transparent;
                        board[i, j].Image = Properties.Resources.redTransparent;
                        board[i, j].SizeMode = PictureBoxSizeMode.CenterImage;
                        left += 60;
                        boardPanel.Controls.Add(board[i, j]);
                    }
                    else if (boardPositions[i, j] == 1 && i > 4)
                    {
                        board[i, j] = new PictureBox();

                        board[i, j].Location = new Point(left, top);
                        board[i, j].Size = new Size(60, 60);
                        board[i, j].BackColor = Color.Transparent;
                        board[i, j].Image = Properties.Resources.blueTransparent;
                        board[i, j].SizeMode = PictureBoxSizeMode.CenterImage;
                        left += 60;
                        boardPanel.Controls.Add(board[i, j]);
                    }
                    else
                    {
                        board[i, j] = new PictureBox();

                        board[i, j].Location = new Point(left, top);
                        board[i, j].Size = new Size(60, 60);
                        board[i, j].BackColor = Color.Transparent;
                        left += 60;
                        boardPanel.Controls.Add(board[i, j]);
                    }

                }
                top += 60;
            }


            for (int i = 0; i < 8; i++)
            {

                for (int j = 0; j < 8; j++)
                {
                    board[i, j].MouseClick += new MouseEventHandler(clickOnPiece);

                }

            }
        }
        void clickOnPiece(object sender, EventArgs e)
        {

            if (pieceClicked == true)
            {
                PictureBox p = (PictureBox)sender;
                p.Image = Properties.Resources.redTransparent;
                p.SizeMode = PictureBoxSizeMode.CenterImage;
                pieceClicked = false;
            }
            else
            {
                PictureBox p = (PictureBox)sender;
                PictureBox temp = new PictureBox();
                temp.Image = p.Image;
                p.Image = null;
                pieceClicked = true;
            }
           

        }
    }
}
