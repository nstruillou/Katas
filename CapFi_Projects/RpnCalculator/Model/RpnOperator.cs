using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpnCalculator.Model
{
    public delegate int? Operation(int leftNumber, int rightNumber);

    public class RpnOperator
    {
        private readonly Operation operation;

        public RpnOperator(string inputOperator)
        {
            switch(inputOperator)
            {
                case "+":
                    this.operation += (a, b) =>  a + b ;
                    break;
                case "-":
                    this.operation += (a, b) => a - b;
                    break;
                case "*":
                    this.operation += (a, b) => a * b;
                    break;
                case "/":
                    this.operation += (a, b) =>
                        {
                            if (b == 0)
                            {
                                return null;
                            }
                            else
                            {
                                return a / b;
                            }
                        };
                    break;
                default:
                    this.operation += (a,b) => null;
                    break;
            }
        }

        public int? ApplyOperation(int leftElement, int rightElement)
        {
            return this.operation(leftElement, rightElement);
        }
    }
}
