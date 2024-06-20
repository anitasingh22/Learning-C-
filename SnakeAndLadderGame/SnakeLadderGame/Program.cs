// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;
using SnakeLadderGame;

Console.WriteLine("Hello, World!");


var board =new Board();
board.noOfTiles=72;

var player= new Pawn();

int actualPosition=1;

List <Snake> snakes = new List<Snake>();
snakes.Add(new Snake(16,6));
snakes.Add(new Snake(46, 23));
snakes.Add(new Snake(56, 12));


List<Ladder> ladder = new List<Ladder>();
ladder.Add(new Ladder(4, 36));
ladder.Add(new Ladder(25, 67));
ladder.Add(new Ladder(50, 71));

Console.WriteLine("LadderPosition");


while(actualPosition<72)
{
    Random rnd = new Random();
    var diceNumber=rnd.Next(1, 7);

    Console.WriteLine($"Player Rolled a dice and a no = {diceNumber}");

    var playerNewCalculatedPosition= player.MovePlayer(diceNumber,actualPosition);
    actualPosition = playerNewCalculatedPosition;

    foreach (var snk in snakes)
    {
        if (snk.currentPosition== playerNewCalculatedPosition)
        {
            actualPosition= snk.targetPosition;
            Console.WriteLine($"Player is on snake tile, its CurrentPosition ={snk.currentPosition} after snake bite new position= {actualPosition}");
            break;
        }
    }

    foreach (var ladd in ladder)
    {
       
        if (ladd.currentPosition == playerNewCalculatedPosition)
        {
            actualPosition = ladd.targetPosition;
            Console.WriteLine($"Player need to take ladder, its CurrentPosition ={ladd.currentPosition} and new position= {actualPosition}");
            break;
        }
    }


    if (actualPosition >= 72)
    {
        Console.WriteLine($"Player is at Winning Position = {actualPosition}");
        break;
    }
      
    
}


