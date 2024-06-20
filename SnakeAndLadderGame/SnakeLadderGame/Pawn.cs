using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderGame
{
    public class Pawn
    {
        public int position { get; set; } = 1;

        public int MovePlayer(int diceNo , int actualposition)
        {
            position = actualposition;
            var newCalculatedPosition=position + diceNo;
            return newCalculatedPosition;
        }


    }
}
