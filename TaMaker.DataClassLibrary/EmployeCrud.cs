using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;
using TaMaker.BaseClassLibrary;

namespace TaMaker.DataClassLibrary
{
    public class EmployeCrud
    {
        public static List<Employee> ViewEmployee(string unit)
        {
            List<Employee> employees = new List<Employee>();

            using (var Cmd = new SQLiteCommand(DbConnection.Conn))
            {
                if (unit.Length > 0)
                {
                    Cmd.CommandText = ($"SELECT EmpNumber, EmpDesignation, EmpName, EmpSalary, EmpStation, EmpGroup, EmpStatus FROM EmployeeView WHERE EmpStation='{ unit }'");
                    DbConnection.OpenConnection();

                    SQLiteDataReader dr = Cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Employee emp = new Employee()
                        {
                            EmpNumber = int.Parse(dr.GetValue(0).ToString()),
                            EmpDesignation = (string)dr.GetValue(1),
                            EmpName = (string)dr.GetValue(2),
                            EmpSalary = double.Parse(dr.GetValue(3).ToString()),
                            EmpStation = (string)dr.GetValue(4),
                            EmpGroup = dr.GetValue(5).ToString(),
                            EmpStatus = dr.GetValue(6).ToString()
                        };

                        employees.Add(emp);
                    }
                    DbConnection.CloseConnection();
                }
            }

            return employees;
        }


        public void AddEmployee(Employee emp, bool save)
        {
            using (var Cmd = new SQLiteCommand(DbConnection.Conn))
            {
                if (save)
                {
                    Cmd.CommandText = ($"INSERT OR IGNORE INTO Employee "
                                       + " (EmpNumber, EmpDesignation, EmpName, EmpSalary, EmpStation, EmpGroup) values "
                                       + " (@empNo, @Desig, @empName, @empSalary, @empPs, @empgroup)");
                    Cmd.Parameters.AddWithValue("@empNo", emp.EmpNumber);
                }
                else
                {
                    Cmd.CommandText = @"UPDATE Employee SET EmpDesignation=@Desig, EmpName=@empName, EmpSalary=@empSalary, "
                                       + " EmpStation =@empPs, EmpGroup=@empgroup, EmpStatus=@status WHERE EmpNumber =" + emp.EmpNumber + "";
                }

                Cmd.Parameters.AddWithValue("@Desig", emp.EmpDesignation);
                Cmd.Parameters.AddWithValue("@empName", emp.EmpName);
                Cmd.Parameters.AddWithValue("@empSalary", emp.EmpSalary);
                Cmd.Parameters.AddWithValue("@empPs", emp.EmpStation);
                Cmd.Parameters.AddWithValue("@empgroup", emp.EmpGroup);
                Cmd.Parameters.AddWithValue("@status", emp.EmpStatus);

                DbConnection.OpenConnection();
                Cmd.ExecuteNonQuery();
                DbConnection.CloseConnection();
            }
        }

        public void DeleteEmployee(int kgid)
        {
            string SqlQuery = ($"DELETE FROM Employee WHERE EmpNumber = { kgid }");
            using (var Cmd = new SQLiteCommand(SqlQuery, DbConnection.Conn))
            {
                DbConnection.OpenConnection();
                Cmd.ExecuteNonQuery();
                DbConnection.CloseConnection();
            }
        }

        public static void SearchEmployee(DataGridView dgv, string unit, string searchText, bool check)
        {
            using (var Cmd = new SQLiteCommand(DbConnection.Conn))
            {
                if (unit.Length > 0)
                {
                    if (check)
                    {
                        Cmd.CommandText = ($"SELECT EmpDesignation, EmpName, EmpSalary, EmpNumber, EmpStatus FROM EmployeeView WHERE EmpName Like '{searchText}%' AND EmpStation='{unit}' ORDER BY SortOrder");
                    }
                    else
                    {
                        Cmd.CommandText = ($"SELECT EmpDesignation, EmpName, EmpSalary, EmpNumber, EmpStatus FROM EmployeeView WHERE EmpDesignation Like '{searchText}%' AND EmpStation='{unit}' ORDER BY SortOrder");
                    }
                   
                    DbConnection.OpenConnection();

                    using (SQLiteDataReader dr = Cmd.ExecuteReader())
                    {
                        dgv.Rows.Clear();
                        while (dr.Read())
                        {
                            string status = dr.GetValue(4).ToString();
                            if (status != "DELETE" && status != "RETAIRED" && status != "TRANSFFER")
                            {
                                int n = dgv.Rows.Add();
                                dgv.Rows[n].Cells[0].Value = false;
                                dgv.Rows[n].Cells[1].Value = dr.GetValue(0);
                                dgv.Rows[n].Cells[2].Value = dr.GetValue(1);
                                dgv.Rows[n].Cells[3].Value = dr.GetValue(2);
                                dgv.Rows[n].Cells[4].Value = dr.GetValue(3);
                            }
                        }
                    }
                    DbConnection.CloseConnection();
                }
            }
        }
    }
}
