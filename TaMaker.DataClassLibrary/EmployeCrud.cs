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
                    Cmd.CommandText = ($"SELECT * FROM EmployeeView WHERE EmpStation='{ unit }' ORDER BY EmpShort");
                }
                else
                {
                    Cmd.CommandText = "SELECT * FROM EmployeeView ORDER BY EmpShort";
                }
                DbConnection.OpenConnection();

                SQLiteDataReader dr = Cmd.ExecuteReader();
                while (dr.Read())
                {
                    Employee emp = new Employee()
                    {
                        EmpNumber = (int)dr.GetValue(0),
                        EmpDesignation = (string)dr.GetValue(1),
                        EmpName = (string)dr.GetValue(2),
                        EmpSalary = double.Parse(dr.GetValue(3).ToString()),
                        EmpStation = (string)dr.GetValue(4),
                        EmpShort = (int)dr.GetValue(5)
                    };

                    employees.Add(emp);
                }
                DbConnection.CloseConnection();
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
                                       + " (EmpNumber, EmpDesignation, EmpName, EmpSalary, EmpStation, EmpShort) values "
                                       + " (@empNo, @Desig, @empName, @empSalary, @empPs, @empOrder)");
                    Cmd.Parameters.AddWithValue("@empNo", emp.EmpNumber);
                }
                else
                {
                    Cmd.CommandText = @"UPDATE Employee SET EmpDesignation=@Desig, EmpName=@empName, EmpSalary=@empSalary, "
                                       + " EmpStation =@empPs, EmpShort=@empOrder WHERE EmpNumber =" + emp.EmpNumber + "";
                }

                Cmd.Parameters.AddWithValue("@Desig", emp.EmpDesignation);
                Cmd.Parameters.AddWithValue("@empName", emp.EmpName);
                Cmd.Parameters.AddWithValue("@empSalary", emp.EmpSalary);
                Cmd.Parameters.AddWithValue("@empPs", emp.EmpStation);
                Cmd.Parameters.AddWithValue("@empOrder", emp.EmpShort);

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

        public static void SearchEmployee(DataGridView dgv, string unit, string searchText)
        {
            using (var Cmd = new SQLiteCommand(DbConnection.Conn))
            {
                if (unit.Length > 0)
                {
                    Cmd.CommandText = ($"SELECT EmpDesignation, EmpName, EmpSalary, EmpNumber FROM Employee WHERE EmpStation='{unit}' AND EmpName Like '{searchText}%' ORDER BY EmpShort");
                }
                else
                {
                    Cmd.CommandText = ($"SELECT EmpDesignation, EmpName, EmpSalary, EmpNumber FROM Employee WHERE EmpName Like '{searchText} %' ORDER BY EmpShort");
                }
                DbConnection.OpenConnection();
                using (SQLiteDataReader dr = Cmd.ExecuteReader())
                {
                    dgv.Rows.Clear();
                    while (dr.Read())
                    {
                        int n = dgv.Rows.Add();
                        dgv.Rows[n].Cells[0].Value = false;
                        dgv.Rows[n].Cells[1].Value = dr.GetValue(0);
                        dgv.Rows[n].Cells[2].Value = dr.GetValue(1);
                        dgv.Rows[n].Cells[3].Value = dr.GetValue(2);
                        dgv.Rows[n].Cells[4].Value = dr.GetValue(3);
                    }
                }
                DbConnection.CloseConnection();
            }
        }
    }
}
