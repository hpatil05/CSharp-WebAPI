using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            /*SortedList s = new SortedList();

            s.Add(103, "Raj");
            s.Add(104, "Rohit");
            s.Add(105, "Amit");
            s.Add(101, "Sumit");
            s.Add(102, "Pradip");

            //to print Sorted List
            foreach (var item in s.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");

            foreach (var item in s.Values)
            {
                Console.WriteLine(item);
            }
            */


            /*SortedList s1 = new SortedList();

            s1.Add("IN", "India");
            s1.Add("US", "United States");
            s1.Add("UK", "United Kingdom");
            s1.Add("JP", "Japan");
            s1.Add("AU", "Australia");

            //Access/retrieve Value by Key
            Console.WriteLine(s1["IN"]);
            */


            /*SortedList emp = new SortedList();

            emp.Add(101, "Raj");
            emp.Add(102, "Gitesh");
            emp.Add(103, "Rahul");
            emp.Add(104, "Dinesh");
            emp.Add(105, "Subham");

            //Update
            emp[104] = "Jayesh";

            foreach (var employee in emp.Keys)
            {
                Console.WriteLine(employee);
            }
            Console.WriteLine("");

            foreach (var employee in emp.Values)
            {
                Console.WriteLine(employee);
            }
            */


            /*SortedList s2 = new SortedList();

            s2.Add("Apple", 100);
            s2.Add("Banana", 50);
            s2.Add("Mango", 120);
            s2.Add("Grapes", 90);
            s2.Add("Orange", 80);

            //to remove item
            s2.Remove("Apple");

            s2.RemoveAt(2);

            foreach (var item in s2.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");

            foreach (var item in s2.Values)
            {
                Console.WriteLine(item);
            }
            */


            /*SortedList s3 = new SortedList();

            s3.Add("abc123", 12345);

            //Check Key & Value Exists or not

            Console.WriteLine(s3.ContainsKey("hrp12"));

            Console.WriteLine(s3.ContainsValue(26435));

            Console.WriteLine(s3.ContainsValue(12345));
            */


            /*SortedList c = new SortedList();

            c.Add(424001, "Dhule");
            c.Add(422001, "Nashik");
            c.Add(425001, "Jalgaon");
            c.Add(425405, "Shirpur");
            c.Add(411001, "Pune");

            Console.WriteLine(c.Count);
            */


            /*SortedList sub = new SortedList();

            sub.Add("CSharp", 90);
            sub.Add("Java", 85);
            sub.Add("Python", 80);
            sub.Add("DBMS", 75);

            Console.WriteLine(sub.GetKey(1));

            Console.WriteLine(sub.GetByIndex(1));
            */

            Console.ReadLine();
        }
    }
}
