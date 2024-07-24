using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderGame
{
    public class Snake
    {
        public int currentPosition { get; set; }
        public int targetPosition { get; set; }

        public static List<Snake> GetSnakes()
        {
            List<Snake> snakes = new List<Snake>();
            snakes.Add(new Snake(7, 3));
            snakes.Add(new Snake(9, 4));
         //   snakes.Add(new Snake(56, 12));
            return snakes;
        }

        public Snake(int currentPosition, int targetPosition)
        {
            this.currentPosition = currentPosition;
            this.targetPosition = targetPosition;
        }

        public static int CheckSnakeBite(int playerNewCalculatedPosition)
        {
            foreach (var snk in GetSnakes())
            {
                if (snk.currentPosition == playerNewCalculatedPosition)
                {
                    Console.WriteLine($"Player is on snake tile, its CurrentPosition ={snk.currentPosition} after snake bite new position= {snk.targetPosition}");
                    return snk.targetPosition;
                }
            }
            return playerNewCalculatedPosition;
        }


    }
}
