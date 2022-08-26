using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace MicrosoftBatch.Ado
{
    static class DBConnect
    {
        public static SqlConnection getConnection()
        {
            string str = "server=SUMIT\\SQLEXPRESS;Database=hr;Integrated Security=True";
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(str);
                Console.WriteLine("Connection Establish");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return con;
        }
    }
    class MyAdo1
    {
        static void Main(string[] args)
        {
            SqlConnection con = DBConnect.getConnection();
            SqlCommand cmd = new SqlCommand("select first_name,salary from employee", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Console.WriteLine(reader[0] + " " + reader[1]);
                }
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
             finally
            {
                 if (con != null)
                 con.Close();
                
            }

        }
    }
}
