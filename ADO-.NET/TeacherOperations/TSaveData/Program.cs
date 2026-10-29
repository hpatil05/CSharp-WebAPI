using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSaveData
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = @"Data Source=DESKTOP-GGF3KLF\SQLEXPRESS; Initial catalog=TeacherDB; Integrated security=true";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("SaveTeacher", con);
            cmd.CommandType = CommandType.StoredProcedure;

            Console.WriteLine("Enter your Id");
            int id = Convert.ToInt32(Console.ReadLine());
            cmd.Parameters.AddWithValue("@TeacherId", id);

            Console.WriteLine("Enter your Name");
            string name = Console.ReadLine();
            cmd.Parameters.AddWithValue("@TeacherName", name);

            Console.WriteLine("Enter your Subject");
            string sub = Console.ReadLine();
            cmd.Parameters.AddWithValue("@Subject", sub);

            Console.WriteLine("Enter your Salary");
            int salary = Convert.ToInt32(Console.ReadLine());
            cmd.Parameters.AddWithValue("@Salary", salary);

            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();

            if (res > 0)
            {
                Console.WriteLine("Inserted successfully!!!");
            }
            else
            {
                Console.WriteLine("Error occurred!!");
            }

            Console.ReadLine();
        }
    }
}
