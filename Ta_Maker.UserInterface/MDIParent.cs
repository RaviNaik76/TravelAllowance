using System;
using System.IO;
using System.Windows.Forms;

namespace Ta_Maker.UserInterface
{
    public partial class MDIParent : Form
    {
        string dbpath = Properties.Resources.DbPath;
        string unit = UserInterface.Properties.Settings.Default["UnitName"].ToString();

        public MDIParent()
        {
            InitializeComponent();
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void dATABASEUTILITYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseUtility databaseUtility = new DatabaseUtility();
            databaseUtility.MdiParent = this;
            databaseUtility.Show();
        }

        private void rELOADMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(dbpath))
            {
                uSERSETTINGToolStripMenuItem.Enabled = true;
                dATAENTRYToolStripMenuItem.Enabled = true;
                rEPORTSToolStripMenuItem.Enabled = true;
                LblMsg.Text = "OK";
            }
            else
            {
                LblMsg.Text = "Please Open Database Utility and Create Or Restore Database";
                uSERSETTINGToolStripMenuItem.Enabled = false;
                dATAENTRYToolStripMenuItem.Enabled = false;
                rEPORTSToolStripMenuItem.Enabled = false;
            }
        }

        private void uNITSETTINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnitSetting unitSetting = new UnitSetting();
            unitSetting.MdiParent = this;
            unitSetting.Show();
        }

        private void mONTHYEARSETTINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (unit.Length > 0)
            {
                MonthYear monthYearSetting = new MonthYear();
                monthYearSetting.MdiParent = this;
                monthYearSetting.Show();
            }
            else { LblMsg.Text = "Please Set Unit and try"; }
        }

        private void eMPLOYEEDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (unit.Length > 0)
            {
                EmployeUI employeUI = new EmployeUI();
                employeUI.MdiParent = this;
                employeUI.Show();
            }
            else { LblMsg.Text = "Please Set Unit and try"; }
        }

        private void tRAVELDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TravelUI travelUI = new TravelUI();
            travelUI.MdiParent = this;
            travelUI.Show();
        }

        private void eMPLOYEEREPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (unit.Length > 0)
            {
                EmployeReport employeReport = new EmployeReport();
                employeReport.MdiParent = this;
                employeReport.Show();
            }
            else { LblMsg.Text = "Please Set Unit and try"; }
        }

        private void mONTHLYREPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (unit.Length > 0)
            {
                TravelReport travelReport = new TravelReport();
                travelReport.MdiParent = this;
                travelReport.Show();
            }
            else { LblMsg.Text = "Please Set Unit and try"; }
        }

        private void rEPORTEXPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (unit.Length > 0)
            {
                ReportExport reportExport = new ReportExport();
                reportExport.MdiParent = this;
                reportExport.Show();
            }
            else { LblMsg.Text = "Please Set Unit and try"; }
        }

        private void MDIParent_Load(object sender, EventArgs e)
        {
            if (File.Exists(dbpath))
            {
                uSERSETTINGToolStripMenuItem.Enabled = true;
                dATAENTRYToolStripMenuItem.Enabled = true;
                rEPORTSToolStripMenuItem.Enabled = true;
                LblMsg.Text = "OK";
            }
            else
            {
                LblMsg.Text = "Please Open Database Utility and Create Or Restore Database";
                uSERSETTINGToolStripMenuItem.Enabled = false;
                dATAENTRYToolStripMenuItem.Enabled = false;
                rEPORTSToolStripMenuItem.Enabled = false;
            }
        }

        private void tHEMESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeTheme changeTheme = new ChangeTheme();
            changeTheme.MdiParent = this;
            changeTheme.Show();
        }

        private void dESIGNATIONSETTINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (unit.Length > 0)
            {
                DesignationEditor de = new DesignationEditor();
                de.MdiParent = this;
                de.Show();
            }
            else { LblMsg.Text = "Please Set Unit and try"; }
            
        }

        private void tAVALUEEDIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaValueEditor tv = new TaValueEditor();
            tv.MdiParent = this;
            tv.Show();
        }
    }
}
