/*using System.Data.SqlClient;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Rikin Tulahdar");
        try
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-4IDNGEI\\SQLEXPRESS;Initial Catalog=Students;Integrated Security=True");
            connection.Open();
            SqlCommand Command = new SqlCommand("Select * from Student", connection);
            SqlDataReader reader = Command.ExecuteReader();
            Console.WriteLine("ID\t|Name");
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine(reader.GetInt32(0) + "\t" + reader.GetString(1));
                }
            }
            else
            {
                Console.WriteLine("No Rows Found");
            }
            reader.Close();

        }

        catch (Exception ex)
        {
            Console.WriteLine("Eroor " + ex);
        }
    }
}*/