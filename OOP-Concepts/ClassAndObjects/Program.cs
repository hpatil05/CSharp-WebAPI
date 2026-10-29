using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    /*class Student
    {
        public int Id = 101;
        public string Name = "Harshada";
        public string CollegeName = "RCP";
    }*/

    /*class Teacher
    {
        public string Name = "Manoj";
        public string Subject = "CSharp";
        public int Age = 30;
    }*/

    /*class Laptop
    {
        public string ModelName;
        public string Configuration;
        public string RAM;
    }
    */

    /*class Customer
    {
        public string CustName = "Abhay";
        public int CustId = 101;
        public double CustMobileNo = 9765342169;
        public string CustAddress = "Pune";      
    }
    */

    /*class Company
    {
        public string CompName= "TCS";
        public string Location = "Hinjewadi";
        public string City = "Pune";
    }*/

     class Order
    {
        public string BurgerName;
        public string size;
        public double Price;
        public string type;
    }

    /*class Hospital
    {
        public string HospitalName;
        public string Location;
        public int NumberOfBeds;
    }*/

    /*class Mobile
    {
        public string MobileName = "Samsung";
        public double MobileNo = 7567894323;
        public int AndroidVersion = 16;
    }*/

    /*class Hotel
    {
        public string HotelName = "Paradise";
        public string Location = "Pune";
        public int NumberOfRooms = 100;
    }*/

    /*class Employee
    {
        public string EmpName = "Yogesh";
        public int EmpId = 101;
        public string Designation = "Software Developer";
        public double Salary = 50000;

    }*/

    /*class Bank
    {
        public int AccountNo;
        public string AccountHolderName;
        public string BranchName;
        public double Balance;
    }*/

    /*class Product
    {
        public string productName = "Laptop";
        public int productId = 102;
        public double price = 50000;
        public string company = "Dell";
    }*/


    /*class Loan
    {
        public int loanId = 101;
        public string custName = "Raj";
        public double amount = 50000;
        public string interest = "8.5%";
        public string duration = "3 yeas";
    }
    */

    /*class Worker
    {
        public int workerId = 101;
        public string workerName = "Ram";
        public string companyName = "DBS Mintek";
        public double salary = 20000;
    }*/

    /*class Machine
    {
        public int machineId;
        public string machineName;
        public string companyName;
        public double price;
    }*/

    class Program
    {
        static void Main(string[] args)
        {
            //Student s1 = new Student();

            //Console.WriteLine(s1.Id);
            //Console.WriteLine(s1.Name);
            //Console.WriteLine(s1.CollegeName);

            /*Teacher t1 = new Teacher();

            Console.WriteLine(t1.Name);
            Console.WriteLine(t1.Subject);
            Console.WriteLine(t1.Age);
            */

            /*Laptop L1 = new Laptop();

            L1.ModelName = "HP";
            L1.Configuration = "2.60GHz";
            L1.RAM = "8 GB";

            Console.WriteLine(L1.ModelName);
            Console.WriteLine(L1.Configuration);
            Console.WriteLine(L1.RAM);
            */

            /*Customer c1 = new Customer();
             
            Console.WriteLine(c1.CustName);
            Console.WriteLine(c1.CustId);
            Console.WriteLine(c1.CustMobileNo);
            Console.WriteLine(c1.CustAddress);
            */

            /*Company c1 = new Company();
            Console.WriteLine(c1.CompName);
            Console.WriteLine(c1.Location);
            Console.WriteLine(c1.City);
            */

            Order ord = new Order();
            ord.BurgerName = "Cheese Burger";
            ord.size = "Medium";
            ord.Price = 250;
            ord.type = "Veg";

            Console.WriteLine(ord.BurgerName);
            Console.WriteLine(ord.size);
            Console.WriteLine(ord.Price);
            Console.WriteLine(ord.type);
             

            /*Hospital h1 = new Hospital();

            h1.HospitalName = "Sancheti Hospital";
            h1.Location = "Pune";
            h1.NumberOfBeds = 150;

            Console.WriteLine(h1.HospitalName);
            Console.WriteLine(h1.Location);
            Console.WriteLine(h1.NumberOfBeds);
            */

            /*Mobile m1 = new Mobile();

            Console.WriteLine(m1.MobileName);
            Console.WriteLine(m1.MobileNo);
            Console.WriteLine(m1.AndroidVersion);
            */

            /*Hotel h1 = new Hotel();
             
            Console.WriteLine(h1.HotelName);
            Console.WriteLine(h1.Location);
            Console.WriteLine(h1.NumberOfRooms);
            */

            /*Employee e1 = new Employee();

            Console.WriteLine(e1.EmpName);
            Console.WriteLine(e1.EmpId);
            Console.WriteLine(e1.Designation);
            Console.WriteLine(e1.Salary);
            */

            /*Bank b1 = new Bank();

            b1.AccountNo = 101;
            b1.AccountHolderName = "Harshada";
            b1.BranchName = "Dhule";
            b1.Balance = 30000;

            Console.WriteLine(b1.AccountNo);
            Console.WriteLine(b1.AccountHolderName);
            Console.WriteLine(b1.BranchName);
            Console.WriteLine(b1.Balance);
            */

            /*Product p1 = new Product();

            Console.WriteLine(p1.productName);
            Console.WriteLine(p1.productId);
            Console.WriteLine(p1.price);
            Console.WriteLine(p1.company);
            */

            /*Loan L1 = new Loan();

            Console.WriteLine(L1.loanId);
            Console.WriteLine(L1.custName);
            Console.WriteLine(L1.amount);
            Console.WriteLine(L1.interest);
            Console.WriteLine(L1.duration);
            */

            /*Worker w1 = new Worker();

            Console.WriteLine(w1.workerId);
            Console.WriteLine(w1.workerName);
            Console.WriteLine(w1.companyName);
            Console.WriteLine(w1.salary);
            */

            /*Machine m1 = new Machine();
            m1.machineId = 102;
            m1.machineName = "Washing Machine";
            m1.companyName = "LG";
            m1.price = 25000;

            Console.WriteLine(m1.machineId);
            Console.WriteLine(m1.machineName);
            Console.WriteLine(m1.companyName);
            Console.WriteLine(m1.price);
            */

            Console.ReadLine();

        }
    }
}
