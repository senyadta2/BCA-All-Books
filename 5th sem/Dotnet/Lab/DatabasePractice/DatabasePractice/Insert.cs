/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DatabasePractice
{
    internal class Insert
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Rikin Tuladhar");
            try
            {
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-4IDNGEI\\SQLEXPRESS;Initial Catalog=Students;Integrated Security=True");
                connection.Open();
                SqlCommand command = new SqlCommand("Insert into Student (Std_ID,Std_Name,Std_Class) values (1,'Ravi','Class 2')", connection);
                int rowAffected = command.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    Console.WriteLine("Inserted into Database");

                }
                else
                {
                    Console.WriteLine("No row affected");
                }


            }
            catch (Exception e)
            {
                Console.WriteLine("Error" + e);
            }
        }
    }
}
*/