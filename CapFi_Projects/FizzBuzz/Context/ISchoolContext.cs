using System.Collections.Generic;
using FizzBuzz.Model;

namespace FizzBuzz.Context
{
    public interface ISchoolContext
    {
        IEnumerable<Teacher> Teachers { get; }
        IEnumerable<Student> Students { get; }
    }
}