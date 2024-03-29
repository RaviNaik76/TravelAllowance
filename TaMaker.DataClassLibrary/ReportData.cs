﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace TaMaker.DataClassLibrary
{
    public class ReportData
    {
        public DataTable GetReportData(string unit, string myear)
        {
            //DateTime mindate = MinMaxDate.GetMinMaxDate(myear, out DateTime maxdate);
            //string min = mindate.ToString("yyyy-MM-dd HH:mm:ss");
            //string max = maxdate.ToString("yyyy-MM-dd HH:mm:ss");
            //T.Dep_Date BETWEEN '" + min + "' AND '" + max + "'
            //string Query = @"SELECT E.EmpNumber, E.EmpName, T.Dep_Place, T.Dep_Date, T.Arr_Place, T.Arr_Date, "
            //                + "T.Dest_Kms, T.Jou_Reason, T.Halt_Place, T.DayRate, T.NoOfDay, T.FareAmt, T.TotalTA, "
            //                + "T.AdvanceTA, T.Jou_Mode, T.Warrant_No, T.Shd_No, T.Remarks, T.Designation, T.Salary "
            //                + "FROM (Employee AS E INNER JOIN Travell AS T ON E.EmpNumber = T.EmpNo) "
            //                + "WHERE (E.EmpStation = '" + unit + "' AND T.MonthYear='" + myear + "') "
            //                + "ORDER BY EmpShort, T.Dep_Date, T.Arr_Date";
            CreateDb createDb = new CreateDb();
            createDb.CreateTravelViews(myear);

            string Query = @"SELECT * FROM (Report_Data_View) "
                           + "WHERE (EmpStation = '" + unit + "' AND MonthYear='" + myear + "')";

            DataTable dt = new DataTable();
            using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(Query, DbConnection.Conn))
            {
                DbConnection.OpenConnection();
                dataAdapter.Fill(dt);
                DbConnection.CloseConnection();
            }
            return dt;
        }

        public DataTable GetEmpReportData(string unit)
        {
            string Query = ($"SELECT * FROM EmployeeView WHERE EmpStation='{unit}'");
            DataTable dt = new DataTable();
            using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(Query, DbConnection.Conn))
            {
                DbConnection.OpenConnection();
                dataAdapter.Fill(dt);
                DbConnection.CloseConnection();
            }
            return dt;
        }
    }
}
