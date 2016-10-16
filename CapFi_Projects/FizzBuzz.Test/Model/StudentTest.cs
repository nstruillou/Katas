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
    public class StudentTest
    {
        private Student student;

        [SetUp]
        public void InitTests()
        {
            this.student = new Student(1);   
        }

        [Test]
        public void Should_return_response_when_Number_Interpretor_not_null()
        {
            this.student.NumberInterpretor = (number) => number.ToString();

            string expected = "the student #1 answers 1";
            string actual = this.student.Reply(1);
            Assert.AreEqual(expected, actual);
        }

    }
}
