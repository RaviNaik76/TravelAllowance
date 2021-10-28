using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using TaMaker.BaseClassLibrary;
using TaMaker.DataClassLibrary;
using TaMaker.HelperClassLibrary;

namespace Ta_Maker
{
    public partial class TravelUI : MaterialForm
    {
        List<TabPage> tpName = new List<TabPage>();
        private string monthYear = ($"{UserInterface.Properties.Settings.Default["DMonth"]} {UserInterface.Properties.Settings.Default["DYear"]}");
        string unit = UserInterface.Properties.Settings.Default["UnitName"].ToString();
        string remarks = "";

        public TravelUI()
        {
            InitializeComponent();
            MaterialDesign.Materialize(this);
        }

        private void DgvEmployee_MouseClick(object sender, MouseEventArgs e)
        {
            if ((bool)DgvEmployee.SelectedRows[0].Cells[0].Value == false)
            {
                DgvEmployee.SelectedRows[0].Cells[0].Value = true;
            }
            else
            {
                DgvEmployee.SelectedRows[0].Cells[0].Value = false;
            }
        }

        private void BtnCalculateDay_Click(object sender, EventArgs e)
        {
            if (DtDepDate.Text.Length == 2 && DtArrDate.Text.Length == 2)
            {
                DateTime fDate = GetFromatedDate(out DateTime tDate);
                double days = CalculateDays.CalculateDay(fDate, tDate, out string lbltxt);
                if (days > 30 && days <= 90)
                {
                    TxtDays.Text = "30";
                    TxtDays.Hint = "Full TA";
                    TxtDays.Width = 116;
                    TxtDays2.Visible = true;
                    TxtDays2.Text = (days - 30).ToString();
                    MessageBox.Show("KCSR Rule 518 Applied", "TA Maker");
                }
                else if (days > 90)
                {
                    TxtDays.Text = "30";
                    TxtDays.Hint = "Full TA";
                    TxtDays.Width = 116;
                    TxtDays2.Visible = true;
                    TxtDays2.Text = "60";
                    MessageBox.Show("KCSR Rule 518 Applied Only 60 day TA will be paid", "TA Maker");
                }
                else
                {
                    TxtDays.Text = days.ToString();
                    TxtDays.Width = 208;
                    TxtDays2.Visible = false;
                    TxtDays.Hint = lbltxt;
                }
            }
            else
            {
                TxtDays.Text = "Error";
                TxtDays.Hint = "Incurrect Date..!";
            }
        }

        private DateTime GetFromatedDate(out DateTime tDate)
        {
            // DateTime fDate = DateTime.Parse($"{DtDepDate.Value.Day} {monthYear} {DtDepTime.Text}");
            DateTime fDate = DateTime.Parse($"{DtDepDate.Value.ToShortDateString()} {DtDepTime.Text}");
            tDate = DateTime.Parse($"{DtArrDate.Value.ToShortDateString()} {DtArrTime.Text}");
            return fDate;
        }

