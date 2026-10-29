using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Hashtable h1 = new Hashtable();

            //Add 5 Students
            h1.Add(11, "Harshada");
            h1.Add(22, "Sita");
            h1.Add(33, "Gita");
            h1.Add(44, "Nita");
            h1.Add(55, "Babita");

            foreach(var item in h1.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");

            foreach (var item in h1.Values)
            {
                Console.WriteLine(item);
            }
            */


            /*Hashtable h = new Hashtable();

            h.Add("IN", "India");
            h.Add("US", "United States");
            h.Add("UK", "United Kingdom");
            h.Add("JP", "Japan");
            h.Add("AU", "Australia");

            //Access/retrieve Value by Key
            Console.WriteLine(h["IN"]);
            */


            /*Hashtable emp = new Hashtable();

            emp.Add(101, "Yogesh");
            emp.Add(102, "Durgesh");
            emp.Add(103, "Suresh");
            emp.Add(104, "Bhavesh");
            emp.Add(105, "Mahesh");

            //Update
            emp[103] = "Jayesh";

            foreach (var employee in emp.Keys)
            {
                Console.WriteLine(employee);
            }
            Console.WriteLine("");

            foreach (var employee in emp.Values)
            {
                Console.WriteLine(employee);
            }

            //foreach (DictionaryEntry employee in emp)
            //{
            //    Console.WriteLine(employee.Key+ " " + employee.Value);
            //}
            */


            /*Hashtable h3 = new Hashtable();

            h3.Add("Apple", 100);
            h3.Add("Banana", 50);
            h3.Add("Mango", 120);
            h3.Add("Grapes", 90);
            h3.Add("Orange", 80);

            h3.Remove(h3["Apple"]);

            foreach (var item in h3.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");

            foreach (var item in h3.Values)
            {
                Console.WriteLine(item);
            }*/


            /*Hashtable h4 = new Hashtable();

            h4.Add("hrp123", 12345);

            //Check Key & Value Exists or not

            Console.WriteLine(h4.ContainsKey("abc12"));

            Console.WriteLine(h4.ContainsValue(26435));

            Console.WriteLine(h4.ContainsValue(12345));
            */


            /*Hashtable c = new Hashtable();

            c.Add(424001, "Dhule");
            c.Add(422001, "Nashik");
            c.Add(425001, "Jalgaon");
            c.Add(425405, "Shirpur");
            c.Add(411001, "Pune");
            c.Add(400001, "Mumbai");

            Console.WriteLine(c.Count);
            */


            Hashtable h5 = new Hashtable();

            h5.Add("CSharp", 90);
            h5.Add("Java", 85);
            h5.Add("Python", 80);
            h5.Add("DBMS", 75);

            //Copy Keys separately
            ICollection Keys = h5.Keys;

            //Copy Values separately
            ICollection Values = h5.Values;

            foreach (var key in Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("");

            foreach (var Value in Values)
            {
                Console.WriteLine(Value);
            }
            


           Console.ReadLine();
        }
    }
}
