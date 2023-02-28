namespace SingletonPattern
{
    public class Database
    {
        private static Database? _databaseInstance;
        public static Database GetDatabaseInstance()
        {
            if (_databaseInstance is null)
            {
                _databaseInstance = new();
            }
            return _databaseInstance;
        }
        private Database()
        {

        }
    }
}