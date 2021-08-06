using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gomoku.Properties;

namespace Gomoku
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }



        private int turns = 0;

        // 1 for black     -1 for white
        private int colors = 1;

        private List<Chess> whiteChesses = new List<Chess>();
        private List<Chess> blackChesses = new List<Chess>();

        private int[,] chessArray = new int[15, 15];

        private readonly int offsetX = 3;
        private readonly int offsetY = 3;
        private void PicBox_Board_Click(object sender, EventArgs e)
        {
            Point mousePostion = MousePosition;

            mousePostion.X -= 25;
            mousePostion.Y -= 25;

            // CheckIfOutBorad

            // CheckBoard(mousePostion);

            var pointOfBoard = PicBox_Board.PointToClient(mousePostion);

            // CheckIf the Position Is Occupied

            // CheckOccupy(pointOfBoard);



            var color = colors == 1 ? ChessColor.BLACK : ChessColor.WHITE;
            var offsetPoint = GetOffsetPoint(pointOfBoard);
            Chess newChess = new Chess()
            {
                ChessColor = color,
                Location = offsetPoint,
                Image = color == ChessColor.BLACK ? Resources.black : Resources.white,
                Name = "Chess" + "_Colors_" + color.ToString() + "_turns_" + turns, 
                Size = new Size(50, 50)
            };

            PicBox_Board.Controls.Add(newChess);
            if (newChess.ChessColor == ChessColor.BLACK)
            {
                chessArray[offsetPoint.X / chessOffset, offsetPoint.Y / chessOffset] = 1;
                // Console.WriteLine($"{offsetPoint.X / chessOffset}, {offsetPoint.Y / chessOffset}, black");
            }
            else
            {
                chessArray[offsetPoint.X / chessOffset, offsetPoint.Y / chessOffset] = -1;
                // Console.WriteLine($"{offsetPoint.X / chessOffset}, {offsetPoint.Y / chessOffset}, white");
            }

            UpdateLabel();
            var flag = CheckWin(color, offsetPoint.X / chessOffset, offsetPoint.Y / chessOffset);
            if (flag)
            {
                MessageBox.Show($"Win");
            }


            turns++;
            colors = -colors;
        }


        private int chessOffset = 54;
        private Point GetOffsetPoint(Point p)
        {
            var x = p.X - offsetX;
            var y = p.Y - offsetY;


            var modX = x % chessOffset;
            var modY = y % chessOffset;

            var divideX = x / chessOffset;
            var divideY = y / chessOffset;

            // 27 for half of chessOffset;

            if (modX > chessOffset / 2) divideX++;

            if (modY > chessOffset / 2) divideY++;

            return new Point(divideX * chessOffset + offsetX, divideY * chessOffset + offsetY);
        }

        private void CheckBoard(Point point)
        {
            // 15, 750 for Borad Size

            if (point.X < 15 || point.Y < 15) return;

            if (point.X > 750 || point.Y > 750) return;
        }

        private void CheckOccupy(Point p)
        {
            var x = p.X - offsetX;
            var y = p.Y - offsetY;


            var modX = x % chessOffset;
            var modY = y % chessOffset;

            var divideX = x / chessOffset;
            var divideY = y / chessOffset;

            if (modX > 27) divideX++;

            if (modY > 27) divideY++;
        }

        private bool CheckWin(ChessColor color, int positionX, int positionY)
        {
            if(turns < 5) return false;
            var flag = false;

            for (int i = -1; i <= 1; ++i)
            {
                for (int j = -1; j <= 1; ++j)
                {
                    if (i == 0 && j == 0) continue;

                    var nowX = positionX + i;
                    var nowY = positionY + j;
                    if (nowX < 0 || nowX > 14 || nowY < 0 || nowY > 14) continue;

                    if (chessArray[nowX, nowY] == (color == ChessColor.BLACK ? 1 : -1))
                    {
                        flag = CheckLine(nowX, nowY, i, j, color);
                        if (flag)
                        {
                            break;
                        }
                    }
                }
            }
            return flag;
        }


        private bool CheckLine(int x, int y, int i, int j, ChessColor color)
        {
            int remainX = i * 3;
            int remainY = j * 3;

            if (x + remainX < 0 || x + remainX > 14 || y + remainY < 0 || y + remainY > 14) return false;


            int times = 0;

            for (int t = 0; t < 3; ++t)
            {
                x += i;
                y += j;
                if (chessArray[x, y] == (color == ChessColor.BLACK ? 1 : -1))
                {
                    ++times;
                }
            }

            // Console.WriteLine(times);
            return times == 3 ? true : false;
        }

        private void UpdateLabel()
        {
            this.lbl_ColorOfChess.Text = colors == 1 ? "黑色" : "白色";
            this.lbl_ColorOfChess.ForeColor = colors == 1 ? Color.Black : Color.White;


            this.lbl_Turns.Text = turns.ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Restart_Click(object sender, EventArgs e)
        {
            turns = 0;
            colors = 1;
            PicBox_Board.Controls.Clear();
            chessArray = new int[15, 15];
        }
    }
}
