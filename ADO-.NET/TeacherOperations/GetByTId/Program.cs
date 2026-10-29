using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetByTId
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = @"Data Source=DESKTOP-GGF3KLF\SQLEXPRESS; Initial catalog=TeacherDB; Integrated security=true";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("GetbyTeacherId", con);
            cmd.CommandType = CommandType.StoredProcedure;

            Console.WriteLine("Enter your Id");
            int id = Convert.ToInt32(Console.ReadLine());
            cmd.Parameters.AddWithValue("@TeacherId", id);



            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Console.WriteLine("TeacherId is " + dt.Rows[i]["TeacherId"]);
                Console.WriteLine("TeacherName is " + dt.Rows[i]["TeacherName"]);
                Console.WriteLine("Subject is " + dt.Rows[i]["Subject"]);
                Console.WriteLine("Salary is " + dt.Rows[i]["Salary"]);
                Console.WriteLine("=========================");
            }

            Console.ReadLine();
        }
    }
}
