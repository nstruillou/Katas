using System;
using RpnCalculator.Event;
using RpnCalculator.Model;
using RpnCalculator.View;
namespace RpnCalculator.Controller
{
    public class RpnControler
    {
        private string command;
        private AbstractCalculator rpnCalculator;
        private ConsolePrompt rpnConsole;

        public RpnControler(AbstractCalculator calculator)
        {
            this.rpnCalculator = calculator;
        }

        public string Command
        {
            get
            {
                return this.command;
            }
            set
            {
                this.command = value;
                this.OnCommandChanged(new CommandChangedEventArgs(command));
            }
        }

        public ConsolePrompt RpnConsole
        {
            get
            {
                return this.rpnConsole;
            }
            set
            {
                this.rpnConsole = value;
            }
        }

        protected virtual void OnCommandChanged(CommandChangedEventArgs e)
        {
            switch(e.Command)
            {
                case "quit":
                    this.InvokeConsoleAction(this.rpnConsole.CloseApplication);
                    break;
                case "clear":
                    this.InvokeConsoleAction(this.rpnConsole.ClearConsole);
                    break;
                case "help":
                    this.InvokeConsoleAction(this.rpnConsole.DisplayHelp);
                    break;
                default:
                    if (ExpressionValidator.ValidateRpnExpression(e.Command))
                    {
                        this.rpnCalculator.Calculate(e.Command);
                    }
                    else
                    {
                        this.InvokeConsoleAction(this.rpnConsole.DisplayInvalidExpression);
                    }
                    break;
            }
        }

        private void InvokeConsoleAction(EventHandler handler)
        {
            this.rpnConsole.CommandExecuted += handler;
            this.rpnConsole.InvokeAction();
            this.rpnConsole.CommandExecuted -= handler;
        }
    }
}