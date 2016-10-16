using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpnCalculator.Model
{
    public class RpnCalculatorModel : AbstractCalculator
    {
        public override void Calculate(string expression)
        {
            string result = "";
            if (string.Empty.Equals(expression))
            {

            }
            else
            {
                List<string> elements = expression.Split(' ').ToList();
                if (elements.Count > 0)
                {
                    result = this.RecursiveCalculation(elements).ToString();
                }
            }

            this.NotifiyObserver(result);
        }

        private int? RecursiveCalculation(List<string> elements)
        {
            int number;
            string lastElement = elements.Last();
            elements.RemoveAt(elements.Count - 1);

            if (Int32.TryParse(lastElement, NumberStyles.Any, CultureInfo.InvariantCulture, out number))
            {
                return number;
            }
            else
            {
                int? rightElement = this.RecursiveCalculation(elements);
                int? leftElement = this.RecursiveCalculation(elements);

                if (leftElement == null || rightElement == null)
                {
                    return null;
                }
                else
                {
                    return new RpnOperator(lastElement).ApplyOperation((int)leftElement, (int)rightElement);
                }
            }

        }
    }
}
