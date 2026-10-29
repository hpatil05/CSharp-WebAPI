using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            //FIFO
            //LILO

            //Enqueue & Display

            /*Queue q1 = new Queue();

            q1.Enqueue(66);
            q1.Enqueue("Harshada");
            q1.Enqueue("SAP");
            q1.Enqueue('C');
            q1.Enqueue(23.897);
            q1.Enqueue(true);

            foreach(var item in q1)
            {
                Console.WriteLine(item);
            }
            */


            //Dequeue Operation

            /*Queue q1 = new Queue();

            q1.Enqueue(66);
            q1.Enqueue("Harshada");
            q1.Enqueue("SAP");
            q1.Enqueue('C');
            q1.Enqueue(23.897);
            q1.Enqueue(true);

            q1.Dequeue();

            foreach(var item in q1)
            {
                Console.WriteLine(item);
            }
            */


            //Peek Operation

            /*Queue fruits = new Queue();

            fruits.Enqueue("Mango");
            fruits.Enqueue("Apple");
            fruits.Enqueue("Banana");
            fruits.Enqueue("Orange");
            fruits.Enqueue("Grapes");

            Console.WriteLine("First fruit: "+fruits.Peek());
            */


            //Search in Queue

            /*Queue Students = new Queue();

            Students.Enqueue("Yogesh");
            Students.Enqueue("Durgesh");
            Students.Enqueue("Bhavesh");
            Students.Enqueue("Mahesh");

            Console.WriteLine("Enter Student Name: ");

            string name = Console.ReadLine();

            if(Students.Contains(name))
            {
                Console.WriteLine("Student exist in the Queue.");
            }
            else
            {
                Console.WriteLine("Student does not exist in the Queue.");
            }
            */


            //Count Elements

            /*Queue numbers = new Queue();

            numbers.Enqueue(5);
            numbers.Enqueue(12);
            numbers.Enqueue(10);
            numbers.Enqueue(25);
            numbers.Enqueue(20);
            numbers.Enqueue(31);
            numbers.Enqueue(36);
            numbers.Enqueue(17);
            numbers.Enqueue(24);
            numbers.Enqueue(30);

            //count before popping 
            Console.WriteLine("Count before Pop: "+numbers.Count);

            //Pop 3 elements
            numbers.Dequeue();
            numbers.Dequeue();
            numbers.Dequeue();

            //count after popping 
            Console.WriteLine("Count after Pop: "+numbers.Count);
            */


            //Copy Queue to Array

            /*Queue numbers = new Queue();

            numbers.Enqueue(11);
            numbers.Enqueue(12);
            numbers.Enqueue(13);
            numbers.Enqueue(14);
            numbers.Enqueue(15);

            int[] arr = new int[5];

            //Copy Queue elements to Array

            numbers.CopyTo(arr, 0);

            //Display Queue

            Console.WriteLine("Queue elements :");

            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            //Display Array

            Console.WriteLine("Array elements :");

            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
            */

            /*Queue q1 = new Queue();

            q1.Enqueue(45);
            q1.Enqueue("Hello");
            q1.Enqueue(3.5);
            q1.Enqueue(3000);
            q1.Enqueue("Rahul");

            q1.Clear();

            Console.WriteLine("Queue should be Empty.");
            */


            Console.ReadLine();
        }
    }
}
