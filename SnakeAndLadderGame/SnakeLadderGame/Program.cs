// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;
using SnakeLadderGame;

Console.WriteLine("Hello, World!");


var board =new Board(10,10);
board.noOfTiles=10;
board.drawBoard();
var player= new Pawn();

int actualPosition=1;


//List <Snake> snakes = new List<Snake>();
//snakes.Add(new Snake(16,6));
//snakes.Add(new Snake(46, 23));
//snakes.Add(new Snake(56, 12));



//List<Ladder> ladder = new List<Ladder>();
//ladder.Add(new Ladder(4, 36));
//ladder.Add(new Ladder(25, 67));
//ladder.Add(new Ladder(50, 71));

Console.WriteLine("LadderPosition");


while(true)
{

    var diceNumber=player.PlayerRollDice();
 

   var playerNewCalculatedPosition = player.CheckPlayerPosition(diceNumber);
    actualPosition = playerNewCalculatedPosition;


    var draw =new Draw();
    draw.Draw1(actualPosition);



    bool status = board.GameCondition(actualPosition);

    if (status)
    {
        break;
    }

}


