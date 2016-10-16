using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz.Interpretors;
using NUnit.Framework;

namespace FizzBuzz.Test.Interpretors
{
    [TestFixture]
    public class FizzBuzzInterpretorTest
    {
        private IFizzBuzzInterpretor interpretor;

        [SetUp]
        public void InitTests()
        {
            this.interpretor = new FizzBuzzInterpretor();
        }

        [Test]
        public void Should_return_number_in_string_variable()
        {
            string expected = "4";
            string actual = this.interpretor.InterpretFizzBuzzNumber(4);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Should_return_Fizz_when_number_is_multiple_of_tree()
        {
            string expected = "Fizz";
            string actual = this.interpretor.InterpretFizzBuzzNumber(3);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Should_return_Buzz_when_number_is_multiple_of_five()
        {
            string expected = "Buzz";
            string actual = this.interpretor.InterpretFizzBuzzNumber(10);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Should_return_fizzbuzz_when_number_is_multiple_of_3_and_5()
        {
            string expected = "FizzBuzz";
            string actual = this.interpretor.InterpretFizzBuzzNumber(15);
            Assert.AreEqual(expected, actual);
        }
    }
}
