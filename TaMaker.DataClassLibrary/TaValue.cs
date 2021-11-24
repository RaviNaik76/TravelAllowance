using System;
using System.Data;
using System.Data.SQLite;

namespace TaMaker.DataClassLibrary
{
    public class TaValue
    {
        public string EmpClass { get; set; }
        public double NormalTa { get; set; }
        public double MetroTa { get; set; }
        public double BangloreTa { get; set; }
        public double OutOfStateTa { get; set; }
        public double OutOfStateMetroTa { get; set; }

        public DataTable ViewTaValue(string EmpClass)
        {
            DataTable dt = new DataTable();

            if (EmpClass.Length > 0)
            {
                using (var Cmd = new SQLiteCommand(DbConnection.Conn))
                {
                    Cmd.CommandText = ($"SELECT * FROM TaValue WHERE EmpClass='{EmpClass}'");

                    DbConnection.OpenConnection();
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(Cmd);
                    dataAdapter.Fill(dt);
                    DbConnection.CloseConnection();
                }

            }
            return dt;
        }

        public void UpdateTaValue(string EmpClass, TaValue taValue)
        {
            using (var Cmd = new SQLiteCommand(DbConnection.Conn))
            {
                Cmd.CommandText = ($"UPDATE TaValue SET NormalTa=@nta, MetroTa=@mta, BangloreTa=@bta, OutOfStateTa=@outnta, OutOfStateMetroTa=@outmta WHERE EmpClass='{EmpClass}'");

                Cmd.Parameters.AddWithValue("@nta", taValue.NormalTa);
                Cmd.Parameters.AddWithValue("@mta", taValue.MetroTa);
                Cmd.Parameters.AddWithValue("@bta", taValue.BangloreTa);
                Cmd.Parameters.AddWithValue("@outnta", taValue.OutOfStateTa);
                Cmd.Parameters.AddWithValue("@outmta", taValue.OutOfStateMetroTa);

                DbConnection.OpenConnection();
                Cmd.ExecuteNonQuery();
                DbConnection.CloseConnection();
            }
        }
    }
}
