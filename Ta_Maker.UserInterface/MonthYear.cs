using MaterialSkin.Controls;
using System;
using System.Data;
using TaMaker.DataClassLibrary;
using TaMaker.HelperClassLibrary;

namespace Ta_Maker
{
    public partial class MonthYear : MaterialForm
    {
        public MonthYear()
        {
            InitializeComponent();
            MaterialDesign.Materialize(this);
        }

        private void MonthYear_Load(object sender, EventArgs e)
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

        private void BtnSetMonthYear_Click(object sender, EventArgs e)
        {
            string monthYear = ($"{UserInterface.Properties.Settings.Default["DMonth"]} {UserInterface.Properties.Settings.Default["DYear"]}");
            string myear = ($"{ CmbMonth.Text} { CmbYear.Text}");
            DateTime pastDate = DateTime.Parse($"02 {monthYear} 10:00:00");
            DateTime selectedDate = DateTime.Parse($"02 {myear} 10:00:00");
            
            if (pastDate < selectedDate)
            {
                DataTable dt = TravelCrud.GetAdvanceTaHolder(monthYear);
                string unit = UserInterface.Properties.Settings.Default["UnitName"].ToString();
                bool marked = FinalPrintMark.GetFinalMark(monthYear, unit);
                if (dt.Rows.Count > 0 && !marked)
                {
                    MaterialMessageBox.Show($"Please lock {monthYear} before you proced","TA Maker");
                }
                else
                {
                    SetProperties();
                }
            }
            else
            {
                SetProperties();
            }
        }

        private void SetProperties()
        {
            UserInterface.Properties.Settings.Default["DYear"] = CmbYear.Text.ToString();
            UserInterface.Properties.Settings.Default["DMonth"] = CmbMonth.Text;
            UserInterface.Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
