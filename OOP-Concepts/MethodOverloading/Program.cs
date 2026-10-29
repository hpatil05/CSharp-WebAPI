using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    /*class Calculator
    {
        public int Add(int a,int b)
        {
            return a + b;
        }
        public double Add(double a,double b)
        {
            return a + b;
        }
        public int Add(int a,int b,int c)
        {
            return a + b + c;
        }
        public string Add(string a,string b)
        {
            return a + b;
        }
    }*/

    /*class Shape
    {
        public int Area(int side)
        {
            return side * side; 
        }
        public int Area(int length,int breadth)
        {
            return length * breadth;
        }
        public double Area(double radius)
        {
            return 3.14 * radius * radius;
        }
    }*/

    /*class Printer
    {
        public void Print(int number)
        {
            Console.WriteLine("Integer = "+number);
        }
        public void Print(string text)
        {
            Console.WriteLine("String = "+text);
        }
        public void Print(double value)
        {
            Console.WriteLine("Double = "+value);
        }
        public void Print(int a,int b)
        {
            Console.WriteLine("Sum = "+(a+b));
        }
    }*/

    /*class Student
    {
        public void DisplayInfo(string name)
        {
            Console.WriteLine("Name = "+name);
        }
        public void DisplayInfo(string name, int age)
        {
            Console.WriteLine("Name = "+name);
            Console.WriteLine("Age = "+age);
        }
        public void DisplayInfo(string name,int age,string course)
        {
            Console.WriteLine("Name = "+name);
            Console.WriteLine("Age = "+age);
            Console.WriteLine("String = "+course);
        }
    }*/

    /*class VolumeCalculator
    {
        public int Volume(int side)
        {
            return side * side * side;
        }
        public int Volume(int length,int breadth,int height)
        {
            return length * breadth * height;
        }
        public double Volume(double radius)
        {
            return (4.0/3.0) * 3.14 * radius * radius *radius;
        }
    }*/

    class Greeting
    {
        public void SayHello()
        {
            Console.WriteLine("Hello!");
        }
        public void SayHello(string name)
        {
            Console.WriteLine("Hello = "+name);
        }
        public void SayHello(string name,int age)
        {
            Console.WriteLine("Hello, " + name + "! You are " + age + " years old.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*Calculator c1 = new Calculator();

            Console.WriteLine("Sum of two integers =" +c1.Add(10,20));
            Console.WriteLine("Sum of two double numbers =" +c1.Add(12.6,20.7));
            Console.WriteLine("Sum of three integers =" +c1.Add(15,20,25));
            Console.WriteLine("Concatenate string ="+c1.Add("Good ","Morning"));
            */

            /*Shape s1 = new Shape();

            Console.WriteLine("Area of Square ="+s1.Area(5));
            Console.WriteLine("Area of Rectangle =" + s1.Area(10,5));
            Console.WriteLine("Area of Circle =" + s1.Area(7.0));
            */

            /*Printer p1 = new Printer();

            p1.Print(10);
            p1.Print("Harshada");
            p1.Print(20.7);
            p1.Print(15, 20);
            */

            /*Student s1 = new Student();

            s1.DisplayInfo("Harshada");
            Console.WriteLine();
            s1.DisplayInfo("Dipali", 20);
            Console.WriteLine();
            s1.DisplayInfo("Mayuri", 30,"CSharp");
            */

            /*VolumeCalculator vc = new VolumeCalculator();

            Console.WriteLine("Volume of Cube = "+vc.Volume(5));
            Console.WriteLine("Volume of Cuboid = "+vc.Volume(10,7,4));
            Console.WriteLine("Volume of Sphere = "+vc.Volume(7.0));
            */

            Greeting g1 = new Greeting();
            g1.SayHello();
            g1.SayHello("Harshada");
            g1.SayHello("Harshada", 25);

            Console.ReadLine();
            
        }
    }
}
