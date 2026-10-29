using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //? ternary operator 
            int a = 11;

            //string variable name =(condtion)? "msg" : "msg" ;

            //string result = (a > 0)? "a is positive" : "a is negative";

            string result = (a % 2 == 0) ? "a is even" : "a is odd";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
