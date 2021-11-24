using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using TaMaker.DataClassLibrary;

namespace Ta_Maker
{
    public partial class UnitSetting : MaterialForm
    {
        public UnitSetting()
        {
            InitializeComponent();
            MaterialDesign.Materialize(this);
        }

        private void UnitSetting_Load(object sender, EventArgs e)
        {
            LoadUnits();

            //string forceType = UserInterface.Properties.Settings.Default["ForceType"].ToString();
            //switch (forceType)
            //{
            //    case "CIVIL":
            //        RbtnCivil.Checked = true;
            //        break;
            //    case "DAR":
            //        RbtnDar.Checked = true;
            //        break;
            //    case "KSRP":
            //        RbtnKsrp.Checked = true;
            //        break;
            //}

            //CmbDist2.Text = UserInterface.Properties.Settings.Default["UnitDist"].ToString();
            //CmbOffice2.Text = UserInterface.Properties.Settings.Default["UnitType"].ToString();
            CmbUnitName.SelectedItem = UserInterface.Properties.Settings.Default["UnitName"].ToString();
        }

        private void BtnDefaltUnit_Click(object sender, EventArgs e)
        {
            //UserInterface.Properties.Settings.Default["UnitDist"] = CmbDist2.Text.ToUpper();
            //UserInterface.Properties.Settings.Default["UnitType"] = CmbOffice2.Text.ToUpper();
            UserInterface.Properties.Settings.Default["UnitName"] = CmbUnitName.Text.ToUpper();
            //if (RbtnCivil.Checked)
            //{
            //    UserInterface.Properties.Settings.Default["ForceType"] = "CIVIL";
            //}
            //else if (RbtnDar.Checked)
            //{
            //    UserInterface.Properties.Settings.Default["ForceType"] = "DAR";
            //}
            //else { UserInterface.Properties.Settings.Default["ForceType"] = "KSRP"; }

            UserInterface.Properties.Settings.Default.Save();
            this.Close();
        }

        private void btnAddUnits_Click(object sender, EventArgs e)
        {
            SourceSuplier sourceSuplier = new SourceSuplier();
            sourceSuplier.AddSource(TxtSourceName.Text.ToUpper(), "Unit");
            TxtSourceName.Text = "";
            LoadUnits();
            TxtSourceName.Focus();
        }

        private void LoadUnits()
        {
            Dictionary<int, string> UnitList = SourceSuplier.LoadUnits();
            CmbUnitName.Items.Clear();
            foreach (var item in UnitList)
            {
                CmbUnitName.Items.Add(item.Value);
            }
        }
        //private void CmbOffice2_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Dictionary<int, string> UnitPs = SourceSuplier.LoadStation(CmbOffice2.Text, CmbDist2.Text);
        //    CmbUnitName.Items.Clear();
        //    foreach (var item in UnitPs)
        //    {
        //        CmbUnitName.Items.Add(item.Value);
        //    }
        //}

        //private void RbtnCivil_CheckedChanged(object sender, EventArgs e)
        //{
        //    CmbOffice2.Items.Clear();
        //    Dictionary<int, string> OfficeType = SourceSuplier.LoadOfficeType();

        //    foreach (var item in OfficeType)
        //    {
        //        CmbOffice2.Items.Add(item.Value);
        //    }
        //}

        //private void RbtnDar_CheckedChanged(object sender, EventArgs e)
        //{
        //    CmbOffice2.Items.Clear();
        //    CmbOffice2.Items.Add("DAR");
        //}

        //private void RbtnKsrp_CheckedChanged(object sender, EventArgs e)
        //{
        //    CmbOffice2.Items.Clear();
        //    CmbOffice2.Items.Add("KSRP");
        //}
    }
}
