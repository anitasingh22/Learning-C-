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

    }

    
}
