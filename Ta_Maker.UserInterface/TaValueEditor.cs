using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using TaMaker.DataClassLibrary;

namespace Ta_Maker.UserInterface
{
    public partial class TaValueEditor : MaterialForm
    {
        public TaValueEditor()
        {
            InitializeComponent();
            MaterialDesign.Materialize(this);
        }

        private void TaValueEditor_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> empClass = SourceSuplier.LoadEmpClass();
            foreach (var item in empClass) CmbEmpClass.Items.Add(item.Value);
        }

        private void CmbEmpClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Load Ta Value to textboxes
            TaValue taValue = new TaValue();
            DataTable dt = taValue.ViewTaValue(CmbEmpClass.Text);
            TxtBangloreTa.Text = dt.Rows[0]["BangloreTa"].ToString();
            TxtNormalTa.Text = dt.Rows[0]["NormalTa"].ToString();
            TxtMetroTa.Text = dt.Rows[0]["MetroTa"].ToString();
            TxtOutNormalTa.Text = dt.Rows[0]["OutOfStateTa"].ToString();
            TxtOutMetroTa.Text = dt.Rows[0]["OutOfStateMetroTa"].ToString();
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            materialCard3.Enabled = true;
            materialCard2.Enabled = true;
            CmbEmpClass.Enabled = false;
            BtnModify.Enabled = false;
            BtnUpdate.Enabled = true;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            TaValue taValue = new TaValue()
            {
                NormalTa = double.Parse(TxtNormalTa.Text),
                MetroTa = double.Parse(TxtMetroTa.Text),
                BangloreTa = double.Parse(TxtBangloreTa.Text),
                OutOfStateTa = double.Parse(TxtOutNormalTa.Text),
                OutOfStateMetroTa = double.Parse(TxtOutMetroTa.Text)
            };

            TaValue ta = new TaValue();
            ta.UpdateTaValue(CmbEmpClass.Text, taValue);
            materialCard3.Enabled = false;
            materialCard2.Enabled = false;
            CmbEmpClass.Enabled = true;
            BtnModify.Enabled = true;
            BtnUpdate.Enabled = false;
        }
    }
}
