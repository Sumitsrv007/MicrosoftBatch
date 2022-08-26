using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace MicrosoftBatch.Ado.AdoPractice
{
    class InsertAdo
    {
        //Taking input from user
        static void Main(string[] args)
        {
            SqlConnection con = DBConnect.getConnection();
            Console.WriteLine("Enter Id,Name,Percent");
            int rollno = int.Parse(Console.ReadLine());
            string nm = Console.ReadLine();
            int marks = int.Parse(Console.ReadLine());
            SqlCommand cmd = new SqlCommand("insert into student values(@id,@nm,@mk)", con);
            cmd.Parameters.AddWithValue("@id", rollno);
            cmd.Parameters.AddWithValue("@nm", nm);
            cmd.Parameters.AddWithValue("@mk", marks);
            int i = cmd.ExecuteNonQuery();
            if(i>0)
            {
                Console.WriteLine("Record Inserted");
            }
        }

        //Non 
        static void Main1(string[] args)
        {
            SqlConnection con = DBConnect.getConnection();
            SqlCommand cmd = new SqlCommand("insert into student values(1,'Zain',95)", con);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Console.WriteLine("Record Inserted");
            }
        }
    }
}
