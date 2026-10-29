using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteCompData
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = @"Data Source=DESKTOP-GGF3KLF\SQLEXPRESS; Initial catalog=CompanyMaster; Integrated security=true";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("DeleteCData", con);
            cmd.CommandType = CommandType.StoredProcedure;

            Console.WriteLine("Enter your Comp Id");
            int id = Convert.ToInt32(Console.ReadLine());
            cmd.Parameters.AddWithValue("@CId", id);


            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();

            if (res > 0)
            {
                Console.WriteLine("Deleted successfully!!!");
            }
            else
            {
                Console.WriteLine("Error occurred!!");
            }

            Console.ReadLine();
        }

    }
}
