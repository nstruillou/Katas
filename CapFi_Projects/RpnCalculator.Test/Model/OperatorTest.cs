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
    public class OperatorTest
    {
        private RpnOperator rpnOperator;

        [Test]
        public void Should_return_result_of_addition_when_operator_plus_selected()
        {
            this.rpnOperator = new RpnOperator("+");
            int expected = 10;
            int actual = (int)this.rpnOperator.ApplyOperation(5, 5);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Should_return_result_of_difference_when_operator_minus_selected()
        {
            this.rpnOperator = new RpnOperator("-");
            int expected = 5;
            int actual = (int)this.rpnOperator.ApplyOperation(10, 5);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Should_return_result_of_multiplication_when_operator_star_selected()
        {
            this.rpnOperator = new RpnOperator("*");
            int expected = 50;
            int actual = (int)this.rpnOperator.ApplyOperation(10, 5);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Should_return_result_of_division_when_operator_slash_selected()
        {
            this.rpnOperator = new RpnOperator("/");
            int expected = 2;
            int actual = (int)this.rpnOperator.ApplyOperation(10, 5);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Should_return_null_when_left_number_equals_to_zero()
        {
            this.rpnOperator = new RpnOperator("/");
            int? actual = this.rpnOperator.ApplyOperation(10, 0);
            Assert.Null(actual);
        }

    }
}
