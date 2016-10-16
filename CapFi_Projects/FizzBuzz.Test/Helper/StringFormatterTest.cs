using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz.Helper;
using NUnit.Framework;

namespace FizzBuzz.Test.Helper
{
    [TestFixture]
    public class StringFormatterTest
    {
        [Test]
        public void Should_return_question_followed_by_reply()
        {
            string question = "toto asks";
            string response = "hello";
            string expected = "toto asks => hello";
            string actual = StringFormatter.FormatQuestionReply(question, response);
            Assert.AreEqual(expected, actual);
        }
    }
}
