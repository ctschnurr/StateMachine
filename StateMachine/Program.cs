using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    internal class Program
    {
        enum State // enums are fundamentally ints
        {
            patrolling,
            chasing,
            searching,
            attacking,
            retreating
        }

        static State state = State.patrolling;
        static bool playerInRange = false;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, we're building a State Machine!");
            Console.WriteLine("");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey(true);
        }

        static void EnemyUpdate()
        {

            switch (state)
            {
                case State.patrolling:
                    Console.WriteLine("Patrolling...");
                    // checks if player is in range/chasable, then switches states to 1
                    if (playerInRange == true)
                    {
                        state = State.chasing;
                    }
                    break;

                case State.chasing:
                    Console.WriteLine("Chasing...");
                    // could switch to searching if the player is lost, or attacking if player is reached
                    break;

                case State.searching:
                    Console.WriteLine("Searching...");
                    // could switch to chasing if player is re-aquired, or back to patrolling if not found
                    break;

                case State.attacking:
                    Console.WriteLine("Attacking...");
                    // could switch to chasing if player gets out of range or retreating if health is low
                    break;

                case State.retreating:
                    Console.WriteLine("Retreating...");
                    // could switch back to patrolling after healing
                    break;
            }
        }
    }
}
