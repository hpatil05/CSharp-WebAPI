using AbstractClassAssig12;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    /*abstract class Shape
    {
        public abstract double Area();  
    }
    class Circle : Shape
    { 

        public override double Area()
        {
            double radius = 5;
            return 3.14 * radius * radius;
        }

    }
    class Rectangle : Shape
    {
  
        public override double Area()
        {
            double length = 10;
            double width = 5;
            return length * width;
        }
    }
    */


    /*abstract class Animal
    {
        public abstract void MakeSound();

        public void Eat()
        {
            Console.WriteLine("Eating");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog says Bark");
        }
    }
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat Says Meow");
        }
    }
    */


    /*abstract class Employee
    {
        public abstract void CalculateSalary();
    }
    class FullTimeEmployee : Employee
    {
        public override void CalculateSalary()
        {
            int monthlySalary = 30000;

            Console.WriteLine("Full Time Employee Salary: "+monthlySalary);
        }
    }
    class PartTimeEmployee : Employee
    {
        public override void CalculateSalary()
        {
            int hours = 5;
            int ratePerHour = 200;
            int Salary = hours * ratePerHour;

            Console.WriteLine("Part Time Employee Salary: "+Salary);
        }
    }
    */


    /*abstract class BankAccount
    {
        public abstract void Withdraw();

        public void deposit()
        {
            Console.WriteLine("Money deposited");
        }
    }
    class SavingsAccount : BankAccount
    {
        public override void Withdraw()
        {
            Console.WriteLine("Money Withdrawn from Saving Account"); 
        }
    }
    class CurrentAccount : BankAccount
    {
        public override void Withdraw()
        {
            Console.WriteLine("Money Withdrawn from Current Account");
        }
    }
    */


    /*abstract class Vehicle
    {
        public abstract void Start();
    }
    class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car is Started");
        }
    }
    class Bike : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Bike is Started");
        }
    }*/



    /*abstract class Appliance
    {
        public Appliance()
        {
            Console.WriteLine("Appliance Created");
        }
        public abstract void Operate();
    }
    class WashingMachine : Appliance
    {
        public override void Operate()
        {
            Console.WriteLine("Washing Machine is Operate");
        }
    }
    class Refrigerator : Appliance
    {
        public override void Operate()
        {
            Console.WriteLine("Refrigerator is Operate");
        }
    }
    */


    /*abstract class Game
    {
        public abstract void StartGame();
    }
    class Cricket : Game
    {
        public override void StartGame()
        {
            Console.WriteLine("Cricket Game is Started"); 
        }
    }
    class Football : Game
    {
        public override void StartGame()
        {
            Console.WriteLine("Football Game is Started");
        }
    }
    */

    class Program
    {
        
        static void Main(string[] args)
        {
            /*Circle c = new Circle();

            Console.WriteLine(c.Area());

            Rectangle r = new Rectangle();

            Console.WriteLine(r.Area());
            */

            /*Dog d = new Dog();
            d.MakeSound();
            d.Eat();

            Cat c = new Cat();
            c.MakeSound();
            c.Eat();
            */

            /*FullTimeEmployee e1 = new FullTimeEmployee();
            e1.CalculateSalary();

            PartTimeEmployee e2 = new PartTimeEmployee();
            e2.CalculateSalary();
            */

            /*SavingsAccount SA = new SavingsAccount();
            SA.deposit();
            SA.Withdraw();
            
            CurrentAccount CA = new CurrentAccount();
            CA.deposit();
            CA.Withdraw();
            */

            /*Car c1 = new Car();
            c1.Start();

            Bike b1 = new Bike();
            b1.Start();
            */

            /*WashingMachine wm = new WashingMachine();
            wm.Operate();

            Refrigerator r = new Refrigerator();
            r.Operate();
            */

            /*Cricket c1 = new Cricket();
            c1.StartGame();

            Football f1 = new Football();
            f1.StartGame();
            */

            Console.ReadLine();
        }
    }
}
