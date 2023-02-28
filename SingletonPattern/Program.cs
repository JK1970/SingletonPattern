namespace SingletonPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Database database1 = Database.GetDatabaseInstance();
            Database database2 = Database.GetDatabaseInstance();

            if (database1 == database2)
            {
                Console.WriteLine("Database1 is equal to database2.");
            }
        }
    }
}
