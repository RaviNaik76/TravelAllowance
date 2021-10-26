using MaterialSkin.Controls;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using TaMaker.DataClassLibrary;

namespace Ta_Maker
{
    public partial class EmployeReport : MaterialForm
    {
        public EmployeReport()
        {
            InitializeComponent();
            MaterialDesign.Materialize(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReportData reportData = new ReportData();
            string unit = UserInterface.Properties.Settings.Default["UnitName"].ToString();
            DataTable dt = reportData.GetEmpReportData(unit);
            this.EmployereportViewer.LocalReport.ReportPath = "Employee.rdlc";
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            this.EmployereportViewer.LocalReport.DataSources.Clear();
            this.EmployereportViewer.LocalReport.DataSources.Add(rds);
            this.EmployereportViewer.RefreshReport();
        }
    }
}