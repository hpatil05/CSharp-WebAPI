using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            //LIFO
            //FIFO

            //Push & Display

            /*Stack s1 = new Stack();

            //add element
            s1.Push(12);
            s1.Push(10);
            s1.Push(15);
            s1.Push(17);
            s1.Push(20);

            foreach (var item in s1)
            {
                Console.WriteLine(item);
            }
            */

            //Pop Operation

            /*Stack s1 = new Stack();

            //remove element
            s1.Push(12);
            s1.Push(10);
            s1.Push(15);
            s1.Push(17);
            s1.Push(20);

            //remove one element //20
            s1.Pop();


            foreach (var item in s1)
            {
                Console.WriteLine(item);
            }
            */

            //Peek Operation

            /*Stack fruits = new Stack();

            fruits.Push("Apple");
            fruits.Push("Banana");
            fruits.Push("Papaya");
            fruits.Push("Cherry");

            fruits.Pop();

            Console.WriteLine(fruits.Peek());
            */

            //Search in Stack

            /*Stack Students = new Stack();

            Students.Push("Keshav");
            Students.Push("Madhav");
            Students.Push("Pramod");
            Students.Push("Amit");

            Console.WriteLine("Enter Student Name: ");

            string name = Console.ReadLine();

            if(Students.Contains(name))
            {
                Console.WriteLine("Student exist in the Stack.");
            }
            else
            {
                Console.WriteLine("Student does not exist in the Stack.");
            }
            */


            //Reverse String using Stack

            /*Stack names = new Stack();

            names.Push("Harshada");
            names.Push("Payal");
            names.Push("Mayuri");
            names.Push("Varsha");
            names.Push("Snehal");

            Console.WriteLine("Enter a string : ");

            string name = Console.ReadLine();

            string reverse = "";

            for(int i= name.Length-1; i>=0; i--)
            {
                reverse = reverse + name[i];
            }
            Console.WriteLine("Reverse String : "+reverse);
            */


            //Count Elements

            /*Stack numbers = new Stack();

            numbers.Push(5);
            numbers.Push(12);
            numbers.Push(10);
            numbers.Push(25);
            numbers.Push(20);
            numbers.Push(31);
            numbers.Push(36);
            numbers.Push(17);
            numbers.Push(24);
            numbers.Push(30);

            //count before popping 
            Console.WriteLine("Count before Pop: "+numbers.Count);

            //Pop 3 elements
            numbers.Pop();
            numbers.Pop();
            numbers.Pop();

            //count after popping 
            Console.WriteLine("Count after Pop: "+numbers.Count);
            */


            //Clear Stack

            /*Stack s1 = new Stack();

            s1.Push(45);
            s1.Push("Hello");
            s1.Push(3.5);
            s1.Push(3000);
            s1.Push("Rahul");

            s1.Clear();

            Console.WriteLine("Stack should be Empty.");
            */

            Console.ReadLine();
        }
    }
}
