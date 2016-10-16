using System;
using System.Linq;
using FizzBuzz.Context;
using FizzBuzz.Model;

namespace FizzBuzz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ISchoolContext schoolContext = new SchoolContext();

            ClassRoom classRoom = new ClassRoom(schoolContext.Teachers.Where(teacher => teacher.LastName.Equals("Poincare")).Single(), schoolContext.Students.ToList(), new FizzBuzzCourse());
            classRoom.StartExercise(100);

            Console.ReadKey();
        }
    }
}