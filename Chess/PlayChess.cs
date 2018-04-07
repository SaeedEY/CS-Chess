using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Drawing;
using System.Windows.Forms;
namespace Chess
{
    class PlayChess
    {
        //DEVELOPER DEFINED
        private string PLAYER_NAME = "Player";
        private int DIFF = 0;//0==Easy & 1==Normal & 2==Hard;
        private int COLOR = 0;//0==White & 1==Black;
        private PictureBox[][] TABLES;

        //IN CODE DEFINED
        public PlayChess()
        {
            TABLES = new PictureBox[8][];
            for (int i = 0; i < 8; i++)
                TABLES[i] = new PictureBox[8];
        }
        public void startTimer()
        {
        
        }
        public void stopTimer()
        {
        
        }
        public void setColor(int color){
            COLOR = color;
        }
        public void setTableBoxes(PictureBox[][] boxes)
        {
            TABLES = boxes;
        }
        //public bool isEmptyHome
        public void setPlayerName(string name)
        {
            PLAYER_NAME = name;
        }
        public string getPlayerName()
        {
            return PLAYER_NAME;
        }
        public string getColorName()
        {
            if (getColor() == 1)
                return "Black";
            else
                return "White";

        }
        public int getColor()
        {
            return COLOR;
        }
        public bool moveChess(int[][] last_place,int[][] new_place)
        {
            return true;
        }
    }
    class Vectors : PlayChess
    {
        private Image[][] table;
        private Image cropImage(Rectangle cropArea)
        {
            Image img = Image.FromFile("chess.png");
            Bitmap bmpImage = new Bitmap(img);
            return bmpImage.Clone(cropArea, bmpImage.PixelFormat);
        }
        public Vectors()
        {
            table = new Image[8][];
            table[0] = new Image[8];
            table[1] = new Image[8];
            table[2] = new Image[8];
            table[3] = new Image[8];
            table[4] = new Image[8];
            table[5] = new Image[8];
            table[6] = new Image[8];
            table[7] = new Image[8];
        }
        public Image emptyImage()
        {
            Image img = Image.FromFile("empty.png");
            Bitmap bmpImage = new Bitmap(img);
            return bmpImage.Clone(new Rectangle(0,0,1,1), bmpImage.PixelFormat);
        }
        public void onStart(int team) {
            if (team.Equals(1))
            {
                for (int i = 0; i < 8; i++)
                    table[i][1] = getBlackPawn();
                for (int i = 0; i < 8; i++)
                    table[i][6] = getWhitePawn();
                table[0][0] = table[7][0] = getBlackRook();
                table[1][0] = table[6][0] = getBlackKnight();
                table[2][0] = table[5][0] = getBlackBishop();
                table[3][0] = getBlackQueen();
                table[4][0] = getBlackKing();

                table[0][7] = table[7][7] = getWhiteRook();
                table[1][7] = table[6][7] = getWhiteKnight();
                table[2][7] = table[5][7] = getWhiteBishop();
                table[3][7] = getWhiteKing();
                table[4][7] = getWhiteQueen();
            }
            else
            {
                for (int i = 0; i < 8; i++)
                    table[i][6] = getBlackPawn();
                for (int i = 0; i < 8; i++)
                    table[i][1] = getWhitePawn();
                table[0][7] = table[7][7] = getBlackRook();
                table[1][7] = table[6][7] = getBlackKnight();
                table[2][7] = table[5][7] = getBlackBishop();
                table[3][7] = getBlackQueen();
                table[4][7] = getBlackKing();

                table[0][0] = table[7][0] = getWhiteRook();
                table[1][0] = table[6][0] = getWhiteKnight();
                table[2][0] = table[5][0] = getWhiteBishop();
                table[3][0] = getWhiteKing();
                table[4][0] = getWhiteQueen();
            }
        }
        public Image[][] getTable()
        {
            return table;
        }
        public Image getWhitePawn()
        {
            return cropImage(new Rectangle(320,64,64,64));
        }
        public Image getWhiteKing()
        {
            return cropImage(new Rectangle(192,64, 64, 64));
        }
        public Image getWhiteKnight()
        {
            return cropImage(new Rectangle(64, 64, 64, 64));
        }
        public Image getWhiteQueen()
        {
            return cropImage(new Rectangle(256, 64, 64, 64));
        }
        public Image getWhiteRook()
        {
            return cropImage(new Rectangle(0, 64, 64, 64));
        }
        public Image getWhiteBishop()
        {
            return cropImage(new Rectangle(128, 64, 64, 64));
        }
        public Image getBlackPawn()
        {
            return cropImage(new Rectangle(320, 0, 64, 64));
        }
        public Image getBlackKing()
        {
            return cropImage(new Rectangle(192, 0, 64, 64));
        }
        public Image getBlackKnight()
        {
            return cropImage(new Rectangle(64, 0, 64, 64));
        }
        public Image getBlackQueen()
        {
            return cropImage(new Rectangle(256, 0, 64, 64));
        }
        public Image getBlackRook()
        {
            return cropImage(new Rectangle(0, 0, 64, 64));
        }
        public Image getBlackBishop()
        {
            return cropImage(new Rectangle(128, 0, 64, 64));
        }

    }
}

