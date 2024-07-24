using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderGame
{
    public class Ladder
    {
        public int currentPosition { get; set; }
        public int targetPosition { get; set; }

        public Ladder(int _currentPosition, int _targetPosition)
        {

            currentPosition= _currentPosition;
            targetPosition= _targetPosition;
        }



        public static List<Ladder> GetLadder()
        {
            List<Ladder> ladder = new List<Ladder>();
            ladder.Add(new Ladder(4, 8));
            ladder.Add(new Ladder(2, 6));
            //ladder.Add(new Ladder(50, 71));

            return ladder;
        }


        public static int CheckLadderClimb(int playerNewCalculatedPosition)
        {
            foreach (var Lad in GetLadder())
            {
                if (Lad.currentPosition == playerNewCalculatedPosition)
                {
                    Console.WriteLine($"Player is on ladder tile, its CurrentPosition ={Lad.currentPosition} after climbing ladder new position= {Lad.targetPosition}");
                    return Lad.targetPosition;
                }
            }
            return playerNewCalculatedPosition;
        }

    }

    
}
