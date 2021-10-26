using MaterialSkin.Controls;
using System;
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
            UserInterface.Properties.Settings.Default["DYear"] = CmbYear.Text.ToString();
            UserInterface.Properties.Settings.Default["DMonth"] = CmbMonth.Text;
            UserInterface.Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
