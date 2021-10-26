using System.Data.SQLite;
using TaMaker.BaseClassLibrary;

namespace TaMaker.DataClassLibrary
{
    public class DistrictUnits
    {
        public void AddUnits(Units units)
        {
            using (var Cmd = new SQLiteCommand(DbConnection.Conn))
            {
                Cmd.CommandText = ($"INSERT OR IGNORE INTO Units (UnitName, UnitType, UnitDist) values (@uname, @utype, @distCode)");
                Cmd.Parameters.AddWithValue("@uname", units.UnitName);
                Cmd.Parameters.AddWithValue("@utype", units.UnitType);
                Cmd.Parameters.AddWithValue("@distCode", units.DistCode);

                DbConnection.OpenConnection();
                Cmd.ExecuteNonQuery();
                DbConnection.CloseConnection();
            }
        }

        public void AddSource(Source src)
        {
            using (var Cmd = new SQLiteCommand(DbConnection.Conn))
            {
                Cmd.CommandText = ($"INSERT OR IGNORE INTO SourceTable (SourceName, SourceType) values (@sname, @stype)");
                Cmd.Parameters.AddWithValue("@sname", src.SourceName);
                Cmd.Parameters.AddWithValue("@stype", src.SourceType);

                DbConnection.OpenConnection();
                Cmd.ExecuteNonQuery();
                DbConnection.CloseConnection();
            }
        }
    }
}
