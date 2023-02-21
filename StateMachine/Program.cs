using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    internal class Program
    {

        static int state = 0;
        // 0 = patrolling
        // 1 = chasing
        // 2 = searching
        // 3 = attacking
        // 4 = retreating
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, we're building a State Machine!");
            Console.WriteLine("");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey(true);
        }
    }
}
