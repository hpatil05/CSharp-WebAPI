using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleDimentionalArray
{

    class Program
    {
        static void Main(string[] args)
        {
            /*int[] arr = new int[5];

            //Accept 5 numbers
            Console.WriteLine("Enter 5 numbers: ");

            for (int i=0; i<5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Display numbers

            Console.WriteLine("Array Elements :");

            foreach ( int num in arr)
            {
                Console.WriteLine(num);
            }*/


            // Sum of Array Elements

             /*int[] arr = { 10, 23, 45, 27, 65, 12, 43, 12, 41, 32 };

             int sum = 0;

             //sum

             foreach (int num in arr)
             {
                 sum = sum + num;
             }
             Console.WriteLine("Sum = " +sum);
             */


            // Maximum & Minimum Element

            /*int[] arr = { 10, 24, 56, 47, 65, 89, 90, 70 };

            int max = arr[0];
            int min = arr[0];

            foreach (int num in arr)
            {
                if (num > max)
                {
                    max = num;
                }
                if (num < min)
                {
                    min = num;
                }
            }
            Console.WriteLine("Largest element =" +max);
            Console.WriteLine("Smallest element =" +min);
            */

            
            //Reverse Array

            /*int[] arr = new int[6];

            //Accept 6 numbers

            for (int i=0; i<6; i++)
            {
                Console.WriteLine("Enter number :");

                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Array in Reverse order 

            Console.WriteLine("Reverse Array :");

            for (int i = 5; i>=0; i--)
            {
                Console.WriteLine(arr[i]);
            }
            */
            
            
            //Count Even & Odd numbers

            /*int[] arr = { 12,34,67,23,48,87,74,51,21,15 };

            int even = 0;
            int odd = 0;

            //foreach (int num in arr)
            //{
            //  if (num % 2 == 0)
            //    {
            //        even++;
            //    }
            //    else
            //    {
            //        odd++;
            //    }
            //}
            
            Console.WriteLine("Even Numbers = " +even);
            Console.WriteLine("Odd Numbers= " +odd);
            */


            //Linear Search

            /*int[] arr = { 12, 34, 65, 24, 45, 78, 92, 25, 10, 55 };
        
            Console.WriteLine("Enter Number:");

            int search = Convert.ToInt32(Console.ReadLine());

            bool found = false;

            foreach (int num in arr)
            {
                if (num == search)
                {
                    found = true;
                }
            }
            if (found == true)
            {
                Console.WriteLine("found");
            }
            else
            {
                Console.WriteLine("Not found");
            }
            */
                   

            //Copy Array

            //cretae 1st array

            int[] arr1 = new int[5];

            //Read 5 numbers 
            for (int i=0; i<5; i++)
            {
                Console.WriteLine("Enter number: ");

                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            //create 2nd array

            int[] arr2 = new int[5];

            //Copy arr1 to arr2

            for (int i=0; i<5; i++)
            {
                arr2[i] = arr1[i];
            }
          
            //Display 1st array
            Console.WriteLine("First Array:");

            foreach (int num in arr1)
            {
                Console.WriteLine(num);
            }

            //Display 2nd array

            Console.WriteLine("Second Array:");
            
            foreach (int num in arr2)
            {
                Console.WriteLine(num);
            }
            

            Console.ReadLine();
            

        }
    }
}
