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
            ReportData reportData = new ReportData();
            string myear = ($"{ CmbMonth.Text} { CmbYear.Text}");
            string unit = UserInterface.Properties.Settings.Default["UnitName"].ToString();
            DataTable dt = reportData.GetReportData(unit, myear);
          
            ReportParameter rp1 = new ReportParameter("RP_Station", unit);
            ReportParameter rp2 = new ReportParameter("RP_MonthYear", myear.ToString());
            ReportParameter rp3 = new ReportParameter();
            if (dt.Rows.Count > 0)
            {
                if (!marked)
                {
                    rp3 = new ReportParameter("watermark", "DRAFT COPY");
                }
            }
           
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
            string unit = UserInterface.Properties.Settings.Default["UnitName"].ToString();
            marked = FinalPrintMark.GetFinalMark(myear, unit);
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
                string myear = ($"{ CmbMonth.Text} { CmbYear.Text}");
                //check who had advance ta
                DataTable dt = TravelCrud.GetAdvanceTaHolder(myear);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        int kgid = int.Parse(row[0].ToString());
                        DataTable dataTable = TravelCrud.GetVeriationAmount(myear, kgid);
                        double Fair = double.Parse(dataTable.Rows[0][0].ToString());
                        double Advance = double.Parse(dataTable.Rows[0][1].ToString());
                        double TotalTa = double.Parse(dataTable.Rows[0][2].ToString());
                        double LessTotalTa = ((Fair + Advance) - TotalTa);
                        //if (advance+fair) > totalTa 
                        if (LessTotalTa > 0)
                        {
                            //insert to ExcessAdvance (KGID, ExcessAmt, M_Year)
                            TravelCrud.AddDefAmt(kgid, LessTotalTa, myear, "Credited");
                        }
                    }
                }
                
                //save marke
                string unit = UserInterface.Properties.Settings.Default["UnitName"].ToString();
                FinalPrintMark.AddFinalMark(myear, unit, "Marked", DateTime.Now.ToString());
                BtnFinalMark.Enabled = false;
            }
        }
    }
}
