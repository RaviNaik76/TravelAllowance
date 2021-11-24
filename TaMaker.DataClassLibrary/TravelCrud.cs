using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using TaMaker.BaseClassLibrary;

namespace TaMaker.DataClassLibrary
{
    public class TravelCrud
    {
        public string themeMe { get; set; }

        public static int AddTravell(Travel travell)
        {
            int r = 0;
            DbConnection.OpenConnection();
            using (var Cmd = new SQLiteCommand(DbConnection.Conn))
            {
                Cmd.CommandText = ($"INSERT OR IGNORE INTO Travell "
                                + " (Dep_Place, Dep_Date, Arr_Place, Arr_Date, Dest_Kms, Jou_Reason, Halt_Place, DayRate, NoOfDay, FareAmt, TotalTA, AdvanceTA, Jou_Mode, Warrant_No, Shd_No, Destination, EmpNo, GroupNo, MonthYear, Remarks, Designation, Salary) values "
                                + " (@dep_place, @dep_date, @arr_place, @arr_date, @dkms, @jreason, @halting, @dayrate, @days, @famt, @ta, @adv, @jmode, @wno, @shd, @dest, @empno, @groupno, @myear, @remark, @desig, @salary)");

                Cmd.Parameters.AddWithValue("@dep_place", travell.Dep_Place);
                Cmd.Parameters.AddWithValue("@dep_date", travell.Dep_Date);
                Cmd.Parameters.AddWithValue("@arr_place", travell.Arr_Place);
                Cmd.Parameters.AddWithValue("@arr_date", travell.Arr_Date);
                Cmd.Parameters.AddWithValue("@dkms", travell.Dest_Kms);
                Cmd.Parameters.AddWithValue("@jreason", travell.Jou_Reason);
                Cmd.Parameters.AddWithValue("@halting", travell.Halt_Place);
                Cmd.Parameters.AddWithValue("@dayrate", travell.DayRate);
                Cmd.Parameters.AddWithValue("@days", travell.NoOfDay);
                Cmd.Parameters.AddWithValue("@famt", travell.FareAmt);
                Cmd.Parameters.AddWithValue("@ta", travell.TotalTA);
                Cmd.Parameters.AddWithValue("@adv", travell.AdvanceTA);
                Cmd.Parameters.AddWithValue("@jmode", travell.Jou_Mode);
                Cmd.Parameters.AddWithValue("@wno", travell.Warrant_No);
                Cmd.Parameters.AddWithValue("@shd", travell.Shd_No);
                Cmd.Parameters.AddWithValue("@dest", travell.Destination);
                Cmd.Parameters.AddWithValue("@empno", travell.EmpNo);
                Cmd.Parameters.AddWithValue("@groupno", travell.GroupNo);
                Cmd.Parameters.AddWithValue("@myear", travell.MonthYear);
                Cmd.Parameters.AddWithValue("@remark", travell.Remarks);
                Cmd.Parameters.AddWithValue("@desig", travell.Designation);
                Cmd.Parameters.AddWithValue("@salary", travell.Salary);
                Cmd.ExecuteNonQuery();
            }
            DbConnection.CloseConnection();
            return r;
        }

        public void DeleteTravell(int GroupNo)
        {
            using (var Cmd = new SQLiteCommand(DbConnection.Conn))
            {
                Cmd.CommandText = ($"DELETE FROM Travell WHERE GroupNo ='{GroupNo}'");
                DbConnection.OpenConnection();
                Cmd.ExecuteNonQuery();
                DbConnection.CloseConnection();
            }
        }

        public static DataTable ViewTravell(string mYear, int kgid)
        {
            string Query = ($"SELECT Dep_Place, Dep_Date, Arr_Place, Arr_Date, Dest_Kms, Jou_Reason, Halt_Place, DayRate, NoOfDay, FareAmt, TotalTA, AdvanceTA, Jou_Mode, Warrant_No, Shd_No, Destination, GroupNo FROM Travell WHERE MonthYear='{mYear}' AND EmpNo ={kgid} ORDER BY Dep_Date, Arr_Date");
            DbConnection.OpenConnection();
            DataTable dt = new DataTable();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(Query, DbConnection.Conn);
            dataAdapter.Fill(dt);
            DbConnection.CloseConnection();
            return dt;
        }

        public static int CheckTravell(int kgid)
        {
            string Query = ($"SELECT Dep_Place, Dep_Date, Arr_Place, Arr_Date, Dest_Kms FROM Travell WHERE EmpNo ={kgid} ORDER BY Dep_Date");
            DbConnection.OpenConnection();
            DataTable dt = new DataTable();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(Query, DbConnection.Conn);
            dataAdapter.Fill(dt);
            DbConnection.CloseConnection();
            return dt.Rows.Count;
        }

        public static bool CheckTravell(int kgid, string mYear, DateTime fdate)
        {
            bool IsIn = false;
            using (var Cmd = new SQLiteCommand(DbConnection.Conn))
            {
                Cmd.CommandText = ($"SELECT Dep_Date, Arr_Date FROM Travell WHERE MonthYear='{mYear}' AND EmpNo ={kgid} ORDER BY Dep_Date");

                DbConnection.OpenConnection();

                using (SQLiteDataReader dr = Cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        DateTime from = DateTime.Parse(dr.GetValue(0).ToString());
                        DateTime to = DateTime.Parse(dr.GetValue(1).ToString());
                        if (fdate >= from && fdate <= to)
                        {
                            IsIn = true;
                        }
                    }
                }
                DbConnection.CloseConnection();
            }
            return IsIn;
        }

