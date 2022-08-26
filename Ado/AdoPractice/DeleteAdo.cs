using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace MicrosoftBatch.Ado.AdoPractice
{
    class DeleteAdo
    {
        static void Main(string[] args)
        {
            SqlConnection con = DBConnect.getConnection();
            SqlCommand cmd = new SqlCommand("delete from employees where first_name='Lex' ", con);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Console.WriteLine("Record Inserted");
            }
        }
    }
}
