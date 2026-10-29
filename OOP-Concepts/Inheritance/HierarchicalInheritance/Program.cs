using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchicalInInheritance
{

    /*class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing Shape");
        }
    }
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Circle Shape");
        }
    }
    class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Square Shape");
        }
    }
    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Triangle Shape");
        }
    }*/

    
    /*class Person
    {
        public string Name;
        public int Age;
    }
    class Student : Person
    {
        public int RollNo;
    }
    class Teacher : Person
    {
        public string Subject;
    }
    class Principal : Person
    {
        public string YearOfExperience;
    }
    */


    /*class vehicle
    {
        public string Brand;
        public string Model;
    }
    class Car : Vehicle
    {
        public string FuelType;
    }
    class Bike : Vehicle
    {
        public int CC;
    }
    class Truck : Vehicle
    {
        public double LoadCapacity;
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
    class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("Cat Says Meow");
        }
    }
    class Cow : Animal
    {
        public void Moo()
        {
            Console.WriteLine("Cow Says Moo");
        }
    }
    */


    /*class Account
    {
        public double AccountNo;
        public double Balance;
    }
    class SavingAccount : Account
    {
        public double InterestRate;
    }
    class CurrentAccount : Account
    {
        public double OverdraftLimit;
    }
    class LoanAccount : Account
    {
        public double LoanAmount;
    }
    */


    /*class Employee
    {
        public int EmpId;
        public double Salary;
    }
    class Manager : Employee
    {
        public string Department = "Sales";
    }
    class Developer : Employee
    {
        public string ProgrammingLanguage = "CSharp";
    }
    class Intern : Employee
    {
        public string Duration = "6 Month";
    }
    */


    class Apliance
    {
        public string Brand;
    }
    class WashingMachine : Apliance
    {
        public string LoadCapacity;
    }
    class Refrigerator : Apliance
    {
        public string Volume;
    }
    class Microwave : Apliance
    {
        public string Power;
    }


    class Program
    {
        static void Main(string[] args)
        {
            /*Circle c = new Circle();
            c.Draw();

            Square s1 = new Square();
            s1.Draw();
        
            Triangle t1 = new Triangle();
            t1.Draw();
            */


            /*Person p = new Person();
            p.Name = "Yogesh";
            p.Age = 30;

            Console.WriteLine(p.Name);
            Console.WriteLine(p.Age);
            Console.WriteLine();

            Student s = new Student();
            s.Name = "Harshada";
            s.Age = 25;
            s.RollNo = 101;

            Console.WriteLine(s.Name);
            Console.WriteLine(s.Age);
            Console.WriteLine(s.RollNo);
            Console.WriteLine();

            Teacher t = new Teacher();
            t.Name = "Pawar sir";
            t.Age = 38;
            t.Subject = "CSharp";

            Console.WriteLine(t.Name);
            Console.WriteLine(t.Age);
            Console.WriteLine(t.Subject);
            Console.WriteLine();

            Principal p1 = new Principal();
            p1.Name = "Dr.M.V.Patil";
            p1.Age = 55;
            p1.YearOfExperience = "5 Years";

            Console.WriteLine(p1.Name);
            Console.WriteLine(p1.Age);
            Console.WriteLine(p1.YearOfExperience);
            */

            /*
            Car c1 = new Car();
            c1.Brand = "BMW";
            c1.Model = "X5";
            c1.FuelType = "Petrol";

            Console.WriteLine(c1.Brand);
            Console.WriteLine(c1.Model);
            Console.WriteLine(c1.FuelType);
            Console.WriteLine();

            Bike b1 = new Bike();
            b1.Brand = "Honda";
            b1.Model = "Shine";
            b1.CC = 125;

            Console.WriteLine(b1.Brand);
            Console.WriteLine(b1.Model);
            Console.WriteLine(b1.CC);
            Console.WriteLine();

            Truck t1 = new Truck();
            t1.Brand = "Tata";
            t1.Model = "Prima";
            t1.LoadCapacity = 10;

            Console.WriteLine(t1.Brand);
            Console.WriteLine(t1.Model);
            Console.WriteLine(t1.LoadCapacity);
            */

            /*Animal a1 = new Animal();
            a1.Eat();

            Dog d1 = new Dog();
            d1.Eat();
            d1.Bark();

            Cat c1 = new Cat();
            c1.Eat();
            c1.Meow();

            Cow c = new Cow();
            c.Eat();
            c.Moo();
            */

            /*Account a1 = new Account();

            a1.AccountNo = 123456 ;
            a1.Balance = 60000 ;

            Console.WriteLine(a1.AccountNo);
            Console.WriteLine(a1.Balance);
            Console.WriteLine();

            SavingAccount s1 = new SavingAccount();

            s1.AccountNo = 100001 ;
            s1.Balance = 50000;
            s1.InterestRate = 5.5;

            Console.WriteLine(s1.AccountNo);
            Console.WriteLine(s1.Balance);
            Console.WriteLine(s1.InterestRate);
            Console.WriteLine();

            CurrentAccount c1 = new CurrentAccount();

            c1.AccountNo = 100005 ;
            c1.Balance = 30000;
            c1.OverdraftLimit = 10000 ;

            Console.WriteLine(c1.AccountNo);
            Console.WriteLine(c1.Balance);
            Console.WriteLine(c1.OverdraftLimit);
            Console.WriteLine();

            LoanAccount l1 = new LoanAccount();

            l1.AccountNo = 100002 ;
            l1.Balance = 20000;
            l1.LoanAmount = 500000;

            Console.WriteLine(l1.AccountNo);
            Console.WriteLine(l1.Balance);
            Console.WriteLine(l1.LoanAmount);
            */

            /*Employee e1 = new Employee();
            e1.EmpId = 101;
            e1.Salary = 30000;

            Console.WriteLine(e1.EmpId);
            Console.WriteLine(e1.Salary);
            Console.WriteLine();

            Manager m1 = new Manager();
            m1.EmpId = 102;
            m1.Salary = 50000;

            Console.WriteLine(m1.EmpId);
            Console.WriteLine(m1.Salary);
            Console.WriteLine(m1.Department);
            Console.WriteLine();

            Developer d1 = new Developer();
            d1.EmpId = 103;
            d1.Salary = 45000;

            Console.WriteLine(d1.EmpId);
            Console.WriteLine(d1.Salary);
            Console.WriteLine(d1.ProgrammingLanguage);
            Console.WriteLine();

            Intern I1 = new Intern();
            I1.EmpId = 104;
            I1.Salary = 15000;

            Console.WriteLine(I1.EmpId);
            Console.WriteLine(I1.Salary);
            Console.WriteLine(I1.Duration);
            */

            WashingMachine wm = new WashingMachine();

            wm.Brand = "LG";
            wm.LoadCapacity = "7 kg";

            Console.WriteLine(wm.Brand);
            Console.WriteLine(wm.LoadCapacity);
            Console.WriteLine();

            Refrigerator r = new Refrigerator();

            r.Brand = "Samsung";
            r.Volume = "250 Litres";

            Console.WriteLine(r.Brand);
            Console.WriteLine(r.Volume);
            Console.WriteLine();

            Microwave m = new Microwave();

            m.Brand = "IFB";
            m.Power = "1200 Watts";

            Console.WriteLine(m.Brand);
            Console.WriteLine(m.Power);


            Console.ReadLine();
        }
    }
}
