using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RpnCalculator.Model;

namespace RpnCalculator.Test.Model
{
    [TestFixture]
    public class ExpressionValidatorTest
    {
        [Test]
        public void Should_return_false_when_expression_not_match_with_regex()
        {
            string expression = "20 a /";
            bool actual = ExpressionValidator.ValidateRpnExpression(expression);
            Assert.IsFalse(actual);
        }

        [Test]
        public void Should_return_true_when_expression_not_match_with_regex()
        {
            string expression = "20 5 /";
            bool actual = ExpressionValidator.ValidateRpnExpression(expression);
            Assert.IsTrue(actual);
        }
    }
}
