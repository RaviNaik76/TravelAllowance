using MaterialSkin.Controls;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using TaMaker.DataClassLibrary;
using TaMaker.HelperClassLibrary;

namespace Ta_Maker
{
    public partial class TravelReport : MaterialForm
    {
        public TravelReport()
        {
            InitializeComponent();
            MaterialDesign.Materialize(this);
        }

        private void TravelReport_Load(object sender, EventArgs e)
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

        private void BtnShowReport_Click(object sender, EventArgs e)
        {
            ReportData reportData = new ReportData();
            string myear = ($"{ CmbMonth.Text} { CmbYear.Text}");
            string unit = UserInterface.Properties.Settings.Default["UnitName"].ToString();
            DataTable dt = reportData.GetReportData(unit, myear);
            string utype = UserInterface.Properties.Settings.Default["UnitType"].ToString();

            string forceType = UserInterface.Properties.Settings.Default["ForceType"].ToString();
            ReportParameter rp1;
            if (forceType == "DAR" || forceType == "KSRP")
            {
                rp1 = new ReportParameter("RP_Station", unit);
            }
            else { rp1 = new ReportParameter("RP_Station", ($"{unit} {utype}")); }
            ReportParameter rp2 = new ReportParameter("RP_MonthYear", myear.ToString());

            this.TravelReportViewer.LocalReport.ReportPath = "TravellReport.rdlc";
            TravelReportViewer.LocalReport.SetParameters(new ReportParameter[] { rp1, rp2 });
            ReportDataSource rds = new ReportDataSource("TravellDataSet", dt);

            this.TravelReportViewer.LocalReport.DataSources.Clear();
            this.TravelReportViewer.LocalReport.DataSources.Add(rds);
            this.TravelReportViewer.RefreshReport();
        }
    }
}
