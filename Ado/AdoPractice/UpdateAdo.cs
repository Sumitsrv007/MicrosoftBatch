using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace MicrosoftBatch.Ado.AdoPractice
{
    class UpdateAdo
    {
        static void Main(string[] args)
        {
            SqlConnection con = DBConnect.getConnection();
            SqlCommand cmd = new SqlCommand("update employees set last_name='Sumit' where last_name='King' ", con);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Console.WriteLine("Record Updated");
            }
        }
    }
}