        public static DataTable GetAdvanceTaHolder(string mYear)
        {
            string Query = ($"SELECT EmpNo FROM Travell WHERE AdvanceTA > 0 AND MonthYear='{mYear}' GROUP BY EmpNo");
            DbConnection.OpenConnection();
            DataTable dt = new DataTable();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(Query, DbConnection.Conn);
            dataAdapter.Fill(dt);
            DbConnection.CloseConnection();
            return dt;
        }

        public static DataTable GetVeriationAmount(string mYear, int kgid)
        {
            string Query = ($"SELECT Sum(FareAmt), Sum(AdvanceTA), Sum(TotalTA) FROM Travell WHERE MonthYear='{mYear}' AND EmpNo={kgid}");
            DbConnection.OpenConnection();
            DataTable dt = new DataTable();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(Query, DbConnection.Conn);
            dataAdapter.Fill(dt);
            DbConnection.CloseConnection();
            return dt;
        }

        public static DataTable GetExcessTaHolder()
        {
            string Query = ($"SELECT * FROM ExcessAdvance WHERE Status='Credited'");
            DbConnection.OpenConnection();
            DataTable dt = new DataTable();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(Query, DbConnection.Conn);
            dataAdapter.Fill(dt);
            DbConnection.CloseConnection();
            return dt;
        }

        public static void LessExcessTa(int kgid, string myear)
        {
            DbConnection.OpenConnection();
            using (var Cmd = new SQLiteCommand(DbConnection.Conn))
            {
                string status = ($"Debited in {myear}");
                Cmd.CommandText = ($"UPDATE ExcessAdvance SET Status ='{status}' WHERE KGID={kgid}");
               // Cmd.Parameters.AddWithValue("@status", status);
                Cmd.ExecuteNonQuery();
            }
            DbConnection.CloseConnection();
        }

        public static void AddDefAmt(int kgid, double amt, string myear, string status)
        {
            DbConnection.OpenConnection();
            using (var Cmd = new SQLiteCommand(DbConnection.Conn))
            {
                Cmd.CommandText = ($"INSERT OR IGNORE INTO ExcessAdvance (KGID, ExcessAmt, M_Year, Status) values (@kgid, @examt, @myear, @status)");
                Cmd.Parameters.AddWithValue("@kgid", kgid);
                Cmd.Parameters.AddWithValue("@examt", amt);
                Cmd.Parameters.AddWithValue("@myear", myear);
                Cmd.Parameters.AddWithValue("@status", status);
                Cmd.ExecuteNonQuery();
            }
            DbConnection.CloseConnection();
        }

        public void AsaignDataToEmployeeGrid(DataGridView DgvEmployee, List<Employee> emplist, bool check)
        {
            foreach (Employee item in emplist)
            {
                if (item.EmpStatus != "DELETE" && item.EmpStatus != "RETAIRED" && item.EmpStatus != "TRANSFFER")
                {
                    int n = DgvEmployee.Rows.Add();
                    DgvEmployee.Rows[n].Cells[0].Value = check;
                    DgvEmployee.Rows[n].Cells[1].Value = item.EmpDesignation.ToString();
                    DgvEmployee.Rows[n].Cells[2].Value = item.EmpName.ToString();
                    DgvEmployee.Rows[n].Cells[3].Value = item.EmpSalary.ToString();
                    DgvEmployee.Rows[n].Cells[4].Value = item.EmpNumber.ToString();
                    DgvEmployee.Rows[n].Cells[5].Value = item.EmpGroup.ToString();
                }
            }

            DgvEmployee.Columns[0].Width = 40;
            DgvEmployee.Columns[1].Width = 70;
            DgvEmployee.Columns[3].Width = 70;
            DgvEmployee.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvEmployee.DefaultCellStyle.NullValue = "";
            SetGridColor(DgvEmployee);
        }

        public void FormatTravellGrid(DataGridView dataGridView)
        {
            dataGridView.Columns[16].Visible = false;
            dataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView.DefaultCellStyle.NullValue = "";
            SetGridColor(dataGridView);
        }

        public void CreateTabAndGridView(DataTable dt, TabPage tp)
        {
            DataGridView gridView = new DataGridView()
            {
                BackgroundColor = System.Drawing.Color.GhostWhite,
                Dock = DockStyle.Fill,
                Parent = tp,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                DataSource = dt
            };
            FormatTravellGrid(gridView);
        }

        public void SetGridColor(DataGridView dataGridView)
        {
            if (themeMe == "DARK")
            {
                dataGridView.RowsDefaultCellStyle.BackColor = System.Drawing.Color.DarkTurquoise;
                dataGridView.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.DarkOrange;
            }
            else
            {
                dataGridView.RowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                dataGridView.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightSkyBlue;
            }
        }

        public int GetColumnIndexByName(DataGridView grid, string name)
        {
            for (int i = 0; i < grid.Columns.Count; i++)
            {
                if (grid.Columns[i].HeaderText.ToLower().Trim() == name.ToLower().Trim())
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
