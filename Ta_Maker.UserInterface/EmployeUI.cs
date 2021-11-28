using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TaMaker.BaseClassLibrary;
using TaMaker.DataClassLibrary;

namespace Ta_Maker
{
    public partial class EmployeUI : MaterialForm
    {
        string unit = UserInterface.Properties.Settings.Default["UnitName"].ToString();
        private string monthYear = ($"{UserInterface.Properties.Settings.Default["DMonth"]} {UserInterface.Properties.Settings.Default["DYear"]}");
        List<Employee> employees = new List<Employee>();

        public EmployeUI()
        {
            InitializeComponent();
            MaterialDesign.Materialize(this);
        }

        private void EmployeUI_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> Designations = SourceSuplier.LoadDesignation(unit);
            foreach (var item in Designations)
            {
                CmbDesignation.Items.Add(item.Value);
            }

            CmbStation.Items.Add(unit);

            Dictionary<int, string> EmpStatus = SourceSuplier.LoadEmpStatus();
            foreach (var item in EmpStatus)
            {
                CmbStatus.Items.Add(item.Value);
            }

            Dictionary<int, string> EmpGroup = SourceSuplier.LoadEmpClass();
            foreach (var item in EmpGroup)
            {
                CmbEmpGroup.Items.Add(item.Value);
            }

