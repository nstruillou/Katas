using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpnCalculator.Observer;

namespace RpnCalculator.View
{
    public class ConsolePrompt : IObserver
    {
        private const string ConsolePrefix = "RPN Calculator > ";

        private bool isRunning = false;

        public void Run()
        {
            this.isRunning = true;
            while (isRunning)
            {
                Console.Write(ConsolePrefix);
                string command = Console.ReadLine();
                this.InterpretCommand(command);
            }
        }

        private void InterpretCommand(string command)
        {
            if (command == "quit")
            {

            }

            Console.WriteLine(command);
        }


        public void Update(string output)
        {
            Console.WriteLine(output);
        }

    }
}
