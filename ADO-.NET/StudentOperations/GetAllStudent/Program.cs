using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetAllStudent
{
    class Program
    {
        static void Main(string[] args)
        {
          string str = @"Data Source=DESKTOP-GGF3KLF\SQLEXPRESS; Initial catalog=studentDB; Integrated security=true";
          SqlConnection con = new SqlConnection(str);
          SqlCommand cmd = new SqlCommand("SPGetAll", con);
          cmd.CommandType = CommandType.StoredProcedure;

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
    

