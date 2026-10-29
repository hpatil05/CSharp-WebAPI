using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{

    /*class LivingBeing
    {
        public void Eat()
        {
            Console.WriteLine("LivingBeing is Eating");
        }
    }
    class Human : LivingBeing
    {
        public void Speak()
        {
            Console.WriteLine("Human is Speaking");
        }
    }
    class Employee : Human
    {
        public void Work()
        {
            Console.WriteLine("Employee is Working");
        }
    }*/


    /*class Vehicle
    {
        public string Brand = "kia";
        public string Model = "EV6";
    }

    class Car : Vehicle
    {
        public string FuelType = "Electric";
    }

    class ElectricCar:Car
    {
        public string BatteryCapacity = "77kwh";

    }*/


    /*class Person
    {
        public string Name = "Riya";
        public int Age = 18;
    }
    class Student : Person
    {
        public int RollNo = 101;
    }
    class GraduateStudent : Student
    {
        public string ThesisTopic = "Cybersecurity";
    }
    */


    /*class Shape
    {
        public void Draw()
        {
            Console.WriteLine("Draw Shape");
        }
    }
    class Polygen : Shape
    {
        public int NoOfSides = 5;
    }
    class Rectangle : Polygen
    {
        public int Length = 10;
        public int Breadth = 5;
    }
    */


    /*class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal Eating");
        }
    }
    class Mammal : Animal
    {
        public void Breastfeed()
        {
            Console.WriteLine("Mammal Breastfeeding");
        }
    }
    class Dog : Mammal
    {
        public void Bark()
        {
            Console.WriteLine("Dog Barking");
        }
    }
    */


    /*class Bank
    {
        public string BankName { get; set; }
    }
    class Account:Bank
    {
        public double AccountNo{ get; set; }
        public double Balance { get; set; }
    }
    class SavingAccount:Account
    {
        public double InterestRate { get; set; }

        public double CalculateInterest()
        {
            return Balance * InterestRate / 100;
        }
    }
    */


    class Device
    {
        public string Brand { get; set; }
    }
    class Computer : Device
    {
        public string Processor;
    }
    class Laptop : Computer
    {
        public string BatteryBackup;
    }


    class Program
    {
        static void Main(string[] args)
        {
            /*Employee e1 = new Employee();

            e1.Eat();
            e1.Speak();
            e1.Work();
            */

            /*Vehicle v1 = new Vehicle();
            Console.WriteLine(v1.Brand);
            Console.WriteLine(v1.Model);

            Car c1 = new Car();
            Console.WriteLine(c1.Brand);
            Console.WriteLine(c1.Model);
            Console.WriteLine(c1.FuelType);

            ElectricCar e1 = new ElectricCar();
            Console.WriteLine(e1.Brand);
            Console.WriteLine(e1.Model);
            Console.WriteLine(e1.FuelType);
            Console.WriteLine(e1.BatteryCapacity);
            */

            /*GraduateStudent obj = new GraduateStudent();

            Console.WriteLine(obj.Name);
            Console.WriteLine(obj.Age);
            Console.WriteLine(obj.RollNo);
            Console.WriteLine(obj.ThesisTopic);
            */

            /*Rectangle r = new Rectangle();

            int Area = r.Length * r.Breadth;

            r.Draw();
            Console.WriteLine(r.NoOfSides);
            Console.WriteLine(r.Length);
            Console.WriteLine(r.Breadth);
            Console.WriteLine("Area of Ractangle: " +Area);
            */

            /*Dog d = new Dog();

            d.Eat();
            d.Breastfeed();
            d.Bark();
            */

            /*SavingAccount s1 = new SavingAccount();

            s1.BankName = "State Bank";
            s1.AccountNo = 123456;
            s1.Balance = 70000;
            s1.InterestRate = 5;

            Console.WriteLine(s1.BankName);
            Console.WriteLine(s1.AccountNo);
            Console.WriteLine(s1.Balance);
            Console.WriteLine(s1.InterestRate);

            Console.WriteLine(s1.CalculateInterest());
            */

            Laptop L1 = new Laptop();

            L1.Brand = "HP" ;
            L1.Processor = "Intel Core i5";
            L1.BatteryBackup = "8";

            Console.WriteLine(L1.Brand);
            Console.WriteLine(L1.Processor);
            Console.WriteLine(L1.BatteryBackup);

            Console.ReadLine();
        }
    }
}
