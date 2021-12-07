using System.Data;
using System.Data.SQLite;

namespace TaMaker.DataClassLibrary
{
    public class TaValueSuplier
    {
        public static double GetTaValue(string empClass, string placeType)
        {
            double Tavalue = 0.0;
            DataTable dt = GetTaValueTable(empClass);

            if (dt.Rows.Count > 0)
            {
                switch (placeType)
                {
                    case "Banglore":
                        Tavalue = double.Parse(dt.Rows[0]["BangloreTa"].ToString());
                        break;
                    case "State Others":
                        Tavalue = double.Parse(dt.Rows[0]["NormalTa"].ToString());
                        break;
                    case "State Metro":
                        Tavalue = double.Parse(dt.Rows[0]["MetroTa"].ToString());
                        break;
                    case "Out of State Others":
                        Tavalue = double.Parse(dt.Rows[0]["OutOfStateTa"].ToString());
                        break;
                    case "Out of State Metro":
                        Tavalue = double.Parse(dt.Rows[0]["OutOfStateMetroTa"].ToString());
                        break;
                }
            }
            return Tavalue;
        }

        public static DataTable GetTaValueTable(string EmpClass)
        {
            DataTable dt = new DataTable();
            using (var Cmd = new SQLiteCommand(DbConnection.Conn))
            {
                Cmd.CommandText = ($"SELECT * FROM TaValue WHERE EmpClass='{EmpClass}'");
                DbConnection.OpenConnection();
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(Cmd);
                dataAdapter.Fill(dt);
                DbConnection.CloseConnection();
            }
            return dt;
        }
    }
}
