using System.Collections.Generic;
using FizzBuzz.Model;

namespace FizzBuzz.Context
{
    public class SchoolContext : ISchoolContext
    {
        private const int nbStudents = 29;

        public SchoolContext()
        {
            this.OnContextCreated();
        }

        private void OnContextCreated()
        {
            Teacher teacher = new Teacher(1)
            {
                FistName = "Henri",
                LastName = "Poincare",
                Discipline = Discipline.Math
            };

            this.Teachers = new List<Teacher> { teacher };

            var students = new List<Student>();
            for (int i = 0; i < nbStudents; i++)
            {
                students.Add(new Student(i + 1));
            }

            this.Students = students;
        }

        public IEnumerable<Teacher> Teachers
        {
            get;
            private set;
        }

        public IEnumerable<Student> Students
        {
            get;
            private set;
        }
    }
}