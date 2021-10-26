﻿using System.Collections.Generic;
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
                                + " (Dep_Place, Dep_Date, Arr_Place, Arr_Date, Dest_Kms, Jou_Reason, Halt_Place, DayRate, NoOfDay, FareAmt, TotalTA, AdvanceTA, Jou_Mode, Warrant_No, Shd_No, Destination, EmpNo, GroupNo, MonthYear, Remarks) values "
                                + " (@dep_place, @dep_date, @arr_place, @arr_date, @dkms, @jreason, @halting, @dayrate, @days, @famt, @ta, @adv, @jmode, @wno, @shd, @dest, @empno, @groupno, @myear, @remark)");

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
            //DateTime mindate = MinMaxDate.GetMinMaxDate(mYear, out DateTime maxdate);
            //string min = mindate.ToString("yyyy-MM-dd HH:mm:ss");
            //string max = maxdate.ToString("yyyy-MM-dd HH:mm:ss");
            //string Query = ($"SELECT * FROM Travell WHERE Dep_Date BETWEEN '{ min }' AND '{ max }' AND EmpNo ={ kgid}");
            string Query = ($"SELECT * FROM Travell WHERE MonthYear='{mYear}' AND EmpNo ={kgid}");
            DbConnection.OpenConnection();
            DataTable dt = new DataTable();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(Query, DbConnection.Conn);
            dataAdapter.Fill(dt);
            DbConnection.CloseConnection();
            return dt;
        }

        public void AsaignDataToEmployeeGrid(DataGridView DgvEmployee, List<Employee> emplist, bool check)
        {
            foreach (Employee item in emplist)
            {
                int n = DgvEmployee.Rows.Add();
                DgvEmployee.Rows[n].Cells[0].Value = check;
                DgvEmployee.Rows[n].Cells[1].Value = item.EmpDesignation.ToString();
                DgvEmployee.Rows[n].Cells[2].Value = item.EmpName.ToString();
                DgvEmployee.Rows[n].Cells[3].Value = item.EmpSalary.ToString();
                DgvEmployee.Rows[n].Cells[4].Value = item.EmpNumber.ToString();
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
            dataGridView.Columns[0].Width = 200;
            dataGridView.Columns[1].Width = 130;
            dataGridView.Columns[2].Width = 200;
            dataGridView.Columns[3].Width = 130;
            dataGridView.Columns[4].Width = 60;
            dataGridView.Columns[5].Width = 100;
            dataGridView.Columns[6].Width = 250;
            dataGridView.Columns[7].Width = 60;
            dataGridView.Columns[8].Width = 60;
            dataGridView.Columns[9].Width = 60;
            dataGridView.Columns[10].Width = 40;
            dataGridView.Columns[11].Width = 100;
            dataGridView.Columns[12].Width = 60;

            //dataGridView.Columns[13].Visible = false;
            //dataGridView.Columns[14].Visible = false;
            dataGridView.Columns[15].Visible = false;
            dataGridView.Columns[16].Visible = false;
            dataGridView.Columns[17].Visible = false;
            dataGridView.Columns[18].Visible = false;
            dataGridView.Columns[19].Visible = false;

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
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                DataSource = dt
            };
            FormatTravellGrid(gridView);
        }

        public void SetGridColor(DataGridView dataGridView)
        {
            // string themeMe = UserInterface.Properties.Settings.Default["ThemeMe"].ToString();
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
    }
}