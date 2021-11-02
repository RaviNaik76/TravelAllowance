﻿using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TaMaker.BaseClassLibrary;
using TaMaker.DataClassLibrary;

namespace Ta_Maker
{
    public partial class EmployeUI : MaterialForm
    {
        string forceType = UserInterface.Properties.Settings.Default["ForceType"].ToString();
        string unit = UserInterface.Properties.Settings.Default["UnitName"].ToString();
        List<Employee> employees = new List<Employee>();

        public EmployeUI()
        {
            InitializeComponent();
            MaterialDesign.Materialize(this);
        }

        private void EmployeUI_Load(object sender, EventArgs e)
        {
            if (unit.Length > 0)
            {
                Dictionary<int, string> Designations = SourceSuplier.LoadDesignation(forceType);

                foreach (var item in Designations)
                {
                    CmbDesignation.Items.Add(item.Value);
                }

                string dist = UserInterface.Properties.Settings.Default["UnitDist"].ToString();
                string utype = UserInterface.Properties.Settings.Default["UnitType"].ToString();
                Dictionary<int, string> Stations = SourceSuplier.LoadStation(utype, dist);
                foreach (var item in Stations)
                {
                    CmbStation.Items.Add(item.Value);
                }
                CmbStation.SelectedItem = unit;
                TxtEmpNo.Focus();
            }
            else { MessageBox.Show("Please set your Unit in Unit Setting", "TA_Maker", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            RbByName.Checked = true;
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
                Employee employee = new Employee()
                {
                    EmpNumber = int.Parse(TxtEmpNo.Text),
                    EmpDesignation = ($"{CmbDesignation.Text} {TxtDesig.Text}"),
                    EmpName = TxtName.Text.ToUpper(),
                    EmpSalary = double.Parse(TxtSalary.Text),
                    EmpStation = CmbStation.Text,
                    EmpShort = SourceSuplier.GetEmployeSort(CmbDesignation.Text, forceType)
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
            NewEmployee(false);
            TxtEmpNo.Enabled = true;
            TxtEmpNo.Focus();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            EmployeCrud employeCrud = new EmployeCrud();
            ListViewItem item = EmployeListView.SelectedItems[0];
            if (int.TryParse(item.Text, out int kgid))
            {
                employeCrud.DeleteEmployee(kgid);
                ClearAllFields();
                TxtEmpNo.Enabled = true;
                LblMsg.Text = "Employee Deleted";
                BtnLoadEmployee_Click(sender, e);
                TxtEmpNo.Focus();
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
            TxtEmpNo.Enabled = false;

            this.EmployeeTabControl.SelectedTab = TabAddEmployee;
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
                ListViewItem item = new ListViewItem(employee.EmpNumber.ToString());
                item.SubItems.Add(employee.EmpDesignation);
                item.SubItems.Add(employee.EmpName);
                item.SubItems.Add(employee.EmpSalary.ToString());
                item.SubItems.Add(employee.EmpStation);
                EmployeListView.Items.Add(item);
            }
        }
    }
}
