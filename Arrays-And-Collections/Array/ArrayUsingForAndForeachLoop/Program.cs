using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayUsingForAndForeachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = new int[5];
            //arr[0] = 11;
            //arr[1] = 45;
            //arr[2] = 56;
            //arr[3] = 84;
            //arr[4] = 21;

            int[] arr = { 11, 22, 33, 44, 55 };
                for (int i =0;i<=4;i++)
                {
                    Console.WriteLine(arr[i]);
                }
                

            string[] fruits = { "banana", "mango", "cherry", "papaya" };

            //forech (Datatype item in Arrayname) 
            //item is a variable
            foreach(string item in fruits)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