        private void BtnAddTravel_Click(object sender, EventArgs e)
        {
            int GroupNo = SourceSuplier.GetGroupId() + 1;
            string forceType = UserInterface.Properties.Settings.Default["ForceType"].ToString();
            //loop employee grid (for every employee)
            if (DgvSelectedEmployee.Rows.Count >= 1)
            {
                try
                {
                    foreach (DataGridViewRow row in DgvSelectedEmployee.Rows)
                    {
                        //get salary and emp number
                        int Kgid = int.Parse(row.Cells[0].Value.ToString());
                        string[] design = row.Cells[1].Value.ToString().Split();

                        //get perday ta
                        double PerDayTa = TaValueSuplier.GetTaValue(design[0], CmbDestination.Text.ToString(), forceType);

                        //ADD DATA TO CLASS
                        Travel travell = NewTravel(PerDayTa, Kgid, GroupNo);
                        //Add to database
                        _ = TravelCrud.AddTravell(travell);
                    }
                    ClearAllFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "TA_Maker", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No Employee Selected", "Travel Entry Error");
            }
        }

        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private Travel NewTravel(double PerDayTa, int Kgid, int GroupNo)
        {
            DateTime fDate = GetFromatedDate(out DateTime tDate);
            double Days = PrepareTravel(PerDayTa, out double totalTA);
            
            //divid the hole amt to all employees
            double fairamt = double.Parse(TxtFair.Text);
            if (fairamt > 0)
            {
                if (DgvSelectedEmployee.Rows.Count > 0)
                {
                    fairamt /= DgvSelectedEmployee.Rows.Count;
                }
            }

            Travel travel = new Travel()
            {
                Dep_Place = TxtDepPlace.Text.ToUpper(),
                Dep_Date = fDate,
                Arr_Place = TxtArrPlace.Text.ToUpper(),
                Arr_Date = tDate,
                Dest_Kms = int.Parse(TxtKms.Text),
                Jou_Reason = TxtResion.Text.ToUpper(),
                Halt_Place = CmbHalting.Text,
                DayRate = PerDayTa,
                NoOfDay = Days,
                FareAmt = fairamt,
                TotalTA = totalTA,
                AdvanceTA = double.Parse(TxtAdvace.Text),
                Jou_Mode = CmbJourneyMode.Text,
                Warrant_No = TxtWarrant.Text,
                Shd_No = ($"{TxtShd.Text}, {TxtShd_No.Text}"),
                Destination = CmbDestination.Text,
                EmpNo = Kgid,
                GroupNo = GroupNo,
                MonthYear = monthYear,
                Remarks = remarks
            };
            return travel;
        }

        private double PrepareTravel(double PerDayTa, out double totalTA)
        {
            double Days;
            double.TryParse(TxtDays2.Text, out double extraDays);
            if (extraDays > 0)
            {
                Days = double.Parse(TxtDays.Text) + double.Parse(TxtDays2.Text);
                totalTA = double.Parse(TxtDays.Text) * PerDayTa;
                totalTA += (double.Parse(TxtDays2.Text) * (PerDayTa / 2));
                remarks = ($"Rule 518 ({TxtDays.Text} x {PerDayTa}, {TxtDays2.Text} x {PerDayTa / 2})");
            }
            else
            {
                Days = double.Parse(TxtDays.Text);
                totalTA = (PerDayTa * double.Parse(TxtDays.Text) + double.Parse(TxtFair.Text));
                remarks = "";
            }
            if (TxtAdvace.Text.Length == 0)
            {
                TxtAdvace.Text = "0";
            }
            if (TxtKms.Text.Length == 0)
            {
                TxtKms.Text = "0";
            }
            if (TxtFair.Text.Length == 0)
            {
                TxtFair.Text = "0";
            }
            return Days;
        }



        private void ClearAllFields()
        {
            SetDate();
            CmbDestination.SelectedIndex = -1;
            CmbJourneyMode.SelectedIndex = -1;
            CmbHalting.SelectedIndex = -1;
            TxtDepPlace.Text = "";
            TxtArrPlace.Text = "";
            TxtResion.Text = "";
            TxtShd.Text = "";
            CmbHalting.Focus();
            CmbJourneyMode.Focus();
            CmbDestination.Focus();
            TxtWarrant.Text = "";
            TxtFair.Text = "";
            TxtKms.Text = "";
            TxtShd_No.Text = "";
            TxtDays.Text = "";
            TxtDays2.Text = "";
            TxtAdvace.Text = "";
            TxtDays.Hint = "Total Days";
        }

        private void TravelUI_Load(object sender, EventArgs e)
        {
            TravelCrud travelCrud = new TravelCrud();
            travelCrud.themeMe = UserInterface.Properties.Settings.Default["ThemeMe"].ToString();
            if (unit.Length > 0)
            {
                LoadEmployee();
                //load places metro, etc
                Dictionary<int, string> Places = SourceSuplier.LoadPlaces();
                foreach (var item in Places)
                {
                    CmbDestination.Items.Add(item.Value);
                }

                //load places metro, etc
                Dictionary<int, string> vehicletype = SourceSuplier.LoadVehicleType();
                foreach (var item in vehicletype)
                {
                    CmbJourneyMode.Items.Add(item.Value);
                }

                //load places metro, etc
                Dictionary<int, string> haltingPlaces = SourceSuplier.LoadHaltingPlace();
                foreach (var item in haltingPlaces)
                {
                    CmbHalting.Items.Add(item.Value);
                }

                SetDate();
                TxtSearchEmployee.Focus();
            }
            else { MessageBox.Show("Please set your Unit in Unit Setting", "TA_Maker", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void SetDate()
        {
            if (monthYear.Length > 1)
            {
                DtArrDate.Value = DateTime.Parse($"01 {monthYear}");
                DtDepDate.Value = DateTime.Parse($"01 {monthYear}");
            }
        }

        private void Okey_Click(object sender, EventArgs e)
        {
            DgvSelectedEmployee.Rows.Clear();
            foreach (DataGridViewRow item in DgvEmployee.Rows)
            {
                if ((bool)item.Cells[0].Value == true)
                {
                    int n = DgvSelectedEmployee.Rows.Add();
                    DgvSelectedEmployee.Rows[n].Cells[0].Value = item.Cells[4].Value.ToString();
                    DgvSelectedEmployee.Rows[n].Cells[1].Value = item.Cells[1].Value.ToString();
                    DgvSelectedEmployee.Rows[n].Cells[2].Value = item.Cells[2].Value.ToString();
                    DgvSelectedEmployee.Rows[n].Cells[3].Value = item.Cells[3].Value.ToString();
                }
            }
            TravelCrud travelCrud = new TravelCrud();
            travelCrud.SetGridColor(DgvSelectedEmployee);
            PanelEmployee.Visible = false;
            CmbDestination.Focus();
        }

        private void CancelEmployee_Click(object sender, EventArgs e)
        {
            PanelEmployee.Visible = false;
        }

        private void BtnLoadTravel_Click(object sender, EventArgs e)
        {
            TabPage tpOld = TravelViewTabControl.SelectedTab;
            ResetTabView(tpOld);

            if (DgvSelectedEmployee.Rows.Count > 0)
            {
                bool fistrow = true;
                foreach (DataGridViewRow row in DgvSelectedEmployee.Rows)
                {
                    int Kgid = int.Parse(row.Cells[0].Value.ToString());

                    DataTable dt = TravelCrud.ViewTravell(monthYear, Kgid);
                    if (dt.Rows.Count > 0)
                    {
                        if (fistrow)
                        {
                            GridTravelView.DataSource = dt;
                            TravelCrud travelCrud = new TravelCrud();
                            travelCrud.FormatTravellGrid(GridTravelView);
                            // SetGridColor(GridTravelView);
                            fistrow = false;
                            tpOld.Text = Kgid.ToString();
                        }
                        else
                        {
                            TabPage tpNew = new TabPage(Kgid.ToString());
                            dt = TravelCrud.ViewTravell(monthYear, Kgid);
                            if (dt.Rows.Count > 0)
                            {
                                //add page
                                TravelViewTabControl.TabPages.Add(tpNew);
                                tpName.Add(tpNew);
                                TravelCrud travelCrud = new TravelCrud();
                                travelCrud.CreateTabAndGridView(dt, tpNew);
                            }
                        }
                    }
                }
            }
        }

        private void ResetTabView(TabPage old)
        {
            if (tpName.Count > 0)
            {
                foreach (var item in tpName)
                {
                    TravelViewTabControl.TabPages.Remove(item);
                }
            }

            old.Text = "KGID";
            GridTravelView.DataSource = "";
        }


        private void BtnCalculateDay_Enter(object sender, EventArgs e)
        {
            BtnCalculateDay.Type = MaterialButton.MaterialButtonType.Outlined;
        }

        private void BtnCalculateDay_Leave(object sender, EventArgs e)
        {
            BtnCalculateDay.Type = MaterialButton.MaterialButtonType.Contained;
        }

        private void BtnAddTravel_Enter(object sender, EventArgs e)
        {
            BtnAddTravel.Type = MaterialButton.MaterialButtonType.Outlined;
        }

        private void BtnAddTravel_Leave(object sender, EventArgs e)
        {
            BtnAddTravel.Type = MaterialButton.MaterialButtonType.Contained;
        }

        private void BtnClearAll_Enter(object sender, EventArgs e)
        {
            BtnClearAll.Type = MaterialButton.MaterialButtonType.Outlined;
        }

        private void BtnClearAll_Leave(object sender, EventArgs e)
        {
            BtnClearAll.Type = MaterialButton.MaterialButtonType.Contained;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = GridTravelView.CurrentRow;
            int id = int.Parse(row.Cells[17].Value.ToString());
            if (id > 0)
            {
                TravelCrud travelCrud = new TravelCrud();
                travelCrud.DeleteTravell(id);
                BtnDelete.Enabled = false;
                BtnLoadTravel_Click(sender, e);
            }
            else { MessageBox.Show("Please select row", "TA Maker", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            BtnLoadTravel.Focus();
        }

        private void GridTravelView_MouseClick(object sender, MouseEventArgs e)
        {
            BtnDelete.Enabled = true;
        }

        private void TxtSearchEmployee_Enter(object sender, EventArgs e)
        {
            PanelEmployee.Height = 395;
            PanelEmployee.Visible = true;
        }

        private void LoadEmployee()
        {
            List<Employee> EmployeeList = EmployeCrud.ViewEmployee(unit);
            if (EmployeeList.Count > 0)
            {
                DgvEmployee.Rows.Clear();
                TravelCrud travelCrud = new TravelCrud();
                travelCrud.AsaignDataToEmployeeGrid(DgvEmployee, EmployeeList, false);
                // SetGridColor(DgvEmployee);
            }
        }

        private void TxtSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            string searchText = TxtSearchEmployee.Text;
            if (searchText.Length > 0)
            {
                List<DataGridViewRow> rows = new List<DataGridViewRow>();
                foreach (DataGridViewRow item in DgvEmployee.Rows)
                {
                    if ((bool)item.Cells[0].Value == true)
                    {
                        rows.Add(item);
                    }
                }

                EmployeCrud.SearchEmployee(DgvEmployee, unit, searchText);
                if (rows.Count > 0)
                {
                    foreach (var row in rows)
                    {
                        DgvEmployee.Rows.Add(row);
                    }
                }
            }
            else 
            {
                List<DataGridViewRow> rows = new List<DataGridViewRow>();
                foreach (DataGridViewRow i in DgvEmployee.Rows)
                {
                    if ((bool)i.Cells[0].Value == true)
                    {
                         rows.Add(i);
                    }
                }

                LoadEmployee();
                foreach (DataGridViewRow item in DgvEmployee.Rows)
                {
                    int bkgid = int.Parse(item.Cells[4].Value.ToString());
                    foreach (var row in rows)
                    {
                        int gkgid = int.Parse(row.Cells[4].Value.ToString());
                        if (bkgid == gkgid)
                        {
                            item.Cells[0].Value = true;
                        }
                    }
                }
            }
        }

        private void CmbJourneyMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbJourneyMode.Text == "KSRTC" || CmbJourneyMode.Text == "Train")
            {
                TxtWarrant.Enabled = true;
                TxtWarrant.Focus();
            }
            else { TxtWarrant.Enabled = false; }
        }
    }
}
