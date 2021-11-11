using MaterialSkin.Controls;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;
using TaMaker.DataClassLibrary;
using TaMaker.HelperClassLibrary;

namespace Ta_Maker
{
    public partial class ReportExport : MaterialForm
    {
        bool marked;

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

        private void BtnGenarateReport_Click(object sender, EventArgs e)
        {
            ReportData reportData = new ReportData();
            string myear = ($"{ CmbMonth.Text} { CmbYear.Text}");
            string unit = UserInterface.Properties.Settings.Default["UnitName"].ToString();
            DataTable dt = reportData.GetReportData(unit, myear);
            this.ExportReport.LocalReport.ReportPath = "K2ReportExport.rdlc";
            ReportDataSource rds = new ReportDataSource("K2ReportData", dt);

            ReportParameter rp3 = new ReportParameter();
            if (!marked)
            {
                rp3 = new ReportParameter("watermark", "DRAFT COPY");
            }
            ExportReport.LocalReport.SetParameters(new ReportParameter[] { rp3 });
            this.ExportReport.LocalReport.DataSources.Clear();
            this.ExportReport.LocalReport.DataSources.Add(rds);
            this.ExportReport.RefreshReport();
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
            if (MessageBox.Show("You canot Add/Edit Travel. Are you sure? ","TA Maker", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //save marke
                string myear = ($"{ CmbMonth.Text} { CmbYear.Text}");
                FinalPrintMark.AddFinalMark(myear, "Marked", DateTime.Now.ToString());
                BtnFinalMark.Enabled = false;
            }
        }
    }
}
