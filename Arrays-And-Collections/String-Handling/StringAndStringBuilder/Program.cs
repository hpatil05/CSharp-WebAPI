using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using String

            /*Console.Write("Enter Name: ");

            string name = Console.ReadLine();


            Length of string

            Console.WriteLine(name.Length);
            */


            //String Reverse

            /*Console.Write("Enter Name: ");

            string name = Console.ReadLine();


            string rev = "";

            for (int i = name.Length-1; i>=0; i--)
            {
                rev = rev + name[i];
               
            }
            Console.WriteLine("Reverse string name: "+rev);
            */


            //Check Palindrome or not
            /*Console.Write("Enter Name: ");

            string name = Console.ReadLine();


            string rev = "";

            for (int i = name.Length - 1; i >= 0; i--)
            {
                rev = rev + name[i];
            }
            if (name == rev)
            {
                Console.WriteLine("String is Palindrome");
            }
            else
            {
                Console.WriteLine("String is not Palindrome");
            }
            */


            //Count Vowels and Consonants
            /*Console.Write("Enter string: ");

            string str = Console.ReadLine();            

            int Vowels = 0;
            int Consonants = 0;

            for(int i =0; i<str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    Vowels++;
                }
                else
                {
                    Consonants++;
                }
            }
            Console.WriteLine("Vowels count: "+Vowels);
            Console.WriteLine("Consonants count: "+Consonants);
            */


            /*string str = "Hello World";

            //substring
            string result = str.Substring(0, 5);

            Console.WriteLine(result);

            //Replace
            Console.WriteLine(str.Replace("World", "C#"));
            */



            //Using StringBuilder

            //Append
            /*StringBuilder sb = new StringBuilder("Hello ");

            Console.WriteLine(sb.Append("World"));            
            */


            //Insert Text
            /*string s1 = "HelloWorld";

            Console.WriteLine(s1.Insert(5," "));
            */


            //Remove Characters
            /*string sb = "Programming";

            Console.WriteLine(sb.Remove(3,4));
            */


            //Replace Text
            /*string s2 = "I Like Java";

            Console.WriteLine(s2.Replace("Java","C#"));
            */


            //with Deafult Capacity And Length

            /*StringBuilder sb = new StringBuilder();

            Console.WriteLine("Capacity: "+sb.Capacity);
            Console.WriteLine("Length: "+sb.Length);

            sb.Append("C# Programming");

            Console.WriteLine("Capacity: " + sb.Capacity);
            Console.WriteLine("Length: " + sb.Length);
            */

            Console.ReadLine();
        }
    }
}
