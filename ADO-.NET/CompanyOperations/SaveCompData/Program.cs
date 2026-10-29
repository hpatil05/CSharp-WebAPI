using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveCompData
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = @"Data Source=DESKTOP-GGF3KLF\SQLEXPRESS; Initial catalog=CompanyMaster; Integrated security=true";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("SaveCompany", con);
            cmd.CommandType = CommandType.StoredProcedure;

            Console.WriteLine("Enter your Comp Id");
            int id = Convert.ToInt32(Console.ReadLine());
            cmd.Parameters.AddWithValue("@CId", id);

            Console.WriteLine("Enter your Comp Name");
            string name = Console.ReadLine();
            cmd.Parameters.AddWithValue("@CName", name);

            Console.WriteLine("Enter your Department");
            string dept = Console.ReadLine();
            cmd.Parameters.AddWithValue("@Department", dept);

            Console.WriteLine("Enter your City");
            string city = Console.ReadLine();
            cmd.Parameters.AddWithValue("@City", city);


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
