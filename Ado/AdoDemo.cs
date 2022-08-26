using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
namespace MicrosoftBatch.Ado
{
    class AdoDemo
    {
        static void Main(string[] args)
        {
            string str = "server=SUMIT\\SQLEXPRESS;Database=hr;Integrated Security=True";
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(str);
                Console.WriteLine("Connection Establish");

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
