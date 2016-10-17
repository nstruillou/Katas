using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RpnCalculator.Model
{
    public static class ExpressionValidator
    {
        private const string RpnPattern = "^[0-9 +*-/]*$";

        public static bool ValidateRpnExpression(string expression)
        {
            Regex regex = new Regex(RpnPattern);
            return regex.IsMatch(expression);
        }
    }
}
