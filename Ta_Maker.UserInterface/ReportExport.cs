using MaterialSkin.Controls;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using TaMaker.DataClassLibrary;
using TaMaker.HelperClassLibrary;

namespace Ta_Maker
{
    public partial class ReportExport : MaterialForm
    {
        public ReportExport()
        {
            InitializeComponent();
            MaterialDesign.Materialize(this);
        }

        private void ReportExport_Load(object sender, EventArgs e)
        {
            for (int i = 2017; i <= DateTime.Today.Year; i++)
            {
                CmbYear.Items.Add(i);
            }

            CmbYear.Text = UserInterface.Properties.Settings.Default["DYear"].ToString();
            CmbMonth.Text = UserInterface.Properties.Settings.Default["DMonth"].ToString();
        }

        private void CmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbMonth.Items.Clear();
            if (CmbYear.Text.Length > 0)
            {
                MonthNames.GetMontNames(int.Parse(CmbYear.Text), CmbMonth);
            }
        }

        private void BtnGenarateReport_Click(object sender, EventArgs e)
        {
            ReportData reportData = new ReportData();
            string myear = ($"{ CmbMonth.Text} { CmbYear.Text}");
            string unit = UserInterface.Properties.Settings.Default["UnitName"].ToString();
            DataTable dt = reportData.GetReportData(unit, myear);
            this.ExportReport.LocalReport.ReportPath = "K2ReportExport.rdlc";
            ReportDataSource rds = new ReportDataSource("K2ReportData", dt);

            this.ExportReport.LocalReport.DataSources.Clear();
            this.ExportReport.LocalReport.DataSources.Add(rds);
            this.ExportReport.RefreshReport();
        }
    }
}
