using System.Collections.Generic;
using System.Data.SQLite;

namespace TaMaker.DataClassLibrary
{
    public class SourceSuplier
    {
        public static Dictionary<int, string> LoadDistrict()
        {
            Dictionary<int, string> District = new Dictionary<int, string>();
            string SqlQuery = "SELECT * FROM DistrictView";
            LoadSource(SqlQuery, District);
            return District;
        }

        public static Dictionary<int, string> LoadOfficeType()
        {
            Dictionary<int, string> OfficeType = new Dictionary<int, string>();
            string SqlQuery = "SELECT * FROM OfficeTypeView";
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

        public static Dictionary<int, string> LoadStation(string uType, string uDist)
        {
            Dictionary<int, string> PlaceList = new Dictionary<int, string>();
            string SqlQuery = ($"SELECT * FROM Units WHERE UnitType='{uType}' AND UnitDist='{uDist }'");
            LoadSource(SqlQuery, PlaceList);
            return PlaceList;
        }

        public static Dictionary<int, string> LoadStation()
        {
            Dictionary<int, string> PlaceList = new Dictionary<int, string>();
            string SqlQuery = "SELECT * FROM Units";
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

        public static Dictionary<int, string> LoadDesignation(string forceType)
        {
            Dictionary<int, string> Designation = new Dictionary<int, string>();
            string SqlQuery = ($"SELECT * FROM DesignationTable WHERE ForceType='{ forceType}'");
            LoadSource(SqlQuery, Designation);
            return Designation;
        }
       
        public static int GetEmployeSort(string desn, string forceType)
        {
            int sorder = -10;
            string SqlQuery = ($"SELECT SortOrder FROM DesignationTable WHERE ForceType='{forceType}' AND Designation='{desn}'");
            DbConnection.OpenConnection();
            SQLiteCommand Cmd = new SQLiteCommand(SqlQuery, DbConnection.Conn);
            SQLiteDataReader reader = Cmd.ExecuteReader();
            while (reader.Read())
            {
                sorder = int.Parse(reader.GetValue(0).ToString());
            }
            DbConnection.CloseConnection();

            return sorder;
        }

        public static int GetGroupId()
        {
            int groupId = 0;
            string SqlQuery = "SELECT * FROM GroupIdView";
            try
            {
                DbConnection.OpenConnection();
                SQLiteCommand Cmd = new SQLiteCommand(SqlQuery, DbConnection.Conn);
                SQLiteDataReader reader = Cmd.ExecuteReader();
                while (reader.Read())
                {
                    groupId = int.Parse(reader.GetValue(0).ToString());
                }
            }
            finally
            {
                DbConnection.CloseConnection();
            }
            return groupId;
        }


        public static Dictionary<int, string> LoadSource(string Query, Dictionary<int, string> sourtlist)
        {
            int id = 0;
            try
            {
                DbConnection.OpenConnection();
                SQLiteCommand Cmd = new SQLiteCommand(Query, DbConnection.Conn);
                SQLiteDataReader reader = Cmd.ExecuteReader();
                while (reader.Read())
                {
                    sourtlist.Add(id, (string)reader.GetValue(0));
                    id += 1;
                }
            }
            finally
            {
                DbConnection.CloseConnection();
            }
            return sourtlist;
        }
    }
}
