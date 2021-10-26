using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace TaMaker.DataClassLibrary
{
    public class CreateDb
    {
        private string SqlQuery;

        //db creation
        public void CreateDatabase()
        {
            string ConnString = DbConnection.Conn.ConnectionString.ToString();
            var dbDirectory = Path.Combine("C:\\", "Database");

            if (!Directory.Exists(dbDirectory))
                Directory.CreateDirectory(dbDirectory);

            if (!File.Exists(ConnString))
            {
                try
                {
                    SQLiteConnection Conn;
                    Conn = new SQLiteConnection(ConnString);
                    Conn.Open();

                    CreateRequiredTabls();

                    InsertSampleData();

                    CreateRequiredViews();

                    Conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message.ToString(), "DB Creation Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }


        //create all required tables
        private void CreateRequiredTabls()
        {
            List<String> SqlQueryList = new List<string>();

            SqlQuery = @"CREATE TABLE IF NOT EXISTS Employee 
                        (
                            EmpNumber int not null primary key,
                            EmpDesignation varchar(20),
                            EmpName varchar(100),
                            EmpSalary double, 
                            EmpStation varchar(50),
                            EmpShort int
                        )";
            SqlQueryList.Add(SqlQuery);

            SqlQuery = @"CREATE TABLE IF NOT EXISTS Travell 
                        ( 
                            Dep_Place varchar(50),
                            Dep_Date text,
                            Arr_Place varchar(50),
                            Arr_Date text,
                            Dest_Kms int,
                            Jou_Reason varchar(50),
                            Halt_Place varchar(50),
                            DayRate double,
                            NoOfDay double,
                            FareAmt double,
                            TotalTA double,
                            AdvanceTA double,
                            Jou_Mode varchar(50),
                            Warrant_No text,
                            Shd_No text,
                            Destination varchar(50),
                            EmpNo int not null,
                            GroupNo int,
                            MonthYear varchar(50),
                            Remarks text,
                            FOREIGN KEY(EmpNo) REFERENCES Employee(EmployeeNumber)
                        )";
            SqlQueryList.Add(SqlQuery);

            SqlQuery = @"CREATE TABLE IF NOT EXISTS TaValue 
                        (
                            EmpClass text not null,
                            NormalTa decimal, 
                            MetroTa decimal,
                            BangloreTa decimal,
                            OutOfStateTa decimal,
                            OutOfStateMetroTa decimal
                        )";

            SqlQueryList.Add(SqlQuery);

            SqlQuery = @"CREATE TABLE IF NOT EXISTS SourceTable 
                        (
                            SourceName text not null,
                            SourceType varchar(20) not null
                        )";

            SqlQueryList.Add(SqlQuery);

            SqlQuery = @"CREATE TABLE IF NOT EXISTS DesignationTable 
                        (
                            Designation text not null,
                            ForceType text,
                            SortOrder int not null
                        )";

            SqlQueryList.Add(SqlQuery);

            SqlQuery = @"CREATE TABLE IF NOT EXISTS Units 
                        (
                            UnitName text not null,
                            UnitType varchar(20) not null,
                            UnitDist text not null
                        )";

            SqlQueryList.Add(SqlQuery);

            ExicuteQueryList(SqlQueryList);
        }


        //insert sample data to all tables
        public void InsertSampleData()
        {
            List<String> InsertQueryList = new List<string>();

            SqlQuery = @"INSERT OR IGNORE INTO Employee 
                                (EmpNumber, EmpDesignation, EmpName, EmpSalary, EmpStation, EmpShort) values 
                                (145895, 'CHC 1504', 'RAVI NAIK', 35500, 'DANDELI TOWN', 6), 
                                (145896, 'CHC 1475', 'RAMADAS NAIK', 39500, 'DANDELI RURAL', 6)";

            InsertQueryList.Add(SqlQuery);

            SqlQuery = @"INSERT OR IGNORE INTO Travell
                                (Dep_Place, Dep_Date, Arr_Place, Arr_Date, Dest_Kms, Jou_Reason, Halt_Place, DayRate, NoOfDay, FareAmt, TotalTA, AdvanceTA, Jou_Mode, Warrant_No, Shd_No, Destination, EmpNo, GroupNo, MonthYear) values 
                                ('dandeli', '2020-10-01 10:20:05', 'KARWAR', '2020-10-01 10:20:05', 95, 'tapal', 'karwar', 130, 1.5, 230, 195, 100, 'ksrtc', '145456, 245687', '5, 45', 'State Others', 145895, 1, 'January 2021'),
                                ('dandeli', '2020-10-01 10:20:05', 'KARWAR', '2020-10-01 10:20:05', 95, 'tapal', 'karwar', 130, 1.5, 230, 195, 100, 'ksrtc', '654789, 456987', '5, 45', 'State Others', 145896, 2, 'January 2021')";

            InsertQueryList.Add(SqlQuery);

            SqlQuery = @"INSERT OR IGNORE INTO TaValue
                                (EmpClass, NormalTa, MetroTa, BangloreTa,
                                  OutOfStateTa, OutOfStateMetroTa) values 
                                ('I', 400.00, 500.00, 600.00, 600.00, 800.00),
                                ('II', 300.00, 400.00, 400.00, 400.00, 600.00),
                                ('III', 200.00, 300.00, 300.00, 300.00, 500.00)";

            InsertQueryList.Add(SqlQuery);

            SqlQuery = @"INSERT OR IGNORE INTO SourceTable
                                (SourceName, SourceType) values 
                                ('UTTARA KANNADA', 'District'),
                                ('DAKSHINA KANNADA', 'District'),
                                ('UDUPI', 'District'),
                                ('Banglore', 'Place'),
                                ('State Metro', 'Place'),
                                ('State Others', 'Place'),
                                ('Mysore', 'sMetro'),
                                ('Huble-Dharwad', 'sMetro'),
                                ('Belguam', 'sMetro'),
                                ('Manglore', 'sMetro'),
                                ('Ahamdabad', 'Metro'),
                                ('Mumbai', 'Metro'),
                                ('Calcutta', 'Metro'),
                                ('Delhi', 'Metro'),
                                ('Ganjiyabad', 'Metro'),
                                ('Hydrabad', 'Metro'),
                                ('Channi-Kanpur', 'Metro'),
                                ('Masoori', 'Metro'),
                                ('Pune', 'Metro'),
                                ('Simla', 'Metro'),
                                ('Nagpur', 'Metro'),
                                ('Shrinagar', 'Metro'),
                                ('Goa', 'Metro'),
                                ('Due-Daman', 'Metro'),
                                ('Others', 'Metro'),
                                ('KSRTC', 'Vehicle'),
                                ('Train', 'Vehicle'),
                                ('Private', 'Vehicle'),
                                ('Govt-Vehicle', 'Vehicle'),
                                ('Airoplane', 'Vehicle'),
                                ('Ahmedabad~21', 'Holting'),
                                ('Bangalore~1', 'Holting'),
                                ('Chennai~56', 'Holting'),
                                ('Daman~96', 'Holting'),
                                ('Delhi~36', 'Holting'),
                                ('Diu~91', 'Holting'),
                                ('Ghaziabad~41', 'Holting'),
                                ('Goa~86', 'Holting'),
                                ('Hyderabad~46', 'Holting'),
                                ('Kanpur~51', 'Holting'),
                                ('Kolkata~31', 'Holting'),
                                ('Mumbai~26', 'Holting'),
                                ('Mysore~61', 'Holting'),
                                ('Nagpur~76', 'Holting'),
                                ('Other Place Outside the State~16', 'Holting'),
                                ('Other Place Within State~11', 'Holting'),
                                ('Places with muncipal corporations within state~6', 'Holting'),
                                ('Pune~66', 'Holting'),
                                ('Shimla~71', 'Holting'),
                                ('Srinagar~81', 'Holting'),
                                ('Out of State Metro', 'Place'),
                                ('Out of State Others', 'Place'),
                                ('DSP OFFICE', 'Office'),
                                ('CPI OFFICE', 'Office'),
                                ('POLICE STATION', 'Office'),
                                ('FMS UNIT', 'Office'),
                                ('TRAFFIC AID UNIT', 'Office'),
                                ('OUT POST', 'Office'),
                                ('INT', 'Office'),
                                ('DAR', 'Office'),
                                ('DAR MT', 'Office'),
                                ('ISD', 'Office')";
            InsertQueryList.Add(SqlQuery);

            SqlQuery = @"INSERT OR IGNORE INTO Units
                                (UnitName, UnitType, UnitDist) values 
                                ('DANDELI TOWN', 'POLICE STATION', 'UTTARA KANNADA'),
                                ('DANDELI RURAL', 'POLICE STATION', 'UTTARA KANNADA'),
                                ('DAR KARWAR', 'DAR', 'UTTARA KANNADA'),
                                ('DAR MT KARWAR', 'DAR', 'UTTARA KANNADA')";
            InsertQueryList.Add(SqlQuery);

            SqlQuery = @"INSERT OR IGNORE INTO DesignationTable
                                (Designation, ForceType, SortOrder) values 
                                ('ADDL SP', 'CIVIL', 1),
                                ('DSP', 'CIVIL', 2),
                                ('CPI', 'CIVIL', 3),
                                ('PSI', 'CIVIL', 4),
                                ('WPSI', 'CIVIL', 5),
                                ('ASI', 'CIVIL', 6),
                                ('WASI', 'CIVIL', 7),
                                ('CHC', 'CIVIL', 8),
                                ('WHC', 'CIVIL', 9),
                                ('CPC', 'CIVIL', 10),
                                ('WPC', 'CIVIL', 11),
                                ('DSP', 'DAR', 2),
                                ('RPI', 'DAR', 3),
                                ('RSI', 'DAR', 4),
                                ('ARSI', 'DAR', 5),
                                ('AHC', 'DAR', 6),
                                ('APC', 'DAR', 7)";
            InsertQueryList.Add(SqlQuery);

            ExicuteQueryList(InsertQueryList);
        }


        //create all required views
        public void CreateRequiredViews()
        {
            List<String> ViewsQueryList = new List<string>();

            SqlQuery = @"CREATE VIEW IF NOT EXISTS EmployeeView AS 
                        SELECT * FROM Employee ORDER BY EmpShort ASC";
            ViewsQueryList.Add(SqlQuery);

            SqlQuery = @"CREATE VIEW IF NOT EXISTS DistrictView AS 
                        SELECT* FROM SourceTable WHERE SourceType = 'District'";
            ViewsQueryList.Add(SqlQuery);

            SqlQuery = @"CREATE VIEW IF NOT EXISTS OfficeTypeView AS 
                        SELECT * FROM SourceTable WHERE SourceType='Office'";
            ViewsQueryList.Add(SqlQuery);

            SqlQuery = @"CREATE VIEW IF NOT EXISTS DesignationView AS 
                        SELECT * FROM SourceTable WHERE SourceType='Designation'";
            ViewsQueryList.Add(SqlQuery);

            SqlQuery = @"CREATE VIEW IF NOT EXISTS GroupIdView AS 
                        SELECT MAX(GroupNo) FROM Travell";
            ViewsQueryList.Add(SqlQuery);

            SqlQuery = @"CREATE VIEW IF NOT EXISTS PlacesView AS 
                        SELECT * FROM SourceTable WHERE SourceType='Place'";
            ViewsQueryList.Add(SqlQuery);

            SqlQuery = @"CREATE VIEW IF NOT EXISTS StationView AS 
                        SELECT UnitName FROM Units WHERE UnitType='Station'";
            ViewsQueryList.Add(SqlQuery);

            SqlQuery = @"CREATE VIEW IF NOT EXISTS VehicleTypeView AS 
                        SELECT * FROM SourceTable WHERE SourceType='Vehicle'";
            ViewsQueryList.Add(SqlQuery);

            SqlQuery = @"CREATE VIEW IF NOT EXISTS HaltingPlaceView AS 
                        SELECT * FROM SourceTable WHERE SourceType='Holting'";
            ViewsQueryList.Add(SqlQuery);

            ExicuteQueryList(ViewsQueryList);
        }


        public void ExicuteQueryList(List<String> QueryList)
        {
            SQLiteCommand Cmd = new SQLiteCommand();
            try
            {
                DbConnection.OpenConnection();

                foreach (var Query in QueryList)
                {
                    Cmd = new SQLiteCommand(Query, DbConnection.Conn);
                    Cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                DbConnection.CloseConnection();
            }
        }
    }
}
