﻿namespace FizzBuzz.Model
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