using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetbyCompId
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = @"Data Source=DESKTOP-GGF3KLF\SQLEXPRESS; Initial catalog=CompanyMaster; Integrated security=true";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("GetbyCId", con);
            cmd.CommandType = CommandType.StoredProcedure;

            Console.WriteLine("Enter your Id");
            int id = Convert.ToInt32(Console.ReadLine());
            cmd.Parameters.AddWithValue("@CId", id);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Console.WriteLine("CompanyId is " + dt.Rows[i]["CId"]);
                Console.WriteLine("CompanyName is " + dt.Rows[i]["CName"]);
                Console.WriteLine("Department is " + dt.Rows[i]["Department"]);
                Console.WriteLine("City is " + dt.Rows[i]["City"]);

                Console.WriteLine("=========================");
            }

            Console.ReadLine();
        }
    }
}