            CmbStation.SelectedItem = unit;
            CmbStation.Enabled = false;
            RbByName.Checked = true;
            TxtEmpNo.Focus();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (CmbDesignation.SelectedIndex != -1 && CmbStation.SelectedIndex != -1)
            {
                NewEmployee(true);
                LblMsg.Text = "Employee Added";
            }
            else { LblMsg.Text = ""; MessageBox.Show("All the fields required", "TA_Maker", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void NewEmployee(bool save)
        {
            try
            {
                string designation = "";
                if (TxtDesig.Text.Length > 0)
                {
                    designation = ($"{CmbDesignation.Text} {TxtDesig.Text}");
                }
                else { designation = CmbDesignation.Text.Trim();}
                    
                Employee employee = new Employee()
                {
                    EmpNumber = int.Parse(TxtEmpNo.Text),
                    EmpDesignation = designation,
                    EmpName = TxtName.Text.ToUpper(),
                    EmpSalary = double.Parse(TxtSalary.Text),
                    EmpStation = CmbStation.Text,
                    EmpStatus = CmbStatus.Text,
                    EmpGroup = CmbEmpGroup.Text,
                };

                EmployeCrud employeCrud = new EmployeCrud();
                employeCrud.AddEmployee(employee, save);
                ClearAllFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TA_Maker", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            DataTable dt = TravelCrud.ViewTravell(monthYear, int.Parse(TxtEmpNo.Text));
            if (dt.Rows.Count == 0)
            {
                NewEmployee(false);
                TxtEmpNo.Enabled = true;
                CmbStatus.Visible = false;
                TxtEmpNo.Focus();
            }
            else { LblMsg.Text = "You con't Change Salary, Designation in this Month"; }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            EmployeCrud employeCrud = new EmployeCrud();
            ListViewItem item = EmployeListView.SelectedItems[0];
            if (int.TryParse(item.Text, out int kgid))
            {
                //get travel details
                int DataIn = TravelCrud.CheckTravell(kgid);
                if (DataIn == 0)
                {
                    employeCrud.DeleteEmployee(kgid);
                    ClearAllFields();
                    TxtEmpNo.Enabled = true;
                    LblMsg.Text = "Employee Deleted";
                    BtnLoadEmployee_Click(sender, e);
                    TxtEmpNo.Focus();
                }
                else { LblMsg.Text = "You Could`t Delete this Employee, Please contact Admin"; }
                
            }
            else { LblMsg.Text ="Could`t Delete"; }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
            TxtEmpNo.Enabled = true;
            TxtEmpNo.Focus();
        }

        private void ClearAllFields()
        {
            CmbDesignation.SelectedIndex = -1;
            TxtEmpNo.Text = "";
            TxtDesig.Text = "";
            TxtName.Text = "";
            CmbDesignation.Focus();
            TxtSalary.Text = "";
            BtnInsert.Enabled = true;
            BtnDelete.Enabled = false;
            BtnModify.Enabled = false;
            CmbStatus.Visible = false;
            TxtEmpNo.Focus();
        }

        private void EmployeListView_MouseClick(object sender, MouseEventArgs e)
        {
            ClearAllFields();
            ListViewItem item = EmployeListView.SelectedItems[0];
            TxtEmpNo.Text = item.Text;
            string[] desig = item.SubItems[1].Text.Split();
            if (desig.Length != 1)
            {
                CmbDesignation.Text = desig[0];
                TxtDesig.Text = desig[1];
            }
            else { TxtDesig.Text = item.SubItems[1].Text; }
            TxtName.Text = item.SubItems[2].Text;
            TxtSalary.Text = item.SubItems[3].Text;
            CmbStation.Text = item.SubItems[4].Text;
            CmbEmpGroup.Text = item.SubItems[6].Text;
            CmbStatus.Text = item.SubItems[5].Text;
            TxtEmpNo.Enabled = false;

            this.EmployeeTabControl.SelectedTab = TabAddEmployee;
            CmbStatus.Visible = true;
            BtnInsert.Enabled = false;
            BtnDelete.Enabled = true;
            BtnModify.Enabled = true;
        }

        private void BtnLoadEmployee_Click(object sender, EventArgs e)
        {
            employees = EmployeCrud.ViewEmployee(unit);
            AssignListView(employees);
        }

        private void BtnDelete_Enter(object sender, EventArgs e)
        {
            BtnDelete.Type = MaterialButton.MaterialButtonType.Outlined;
        }

        private void BtnDelete_Leave(object sender, EventArgs e)
        {
            BtnDelete.Type = MaterialButton.MaterialButtonType.Contained;
        }

        private void BtnInsert_Enter(object sender, EventArgs e)
        {
            BtnInsert.Type = MaterialButton.MaterialButtonType.Outlined;
        }

        private void BtnInsert_Leave(object sender, EventArgs e)
        {
            BtnInsert.Type = MaterialButton.MaterialButtonType.Contained;
        }

        private void BtnModify_Enter(object sender, EventArgs e)
        {
            BtnModify.Type = MaterialButton.MaterialButtonType.Outlined;
        }

        private void BtnModify_Leave(object sender, EventArgs e)
        {
            BtnModify.Type = MaterialButton.MaterialButtonType.Contained;
        }

        private void BtnClear_Enter(object sender, EventArgs e)
        {
            BtnClear.Type = MaterialButton.MaterialButtonType.Outlined;
        }

        private void BtnClear_Leave(object sender, EventArgs e)
        {
            BtnClear.Type = MaterialButton.MaterialButtonType.Contained;
        }

        private void TxtSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            if (TxtSearchEmployee.Text.Length > 0)
            {
                var empls = employees.Where(emp => emp.EmpName.StartsWith(TxtSearchEmployee.Text.ToUpper()));
                if (RbByDesignation.Checked) 
                { empls = employees.Where(emp => emp.EmpDesignation.StartsWith(TxtSearchEmployee.Text.ToUpper()));}
                
                if (empls != null) { AssignListView(empls);}
            }
            else {AssignListView(employees);}
        }

        private void AssignListView(IEnumerable<Employee> employees)
        {
            EmployeListView.Items.Clear();
            foreach (Employee employee in employees)
            {
                if (CkInclude.Checked)
                {
                    ListViewItem item = new ListViewItem(employee.EmpNumber.ToString());
                    item.SubItems.Add(employee.EmpDesignation);
                    item.SubItems.Add(employee.EmpName);
                    item.SubItems.Add(employee.EmpSalary.ToString());
                    item.SubItems.Add(employee.EmpStation);
                    item.SubItems.Add(employee.EmpStatus);
                    item.SubItems.Add(employee.EmpGroup);
                    EmployeListView.Items.Add(item);
                }
                else if (employee.EmpStatus != "DELETE" && employee.EmpStatus != "RETAIRED" && employee.EmpStatus != "TRANSFFER")
                {
                    ListViewItem item = new ListViewItem(employee.EmpNumber.ToString());
                    item.SubItems.Add(employee.EmpDesignation);
                    item.SubItems.Add(employee.EmpName);
                    item.SubItems.Add(employee.EmpSalary.ToString());
                    item.SubItems.Add(employee.EmpStation);
                    item.SubItems.Add(employee.EmpStatus);
                    item.SubItems.Add(employee.EmpGroup);
                    EmployeListView.Items.Add(item);
                }
            }
        }
    }
}
