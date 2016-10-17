using System;
using RpnCalculator.Controller;
using RpnCalculator.Observer;

namespace RpnCalculator.View
{
    public class ConsolePrompt : IObserver
    {
        private const string ConsolePrefix = "RPN Calculator > ";
        private bool isRunning = false;
        private RpnControler rpnControler;

        public ConsolePrompt(RpnControler controler)
        {
            this.rpnControler = controler;
            this.rpnControler.RpnConsole = this;
        }

        public event EventHandler CommandExecuted;

        public void ClearConsole(object sender, EventArgs e)
        {
            Console.Clear();
        }

        public void CloseApplication(object sender, EventArgs e)
        {
            this.isRunning = false;
        }

        public void DisplayHelp(object sender, EventArgs e)
        {
            Console.WriteLine("For more information on a specify command, type help command-name.");
            Console.WriteLine("clear    Clears the screen.");
            Console.WriteLine("help     Provides help information for application commands.");
            Console.WriteLine("quit     Quits the progam.");
        }

        public void DisplayInvalidExpression(object sender, EventArgs e)
        {
            Console.WriteLine("Invalid characters has been provided in the RPN Expression. Please use only numbers and operators (+-*/)");
        }

        public void InvokeAction()
        {
            if (this.CommandExecuted != null)
            {
                this.CommandExecuted(this, EventArgs.Empty);
            }
        }

        public void Run()
        {
            this.isRunning = true;
            while (isRunning)
            {
                Console.Write(ConsolePrefix);
                string command = Console.ReadLine();
                this.rpnControler.Command = command;
            }
        }

        public void Update(string output)
        {
            Console.WriteLine(output);
        }
    }
}