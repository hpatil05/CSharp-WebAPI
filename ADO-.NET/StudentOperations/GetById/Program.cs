using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetById
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = @"Data Source=DESKTOP-GGF3KLF\SQLEXPRESS; Initial catalog=studentDB; Integrated security=true";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("SPGetbyStudId", con);
            cmd.CommandType = CommandType.StoredProcedure;

            Console.WriteLine("Enter your Id");
            int id = Convert.ToInt32(Console.ReadLine());
            cmd.Parameters.AddWithValue("@StudId", id);



            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Console.WriteLine("StudId is " + dt.Rows[i]["Id"]);
                Console.WriteLine("StudName is " + dt.Rows[i]["Name"]);
                Console.WriteLine("Marks is " + dt.Rows[i]["Marks"]);
                Console.WriteLine("=========================");
            }

            Console.ReadLine();

        }
    }
}
    
