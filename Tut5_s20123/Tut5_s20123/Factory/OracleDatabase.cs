namespace Tut5_s20123.Factory
{
    public class OracleDatabase : IDatabase
    {
        public void Connect()
        {
            Console.WriteLine("Connecting to Oracle database...");
        }

        public void ExecuteQuery(string query)
        {
            Console.WriteLine("Executing query in Oracle database: " + query);
        }
    }

}
