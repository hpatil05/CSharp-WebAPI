using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Syntax of if
            //if (Condition)
            //{
            //  //statement
            //}

            //Syntax of if else
            //if (Condition)
            //{
            //  //statement
            //}
            //else
            //{
            //  //statement
            //}

            /*
            //check enetered number is positive or negative
            int a = 10;
            //int a = -10;
            if (a > 0)
            {
                Console.WriteLine("a is positive");
            }
            else
            {
                Console.WriteLine("a is negative");
            }
            */

            /*
            //check whether the given Age is eligible for vote or not
            int age = 22;
            //int age = 15;
            if(age>=18)
            {
                Console.WriteLine("Eligible for vote");
            }
            else
            {
                Console.WriteLine("Not eligible");
            }
            */

            /*
            //check entered number is even or odd
            int num = 13;
            //int num = 42;
            if (num % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }
            */

            /*
            //Create one integer variable and initialize it.Check number is greater than 10 or not
            int num = 12;
            //int num = 9;
            if (num >= 10)
            {
                Console.WriteLine("Number is greater than 10");
            }
            else
            {
                Console.WriteLine("Number is less than 10");
            }
            */


            //Syntax of Ladder if else //if else if
            //if (Condition)
            //{
            //  //statement
            //}
            //else if (Condition)
            //{
            //  //statement
            //}
            //else
            //{
            //  //statement
            //}

            /*
            //find the largest number of the three.
            int a = 35, b = 48, c = 22;
            if (a > b)
            {
                Console.WriteLine("a is larger than b");

                if (a > c)
                {
                    Console.WriteLine("a is larger than c");
                    Console.WriteLine("a is larger");
                }
                else
                {
                    Console.WriteLine("a is smaller than b");
                }
            }
            else if (b > a)
            {
                Console.WriteLine("b is larger than a");

                if (b > c)
                {
                    Console.WriteLine("b is larger than c");
                    Console.WriteLine("b is larger");
                }
                else
                {
                    Console.WriteLine("b is smaller than c");
                }
            }
            else if (c > a)
            {
                Console.WriteLine("c is larger than a");

                if (c > b)
                {
                    Console.WriteLine("c is larger than b");
                    Console.WriteLine("c is larger");
                }
                else
                {
                    Console.WriteLine("c is smaller");
                }
            }
            */

            /*
            int a = 35, b = 48, c = 22;
            if (a>b && a>c)
            {
                Console.WriteLine("a is the largest");
            }
            else if (b>a && b>c)
            {
                Console.WriteLine("b is the largest");
            }
            else
            {
                Console.WriteLine("c is the largest");
            }
            */

            /*
            //Calculate the grade of the students according to specified marks
            int marks = 90;
            
            if (marks >= 85)
            {
                Console.WriteLine("grade A");
            }
            else if (marks >= 75)
            {
                Console.WriteLine("grade B");
            }
            else if(marks >= 65)
            {
                Console.WriteLine("grade C");
            }
            else if(marks >= 55)
            {
                Console.WriteLine("grade D");
            }
            else
            {
                Console.WriteLine("Fail");
            }
            */

            /*
            //Find the vowels among the Alphabets.
            char ch = 'a';
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Not a Vowel");
            }
            */

            /*
            char ch ='a';
            if (ch == 'a')
            {
                Console.WriteLine("it is vowel");
            }
            else if (ch == 'e')
            {
                Console.WriteLine("it is vowel");
            }
            else if (ch == 'i')
            {
                Console.WriteLine("it is vowel");
            }
            else if (ch == 'o')
            {
                Console.WriteLine("it is vowel");
            }
            else if (ch == 'u')
            {
                Console.WriteLine("it is vowel");
            }
            else
            {
                Console.WriteLine("it is not vowel");
            }
            */
            Console.ReadLine();
        }
    }
}
