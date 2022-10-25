using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class ExactWinningPosition
    {
        public static void Check()
        {
            int StartPosition = 0;
            int CurrentPosition = 0;
            int IfLadder = 0;
            int IfSanke = 0;

            Console.WriteLine("Dice Roll Number : ");

            while(CurrentPosition < 100)
            {
                Random random = new Random();
                int dice = random.Next(1, 7);
                int option = random.Next(0,3);
                
                if(option == IfLadder)
                {
                    Console.WriteLine("Player Position is Ladder");
                    CurrentPosition += dice;
                }
                else if(option == IfSanke)
                {
                    Console.WriteLine("Player Postion is Snake");
                    CurrentPosition -= dice;
                }
                else
                {
                    Console.WriteLine("Player is No Play");
                }
                if(CurrentPosition > StartPosition)
                {
                    CurrentPosition -= StartPosition;
                }
                if(CurrentPosition > 100)
                {
                    CurrentPosition = 100;
                }
            }
            Console.WriteLine("Player Final Position after Play : " + CurrentPosition);
        }
    }
}
