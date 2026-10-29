using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLevelInheritance
{

    /*class Person
    {
        public string Name { get; set;}
        public int Age { get; set; }
    }
    class Student:Person
    {
        public int RollNo { get; set; }
        public string Course { get; set; }

        public void DisplayDetails()
        {
            string Name = "Harshada";
            int Age = 25;
            int RollNo = 101;
            string Course = "CSharp";

            Console.WriteLine(Name);
            Console.WriteLine(Age);
            Console.WriteLine(RollNo);
            Console.WriteLine(Course);

        }
    }*/

    /*class Employee
    {
        public int EmpId = 101;
        public double Salary = 40000;
    }
    

    class Manager:Employee
    {
        public string Department = "IT";

        public void DisplayDetails()
        {
            double YearlySalary = Salary * 12;

            Console.WriteLine("EmpId: "+EmpId);
            Console.WriteLine("Salary: "+Salary);
            Console.WriteLine("Department:" +Department);

        }
    }
    */


    /*class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
    }
    class Car : Vehicle
    {
        public string FuelType;

        public void CarDetails()
        {
            string Brand = "BMW";
            string Model = "BMW X5";
            string FuelType = "Petrol";

            Console.WriteLine("Brand Name = "+Brand);
            Console.WriteLine("Model Name = "+Model);
            Console.WriteLine("FuelType = "+FuelType);
        }
    }
    */


    /*class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is Eating");
        }
    }
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is Barking");
        }
    }
    */


    /*class BankAccount
    {
        public double AccountNumber { get; set; }
        public double Balance { get; set; }
    }
    class SavingAccount : BankAccount
    {
        public double InterestRate;

        public double CalculateInterest()
        {
            return Balance * InterestRate / 100;
        }
    }
    */


    /*class Shape
    {
        public virtual void Area()
        {
            Console.WriteLine("Area of Shape");
        }

    }
    class circle : Shape
    {
        public override void Area()
        {
            double radius = 5;
            double area = 3.14 * radius * radius;

            Console.WriteLine("Area of Circle = "+area);
        }
    }
    */

    
    /*class Teacher
    {
        public string Name ="Mone Sir";
        public string Subject = "Biology";            
    }
    class ScienceTeacher : Teacher
    {
        public void ConductExperiment()
        {
            Console.WriteLine("Teacher Name = "+Name);
            Console.WriteLine("Subject Name = "+Subject);
        }
    }*/

    class Program
    {
        static void Main(string[] args)
        {

            /* Student s1 = new Student();

             s1.DisplayDetails();

             */

            /*Manager m1 = new Manager();

            m1.DisplayDetails();
            */

            /*Car c1 = new Car();

            c1.CarDetails();
            */

            /*Dog d1 = new Dog();
            d1.Eat();
            d1.Bark();
            */

            /*SavingAccount s1 = new SavingAccount();

            s1.AccountNumber = 123456;
            s1.Balance = 50000;
            s1.InterestRate = 8;

            Console.WriteLine(s1.AccountNumber);
            Console.WriteLine(s1.Balance);
            Console.WriteLine(s1.InterestRate);
            Console.WriteLine(s1.CalculateInterest());
            */

            /*circle c = new circle();
            c.Area();
            */

            /*ScienceTeacher t1 = new ScienceTeacher();

            t1.ConductExperiment();
            */

            Console.ReadLine();

                   
        }
    }
}
