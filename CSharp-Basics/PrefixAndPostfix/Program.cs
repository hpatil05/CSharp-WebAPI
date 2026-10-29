using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrefixAndPostfix
{
    class Program
    {
        static void Main(string[] args)
        {
            //prefix
            int i = 20;
            int j = ++i;
            Console.WriteLine(j);

            //postfix
            int x = 10;
            int y = x++;
            Console.WriteLine(y);
            Console.WriteLine(x);
            Console.ReadLine();

        }
       
    }
}
