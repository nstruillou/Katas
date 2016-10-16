using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using NUnit.Framework;
using RpnCalculator.Model;
using RpnCalculator.Observer;

namespace RpnCalculator.Test.Model
{
    [TestFixture]
    public class RpnCalculatorModelTest
    {
        private AbstractCalculator rpnCalculator;
        private IObserver observer;

        [SetUp]
        public void InitTests()
        {
            this.observer = Substitute.For<IObserver>();
            this.rpnCalculator = new RpnCalculatorModel();
            this.rpnCalculator.AddObserver(observer);
        }

        [Test]
        public void Should_return_an_empty_string_when_expression_is_empty()
        {
            this.rpnCalculator.Calculate("");
            this.observer.Received(1).Update("");
        }

        [Test]
        public void Should_return_number_when_expression_contains_only_number()
        {
            string expression = "5";
            this.rpnCalculator.Calculate(expression);
            this.observer.Received(1).Update(expression);
        }

        [Test]
        public void Should_return_operation_result_when_single_addition()
        {
            string expression = "20 5 +";
            this.rpnCalculator.Calculate(expression);
            string expected = "25";
            this.observer.Received(1).Update(expected);
        }

        [TestCase("4 2 + 3 -", "3")]
        [TestCase("3 5 8 * 7 + *", "141")]
        public void Should_return_operation_result_when_multiple_operators_are_used(string expression, string expected)
        {
            this.rpnCalculator.Calculate(expression);
            this.observer.Received(1).Update(expected);
        }

        [Test]
        public void Should_return_empty_string_when_division_by_zero()
        {
            string expression = "20 0 /";
            this.rpnCalculator.Calculate(expression);
            string expected = "";
            this.observer.Received(1).Update(expected);
        }

        [Test]
        public void Should_return_empty_string_when_operator_are_duplicated()
        {
            string expression = "20 5 ++";
            this.rpnCalculator.Calculate(expression);
            string expected = "";
            this.observer.Received(1).Update(expected);
        }
    }
}
