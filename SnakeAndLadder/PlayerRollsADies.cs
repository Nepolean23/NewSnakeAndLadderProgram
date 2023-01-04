using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public  class PlayerRollsADies
    {
        public static void RollDies()
        {
            //Variables
            int Player1;
            int Position = 0;
                                    // Generates random number for Die
            Random random= new Random();
            int Die=random.Next(0,7);
            Console.WriteLine("The Player rolles a dies to move position at :"+Die);
        }
    }
}
