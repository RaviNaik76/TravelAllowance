using System.Data;
using System.Data.SQLite;

namespace TaMaker.DataClassLibrary
{
    public class TaValueSuplier
    {
        public static double GetTaValue(string desgnation, string placeType, string forceType)
        {
            double Tavalue = 0.0;
            DataTable dt = GetTaValueTable(desgnation, placeType, forceType);

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


        public static DataTable GetTaValueTable(string desg, string placeType, string forceType)
        {
            DataTable dt = new DataTable();
            int empSort = SourceSuplier.GetEmployeSort(desg, forceType);

            if (desg.Length > 0 && placeType.Length > 0)
            {
                using (var Cmd = new SQLiteCommand(DbConnection.Conn))
                {
                    switch (empSort)
                    {
                        case int n when n >= 2 && n <= 3:
                            Cmd.CommandText = ($"SELECT * FROM TaValue WHERE EmpClass = 'II'");
                            break;

                        case int n when n > 3:
                            Cmd.CommandText = ($"SELECT * FROM TaValue WHERE EmpClass = 'III'");
                            break;

                        case 1:
                            Cmd.CommandText = ($"SELECT * FROM TaValue WHERE EmpClass = 'I'");
                            break;
                    }
                   
                    DbConnection.OpenConnection();
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(Cmd);
                    dataAdapter.Fill(dt);
                    DbConnection.CloseConnection();
                }

            }
            return dt;
        }
    }
}
