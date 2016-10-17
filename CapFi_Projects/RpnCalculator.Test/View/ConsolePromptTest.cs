using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RpnCalculator.View;

namespace RpnCalculator.Test.View
{
    [TestFixture]
    public class ConsolePromptTest
    {
        private ConsolePrompt rpnConsole;

        [SetUp]
        public void InitTests()
        {
            this.rpnConsole = new ConsolePrompt(null);
        }

    }
}
