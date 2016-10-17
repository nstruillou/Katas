using RpnCalculator.Controller;
using RpnCalculator.Model;
using RpnCalculator.View;

namespace RpnCalculator
{
    public class RpnCalculatorLauncher
    {
        private static void Main(string[] args)
        {
            AbstractCalculator calculator = new RpnCalculatorModel();
            RpnControler rpnControler = new RpnControler(calculator);

            ConsolePrompt view = new ConsolePrompt(rpnControler);
            calculator.AddObserver(view);
            
            view.Run();
        }
    }
}