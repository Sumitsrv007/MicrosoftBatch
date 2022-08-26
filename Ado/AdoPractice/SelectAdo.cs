using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace MicrosoftBatch.Ado.AdoPractice
{
    class SelectAdo
    {
        static void Main(string[] args)
        {
            SqlConnection con = DBConnect.getConnection();
            SqlCommand cmd = new SqlCommand("select last_name,salary from employees", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Console.WriteLine(reader[0] + " " + reader[1]);
                }

            }
            catch (Exception e)
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
