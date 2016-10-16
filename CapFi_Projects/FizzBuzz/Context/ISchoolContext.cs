using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz.Model;

namespace FizzBuzz.Context
{
    public interface ISchoolContext
    {
        IEnumerable<Teacher> Teachers { get; }
        IEnumerable<Student> Students { get; }
    }
}
