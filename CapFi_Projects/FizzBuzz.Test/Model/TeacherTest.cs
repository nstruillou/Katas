using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz.Model;
using NUnit.Framework;

namespace FizzBuzz.Test.Model
{
    [TestFixture]
    public class TeacherTest
    {
        private Teacher teacher;

        [SetUp]
        public void InitTests()
        {
            this.teacher = new Teacher(1)
            {
                Discipline = Discipline.Math
            };
        }

        [Test]
        public void Should_return_question()
        {
            string expected = "the math teacher asks 1";
            string actual = this.teacher.AskNumber(1);
            Assert.AreEqual(expected, actual);
        }
    }
}
