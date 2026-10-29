using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ArrayList list = new ArrayList();

            list.Add(15);
            list.Add(20);
            list.Add(25);
            list.Add(30);
            list.Add(35);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }*/


            /*ArrayList list = new ArrayList();

            list.Add(22);
            list.Add("Harshada");
            list.Add('H');
            list.Add(3500);
            list.Add(5.7);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            */

            /*ArrayList list = new ArrayList();

            list.Add("Apple");
            list.Add("Banana");
            list.Add("Mango");

            list.Insert(1, "Orange");

            list.Remove("Banana");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            */

            /*ArrayList Students = new ArrayList();

            Students.Add("Keshav");
            Students.Add("Madhav");
            Students.Add("Pramod");
            Students.Add("Amit");

            Console.WriteLine("Enter Student Name: ");

            string name = Console.ReadLine();

            if(Students.Contains(name))
            {
                Console.WriteLine("Student exist in the list.");
            }
            else
            {
                Console.WriteLine("Student does not exist in the list.");
            }*/


            /*ArrayList list = new ArrayList();

            list.Add(45);
            list.Add(34);
            list.Add(12);
            list.Add(24);
            list.Add(53);

            list.Sort();

            Console.WriteLine("Sorted in Ascending order:");

            foreach (int number in list)
            {
                Console.WriteLine(number);
            }
            */

            /*ArrayList numbers = new ArrayList();

            numbers.Add(11);
            numbers.Add(12);
            numbers.Add(13);
            numbers.Add(14);
            numbers.Add(15);

            int[] arr = new int[5];

            //Copy ArrayList elements to Array

            numbers.CopyTo(arr);

            //Display ArryList

            Console.WriteLine("ArrayList elements :");

            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            //Display normal Array

            Console.WriteLine("Normal Array elements :");

            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }*/



            /*ArrayList list= new ArrayList();

            list.Add(5);
            list.Add(12);
            list.Add(10);
            list.Add(25);
            list.Add(20);
            list.Add(31);
            list.Add(36);
            list.Add(17);
            list.Add(24);
            list.Add(30);

            //to count element
            Console.WriteLine(list.Count);

            //to count capacity
            //4=8=16=32=64=128=256=512

            Console.WriteLine(list.Capacity);
            */

            Console.ReadLine();
        }

    }
}
