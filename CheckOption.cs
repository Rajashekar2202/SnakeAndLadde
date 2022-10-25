using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class CheckOption
    {
        public static void Check()
        {
            int IfLadder = 1;
            int IfSnake = 2;
            int PlayerPosition = 0;
            Random random = new Random();   
            int dice = random.Next(1,7);
            int option = random.Next(0,3);

            Console.WriteLine("Dice Roll Number : " + dice);

            if(option == IfLadder)
            {
                Console.WriteLine("Dice Number is " + dice);
                Console.WriteLine("Player Position is Ladder");
                PlayerPosition +=dice;
            }
            else if (option == IfSnake)
            {
                Console.WriteLine("Dice Number is " + dice);
                Console.WriteLine("Player Position is Snake");
                PlayerPosition -= dice;
            }
            else
            {
                Console.WriteLine("Player is No Play");
            }
        }
    }
}
