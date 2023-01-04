using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class PlayerChecksForOption
    {
        public const int NoPlay= 1;
        public const int Ladder= 2;
        public const int Sanke = 3;
        public static void Option()
        {
            //Variables
            
            int Position=0;
            
            // Generates random number for Die
            Random random = new Random();
            int Die = random.Next(0, 7);
            Console.WriteLine("The Player rolles a dies to move position at :" + Die);

            int option=random.Next(0, 4);
            switch(option)  //Player checks for options
            {
                case NoPlay:
                    Console.WriteLine("The Player is at No-Play Position");
                    break;

                case Ladder:
                    Console.WriteLine("The Player Moves In Ladder At Position :");
                    Position += Die;
                    Console.Write(+Position);
                    break;

                case Sanke:
                    Console.WriteLine("The Player is Bitten By Snake At Position :");
                    Position-= Die;
                    Console.WriteLine(+Position);
                    break;
                    
            }
        }
    }
    }
}
