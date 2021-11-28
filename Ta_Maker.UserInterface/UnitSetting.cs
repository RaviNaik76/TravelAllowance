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
            CmbUnitName.SelectedItem = UserInterface.Properties.Settings.Default["UnitName"].ToString();
        }

        private void BtnDefaltUnit_Click(object sender, EventArgs e)
        {
            UserInterface.Properties.Settings.Default["UnitName"] = CmbUnitName.Text.ToUpper();
            UserInterface.Properties.Settings.Default.Save();

            CreateDb createDb = new CreateDb();
            createDb.CreateViews(CmbUnitName.Text.ToUpper());
            
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
    }
}
