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
        public string name { get; set; }
        public int DiceNo { get; set; }

        public int MovePlayer(int diceNo , int actualposition)
        {
            position = actualposition;
            var newCalculatedPosition=position + diceNo;
            return newCalculatedPosition;
        }

        public int PlayerRollDice()
        {

            Random rnd = new Random();
            var diceNumber = rnd.Next(1, 7);
            Console.WriteLine($"Player Rolled a dice and a no = {diceNumber}");
            return diceNumber;
        }

        public void SetPlayerName(string name)
        {
            this.name = name;
        }

        public void SetPlayerPosition(int position)
        {
            this.position = position;
        }

        public int CheckPlayerPosition(int diceNo)
        {
            var playerNewCalculatedPosition = MovePlayer(diceNo, position);
            var snakeBitePosition = Snake.CheckSnakeBite(playerNewCalculatedPosition);
            var ladderClimbPosition = Ladder.CheckLadderClimb(snakeBitePosition);
           return position = ladderClimbPosition; 
        }
        

    }
}
