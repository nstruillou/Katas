using RpnCalculator.View;

namespace RpnCalculator
{
    public class RpnCalculatorLauncher
    {
        private static void Main(string[] args)
        {
            ConsolePrompt view = new ConsolePrompt();
            view.Run();
        }
    }
}