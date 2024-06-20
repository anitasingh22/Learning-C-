using System;
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

        public Snake(int _currentPoistion, int _targetpoistion)
        {
            currentPosition=_currentPoistion;
            targetPosition=_targetpoistion;
        }
    }
}
