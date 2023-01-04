using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class PlayerExactWiningPosition
    {
        public const int NoPlay = 1;
        public const int Ladder = 2;
        public const int Sanke = 3;

        public static void ExactWining()
        {
           
        
            //Variables

            int position = 0;
            int winPosition = 100;
            int currentPosition = 0;

            // Generates random number for Die
            Random random = new Random();
            int Die = random.Next(0, 7);
            Console.WriteLine("The Player rolles a dies to move position at :" + Die);

            while (position < winPosition) //looping untill the condition is true
            {
                int option = random.Next(0, 4);


                switch (option)  //Player checks for options
                {
                    case NoPlay:
                        Console.WriteLine("The Player is at No-Play Position");
                        break;

                    case Ladder:


                        if (position < winPosition)
                        {
                            Console.WriteLine("The Player Moves In Ladder At Position :");
                            currentPosition += Die;
                            Console.Write(+currentPosition);
                            position = currentPosition;
                        }

                        else if(position>winPosition)
                        {
                            currentPosition = position;

                        }
                        break;

                    case Sanke:

                        if (position < winPosition)
                        {
                            Console.WriteLine("The Player is Bitten By Snake At Position :");
                            currentPosition -= Die;
                            Console.WriteLine(+currentPosition);
                            position = currentPosition;
                        }
                        else if(position>winPosition)
                        {
                            currentPosition = position;
                        }
                        break;



                }
                Console.WriteLine("The Final position is :" + currentPosition);
            }

        }
    }
}
