using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Model
{
    public abstract class Course
    {
        public Course(Discipline discipline)
        {
            this.Discipline = discipline;
        }

        public Discipline Discipline
        {
            get;
            private set;
        }
    }
}
