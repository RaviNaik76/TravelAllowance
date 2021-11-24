using System;
using System.Data.SQLite;

namespace TaMaker.DataClassLibrary
{
    public static class FinalPrintMark
    {
        public static void AddFinalMark(string myear, string unit, string mark, string mdate)
        {
            using (var Cmd = new SQLiteCommand(DbConnection.Conn))
            {
                Cmd.CommandText = ($"INSERT OR IGNORE INTO Marking (M_Year, Unit, Mark, MarkedDate) values (@myear, @unit, @mark, @date)");
                Cmd.Parameters.AddWithValue("@myear", myear);
                Cmd.Parameters.AddWithValue("@unit", unit);
                Cmd.Parameters.AddWithValue("@mark", mark);
                Cmd.Parameters.AddWithValue("@date", mdate);

                DbConnection.OpenConnection();
                Cmd.ExecuteNonQuery();
                DbConnection.CloseConnection();
            }
        }

        public static bool GetFinalMark(string myear, string unit)
        {
            using (var Cmd = new SQLiteCommand(DbConnection.Conn))
            {
                Cmd.CommandText = ($"SELECT * FROM Marking WHERE M_Year ='{myear}' AND Unit ='{unit}'");
                DbConnection.OpenConnection();
                using (SQLiteDataReader dr = Cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string mark = dr.GetValue(2).ToString();
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
