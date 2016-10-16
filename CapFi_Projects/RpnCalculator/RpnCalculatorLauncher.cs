using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpnCalculator.View;

namespace RpnCalculator
{
    public class RpnCalculatorLauncher
    {
        static void Main(string[] args)
        {
            ConsolePrompt view = new ConsolePrompt();
            view.Run();
        }
    }
}
