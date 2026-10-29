using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveData
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = @"Data Source=DESKTOP-GGF3KLF\SQLEXPRESS; Initial catalog=studentDB; Integrated security=true";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("SPSaveStudent", con);
            cmd.CommandType = CommandType.StoredProcedure;

            Console.WriteLine("Enter your Id");
            int id = Convert.ToInt32(Console.ReadLine());
            cmd.Parameters.AddWithValue("@StudId", id);

            Console.WriteLine("Enter your Name");
            string name = Console.ReadLine();
            cmd.Parameters.AddWithValue("@StudName", name);

            Console.WriteLine("Enter your Marks");
            int marks = Convert.ToInt32(Console.ReadLine());
            cmd.Parameters.AddWithValue("@Marks", marks);

            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();

            if(res > 0)
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
  