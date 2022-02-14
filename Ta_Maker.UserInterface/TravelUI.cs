using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
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
        string remarks = ""; bool marked;
        int kgno = 0; int gid = 0; double perDayTa = 0;

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
            else { DgvEmployee.SelectedRows[0].Cells[0].Value = false;}
        }

        private void BtnCalculateDay_Click(object sender, EventArgs e)
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

        private void BtnAddTravel_Click(object sender, EventArgs e)
        {
            if (DgvSelectedEmployee.Rows.Count >= 1)
            {
                BtnCalculateDay_Click(sender, e);

                if (ValidForm())
                {
                    double Kms = double.Parse(TxtKms.Text);
                    if (Kms >= 16)
                    {
                        if (BtnAddTravel.Text == "ADD TRAVEL DETAILS")
                        {
                            if (DataNotExists())
                            {
                                int GroupNo = SourceSuplier.GetGroupId() + 1;
                                //loop employee grid (for every employee)
                                foreach (DataGridViewRow row in DgvSelectedEmployee.Rows)
                                {
                                    //get salary and emp number
                                    int Kgid = int.Parse(row.Cells[0].Value.ToString());
                                    string design = row.Cells[1].Value.ToString();
                                    double salary = double.Parse(row.Cells[3].Value.ToString());
                                    string empClass = row.Cells[4].Value.ToString();

                                    //get perday ta
                                    double PerDayTa = TaValueSuplier.GetTaValue(empClass, CmbDestination.Text.ToString());

                                    //ADD DATA TO CLASS
                                    Travel travell = NewTravel(PerDayTa, Kgid, GroupNo, design.Trim(), salary);

                                    //Add to database
                                    _ = TravelCrud.AddTravell(travell);
                                }
                                BtnClearAll_Click(sender, e);
                            }
                            else { MessageBox.Show("Data Already Exists within the Date Range", "Travel Entry"); }
                        }
                        else
                        {
                            //get employee details from kgid
                            int Kgid = kgno; int GroupNo = gid;

                            //get dates from dtpicker
                            DateTime fDate = GetFromatedDate(out DateTime tDate);
                            //check data exists
                            bool pass = TravelCrud.CheckExceptTravell(Kgid, fDate, tDate, GroupNo);
                            if (!pass)
                            {
                                //add to travell
                                Travel travell = NewTravel(perDayTa, Kgid, GroupNo, "", 0);

                                //update travell
                                if (optionSelEmp.Checked)
                                {
                                    TravelCrud.UpdateTravell(travell, Kgid, GroupNo, true);
                                }
                                else
                                {
                                    //get kgid list from db

                                    TravelCrud.UpdateTravell(travell, Kgid, GroupNo, false);
                                }

                                //clear fields
                                BtnClearAll_Click(sender, e);
                            }
                            else { MessageBox.Show("Data Already Exists within the Date Range", "Travel Update"); }
                        } 
                    }
                    else { MessageBox.Show("As per rule 497, Above 15 Kms may Claim", "Travel Maker"); }
                }
                else { MessageBox.Show("Entered Values are Not Valid, Please check..", "Travel Entry"); }
            }
            else {MessageBox.Show("No Employee Selected", "Travel Entry Error");}
        }

        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            SetMonthYearToDate();
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
            BtnAddTravel.Text = "ADD TRAVEL DETAILS";
            BtnAddTravel.Width = 169;
            panelOption.Visible = false;
            TxtDays.Hint = "Total Days";
        }

        private void TravelUI_Load(object sender, EventArgs e)
        {
            TravelCrud travelCrud = new TravelCrud();
            travelCrud.themeMe = UserInterface.Properties.Settings.Default["ThemeMe"].ToString();
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

            marked = FinalPrintMark.GetFinalMark(monthYear, unit);
            if (marked)
            {
                BtnAddTravel.Enabled = false;
            }

            SetMonthYearToDate();
            TxtSearchEmployee.Focus();
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
                    DgvSelectedEmployee.Rows[n].Cells[4].Value = item.Cells[5].Value.ToString();
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
            //ResetTabView
            if (tpName.Count > 0)
            {
                foreach (var item in tpName)
                {
                    TravelViewTabControl.TabPages.Remove(item);
                }
            }

            tpOld.Text = "KGID";
            GridTravelView.DataSource = "";

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
            TravelCrud travelCrud = new TravelCrud();
            int index = travelCrud.GetColumnIndexByName(GridTravelView, "GroupNo");
            if (index > 0)
            {
                DataGridViewRow row = GridTravelView.CurrentRow;
                travelCrud.DeleteTravell(int.Parse(row.Cells[index].Value.ToString()));
                BtnDelete.Enabled = false;
                BtnLoadTravel_Click(sender, e);
                BtnLoadTravel.Focus();
            }
            else { MessageBox.Show("Please select row", "TA Maker", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void GridTravelView_MouseClick(object sender, MouseEventArgs e)
        {
            if (!marked)
            {
                BtnDelete.Enabled = true;
            }
        }

        private void TxtSearchEmployee_Enter(object sender, EventArgs e)
        {
            PanelEmployee.Height = 322;
            PanelEmployee.Visible = true;
        }

        private void TxtSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            if (TxtSearchEmployee.Text.Length > 0)
            {
                //store selected employee in row list
                List<DataGridViewRow> rows = new List<DataGridViewRow>();
                foreach (DataGridViewRow item in DgvEmployee.Rows)
                {
                    if ((bool)item.Cells[0].Value == true)
                    {
                        rows.Add(item);
                    }
                }
                //Load all employee
                bool IsNameChecked = false;
                if (CkByName.Checked) {IsNameChecked = true;}
                EmployeCrud.SearchEmployee(DgvEmployee, unit, TxtSearchEmployee.Text, IsNameChecked);
                
                //Add selected row again to grid
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
            if (CmbJourneyMode.Text == "KSRTC" || CmbJourneyMode.Text == "Train" || CmbJourneyMode.Text == "Airoplane")
            {
                TxtWarrant.Enabled = true;
                TxtWarrant.Focus();
            }
            else {
                TxtWarrant.Text = ""; 
                TxtWarrant.Enabled = false; }
        }

        //============================================= METHODS ==============================
       
        private bool ValidForm()
        {
            if (IsNull(TxtDepPlace.Text))
            {
                return false;
            }
            if (IsNull(TxtArrPlace.Text))
            {
                return false;
            }
            if (IsNull(TxtResion.Text))
            {
                return false;
            }
            DateTime fDate = GetFromatedDate(out DateTime tDate);
            if (!(fDate <= tDate))
            {
                return false;
            }
            string month = UserInterface.Properties.Settings.Default["DMonth"].ToString();
            int monthNumber = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month;
            if (monthNumber != fDate.Month && monthNumber != tDate.Month)
            {
                return false;
            }
            if (CmbDestination.SelectedIndex == -1)
            {
                return false;
            }
            if (CmbJourneyMode.SelectedIndex == -1)
            {
                return false;
            }
            if (!IsNumeric(TxtKms.Text))
            {
                return false;
            }
            //if (IsNumeric(TxtKms.Text))
            //{
            //    double Kms = double.Parse(TxtKms.Text);
            //    if (Kms <= 15)
            //    {
            //        return false;
            //    }
            //}
            if (TxtAdvace.Text.Trim().Length > 0 && !IsNumeric(TxtAdvace.Text))
            {
                return false;
            }
            if (fDate.Day != tDate.Day)
            {
                if (CmbHalting.SelectedIndex == -1)
                {
                    return false;
                }
            }
            if (CmbJourneyMode.Text == "Private")
            {
                if (TxtFair.Text.Trim().Length != 0 && IsNumeric(TxtFair.Text))
                {
                    double fairamt = double.Parse(TxtFair.Text.Trim());
                    if (fairamt > 0)
                    {
                        return false;
                    }
                }
            }
            if (CmbJourneyMode.Text == "Govt-Vehicle")
            {
                if (TxtFair.Text.Trim().Length != 0 && IsNumeric(TxtFair.Text))
                {
                    double fairamt = double.Parse(TxtFair.Text.Trim());
                    if (fairamt > 0)
                    {
                        return false;
                    }
                }
            }
            if (CmbJourneyMode.Text != "Private")
            {
                if (CmbJourneyMode.Text != "Govt-Vehicle")
                {
                    if (TxtFair.Text.Trim().Length == 0)
                    {
                        return false;
                    }
                    else
                    {
                        if (IsNumeric(TxtFair.Text))
                        {
                            double fairamt = double.Parse(TxtFair.Text.Trim());
                            if (fairamt <= 0)
                            {
                                return false;
                            }
                        }
                    }
                    if (TxtWarrant.Text.Trim().Length == 0)
                    {
                        return false;
                    }
                }
            }
            if (!IsNumeric(TxtDays.Text))
            {
                return false;
            }
            if (IsNumeric(TxtDays.Text))
            {
                double day = double.Parse(TxtDays.Text);
                if (day <= 0 || day > 30)
                {
                    return false;
                }
            }
            if (TxtDays2.Text.Trim().Length > 0 && IsNumeric(TxtDays2.Text))
            {
                double day2 = double.Parse(TxtDays2.Text);
                if (day2 <= 0 || day2 > 60)
                {
                    return false;
                }
            }
            return true;
        }
        
        private bool DataNotExists()
        {
            //check already exists or not
            foreach (DataGridViewRow row in DgvSelectedEmployee.Rows)
            {
                int Kgid = int.Parse(row.Cells[0].Value.ToString());
                DateTime fDate = GetFromatedDate(out DateTime tDate);
                bool NoDataFrom = TravelCrud.CheckTravell(Kgid, fDate, tDate);
                if (NoDataFrom)
                {
                    return false;
                }
            }
            return true;
        }

        private void LoadEmployee()
        {
            List<Employee> EmployeeList = EmployeCrud.ViewEmployee(unit);
            if (EmployeeList.Count > 0)
            {
                DgvEmployee.Rows.Clear();
                TravelCrud travelCrud = new TravelCrud();
                travelCrud.AsaignDataToEmployeeGrid(DgvEmployee, EmployeeList, false);
            }
        }

        private bool IsNumeric(string text)
        {
            return double.TryParse(text, out _);
        }

        private bool IsNull(string text)
        {
            return string.IsNullOrEmpty(text);
        }

        private Travel NewTravel(double PerDayTa, int Kgid, int GroupNo, string designation, double salary)
        {
            DateTime fDate = GetFromatedDate(out DateTime tDate);
            SetDefaltValue();
            double fairamt = double.Parse(TxtFair.Text);
            if (fairamt > 0)
            {
                if (DgvSelectedEmployee.Rows.Count > 0)
                {
                    fairamt /= DgvSelectedEmployee.Rows.Count;
                }
            }
            //check previous Excess Advance for kgid
            double Advance = double.Parse(TxtAdvace.Text);
            DataTable dt = TravelCrud.GetExcessTaHolder();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    int KGID = int.Parse(row[0].ToString());
                    if (KGID == Kgid)
                    {
                        //if their add to advanceTA
                        double ExAmt = int.Parse(row[1].ToString());
                        Advance += ExAmt;
                        //delete entry in Deference Table
                        TravelCrud.LessExcessTa(Kgid, monthYear);
                    }
                }
            }
            double Days = ReCalculateDays(PerDayTa, fairamt, out double totalTA);

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
                AdvanceTA = Advance,
                Jou_Mode = CmbJourneyMode.Text,
                Warrant_No = TxtWarrant.Text,
                Shd_No = ($"{TxtShd.Text}, {TxtShd_No.Text}"),
                Destination = CmbDestination.Text,
                EmpNo = Kgid,
                GroupNo = GroupNo,
                MonthYear = monthYear,
                Remarks = remarks,
                Designation = designation,
                Salary = salary
            };
            return travel;
        }

        private void SetDefaltValue()
        {
            if (TxtAdvace.Text.Length == 0)
            {
                TxtAdvace.Text = "0";
            }
            if (TxtKms.Text.Length == 0)
            {
                TxtKms.Text = "0";
            }
            if (TxtFair.Text.Trim().Length == 0)
            {
                TxtFair.Text ="0";
            }
        }

        private double ReCalculateDays(double PerDayTa, double fairAmt, out double totalTA)
        {
            double Days;
            SetDefaltValue();

            double.TryParse(TxtDays2.Text, out double extraDays);
            if (extraDays > 0)
            {
                Days = double.Parse(TxtDays.Text) + double.Parse(TxtDays2.Text);
                totalTA = double.Parse(TxtDays.Text) * PerDayTa;
                totalTA += (double.Parse(TxtDays2.Text) * (PerDayTa / 2));
                totalTA += fairAmt;
                remarks = ($"Rule 518 ({TxtDays.Text} x {PerDayTa}, {TxtDays2.Text} x {PerDayTa / 2})");
            }
            else
            {
                Days = double.Parse(TxtDays.Text);
                totalTA = (PerDayTa * double.Parse(TxtDays.Text) + fairAmt);
                remarks = "";
            }
           
            return Days;
        }

        private DateTime GetFromatedDate(out DateTime tDate)
        {
            // DateTime fDate = DateTime.Parse($"{DtDepDate.Value.Day} {monthYear} {DtDepTime.Text}");
            DateTime fDate = DateTime.Parse($"{DtDepDate.Value.ToShortDateString()} {DtDepTime.Text}");
            tDate = DateTime.Parse($"{DtArrDate.Value.ToShortDateString()} {DtArrTime.Text}");
            return fDate;
        }

        private void SetMonthYearToDate()
        {
            if (monthYear.Length > 1)
            {
                DtArrDate.Value = DateTime.Parse($"01 {monthYear}");
                DtDepDate.Value = DateTime.Parse($"01 {monthYear}");
            }
        }

        private void TravelViewTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TravelViewTabControl.SelectedTab != tabPage1)
            {
                BtnDelete.Enabled = false;
            }
        }

        private void TxtShd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void TxtWarrant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar !=',') && e.KeyChar !=(char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void TxtFair_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void TxtKms_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void TxtShd_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void TxtAdvace_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void GridTravelView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TravelCrud travelCrud = new TravelCrud();
            DataGridViewRow row = GridTravelView.CurrentRow;

            CmbDestination.SelectedItem = row.Cells[travelCrud.GetColumnIndexByName(GridTravelView, "Destination")].Value.ToString();
            DateTime depDate = DateTime.Parse(row.Cells[travelCrud.GetColumnIndexByName(GridTravelView, "Dep_Date")].Value.ToString());
            DtDepDate.Value = depDate; DtDepTime.Value = depDate;
            TxtDepPlace.Text= row.Cells[travelCrud.GetColumnIndexByName(GridTravelView, "Dep_Place")].Value.ToString();
            TxtResion.Text = row.Cells[travelCrud.GetColumnIndexByName(GridTravelView, "Jou_Reason")].Value.ToString();
            string[] shdNo= row.Cells[travelCrud.GetColumnIndexByName(GridTravelView, "Shd_No")].Value.ToString().Split();
            if(shdNo[0].Contains(","))
            {
                string sno = shdNo[0].Replace(",", "");
                TxtShd.Text = sno; //remove comma
            }
            TxtShd_No.Text = shdNo[1];
            DateTime arrDate = DateTime.Parse(row.Cells[travelCrud.GetColumnIndexByName(GridTravelView, "Arr_Date")].Value.ToString());
            DtArrDate.Value = arrDate; DtArrTime.Value = arrDate;
            TxtArrPlace.Text = row.Cells[travelCrud.GetColumnIndexByName(GridTravelView, "Arr_Place")].Value.ToString();
            CmbJourneyMode.SelectedItem = row.Cells[travelCrud.GetColumnIndexByName(GridTravelView, "Jou_Mode")].Value.ToString();
            TxtWarrant.Text = row.Cells[travelCrud.GetColumnIndexByName(GridTravelView, "Warrant_No")].Value.ToString();
            CmbHalting.SelectedItem = row.Cells[travelCrud.GetColumnIndexByName(GridTravelView, "Halt_Place")].Value.ToString();
            TxtFair.Text = row.Cells[travelCrud.GetColumnIndexByName(GridTravelView, "FareAmt")].Value.ToString();
            TxtKms.Text = row.Cells[travelCrud.GetColumnIndexByName(GridTravelView, "Dest_Kms")].Value.ToString();
            double totaldays = double.Parse(row.Cells[travelCrud.GetColumnIndexByName(GridTravelView, "NoOfDay")].Value.ToString());
            if (totaldays > 30)
            {
                TxtDays.Text = "30"; TxtDays.Hint = "Full TA";
                TxtDays.Width = 116; TxtDays2.Visible = true;
                TxtDays2.Text = (totaldays - 30).ToString();
            }
            else 
            {
                TxtDays.Width = 208; TxtDays2.Visible = false;
                TxtDays.Text = totaldays.ToString();
            }
            TxtAdvace.Text = row.Cells[travelCrud.GetColumnIndexByName(GridTravelView, "AdvanceTA")].Value.ToString();
            this.TravellTabControl.SelectedTab = TabAddTravel;
            BtnAddTravel.Text = "UPDATE TRAVEL";
            panelOption.Visible = true;
            optionSelEmp.Checked = true;
            DtDepDate.Focus();
            kgno = int.Parse(row.Cells[travelCrud.GetColumnIndexByName(GridTravelView, "EmpNo")].Value.ToString());
            gid = int.Parse(row.Cells[travelCrud.GetColumnIndexByName(GridTravelView, "GroupNo")].Value.ToString());
           

            perDayTa = double.Parse(row.Cells[travelCrud.GetColumnIndexByName(GridTravelView, "DayRate")].Value.ToString());
            // string Query = ($"SELECT Dep_Place, Dep_Date, Arr_Place, Arr_Date, Dest_Kms, Jou_Reason, Halt_Place, DayRate, NoOfDay, FareAmt, TotalTA, AdvanceTA, Jou_Mode, Warrant_No, Shd_No, Destination, GroupNo FROM Travell WHERE MonthYear='{mYear}' AND EmpNo ={kgid} ORDER BY Dep_Date, Arr_Date");
            //  travelCrud.DeleteTravell(int.Parse(row.Cells[travelCrud.GetColumnIndexByName(GridTravelView, "GroupNo")].Value.ToString()));
        }

    }
}