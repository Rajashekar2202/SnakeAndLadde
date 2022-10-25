using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class RollsTheDie
    {
        public static void Check()
        {
            Random random = new Random();
            int die = random.Next(1,7);
            Console.WriteLine("Rolling The Die : " + die);
        }
    }
}
