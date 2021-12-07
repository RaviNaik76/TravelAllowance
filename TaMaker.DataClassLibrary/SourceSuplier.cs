using System.Collections.Generic;
using System.Data.SQLite;

namespace TaMaker.DataClassLibrary
{
    public class SourceSuplier
    {
        public void AddSource(string sName, string sType)
        {
            using (var Cmd = new SQLiteCommand(DbConnection.Conn))
            {
                Cmd.CommandText = ($"INSERT INTO SourceTable (SourceName, SourceType) values (@sname, @stype)");
                Cmd.Parameters.AddWithValue("@sname", sName);
                Cmd.Parameters.AddWithValue("@stype", sType);

                DbConnection.OpenConnection();
                Cmd.ExecuteNonQuery();
                DbConnection.CloseConnection();
            }
        }

        public static Dictionary<int, string> LoadEmpClass()
        {
            Dictionary<int, string> EmpClass = new Dictionary<int, string>();
            string SqlQuery = "SELECT EmpClass FROM TaValue";
            LoadSource(SqlQuery, EmpClass);
            return EmpClass;
        }

        public static Dictionary<int, string> LoadUnits()
        {
            Dictionary<int, string> UnitList = new Dictionary<int, string>();
            string SqlQuery = "SELECT * FROM SourceTable WHERE SourceType='Unit'";
            LoadSource(SqlQuery, UnitList);
            return UnitList;
        }

        public static Dictionary<int, string> LoadEmpStatus()
        {
            Dictionary<int, string> OfficeType = new Dictionary<int, string>();
            string SqlQuery = "SELECT * FROM EmpStatusView";
            LoadSource(SqlQuery, OfficeType);
            return OfficeType;
        }

        public static Dictionary<int, string> LoadPlaces()
        {
            Dictionary<int, string> PlaceList = new Dictionary<int, string>();
            string SqlQuery = "SELECT * FROM PlacesView";
            LoadSource(SqlQuery, PlaceList);
            return PlaceList;
        }

        public static Dictionary<int, string> LoadVehicleType()
        {
            Dictionary<int, string> VehicleType = new Dictionary<int, string>();
            string SqlQuery = "SELECT * FROM VehicleTypeView";
            LoadSource(SqlQuery, VehicleType);
            return VehicleType;
        }


        public static Dictionary<int, string> LoadHaltingPlace()
        {
            Dictionary<int, string> HaltingPlace = new Dictionary<int, string>();
            string SqlQuery = "SELECT * FROM HaltingPlaceView";
            LoadSource(SqlQuery, HaltingPlace);
            return HaltingPlace;
        }

        public static Dictionary<int, string> LoadDesignation(string unit)
        {
            Dictionary<int, string> Designation = new Dictionary<int, string>();
            string SqlQuery = ($"SELECT Designation, SortOrder FROM DesignationTable WHERE UnitName='{unit}'");
            LoadSource(SqlQuery, Designation);
            return Designation;
        }

        public static int GetGroupId()
        {
            int groupId = 0;
            string SqlQuery = "SELECT * FROM GroupIdView";
            using (SQLiteCommand Cmd = new SQLiteCommand(SqlQuery, DbConnection.Conn))
            {
                DbConnection.OpenConnection();
                SQLiteDataReader reader = Cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetValue(0).ToString() != "")
                    {
                        groupId = int.Parse(reader.GetValue(0).ToString());
                    }
                }
                DbConnection.CloseConnection();
            }
            return groupId;
        }


        public static Dictionary<int, string> LoadSource(string Query, Dictionary<int, string> sourtlist)
        {
            int id = 0;
            using (SQLiteCommand Cmd = new SQLiteCommand(Query, DbConnection.Conn))
            {
                DbConnection.OpenConnection();
                SQLiteDataReader reader = Cmd.ExecuteReader();
                while (reader.Read())
                {
                    sourtlist.Add(id, (string)reader.GetValue(0));
                    id += 1;
                }
                DbConnection.CloseConnection();
            }
            return sourtlist;
        }
    }
}
