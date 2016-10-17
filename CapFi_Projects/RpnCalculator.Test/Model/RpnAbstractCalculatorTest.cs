using System;
using NSubstitute;
using NUnit.Framework;
using RpnCalculator.Controller;
using RpnCalculator.Model;
using RpnCalculator.Observer;
using RpnCalculator.View;

namespace RpnCalculator.Test.Model
{
    [TestFixture]
    public class RpnAbstractCalculatorTest
    {
        private AbstractCalculator calculator;
        private RpnControler controler;

        [SetUp]
        public void InitTests()
        {
            this.calculator = new RpnCalculatorModel();
            this.controler = new RpnControler(this.calculator);
        }

        [Test]
        public void Should_add_new_observer_when_observer_not_null()
        {
            IObserver observer = new ConsolePrompt(this.controler);
            this.calculator.AddObserver(observer);
            int expected = 1;
            int actual = this.calculator.Observers.Count;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Should_not_add_observer_when_object_is_null()
        {
            IObserver observer = null;
            this.calculator.AddObserver(observer);
            int expected = 0;
            int actual = this.calculator.Observers.Count;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Should_return_true_when_observer_removed()
        {
            IObserver observer = new ConsolePrompt(this.controler);
            this.calculator.AddObserver(observer);
            var actual = this.calculator.RemoveObserver(observer);
            Assert.IsTrue(actual);
        }

        [Test]
        public void Should_notifiy_all_observers()
        {
            IObserver observer = Substitute.For<IObserver>();
            this.calculator.AddObserver(observer);
            this.calculator.NotifiyObserver("");

            observer.Received(1).Update("");
        }


    }
}
