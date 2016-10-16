using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz.Context;
using FizzBuzz.Model;
using NUnit.Framework;

namespace FizzBuzz.Test.Model
{
    [TestFixture]
    public class ClassRoomTest
    {
        private ClassRoom classRoom;
        private ISchoolContext schoolContext;

        [SetUp]
        public void InitTests()
        {
            this.schoolContext = new SchoolContext();
            
        }

        [Test]
        public void Should_students_learn_fizzbuzz_method_when_course_is_on_fizz_buzz()
        {
            this.classRoom = new ClassRoom(this.schoolContext.Teachers.ElementAt(0), this.schoolContext.Students.ToList(), new FizzBuzzCourse());

            Student student = this.classRoom.Students[0];
            string expected = "InterpretFizzBuzzNumber";
            var actual = student.NumberInterpretor.Method.Name;

            Assert.AreEqual(expected, actual);
        }

    }
}
