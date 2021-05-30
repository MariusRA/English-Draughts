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

            this.Controls.Add(Game.gameboard.boardPanel);

            draughtsGame.showAvailableMoves();
            foreach (var cell in Game.gameboard.cells) 
            {
                cell.Click += pieceClick;
            }
        }
        void pieceClick(object sender, EventArgs e)
        {
            Game.click = true;

            Tablesquare temp = sender as Tablesquare;
            draughtsGame.showAvailableMoves();

            if (temp.piece.color == PieceColor.redPiece)
            {
                foreach(var list in Game.availableMovesRed)
                {
                    if(list[0]==temp.piece.lineposition && list[1] == temp.piece.columnposition)
                    {
                       
                    }
                }
            }

        }
    }
}
