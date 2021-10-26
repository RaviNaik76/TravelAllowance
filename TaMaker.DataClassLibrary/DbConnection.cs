using System.Configuration;
using System.Data;
using System.Data.SQLite;

namespace TaMaker.DataClassLibrary
{
    public class DbConnection
    {
        private static readonly string ConnString = ConfigurationManager.ConnectionStrings["SQLiteConnectionString"].ConnectionString;
        public static readonly SQLiteConnection Conn = new SQLiteConnection(ConnString);

        public static void OpenConnection()
        {
            if (Conn.State == ConnectionState.Closed)
            {
                Conn.Open();
            }
        }

        public static void CloseConnection()
        {
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();
            }
        }
    }
}
