using MaterialSkin.Controls;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;
using TaMaker.DataClassLibrary;
using TaMaker.HelperClassLibrary;

namespace Ta_Maker
{
    public partial class TravelReport : MaterialForm
    {
        bool marked;
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

            CmbMonth_SelectedIndexChanged(sender, e);
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
            //if new marked
            //insert myear, mark, date to table

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

            ReportParameter rp3 = new ReportParameter();

            if (!marked)
            {
               rp3 = new ReportParameter("watermark", "DRAFT COPY");
            }
            //this.TravelReportViewer.LocalReport.EnableExternalImages = true;
            //string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            //ReportParameter watermarkParameter = new ReportParameter("watermark", "", false);
            //if (showWatermark)
            //watermarkParameter = new ReportParameter("watermark", (appPath + "/DRAFT.png").ToString(), false);
            //ReportParameter parameter = new ReportParameter("DraftImagePath", imagePath);

            this.TravelReportViewer.LocalReport.ReportPath = "TravellReport.rdlc";
            TravelReportViewer.LocalReport.SetParameters(new ReportParameter[] { rp1, rp2, rp3 });
            ReportDataSource rds = new ReportDataSource("TravellDataSet", dt);

            this.TravelReportViewer.LocalReport.DataSources.Clear();
            this.TravelReportViewer.LocalReport.DataSources.Add(rds);
            this.TravelReportViewer.RefreshReport();
        }

        private void CmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            //check marked as final or not
            string myear = ($"{ CmbMonth.Text} { CmbYear.Text}");
            marked = FinalPrintMark.GetFinalMark(myear);
            //if marked checkbox checked and desable
            if (marked)
            {
                BtnFinalMark.Enabled = false;
            }
            else { BtnFinalMark.Enabled = true; }
            //else checkbox unchecked and enable
        }

        private void BtnFinalMark_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You canot Add/Edit Travel. Are you sure? ", "TA Maker", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //save marke
                string myear = ($"{ CmbMonth.Text} { CmbYear.Text}");
                FinalPrintMark.AddFinalMark(myear, "Marked", DateTime.Now.ToString());
                BtnFinalMark.Enabled = false;
            }
        }
    }
}
