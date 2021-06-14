using System;
using System.Data.SqlClient;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            String MyConnectString = @"Data Source = localhost; Initial Catalog = Northwind; Integrated Security = True";

            //SqlConnection conn = new SqlConnection(MyConnectString);
            //SqlCommand cmd = new SqlCommand("sp_Myproc", conn);
            //conn.Open();
            //cmd.ExecuteNonQuery();


            SqlConnection conn = new SqlConnection(MyConnectString);
            SqlCommand cmd = new SqlCommand("sp_Myproc", conn);
            using (conn)
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
