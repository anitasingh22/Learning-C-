using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderGame
{
    public class Draw
    {
        public void DrawImage(int row, int column)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {



                    Console.Write(" * ");
                }

                Console.WriteLine();
            }
        }




        public void Draw1(int position)
        {

            for (int i = 1; i < position; i++)
            { 
                Console.Write("*");
                
            }


            Console.Write("P");


            for (int k = position + 1; k <= 10; k++)
            {
                Console.Write("*");

            }
            Console.WriteLine();
        }
    }

}
