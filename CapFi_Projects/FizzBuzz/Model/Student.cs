using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Model
{
    public delegate string NumberInterpretor(int number);

    public class Student : Person
    {
        public Student(int sudentId)
            : base(sudentId)
        {
        }

        public NumberInterpretor NumberInterpretor;

        public string Reply(int number)
        {
            string interpretedNumber = this.NumberInterpretor(number);
            return "the student #" + this.PersonID + " answers " + interpretedNumber;
        }

    }
}
