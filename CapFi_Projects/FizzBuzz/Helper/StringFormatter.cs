using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Helper
{
    public static class StringFormatter
    {
        public static string FormatQuestionReply(string ask, string reply)
        {
            return ask + " => " + reply;
        }
    }
}
