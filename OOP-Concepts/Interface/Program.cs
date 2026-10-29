using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    /*interface Shape
    {
        void Area();
    }
    class Circle : Shape
    {
        public void Area()
        {
            double radius = 5;
            double area = 3.14 * radius * radius;

            Console.WriteLine("Area of Circle :"+area);
        }
    }
    class Rectangle : Shape
    {
        public void Area()
        {
            int length = 10;
            int width = 5;
            int area = length * width;

            Console.WriteLine("Area of Rectangle :"+area);
        }
    }*/


    /*interface Animal
    {
        void Speak();
    }
    class Dog : Animal
    {
        public void Speak()
        {
            Console.WriteLine("Dog is Barking");
        }
    }
    class Cat : Animal
    {
        public void Speak()
        {
            Console.WriteLine("Cat Says Meow");
        }
    }
    */


    /*interface Vehicle
    {
        void Start();
    }
    class Car : Vehicle
    {
        public void Start()
        {
            Console.WriteLine("Car is Started");
        }
    }
    class Bike : Vehicle
    {
        public void Start()
        {
            Console.WriteLine("Bike is Started");
        }
    }*/


    /*interface Playable
    {
        void Play();
    }
    class MusicPlayer : Playable
    {
        public void Play()
        {
            Console.WriteLine("Music is Played");
        }
    }
    class VideoPlayer : Playable
    {
        public void Play()
        {
            Console.WriteLine("Video is Played");
        }
    }*/


    /*interface Printer
    {
        void Print();
    }
    interface Scanner
    {
        void Scan();
    }
    class MultiFunctionPrinter : Printer , Scanner
    {
        public void Print()
        {
            Console.WriteLine("Printed");
        }

        public void Scan()
        {
            Console.WriteLine("Scanned");
        }
    }*/


    /*interface Account
    {
        double Balance { get; set; }

        void Deposit(int amount);

    }
    class SavingsAccount : Account
    {
        public double Balance { get; set; }

        public void Deposit(int amount)
        {
            Balance = Balance + amount;
        }
    }
    */


    /*interface Readable
    {
        void Read();
    }
    interface Writable
    {
        void Write();
    }
    interface Document : Readable, Writable
    {
    }
    class FileDocument : Document
    {
        public void Read()
        {
            Console.WriteLine("Readable File");
        }

        public void Write()
        {
            Console.WriteLine("Writable File");
        }
    }*/


    class Program
    {
        static void Main(string[] args)
        {

            /*Circle c = new Circle();
            c.Area();

            Rectangle r = new Rectangle();
            r.Area();
            */

            /*Dog d1=new Dog();
            d1.Speak();

            Cat c1 = new Cat();
            c1.Speak();
            */

            /*Car c = new Car();
            c.Start();

            Bike b = new Bike();
            b.Start();
            */

            /*MusicPlayer mp = new MusicPlayer();
            mp.Play();

            VideoPlayer vp = new VideoPlayer();
            vp.Play();
            */

            /*MultiFunctionPrinter m1 = new MultiFunctionPrinter();
            m1.Print();
            m1.Scan();
            */

            /*SavingsAccount s = new SavingsAccount();
            s.Balance = 5000;

            Console.WriteLine("Before Deposit: "+s.Balance);

            s.Deposit(2000);

            Console.WriteLine("After Deposit: "+s.Balance);
            */

            /*FileDocument f = new FileDocument();
            f.Read();
            f.Write();
            */

        Console.ReadLine();

        }
    }
}
