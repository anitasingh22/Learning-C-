using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderGame
{
    public class Board
    {
        public int noOfTiles { get; set; }

        public int _column { get; set; }
        public int _row { get; set; }



        public Board(int row, int column)
        {
            _row = row;
            _column = column;

        }


        public void drawBoard()
        {
            var draw = new Draw();
            draw.DrawImage(_row, _column);

        }

        public int getNoOfTiles() {
                        return _row * _column;
        }


        public bool GameCondition(int playerPosition)
        {
            if(playerPosition>=noOfTiles)
            {
                Console.WriteLine("Player Won the Game");

                return true;
            }

            return false;
        }
    }

}
