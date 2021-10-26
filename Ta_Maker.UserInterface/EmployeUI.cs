using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TaMaker.BaseClassLibrary;
using TaMaker.DataClassLibrary;

namespace Ta_Maker
{
    public partial class EmployeUI : MaterialForm
    {
        string forceType = UserInterface.Properties.Settings.Default["ForceType"].ToString();
        string unit = UserInterface.Properties.Settings.Default["UnitName"].ToString();

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
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (CmbDesignation.SelectedIndex != -1 && CmbStation.SelectedIndex != -1)
            {
                NewEmployee(true);
            }
            else { MessageBox.Show("All the fields required", "TA_Maker", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
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
            try
            {
                employeCrud.DeleteEmployee(int.Parse(TxtEmpNo.Text));
                ClearAllFields();
                TxtEmpNo.Enabled = true;
                TxtEmpNo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TA_Maker", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            List<Employee> employees = EmployeCrud.ViewEmployee(unit);
            EmployeListView.Items.Clear();
            foreach (var employee in employees)
            {
                ListViewItem item = new ListViewItem(employee.EmpNumber.ToString());
                item.SubItems.Add(employee.EmpDesignation);
                item.SubItems.Add(employee.EmpName);
                item.SubItems.Add(employee.EmpSalary.ToString());
                item.SubItems.Add(employee.EmpStation);
                EmployeListView.Items.Add(item);
            }
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
    }
}
