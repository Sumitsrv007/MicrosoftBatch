using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace MicrosoftBatch.Ado.AdoPractice
{
    static class DBConnect
    {
        //1 way to create a connection
        public static SqlConnection getConnection()
        {
            string str = "server=SUMIT\\SQLEXPRESS;Database=hr;Integrated Security=True";
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(str);
                Console.WriteLine("Connection Establish");
                con.Open();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return con;
        }
    }
}
