using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arithmetic Operator

            //int p = 30, q = 15;

            //Addition
            //Console.WriteLine(p + q);  //45

            //Substraction
            //Console.WriteLine(p - q);  //15

            //Multiplication
            //Console.WriteLine(p * q);  //450

            //Division
            //Console.WriteLine(p / q);  //2

            //Modulus
            //Console.WriteLine(p % q); //0


            //Relational operators

            //int i = 60, j =45 ;

            //Console.WriteLine(i == j);  //False

            //Console.WriteLine(i !=j );  //True

            //Console.WriteLine(i < j);  //False

            //Console.WriteLine(i > j);  //True

            //Console.WriteLine(i <= j);  //False

            //Console.WriteLine(i >= j);  //True


            //Assignment Operator

            //int q = 12;

            //Console.WriteLine(q += 7);  //19

            //Console.WriteLine(q -= 7);  //12

            //Console.WriteLine(q *= 7);  //84

            //Console.WriteLine(q /= 7);  //1

            //Console.WriteLine(q %= 7);  //5


            //Logical Operator

            //int a = 22, b = 35;

            // && Logical AND

            //Console.WriteLine((a>b) && (a<b)); //False

            //Console.WriteLine((a<b) && (a<=b)); //true

            //Console.WriteLine((a>b) && (a<=b));  //False

            //Console.WriteLine((a<b) && (a>=b));  //False

            //bool result = ((b>a) && (b>=a));
            //Console.WriteLine(result);   //true


            // || Logical OR 

            //bool result = (b > a) || (b >= a);
            //Console.WriteLine(result); //true

            //Console.WriteLine((a<b) || (b<= a)); //true

            //Console.WriteLine((a>b) || (b<=a)); //False

            //Console.WriteLine((b<a) || (a>=b)); //False


            // ! Logical NOT 

            //Console.WriteLine(! (a>b)); //True

            //Console.WriteLine(! (b>a)); //False

            //Console.WriteLine(a<b);  //True



            //Prefix and Postfix 

            //Prefix
            //incre/decre operator before variable
            //the compiler will first increment i by 1 and then will assign it to j.
            // i = 21, j = 21
            int i = 20;
            int j = ++i;
            Console.WriteLine(j); //21

            //Postfix
            //incre/decre operator after variable
            //the compiler will first assign a to b and then increment a by 1.
            //b = 30, a = 31
            int a = 30;
            int b = a++;
            Console.WriteLine(b); //30
            Console.WriteLine(a); //31



            ////Area Of Square
            //int s = 20;

            //int AreaOfSquare = s * s;
            //Console.WriteLine(AreaOfSquare); //400


            ////Area Of Rectangle
            //int l = 15, b = 20;

            //int AreaOfRectangle = l * b;
            //Console.WriteLine(AreaOfRectangle); //300


            ////Area Of Circle
            //float pi = 3.14f, r = 12;

            //float AreaOfCircle = pi * r * r;
            //Console.WriteLine(AreaOfCircle);  // 452.16


            ////Area Of Triangle
            //float b = 10, h = 18;

            //float AreaOfTriangle = 0.5f * b * h;
            //Console.WriteLine(AreaOfTriangle);  //90


            ////Area Of Cone
            //float pi = 3.14f, r = 10, l = 15;

            //float AreaOfCone = pi * r + l; //46.4
            //Console.WriteLine(AreaOfCone);


            ////Area Of Cylinder
            //float pi = 3.14f, r = 16, h = 22;

            //float AreaOfCylinder = 2 * pi * r * r + h;
            //Console.WriteLine(AreaOfCylinder);  //1629.68


            ////Circumference Of Circle
            //float pi = 3.14f, r = 15;

            //float CircumferenceOfCircle = 2 * pi * r;
            //Console.WriteLine(CircumferenceOfCircle); //94.2


            ////Simple Interest
            //int P = 10, R = 20, T = 30;

            //int SimpleInterest = P * R * T / 100;
            //Console.WriteLine(SimpleInterest);  //60


            Console.ReadLine();
        }
    }
}
