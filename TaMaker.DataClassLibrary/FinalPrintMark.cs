using System;
using System.Data.SQLite;

namespace TaMaker.DataClassLibrary
{
    public static class FinalPrintMark
    {
        public static void AddFinalMark(string myear, string mark, string mdate)
        {
            using (var Cmd = new SQLiteCommand(DbConnection.Conn))
            {
                Cmd.CommandText = ($"INSERT OR IGNORE INTO Marking (M_Year, Mark, MarkedDate) values (@myear, @mark, @date)");
                Cmd.Parameters.AddWithValue("@myear", myear);
                Cmd.Parameters.AddWithValue("@mark", mark);
                Cmd.Parameters.AddWithValue("@date", mdate);

                DbConnection.OpenConnection();
                Cmd.ExecuteNonQuery();
                DbConnection.CloseConnection();
            }
        }

        public static bool GetFinalMark(string myear)
        {
            using (var Cmd = new SQLiteCommand(DbConnection.Conn))
            {
                Cmd.CommandText = ($"SELECT * FROM Marking WHERE M_Year ='{myear}'");
                DbConnection.OpenConnection();
                using (SQLiteDataReader dr = Cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string mark = dr.GetValue(1).ToString();
                        if (mark == "Marked")
                        {
                            return true;
                        }
                    }
                }
                DbConnection.CloseConnection();
            }
            return false;
        }
    }
}
