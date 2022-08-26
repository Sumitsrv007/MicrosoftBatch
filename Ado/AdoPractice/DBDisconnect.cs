using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

/*namespace MicrosoftBatch.Ado.AdoPractice
{
    class DBDisconnect
    {

        //2nd way to create a connection and close after select,insert and delete
          public static DataSet getAllStudent
        {
            SqlConnection con = null;
            con = DBConnect.getConnection();
            SqlDataAdapter sdp = new SqlDataAdapter("select * from employees", con);
            DataSet ds = new DataSet();//Collection of table
            foreach (DataRow dr in ds.Tables[employees].Rows)
            {
                Console.WriteLine(dr[0]+" "+dr[1]+" "+dr[2]);
            }
        }
             static void Main(string[] args)
               {
                 
               }
    }
}*/
