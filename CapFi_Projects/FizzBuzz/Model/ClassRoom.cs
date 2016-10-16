using System;
using System.Collections.Generic;
using System.Linq;
using FizzBuzz.Helper;

namespace FizzBuzz.Model
{
    public class ClassRoom
    {
        public ClassRoom(Teacher teacher, List<Student> student, Course course)
        {
            this.Teacher = teacher;
            this.Students = student;

            this.LearNewMethodFromCourse(course);
        }

        private void LearNewMethodFromCourse(Course course)
        {
            if (course is FizzBuzzCourse)
            {
                foreach (Student student in this.Students)
                {
                    student.NumberInterpretor += ((FizzBuzzCourse)course).FizzBuzzInterpretor.InterpretFizzBuzzNumber;
                }
            }
        }

        public void StartExercise(int limitCounter)
        {
            int counter = 1;

            while (counter <= limitCounter)
            {
                foreach (Student student in Students.OrderBy(s => s.PersonID))
                {
                    string question = this.Teacher.AskNumber(counter);
                    string response = student.Reply(counter);
                    Console.WriteLine(StringFormatter.FormatQuestionReply(question, response));

                    counter++;

                    if (counter > limitCounter)
                    {
                        return;
                    }
                }
            }
        }

        public List<Student> Students
        {
            get;
            private set;
        }

        public Teacher Teacher
        {
            get;
            private set;
        }
    }
}