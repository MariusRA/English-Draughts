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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            board = new PictureBox[dimensXxY, dimensXxY];
            boardPanel.SetBounds(100, 25, 400, 400);
            //boardPanel.BackgroundImage = Properties.Resources.draughtsBoard;

            int top = 0, left = 0;

            for (int i = 0; i < 8; i++)
            {
                left = 0;

                for (int j = 0; j < 8; j++)
                {
                    board[i, j] = new PictureBox();
                    if (j % 2 == 0 && i % 2 != 0)
                    {
                        board[i, j].BackColor = Color.FromArgb(255, 255, 0, 0);
                    }
                    else if (j % 2 == 0 && i % 2 == 0)
                    {
                        board[i, j].BackColor = Color.FromArgb(255, 0, 255, 0);
                    }
                    else if (j % 2 != 0 && i % 2 == 0)
                    {
                        board[i, j].BackColor = Color.FromArgb(255, 0, 255, 255);
                    }
                    else
                    {
                        board[i, j].BackColor = Color.FromArgb(255, 0, 0, 255);
                    }

                    board[i, j].Location = new Point(left, top);
                    board[i, j].Size = new Size(50, 50);
                    left += 50;
                    boardPanel.Controls.Add(board[i, j]);
                }
                top += 50;
            }


        }

   
    }
}
