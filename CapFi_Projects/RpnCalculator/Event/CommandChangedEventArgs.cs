using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpnCalculator.Event
{
    public class CommandChangedEventArgs : EventArgs
    {
        public readonly string Command;

        public CommandChangedEventArgs(string command)
        {
            this.Command = command;
        }
    }
}
