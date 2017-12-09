using System;

namespace EX2
{
    class Program
    {
        static void Main(string[] args)
        {
            var steps = new string[] { "a", "a", "a", "a", "a", "c", "d", "b" };
            var stateMachine = new StateMachine();
            var lastStep = stateMachine.Run(steps);
            Console.WriteLine(lastStep);
            Console.ReadKey();
        }
    }
}