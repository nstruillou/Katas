using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz.Interpretors;

namespace FizzBuzz.Model
{
    public class FizzBuzzCourse : Course
    {
        private IFizzBuzzInterpretor fizzBuzzInterpretor;

        public FizzBuzzCourse() : base(Discipline.Math)
        {
            this.fizzBuzzInterpretor = new FizzBuzzInterpretor();
        }

        public IFizzBuzzInterpretor FizzBuzzInterpretor
        {
            get
            {
                return this.fizzBuzzInterpretor;
            }
        }
    }
}
