using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using TaMaker.BaseClassLibrary;
using TaMaker.DataClassLibrary;

namespace Ta_Maker.UserInterface
{
    public partial class AddUnits : MaterialForm
    {
        public AddUnits()
        {
            InitializeComponent();
            MaterialDesign.Materialize(this);
        }

        private void AddUnits_Load(object sender, EventArgs e)
        {

            CmbOfficeType.Items.Add("DISTRICT");

            //string forceType = UserInterface.Properties.Settings.Default["ForceType"].ToString();
            //switch (forceType)
            //{
            //    case "CIVIL":
            //        Dictionary<int, string> OfficeType = SourceSuplier.LoadOfficeType();
            //        CmbOfficeType2.Items.Clear();
            //        foreach (var item in OfficeType)
            //        {
            //            CmbOfficeType2.Items.Add(item.Value);
            //        }
            //        break;
            //    case "DAR":
            //        CmbOfficeType2.Items.Clear();
            //        CmbOfficeType2.Items.Add("DAR");
            //        break;
            //    case "KSRP":
            //        CmbOfficeType2.Items.Clear();
            //        CmbOfficeType2.Items.Add("KSRP");
            //        break;
            //}
            

            //Dictionary<int, string> District = SourceSuplier.LoadDistrict();

            //foreach (var item in District)
            //{
            //    CmbDistrict.Items.Add(item.Value);
            //}
        }

        private void BtnSaveDist_Click(object sender, EventArgs e)
        {
            DistrictUnits du = new DistrictUnits();
            Source src = new Source();
            src.SourceType = CmbOfficeType.Text;
            src.SourceName = TxtPlaceName.Text.ToUpper();
            du.AddSource(src);

            LblMsg.Text = "District Added succusfuly";
            TxtPlaceName.Text = "";
        }

        private void btnAddUnits_Click(object sender, EventArgs e)
        {
            DistrictUnits du = new DistrictUnits();
            Units units = new Units();
            units.UnitName = TxtPlaceName2.Text.ToUpper();
            units.UnitType = CmbOfficeType2.Text;
            units.DistCode = CmbDistrict.Text;
            du.AddUnits(units);

            LblMsg.Text = "Unit Added succusfuly";
            CmbDistrict.Text = "";
            CmbOfficeType2.Text = "";
            TxtPlaceName2.Text = "";
        }

    }
}
