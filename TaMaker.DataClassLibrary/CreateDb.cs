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
        string ConnString = DbConnection.Conn.ConnectionString.ToString();
        
        public void CreateDatabase()
        {
            var dbDirectory = Path.Combine("C:\\", "Database");

            if (!Directory.Exists(dbDirectory))
                Directory.CreateDirectory(dbDirectory);

            if (!File.Exists(ConnString))
            {
                CreateRequiredTabls();

                InsertSampleData();

                CreateRequiredViews();

                //using (SQLiteConnection Conn = new SQLiteConnection(ConnString))
                //{
                    
                //}
                //try
                //{
                //    SQLiteConnection Conn;
                //    Conn = new SQLiteConnection(ConnString);
                //    Conn.Open();

                //    CreateRequiredTabls();

                //    InsertSampleData();

                //    CreateRequiredViews();

                //    Conn.Close();

                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Error: " + ex.Message.ToString(), "DB Creation Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //}
            }
        }


        //create all required tables
        private void CreateRequiredTabls()
        {
            List<String> SqlQueryList = new List<string>();

            SqlQuery = @"CREATE TABLE IF NOT EXISTS Employee 
                        (
                            EmpNumber INTEGER NOT NULL,
	                        EmpDesignation TEXT,
	                        EmpName TEXT,
	                        EmpSalary REAL,
	                        EmpStation TEXT,
                            EmpGroup TEXT,
	                        EmpStatus TEXT,
	                        PRIMARY KEY(EmpNumber)
                        )";
            SqlQueryList.Add(SqlQuery);

            SqlQuery = @"CREATE TABLE IF NOT EXISTS Travell 
                        ( 
                            Dep_Place TEXT,
                            Dep_Date TEXT,
	                        Arr_Place TEXT,
	                        Arr_Date TEXT,
	                        Dest_Kms INTEGER,
	                        Jou_Reason TEXT,
	                        Halt_Place TEXT,
	                        DayRate REAL,
	                        NoOfDay REAL,
	                        FareAmt REAL,
	                        TotalTA REAL,
	                        AdvanceTA REAL,
	                        Jou_Mode TEXT,
	                        Warrant_No TEXT,
	                        Shd_No TEXT,
	                        Destination TEXT,
	                        EmpNo INTEGER NOT NULL,
	                        GroupNo INTEGER,
	                        MonthYear TEXT,
	                        Remarks TEXT,
	                        Designation TEXT,
	                        Salary REAL,
	                        FOREIGN KEY(EmpNo) REFERENCES Employee(EmployeeNumber)
                        )";
            SqlQueryList.Add(SqlQuery);

            SqlQuery = @"CREATE TABLE IF NOT EXISTS TaValue 
                        (
                            EmpClass TEXT NOT NULL,
                            NormalTa REAL,
	                        MetroTa REAL,
	                        BangloreTa REAL,
	                        OutOfStateTa REAL,
	                        OutOfStateMetroTa REAL
                        )";

            SqlQueryList.Add(SqlQuery);

            SqlQuery = @"CREATE TABLE IF NOT EXISTS SourceTable 
                        (
                            SourceName TEXT NOT NULL,
                            SourceType TEXT NOT NULL
                        )";

            SqlQueryList.Add(SqlQuery);

            SqlQuery = @"CREATE TABLE IF NOT EXISTS DesignationTable 
                        (
                            Id INTEGER NOT NULL,
                            Designation TEXT NOT NULL,
	                        SortOrder INTEGER NOT NULL,
                            UnitName TEXT
                        )";

            SqlQueryList.Add(SqlQuery);

            SqlQuery = @"CREATE TABLE IF NOT EXISTS Marking 
                        (
                            M_Year TEXT NOT NULL,
                            Unit TEXT NOT NULL,
                            Mark TEXT NOT NULL,
                            MarkedDate TEXT NOT NULL
                        )";

            SqlQueryList.Add(SqlQuery);


            SqlQuery = @"CREATE TABLE IF NOT EXISTS ExcessAdvance 
                        (
                            KGID INTEGER NOT NULL,
                            ExcessAmt REAL NOT NULL,
                            M_Year TEXT NOT NULL,
                            Status TEXT
                        )";

            SqlQueryList.Add(SqlQuery);

            ExicuteQueryList(SqlQueryList);
        }

        //insert sample data to all tables
        public void InsertSampleData()
        {
            List<String> InsertQueryList = new List<string>();

            SqlQuery = @"INSERT OR IGNORE INTO TaValue
                                (EmpClass, NormalTa, MetroTa, BangloreTa, OutOfStateTa, OutOfStateMetroTa) values 
                                ('A', 400.00, 500.00, 600.00, 600.00, 800.00),
                                ('B', 300.00, 400.00, 400.00, 400.00, 600.00),
                                ('C', 200.00, 300.00, 300.00, 300.00, 500.00),
                                ('D', 200.00, 300.00, 300.00, 300.00, 500.00)";

            InsertQueryList.Add(SqlQuery);

            SqlQuery = @"INSERT OR IGNORE INTO SourceTable (SourceName, SourceType) values 
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
                                ('DELETE', 'Status'),
                                ('TRANSFFER', 'Status'),
                                ('RETAIRED', 'Status'),
                                ('OTHERS', 'Status')";
            InsertQueryList.Add(SqlQuery);

            ExicuteQueryList(InsertQueryList);
        }

        //create all required views
        public void CreateRequiredViews()
        {
            List<String> ViewsQueryList = new List<string>();
            
            SqlQuery = @"CREATE VIEW IF NOT EXISTS EmpStatusView AS 
                        SELECT * FROM SourceTable WHERE SourceType='Status'";
            ViewsQueryList.Add(SqlQuery);

            SqlQuery = @"CREATE VIEW IF NOT EXISTS DesignationVIEW AS 
                        SELECT * FROM DesignationTable";
            ViewsQueryList.Add(SqlQuery);

            SqlQuery = @"CREATE VIEW IF NOT EXISTS EmployeeView AS
                        SELECT EmpNumber, EmpDesignation, EmpName, EmpSalary, EmpStation, EmpGroup, DesignationVIEW.SortOrder, EmpStatus, 
                            CASE
                                WHEN pos == 0 THEN EmpDesignation
                                ELSE substr(EmpDesignation, 1, pos - 1)
                            END AS SORT_DESIG
                        FROM DesignationVIEW, 
                            (SELECT *,
                                instr(EmpDesignation, ' ') AS pos
                            FROM Employee)
                        WHERE SORT_DESIG = DesignationVIEW.Designation
                        ORDER BY SortOrder ASC";
            ViewsQueryList.Add(SqlQuery);

            SqlQuery = @"CREATE VIEW IF NOT EXISTS GroupIdView AS 
                        SELECT MAX(GroupNo) FROM Travell";
            ViewsQueryList.Add(SqlQuery);

            SqlQuery = @"CREATE VIEW IF NOT EXISTS Travel_DesignationView AS
                            SELECT EmpNo, MonthYear, 
                                CASE
                                    WHEN pos == 0 THEN Designation
                                    ELSE substr(Designation, 1, pos - 1)
                                END AS SORT_DESIG
                            FROM
                                (SELECT *,
                                    instr(Designation, ' ') AS pos
                                FROM Travell)";
            ViewsQueryList.Add(SqlQuery);

            //to get SortOrder from split Designation
            SqlQuery = @"CREATE VIEW IF NOT EXISTS Travel_Emp_SortView AS 
                        SELECT EmpNo, EmpName, SORT_DESIG, EmpStation, SortOrder
                        FROM Travel_DesignationView, Employee, DesignationTable
                        WHERE Travel_DesignationView.EmpNo = Employee.EmpNumber AND Travel_DesignationView.SORT_DESIG = DesignationTable.Designation";
            ViewsQueryList.Add(SqlQuery);

            SqlQuery = @"CREATE VIEW IF NOT EXISTS PlacesView AS 
                        SELECT * FROM SourceTable WHERE SourceType='Place'";
            ViewsQueryList.Add(SqlQuery);

            SqlQuery = @"CREATE VIEW IF NOT EXISTS VehicleTypeView AS 
                        SELECT * FROM SourceTable WHERE SourceType='Vehicle'";
            ViewsQueryList.Add(SqlQuery);

            SqlQuery = @"CREATE VIEW IF NOT EXISTS HaltingPlaceView AS 
                        SELECT * FROM SourceTable WHERE SourceType='Holting'";
            ViewsQueryList.Add(SqlQuery);

            //get report data form Travel_Emp_SortView (from Travel_DesignationView)
            SqlQuery = @"CREATE VIEW IF NOT EXISTS Report_Data_View AS 
                        SELECT E.EmpNo AS EmpNumber, E.EmpName, T.Dep_Place, T.Dep_Date, T.Arr_Place, T.Arr_Date, T.Dest_Kms, T.Jou_Reason, T.Halt_Place, T.DayRate, T.NoOfDay, T.FareAmt, T.TotalTA, T.AdvanceTA, T.Jou_Mode, T.Warrant_No, T.Shd_No, T.Remarks, T.Designation, T.Salary, T.MonthYear, E.EmpStation, E.SortOrder
                        FROM(Travel_Emp_SortView AS E INNER JOIN Travell AS T ON E.EmpNo = T.EmpNo)
                        ORDER BY SortOrder, T.Dep_Date, T.Arr_Date";
            ViewsQueryList.Add(SqlQuery);

            ExicuteQueryList(ViewsQueryList);
        }

        public void CreateViews(string unit)
        {
            List<String> ViewsQueryList = new List<string>();
            SqlQuery = @"DROP VIEW IF EXISTS DesignationVIEW";
            ViewsQueryList.Add(SqlQuery);

            //to get split designation
            SqlQuery = @"CREATE VIEW IF NOT EXISTS DesignationVIEW AS 
                        SELECT * FROM DesignationTable
                        WHERE UnitName = '" + unit + "'";
            ViewsQueryList.Add(SqlQuery);

            ExicuteQueryList(ViewsQueryList);
        }

        public void CreateTravelViews(string myear)
        {
            List<String> ViewsQueryList = new List<string>();
            SqlQuery = @"DROP VIEW IF EXISTS Travel_DesignationView";
            ViewsQueryList.Add(SqlQuery);

            SqlQuery = @"CREATE VIEW IF NOT EXISTS Travel_DesignationView AS
                            SELECT EmpNo, MonthYear, 
                                CASE
                                    WHEN pos == 0 THEN Designation
                                    ELSE substr(Designation, 1, pos - 1)
                                END AS SORT_DESIG
                            FROM
                                (SELECT *,
                                    instr(Designation, ' ') AS pos
                                FROM Travell)
                            WHERE (MonthYear = '" + myear + "')";
            ViewsQueryList.Add(SqlQuery);

            ExicuteQueryList(ViewsQueryList);
        }

        public void ExicuteQueryList(List<String> QueryList)
        {
            using (SQLiteConnection Conn = new SQLiteConnection(ConnString))
            {
                Conn.Open();
                foreach (var Query in QueryList)
                {
                    using (SQLiteCommand Cmd = new SQLiteCommand(Query, Conn))
                    {
                        Cmd.ExecuteNonQuery();
                    }
                }
               Conn.Close();
            }
            
            //SQLiteCommand Cmd = new SQLiteCommand();
            //try
            //{
            //    DbConnection.OpenConnection();

            //    foreach (var Query in QueryList)
            //    {
            //        Cmd = new SQLiteCommand(Query, DbConnection.Conn);
            //        Cmd.ExecuteNonQuery();
            //    }
            //}
            //finally
            //{
            //    DbConnection.CloseConnection();
            //}
        }
    }
}
