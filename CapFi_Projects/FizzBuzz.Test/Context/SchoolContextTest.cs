using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz.Context;
using NUnit.Framework;

namespace FizzBuzz.Test.Context
{
    [TestFixture]
    public class SchoolContextTest
    {
        private ISchoolContext context;

        [SetUp]
        public void InitTests()
        {
            this.context = new SchoolContext();
        }

        [Test]
        public void Should_return_list_of_students()
        {
            var students = this.context.Students;
            Assert.IsTrue(students.Count() > 0);
        }

        [Test]
        public void Should_return_list_of_teachers()
        {
            var teachers = this.context.Teachers;
            Assert.IsTrue(teachers.Count() > 0);
        }
    }
}
