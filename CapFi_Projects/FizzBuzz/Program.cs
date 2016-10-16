using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz.Context;
using FizzBuzz.Model;

namespace FizzBuzz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ISchoolContext schoolContext = new SchoolContext();
 
            ClassRoom classRoom = new ClassRoom(schoolContext.Teachers.Where(teacher => teacher.LastName.Equals("Poincare")).Single(),schoolContext.Students.ToList(), new FizzBuzzCourse());
            classRoom.StartExercise(100);

            Console.ReadKey();

        }
    }
}
