using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class ReportingDetails
    {
        public static void Check()
        {
            
            int CurrentPosition = 0;
            int IfLadder = 0;
            int IfSanke = 0;

            Console.WriteLine("Dice Roll Number : ");

            while (CurrentPosition < 100)
            {
                Random random = new Random();
                int dice = random.Next(1, 7);
                int option = random.Next(0, 3);

                if (option == IfLadder)
                {
                    Console.WriteLine("Player Position is Ladder");
                    CurrentPosition += dice;
                }
                else if (option == IfSanke)
                {
                    Console.WriteLine("Player Postion is Snake");
                    CurrentPosition -= dice;
                }
                else
                {
                    Console.WriteLine("Player is No Play");
                }

                Console.WriteLine("Player Final Position after Play: " + CurrentPosition);
                Console.WriteLine("Number of Times The Die was Played to Win The Game: " );

            }
        }
    }
}
