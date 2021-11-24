using MaterialSkin.Controls;
using System;
using System.Data;
using System.Windows.Forms;
using TaMaker.DataClassLibrary;

namespace Ta_Maker.UserInterface
{
    public partial class DesignationEditor : MaterialForm
    {
        string unit = "";
        bool modify = false;

        public DesignationEditor()
        {
            InitializeComponent();
            MaterialDesign.Materialize(this);
        }

        private void DesignationEditor_Load(object sender, EventArgs e)
        {
            unit = UserInterface.Properties.Settings.Default["UnitName"].ToString();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Designation desig = NewDesignation();
            Designation.AddDesignation(desig);
            LoadDesignation();
            BtnUpdate.Enabled = false;
            BtnModify.Enabled = true;
            TxtDesignation.Text = "";
            TxtSortOrder.Text = "";
            TxtDesignation.Focus();
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            BtnModify.Enabled = false;
            LoadDesignation();
            BtnUpdate.Enabled = true;
            modify = true;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (modify)
            {
                if (GridDesignation.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in GridDesignation.Rows)
                    {
                        int Id = int.Parse(row.Cells[0].Value.ToString());
                        Designation designation = new Designation();
                        designation.Desig = row.Cells[1].Value.ToString();
                        designation.SortOrder = int.Parse(row.Cells[2].Value.ToString());
                        if (unit.Length > 0)
                        {
                            designation.UnitName = unit;
                        }
                        else {designation.UnitName = row.Cells[3].Value.ToString();}
                        
                        Designation.UpdateDesignation(Id, designation);
                    }
                }
            }
        }

        private Designation NewDesignation()
        {
            Designation designation = new Designation()
            {
                Id = 0,
                Desig = TxtDesignation.Text.ToUpper(),
                SortOrder = int.Parse(TxtSortOrder.Text.ToString()),
                UnitName = unit
            };

            return designation;
        }

        private void LoadDesignation()
        {
            Designation desig = new Designation();
            DataTable dt = desig.ViewDesignation(unit);
            GridDesignation.DataSource = dt;
            GridDesignation.Columns[0].Visible = false;
            GridDesignation.Columns[3].Visible = false;
            GridDesignation.Columns[1].Width = 360;
        }
    }
}
