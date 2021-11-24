using System;
using System.Data;
using System.Data.SQLite;

namespace TaMaker.DataClassLibrary
{
    public class Designation
    {
        public int Id { get; set; }
        public string Desig { get; set; }
        public int SortOrder { get; set; }
        public string UnitName { get; set; }


        public DataTable ViewDesignation(string Unit)
        {
            DataTable dt = new DataTable();
            using (var Cmd = new SQLiteCommand(DbConnection.Conn))
            {
                Cmd.CommandText = ($"SELECT * FROM DesignationTable WHERE UnitName='{Unit}'");

                DbConnection.OpenConnection();
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(Cmd);
                dataAdapter.Fill(dt);
                DbConnection.CloseConnection();
            }
            return dt;
        }

        public static void UpdateDesignation(int id, Designation desig)
        {
            using (var Cmd = new SQLiteCommand(DbConnection.Conn))
            {
                Cmd.CommandText = ($"UPDATE DesignationTable SET Designation=@desig, SortOrder=@sorder, UnitName=@unit WHERE Id={id}");

                Cmd.Parameters.AddWithValue("@desig", desig.Desig);
                Cmd.Parameters.AddWithValue("@sorder", desig.SortOrder);
                Cmd.Parameters.AddWithValue("@unit", desig.UnitName);

                DbConnection.OpenConnection();
                Cmd.ExecuteNonQuery();
                DbConnection.CloseConnection();
            }
        }
       
        public static void AddDesignation(Designation desig)
        {
            using (var Cmd = new SQLiteCommand(DbConnection.Conn))
            {
                //get id
                int id = GetDesigId();

                Cmd.CommandText = ($"INSERT INTO DesignationTable (Id, Designation, SortOrder, UnitName) Values (@id, @desig, @sorder, @unit)");
                Cmd.Parameters.AddWithValue("@id", id);
                Cmd.Parameters.AddWithValue("@desig", desig.Desig);
                Cmd.Parameters.AddWithValue("@sorder", desig.SortOrder);
                Cmd.Parameters.AddWithValue("@unit", desig.UnitName);

                DbConnection.OpenConnection();
                Cmd.ExecuteNonQuery();
                DbConnection.CloseConnection();
            }
        }

        private static int GetDesigId()
        {
            int desId = 0;
            string SqlQuery = "SELECT MAX(Id) FROM DesignationTable";
            
            SQLiteCommand Cmd = new SQLiteCommand(SqlQuery, DbConnection.Conn);
            DbConnection.OpenConnection();

            SQLiteDataReader reader = Cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetValue(0).ToString() != "")
                {
                    desId = int.Parse(reader.GetValue(0).ToString());
                }
            }
            DbConnection.CloseConnection();
            if (desId > 0)
            {
                desId++;
            }
            else { desId=1; }
            
            return desId;
        }
    }
}
