
namespace Ta_Maker
{
    partial class TravelUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TravelUI));
            this.TravellTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.TabAddTravel = new System.Windows.Forms.TabPage();
            this.TxtDays = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtAdvace = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtDays2 = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtWarrant = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.DtDepDate = new System.Windows.Forms.DateTimePicker();
            this.DtDepTime = new System.Windows.Forms.DateTimePicker();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.DtArrDate = new System.Windows.Forms.DateTimePicker();
            this.DtArrTime = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.BtnAddTravel = new MaterialSkin.Controls.MaterialButton();
            this.BtnClearAll = new MaterialSkin.Controls.MaterialButton();
            this.BtnCalculateDay = new MaterialSkin.Controls.MaterialButton();
            this.TxtShd_No = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtKms = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtFair = new MaterialSkin.Controls.MaterialTextBox();
            this.CmbHalting = new MaterialSkin.Controls.MaterialComboBox();
            this.CmbJourneyMode = new MaterialSkin.Controls.MaterialComboBox();
            this.TxtArrPlace = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtShd = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtResion = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtDepPlace = new MaterialSkin.Controls.MaterialTextBox();
            this.CmbDestination = new MaterialSkin.Controls.MaterialComboBox();
            this.TabViewTravel = new System.Windows.Forms.TabPage();
            this.BtnDelete = new MaterialSkin.Controls.MaterialButton();
            this.BtnLoadTravel = new MaterialSkin.Controls.MaterialButton();
            this.TravelViewTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.TravelViewTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.GridTravelView = new System.Windows.Forms.DataGridView();
            this.TravelTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.DgvSelectedEmployee = new System.Windows.Forms.DataGridView();
            this.EmpNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelEmployee = new System.Windows.Forms.Panel();
            this.DgvEmployee = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Okey = new System.Windows.Forms.Button();
            this.CancelEmployee = new System.Windows.Forms.Button();
            this.DeselectAll = new System.Windows.Forms.Button();
            this.SelectAll = new System.Windows.Forms.Button();
            this.TxtSearchEmployee = new MaterialSkin.Controls.MaterialTextBox();
            this.TravellTabControl.SuspendLayout();
            this.TabAddTravel.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.TabViewTravel.SuspendLayout();
            this.TravelViewTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTravelView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSelectedEmployee)).BeginInit();
            this.PanelEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // TravellTabControl
            // 
            this.TravellTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TravellTabControl.Controls.Add(this.TabAddTravel);
            this.TravellTabControl.Controls.Add(this.TabViewTravel);
            this.TravellTabControl.Depth = 0;
            this.TravellTabControl.Location = new System.Drawing.Point(21, 224);
            this.TravellTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.TravellTabControl.Multiline = true;
            this.TravellTabControl.Name = "TravellTabControl";
            this.TravellTabControl.SelectedIndex = 0;
            this.TravellTabControl.Size = new System.Drawing.Size(955, 438);
            this.TravellTabControl.TabIndex = 0;
            this.TravellTabControl.TabStop = false;
            // 
            // TabAddTravel
            // 
            this.TabAddTravel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TabAddTravel.Controls.Add(this.TxtDays);
            this.TabAddTravel.Controls.Add(this.TxtAdvace);
            this.TabAddTravel.Controls.Add(this.TxtDays2);
            this.TabAddTravel.Controls.Add(this.TxtWarrant);
            this.TabAddTravel.Controls.Add(this.materialCard2);
            this.TabAddTravel.Controls.Add(this.materialCard1);
            this.TabAddTravel.Controls.Add(this.BtnAddTravel);
            this.TabAddTravel.Controls.Add(this.BtnClearAll);
            this.TabAddTravel.Controls.Add(this.BtnCalculateDay);
            this.TabAddTravel.Controls.Add(this.TxtShd_No);
            this.TabAddTravel.Controls.Add(this.TxtKms);
            this.TabAddTravel.Controls.Add(this.TxtFair);
            this.TabAddTravel.Controls.Add(this.CmbHalting);
            this.TabAddTravel.Controls.Add(this.CmbJourneyMode);
            this.TabAddTravel.Controls.Add(this.TxtArrPlace);
            this.TabAddTravel.Controls.Add(this.TxtShd);
            this.TabAddTravel.Controls.Add(this.TxtResion);
            this.TabAddTravel.Controls.Add(this.TxtDepPlace);
            this.TabAddTravel.Controls.Add(this.CmbDestination);
            this.TabAddTravel.Location = new System.Drawing.Point(4, 22);
            this.TabAddTravel.Name = "TabAddTravel";
            this.TabAddTravel.Padding = new System.Windows.Forms.Padding(3);
            this.TabAddTravel.Size = new System.Drawing.Size(947, 412);
            this.TabAddTravel.TabIndex = 0;
            this.TabAddTravel.Text = "ADD TRAVEL DETAILS";
            // 
            // TxtDays
            // 
            this.TxtDays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDays.Depth = 0;
            this.TxtDays.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtDays.Hint = "Total Days";
            this.TxtDays.LeadingIcon = null;
            this.TxtDays.Location = new System.Drawing.Point(182, 357);
            this.TxtDays.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDays.MaxLength = 50;
            this.TxtDays.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtDays.Multiline = false;
            this.TxtDays.Name = "TxtDays";
            this.TxtDays.Size = new System.Drawing.Size(208, 50);
            this.TxtDays.TabIndex = 18;
            this.TxtDays.TabStop = false;
            this.TxtDays.Text = "";
            this.TxtDays.TrailingIcon = null;
            // 
            // TxtAdvace
            // 
            this.TxtAdvace.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtAdvace.Depth = 0;
            this.TxtAdvace.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtAdvace.Hint = "Advance TA";
            this.TxtAdvace.LeadingIcon = null;
            this.TxtAdvace.Location = new System.Drawing.Point(444, 357);
            this.TxtAdvace.MaxLength = 50;
            this.TxtAdvace.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtAdvace.Multiline = false;
            this.TxtAdvace.Name = "TxtAdvace";
            this.TxtAdvace.Size = new System.Drawing.Size(141, 50);
            this.TxtAdvace.TabIndex = 20;
            this.TxtAdvace.Text = "";
            this.TxtAdvace.TrailingIcon = null;
            // 
            // TxtDays2
            // 
            this.TxtDays2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDays2.Depth = 0;
            this.TxtDays2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtDays2.Hint = "Half TA";
            this.TxtDays2.LeadingIcon = null;
            this.TxtDays2.Location = new System.Drawing.Point(314, 357);
            this.TxtDays2.MaxLength = 50;
            this.TxtDays2.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtDays2.Multiline = false;
            this.TxtDays2.Name = "TxtDays2";
            this.TxtDays2.Size = new System.Drawing.Size(76, 50);
            this.TxtDays2.TabIndex = 19;
            this.TxtDays2.TabStop = false;
            this.TxtDays2.Text = "";
            this.TxtDays2.TrailingIcon = null;
            this.TxtDays2.Visible = false;
            // 
            // TxtWarrant
            // 
            this.TxtWarrant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtWarrant.Depth = 0;
            this.TxtWarrant.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtWarrant.Hint = "Warrant No";
            this.TxtWarrant.LeadingIcon = null;
            this.TxtWarrant.Location = new System.Drawing.Point(209, 243);
            this.TxtWarrant.MaxLength = 50;
            this.TxtWarrant.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtWarrant.Multiline = false;
            this.TxtWarrant.Name = "TxtWarrant";
            this.TxtWarrant.Size = new System.Drawing.Size(181, 50);
            this.TxtWarrant.TabIndex = 12;
            this.TxtWarrant.Text = "";
            this.TxtWarrant.TrailingIcon = null;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.materialLabel4);
            this.materialCard2.Controls.Add(this.materialLabel5);
            this.materialCard2.Controls.Add(this.DtDepDate);
            this.materialCard2.Controls.Add(this.DtDepTime);
            this.materialCard2.Controls.Add(this.materialLabel6);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(40, 67);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(350, 50);
            this.materialCard2.TabIndex = 1;
            // 
            // materialLabel4
            // 
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(6, 7);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(76, 35);
            this.materialLabel4.TabIndex = 31;
            this.materialLabel4.Text = "Departure Date Time";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(281, 1);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(37, 19);
            this.materialLabel5.TabIndex = 34;
            this.materialLabel5.Text = "Time";
            // 
            // DtDepDate
            // 
            this.DtDepDate.CustomFormat = "dd";
            this.DtDepDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtDepDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtDepDate.Location = new System.Drawing.Point(122, 21);
            this.DtDepDate.Name = "DtDepDate";
            this.DtDepDate.Size = new System.Drawing.Size(67, 26);
            this.DtDepDate.TabIndex = 2;
            // 
            // DtDepTime
            // 
            this.DtDepTime.CustomFormat = "HH:mm";
            this.DtDepTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtDepTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtDepTime.Location = new System.Drawing.Point(264, 22);
            this.DtDepTime.Name = "DtDepTime";
            this.DtDepTime.Size = new System.Drawing.Size(69, 26);
            this.DtDepTime.TabIndex = 3;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(122, 1);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(67, 19);
            this.materialLabel6.TabIndex = 34;
            this.materialLabel6.Text = "Date(DD)";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.DtArrDate);
            this.materialCard1.Controls.Add(this.DtArrTime);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(40, 185);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(350, 50);
            this.materialCard1.TabIndex = 7;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(6, 7);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(76, 35);
            this.materialLabel2.TabIndex = 31;
            this.materialLabel2.Text = "Arrival Date Time";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(281, 1);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(37, 19);
            this.materialLabel3.TabIndex = 34;
            this.materialLabel3.Text = "Time";
            // 
            // DtArrDate
            // 
            this.DtArrDate.CustomFormat = "dd";
            this.DtArrDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtArrDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtArrDate.Location = new System.Drawing.Point(122, 21);
            this.DtArrDate.Name = "DtArrDate";
            this.DtArrDate.Size = new System.Drawing.Size(67, 26);
            this.DtArrDate.TabIndex = 8;
            // 
            // DtArrTime
            // 
            this.DtArrTime.CustomFormat = "HH:mm";
            this.DtArrTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtArrTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtArrTime.Location = new System.Drawing.Point(264, 22);
            this.DtArrTime.Name = "DtArrTime";
            this.DtArrTime.Size = new System.Drawing.Size(69, 26);
            this.DtArrTime.TabIndex = 9;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(122, 1);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(67, 19);
            this.materialLabel1.TabIndex = 34;
            this.materialLabel1.Text = "Date(DD)";
            // 
            // BtnAddTravel
            // 
            this.BtnAddTravel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnAddTravel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAddTravel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnAddTravel.Depth = 0;
            this.BtnAddTravel.HighEmphasis = true;
            this.BtnAddTravel.Icon = null;
            this.BtnAddTravel.Location = new System.Drawing.Point(610, 366);
            this.BtnAddTravel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnAddTravel.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAddTravel.Name = "BtnAddTravel";
            this.BtnAddTravel.Size = new System.Drawing.Size(169, 36);
            this.BtnAddTravel.TabIndex = 21;
            this.BtnAddTravel.Text = "ADD TRAVEL DETAILS";
            this.BtnAddTravel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnAddTravel.UseAccentColor = false;
            this.BtnAddTravel.UseVisualStyleBackColor = true;
            this.BtnAddTravel.Click += new System.EventHandler(this.BtnAddTravel_Click);
            this.BtnAddTravel.Enter += new System.EventHandler(this.BtnAddTravel_Enter);
            this.BtnAddTravel.Leave += new System.EventHandler(this.BtnAddTravel_Leave);
            // 
            // BtnClearAll
            // 
            this.BtnClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClearAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnClearAll.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnClearAll.Depth = 0;
            this.BtnClearAll.HighEmphasis = true;
            this.BtnClearAll.Icon = null;
            this.BtnClearAll.Location = new System.Drawing.Point(857, 366);
            this.BtnClearAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnClearAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnClearAll.Name = "BtnClearAll";
            this.BtnClearAll.Size = new System.Drawing.Size(66, 36);
            this.BtnClearAll.TabIndex = 22;
            this.BtnClearAll.Text = "CLEAR";
            this.BtnClearAll.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnClearAll.UseAccentColor = false;
            this.BtnClearAll.UseVisualStyleBackColor = true;
            this.BtnClearAll.Click += new System.EventHandler(this.BtnClearAll_Click);
            this.BtnClearAll.Enter += new System.EventHandler(this.BtnClearAll_Enter);
            this.BtnClearAll.Leave += new System.EventHandler(this.BtnClearAll_Leave);
            // 
            // BtnCalculateDay
            // 
            this.BtnCalculateDay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCalculateDay.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnCalculateDay.Depth = 0;
            this.BtnCalculateDay.HighEmphasis = true;
            this.BtnCalculateDay.Icon = null;
            this.BtnCalculateDay.Location = new System.Drawing.Point(40, 366);
            this.BtnCalculateDay.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnCalculateDay.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCalculateDay.Name = "BtnCalculateDay";
            this.BtnCalculateDay.Size = new System.Drawing.Size(135, 36);
            this.BtnCalculateDay.TabIndex = 17;
            this.BtnCalculateDay.Text = "Calculate Day";
            this.BtnCalculateDay.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnCalculateDay.UseAccentColor = false;
            this.BtnCalculateDay.UseVisualStyleBackColor = true;
            this.BtnCalculateDay.Click += new System.EventHandler(this.BtnCalculateDay_Click);
            this.BtnCalculateDay.Enter += new System.EventHandler(this.BtnCalculateDay_Enter);
            this.BtnCalculateDay.Leave += new System.EventHandler(this.BtnCalculateDay_Leave);
            // 
            // TxtShd_No
            // 
            this.TxtShd_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtShd_No.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtShd_No.Depth = 0;
            this.TxtShd_No.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtShd_No.Hint = "Shd No / Logbook No";
            this.TxtShd_No.LeadingIcon = null;
            this.TxtShd_No.Location = new System.Drawing.Point(691, 300);
            this.TxtShd_No.MaxLength = 50;
            this.TxtShd_No.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtShd_No.Multiline = false;
            this.TxtShd_No.Name = "TxtShd_No";
            this.TxtShd_No.Size = new System.Drawing.Size(232, 50);
            this.TxtShd_No.TabIndex = 16;
            this.TxtShd_No.Text = "";
            this.TxtShd_No.TrailingIcon = null;
            // 
            // TxtKms
            // 
            this.TxtKms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtKms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtKms.Depth = 0;
            this.TxtKms.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtKms.Hint = "Total Distance (Kms)";
            this.TxtKms.LeadingIcon = null;
            this.TxtKms.Location = new System.Drawing.Point(444, 301);
            this.TxtKms.MaxLength = 50;
            this.TxtKms.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtKms.Multiline = false;
            this.TxtKms.Name = "TxtKms";
            this.TxtKms.Size = new System.Drawing.Size(240, 50);
            this.TxtKms.TabIndex = 15;
            this.TxtKms.Text = "";
            this.TxtKms.TrailingIcon = null;
            // 
            // TxtFair
            // 
            this.TxtFair.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtFair.Depth = 0;
            this.TxtFair.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtFair.Hint = "Fair Charge (KSRTC / TRAIN)";
            this.TxtFair.LeadingIcon = null;
            this.TxtFair.Location = new System.Drawing.Point(40, 301);
            this.TxtFair.MaxLength = 50;
            this.TxtFair.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtFair.Multiline = false;
            this.TxtFair.Name = "TxtFair";
            this.TxtFair.Size = new System.Drawing.Size(350, 50);
            this.TxtFair.TabIndex = 14;
            this.TxtFair.Text = "";
            this.TxtFair.TrailingIcon = null;
            // 
            // CmbHalting
            // 
            this.CmbHalting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbHalting.AutoResize = false;
            this.CmbHalting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CmbHalting.Depth = 0;
            this.CmbHalting.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CmbHalting.DropDownHeight = 174;
            this.CmbHalting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbHalting.DropDownWidth = 121;
            this.CmbHalting.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CmbHalting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CmbHalting.FormattingEnabled = true;
            this.CmbHalting.Hint = "Select Halting Place";
            this.CmbHalting.IntegralHeight = false;
            this.CmbHalting.ItemHeight = 43;
            this.CmbHalting.Location = new System.Drawing.Point(444, 243);
            this.CmbHalting.MaxDropDownItems = 4;
            this.CmbHalting.MouseState = MaterialSkin.MouseState.OUT;
            this.CmbHalting.Name = "CmbHalting";
            this.CmbHalting.Size = new System.Drawing.Size(479, 49);
            this.CmbHalting.StartIndex = 0;
            this.CmbHalting.TabIndex = 13;
            // 
            // CmbJourneyMode
            // 
            this.CmbJourneyMode.AutoResize = false;
            this.CmbJourneyMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CmbJourneyMode.Depth = 0;
            this.CmbJourneyMode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CmbJourneyMode.DropDownHeight = 174;
            this.CmbJourneyMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbJourneyMode.DropDownWidth = 121;
            this.CmbJourneyMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CmbJourneyMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CmbJourneyMode.FormattingEnabled = true;
            this.CmbJourneyMode.Hint = "Mode Of Journey";
            this.CmbJourneyMode.IntegralHeight = false;
            this.CmbJourneyMode.ItemHeight = 43;
            this.CmbJourneyMode.Location = new System.Drawing.Point(40, 243);
            this.CmbJourneyMode.MaxDropDownItems = 4;
            this.CmbJourneyMode.MouseState = MaterialSkin.MouseState.OUT;
            this.CmbJourneyMode.Name = "CmbJourneyMode";
            this.CmbJourneyMode.Size = new System.Drawing.Size(163, 49);
            this.CmbJourneyMode.StartIndex = 0;
            this.CmbJourneyMode.TabIndex = 11;
            this.CmbJourneyMode.SelectedIndexChanged += new System.EventHandler(this.CmbJourneyMode_SelectedIndexChanged);
            // 
            // TxtArrPlace
            // 
            this.TxtArrPlace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtArrPlace.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtArrPlace.Depth = 0;
            this.TxtArrPlace.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtArrPlace.Hint = "Destination Place to Head Quarter";
            this.TxtArrPlace.LeadingIcon = null;
            this.TxtArrPlace.Location = new System.Drawing.Point(444, 185);
            this.TxtArrPlace.MaxLength = 50;
            this.TxtArrPlace.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtArrPlace.Multiline = false;
            this.TxtArrPlace.Name = "TxtArrPlace";
            this.TxtArrPlace.Size = new System.Drawing.Size(479, 50);
            this.TxtArrPlace.TabIndex = 10;
            this.TxtArrPlace.Text = "";
            this.TxtArrPlace.TrailingIcon = null;
            // 
            // TxtShd
            // 
            this.TxtShd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtShd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtShd.Depth = 0;
            this.TxtShd.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtShd.Hint = "Shd No / Logbook No";
            this.TxtShd.LeadingIcon = null;
            this.TxtShd.Location = new System.Drawing.Point(444, 124);
            this.TxtShd.MaxLength = 50;
            this.TxtShd.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtShd.Multiline = false;
            this.TxtShd.Name = "TxtShd";
            this.TxtShd.Size = new System.Drawing.Size(240, 50);
            this.TxtShd.TabIndex = 6;
            this.TxtShd.Text = "";
            this.TxtShd.TrailingIcon = null;
            // 
            // TxtResion
            // 
            this.TxtResion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtResion.Depth = 0;
            this.TxtResion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtResion.Hint = "Journey Reasion";
            this.TxtResion.LeadingIcon = null;
            this.TxtResion.Location = new System.Drawing.Point(40, 126);
            this.TxtResion.MaxLength = 50;
            this.TxtResion.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtResion.Multiline = false;
            this.TxtResion.Name = "TxtResion";
            this.TxtResion.Size = new System.Drawing.Size(350, 50);
            this.TxtResion.TabIndex = 5;
            this.TxtResion.Text = "";
            this.TxtResion.TrailingIcon = null;
            // 
            // TxtDepPlace
            // 
            this.TxtDepPlace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDepPlace.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDepPlace.Depth = 0;
            this.TxtDepPlace.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtDepPlace.Hint = "Head Quarter to Destination";
            this.TxtDepPlace.LeadingIcon = null;
            this.TxtDepPlace.Location = new System.Drawing.Point(444, 67);
            this.TxtDepPlace.MaxLength = 50;
            this.TxtDepPlace.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtDepPlace.Multiline = false;
            this.TxtDepPlace.Name = "TxtDepPlace";
            this.TxtDepPlace.Size = new System.Drawing.Size(479, 50);
            this.TxtDepPlace.TabIndex = 4;
            this.TxtDepPlace.Text = "";
            this.TxtDepPlace.TrailingIcon = null;
            // 
            // CmbDestination
            // 
            this.CmbDestination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbDestination.AutoResize = false;
            this.CmbDestination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CmbDestination.Depth = 0;
            this.CmbDestination.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CmbDestination.DropDownHeight = 174;
            this.CmbDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDestination.DropDownWidth = 121;
            this.CmbDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CmbDestination.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CmbDestination.FormattingEnabled = true;
            this.CmbDestination.Hint = "Select Destination Place";
            this.CmbDestination.IntegralHeight = false;
            this.CmbDestination.ItemHeight = 43;
            this.CmbDestination.Location = new System.Drawing.Point(324, 10);
            this.CmbDestination.MaxDropDownItems = 4;
            this.CmbDestination.MouseState = MaterialSkin.MouseState.OUT;
            this.CmbDestination.Name = "CmbDestination";
            this.CmbDestination.Size = new System.Drawing.Size(261, 49);
            this.CmbDestination.StartIndex = 0;
            this.CmbDestination.TabIndex = 0;
            // 
            // TabViewTravel
            // 
            this.TabViewTravel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TabViewTravel.Controls.Add(this.BtnDelete);
            this.TabViewTravel.Controls.Add(this.BtnLoadTravel);
            this.TabViewTravel.Controls.Add(this.TravelViewTabSelector);
            this.TabViewTravel.Controls.Add(this.TravelViewTabControl);
            this.TabViewTravel.Location = new System.Drawing.Point(4, 22);
            this.TabViewTravel.Name = "TabViewTravel";
            this.TabViewTravel.Padding = new System.Windows.Forms.Padding(3);
            this.TabViewTravel.Size = new System.Drawing.Size(947, 412);
            this.TabViewTravel.TabIndex = 1;
            this.TabViewTravel.Text = "View Travel Details";
            // 
            // BtnDelete
            // 
            this.BtnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnDelete.Depth = 0;
            this.BtnDelete.Enabled = false;
            this.BtnDelete.HighEmphasis = true;
            this.BtnDelete.Icon = null;
            this.BtnDelete.Location = new System.Drawing.Point(8, 370);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(192, 36);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Delete Travel Details";
            this.BtnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnDelete.UseAccentColor = false;
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnLoadTravel
            // 
            this.BtnLoadTravel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLoadTravel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnLoadTravel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnLoadTravel.Depth = 0;
            this.BtnLoadTravel.HighEmphasis = true;
            this.BtnLoadTravel.Icon = null;
            this.BtnLoadTravel.Location = new System.Drawing.Point(759, 369);
            this.BtnLoadTravel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnLoadTravel.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnLoadTravel.Name = "BtnLoadTravel";
            this.BtnLoadTravel.Size = new System.Drawing.Size(178, 36);
            this.BtnLoadTravel.TabIndex = 2;
            this.BtnLoadTravel.Text = "Load Travel Details";
            this.BtnLoadTravel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnLoadTravel.UseAccentColor = false;
            this.BtnLoadTravel.UseVisualStyleBackColor = true;
            this.BtnLoadTravel.Click += new System.EventHandler(this.BtnLoadTravel_Click);
            // 
            // TravelViewTabSelector
            // 
            this.TravelViewTabSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TravelViewTabSelector.BaseTabControl = this.TravelViewTabControl;
            this.TravelViewTabSelector.Depth = 0;
            this.TravelViewTabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TravelViewTabSelector.Location = new System.Drawing.Point(-3, 329);
            this.TravelViewTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.TravelViewTabSelector.Name = "TravelViewTabSelector";
            this.TravelViewTabSelector.Size = new System.Drawing.Size(947, 29);
            this.TravelViewTabSelector.TabIndex = 1;
            this.TravelViewTabSelector.Text = "materialTabSelector1";
            // 
            // TravelViewTabControl
            // 
            this.TravelViewTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TravelViewTabControl.Controls.Add(this.tabPage1);
            this.TravelViewTabControl.Depth = 0;
            this.TravelViewTabControl.Location = new System.Drawing.Point(3, 6);
            this.TravelViewTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.TravelViewTabControl.Multiline = true;
            this.TravelViewTabControl.Name = "TravelViewTabControl";
            this.TravelViewTabControl.SelectedIndex = 0;
            this.TravelViewTabControl.Size = new System.Drawing.Size(935, 321);
            this.TravelViewTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.GridTravelView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(927, 295);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "KGID";
            // 
            // GridTravelView
            // 
            this.GridTravelView.AllowUserToAddRows = false;
            this.GridTravelView.AllowUserToDeleteRows = false;
            this.GridTravelView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTravelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridTravelView.Location = new System.Drawing.Point(3, 3);
            this.GridTravelView.Name = "GridTravelView";
            this.GridTravelView.ReadOnly = true;
            this.GridTravelView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridTravelView.Size = new System.Drawing.Size(921, 289);
            this.GridTravelView.TabIndex = 0;
            this.GridTravelView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GridTravelView_MouseClick);
            // 
            // TravelTabSelector
            // 
            this.TravelTabSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TravelTabSelector.BaseTabControl = this.TravellTabControl;
            this.TravelTabSelector.Depth = 0;
            this.TravelTabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TravelTabSelector.Location = new System.Drawing.Point(22, 195);
            this.TravelTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.TravelTabSelector.Name = "TravelTabSelector";
            this.TravelTabSelector.Size = new System.Drawing.Size(950, 35);
            this.TravelTabSelector.TabIndex = 1;
            this.TravelTabSelector.TabStop = false;
            this.TravelTabSelector.Text = "materialTabSelector1";
            // 
            // DgvSelectedEmployee
            // 
            this.DgvSelectedEmployee.AllowUserToAddRows = false;
            this.DgvSelectedEmployee.AllowUserToDeleteRows = false;
            this.DgvSelectedEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvSelectedEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSelectedEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpNo,
            this.designation,
            this.empname,
            this.salary});
            this.DgvSelectedEmployee.Location = new System.Drawing.Point(194, 64);
            this.DgvSelectedEmployee.Name = "DgvSelectedEmployee";
            this.DgvSelectedEmployee.ReadOnly = true;
            this.DgvSelectedEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSelectedEmployee.Size = new System.Drawing.Size(589, 96);
            this.DgvSelectedEmployee.TabIndex = 2;
            this.DgvSelectedEmployee.TabStop = false;
            // 
            // EmpNo
            // 
            this.EmpNo.HeaderText = "KGID Number";
            this.EmpNo.Name = "EmpNo";
            this.EmpNo.ReadOnly = true;
            this.EmpNo.Width = 120;
            // 
            // designation
            // 
            this.designation.HeaderText = "Designation";
            this.designation.Name = "designation";
            this.designation.ReadOnly = true;
            // 
            // empname
            // 
            this.empname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.empname.HeaderText = "Employee Name";
            this.empname.Name = "empname";
            this.empname.ReadOnly = true;
            // 
            // salary
            // 
            this.salary.HeaderText = "Salary";
            this.salary.Name = "salary";
            this.salary.ReadOnly = true;
            // 
            // PanelEmployee
            // 
            this.PanelEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelEmployee.Controls.Add(this.DgvEmployee);
            this.PanelEmployee.Controls.Add(this.Okey);
            this.PanelEmployee.Controls.Add(this.CancelEmployee);
            this.PanelEmployee.Controls.Add(this.DeselectAll);
            this.PanelEmployee.Controls.Add(this.SelectAll);
            this.PanelEmployee.Location = new System.Drawing.Point(284, 195);
            this.PanelEmployee.Name = "PanelEmployee";
            this.PanelEmployee.Size = new System.Drawing.Size(418, 35);
            this.PanelEmployee.TabIndex = 26;
            this.PanelEmployee.Visible = false;
            // 
            // DgvEmployee
            // 
            this.DgvEmployee.AllowUserToAddRows = false;
            this.DgvEmployee.AllowUserToDeleteRows = false;
            this.DgvEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DgvEmployee.Location = new System.Drawing.Point(-41, 0);
            this.DgvEmployee.MultiSelect = false;
            this.DgvEmployee.Name = "DgvEmployee";
            this.DgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvEmployee.Size = new System.Drawing.Size(460, 361);
            this.DgvEmployee.TabIndex = 26;
            this.DgvEmployee.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Select";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Designation";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Employee Name";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Basic Pay";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Employee Number";
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            // 
            // Okey
            // 
            this.Okey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Okey.Location = new System.Drawing.Point(349, 367);
            this.Okey.Name = "Okey";
            this.Okey.Size = new System.Drawing.Size(62, 23);
            this.Okey.TabIndex = 6;
            this.Okey.Text = "Okey";
            this.Okey.UseVisualStyleBackColor = true;
            this.Okey.Click += new System.EventHandler(this.Okey_Click);
            // 
            // CancelEmployee
            // 
            this.CancelEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelEmployee.Location = new System.Drawing.Point(276, 367);
            this.CancelEmployee.Name = "CancelEmployee";
            this.CancelEmployee.Size = new System.Drawing.Size(62, 23);
            this.CancelEmployee.TabIndex = 6;
            this.CancelEmployee.Text = "Cancel";
            this.CancelEmployee.UseVisualStyleBackColor = true;
            this.CancelEmployee.Click += new System.EventHandler(this.CancelEmployee_Click);
            // 
            // DeselectAll
            // 
            this.DeselectAll.Location = new System.Drawing.Point(80, 367);
            this.DeselectAll.Name = "DeselectAll";
            this.DeselectAll.Size = new System.Drawing.Size(72, 23);
            this.DeselectAll.TabIndex = 6;
            this.DeselectAll.Text = "Deselect All";
            this.DeselectAll.UseVisualStyleBackColor = true;
            // 
            // SelectAll
            // 
            this.SelectAll.Location = new System.Drawing.Point(3, 367);
            this.SelectAll.Name = "SelectAll";
            this.SelectAll.Size = new System.Drawing.Size(62, 23);
            this.SelectAll.TabIndex = 6;
            this.SelectAll.Text = "Select All";
            this.SelectAll.UseVisualStyleBackColor = true;
            // 
            // TxtSearchEmployee
            // 
            this.TxtSearchEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSearchEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSearchEmployee.Depth = 0;
            this.TxtSearchEmployee.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtSearchEmployee.Hint = "Search Employee";
            this.TxtSearchEmployee.LeadingIcon = null;
            this.TxtSearchEmployee.Location = new System.Drawing.Point(283, 158);
            this.TxtSearchEmployee.MaxLength = 50;
            this.TxtSearchEmployee.MinimumSize = new System.Drawing.Size(0, 30);
            this.TxtSearchEmployee.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtSearchEmployee.Multiline = false;
            this.TxtSearchEmployee.Name = "TxtSearchEmployee";
            this.TxtSearchEmployee.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.TxtSearchEmployee.ShortcutsEnabled = false;
            this.TxtSearchEmployee.ShowSelectionMargin = true;
            this.TxtSearchEmployee.Size = new System.Drawing.Size(418, 36);
            this.TxtSearchEmployee.TabIndex = 0;
            this.TxtSearchEmployee.Text = "";
            this.TxtSearchEmployee.TrailingIcon = null;
            this.TxtSearchEmployee.UseTallSize = false;
            this.TxtSearchEmployee.TextChanged += new System.EventHandler(this.TxtSearchEmployee_TextChanged);
            this.TxtSearchEmployee.Enter += new System.EventHandler(this.TxtSearchEmployee_Enter);
            // 
            // TravelUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 674);
            this.Controls.Add(this.PanelEmployee);
            this.Controls.Add(this.DgvSelectedEmployee);
            this.Controls.Add(this.TravelTabSelector);
            this.Controls.Add(this.TravellTabControl);
            this.Controls.Add(this.TxtSearchEmployee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TravelUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Travel Details";
            this.Load += new System.EventHandler(this.TravelUI_Load);
            this.TravellTabControl.ResumeLayout(false);
            this.TabAddTravel.ResumeLayout(false);
            this.TabAddTravel.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.TabViewTravel.ResumeLayout(false);
            this.TabViewTravel.PerformLayout();
            this.TravelViewTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridTravelView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSelectedEmployee)).EndInit();
            this.PanelEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TravellTabControl;
        private System.Windows.Forms.TabPage TabAddTravel;
        private System.Windows.Forms.TabPage TabViewTravel;
        private MaterialSkin.Controls.MaterialTabSelector TravelTabSelector;
        private MaterialSkin.Controls.MaterialTextBox TxtDepPlace;
        private MaterialSkin.Controls.MaterialComboBox CmbDestination;
        private MaterialSkin.Controls.MaterialTextBox TxtShd_No;
        private MaterialSkin.Controls.MaterialTextBox TxtKms;
        private MaterialSkin.Controls.MaterialTextBox TxtFair;
        private MaterialSkin.Controls.MaterialComboBox CmbHalting;
        private MaterialSkin.Controls.MaterialComboBox CmbJourneyMode;
        private MaterialSkin.Controls.MaterialTextBox TxtArrPlace;
        private MaterialSkin.Controls.MaterialTextBox TxtShd;
        private MaterialSkin.Controls.MaterialTextBox TxtResion;
        private MaterialSkin.Controls.MaterialButton BtnAddTravel;
        private MaterialSkin.Controls.MaterialButton BtnClearAll;
        private MaterialSkin.Controls.MaterialButton BtnCalculateDay;
        private MaterialSkin.Controls.MaterialButton BtnLoadTravel;
        private MaterialSkin.Controls.MaterialTabSelector TravelViewTabSelector;
        private MaterialSkin.Controls.MaterialTabControl TravelViewTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView DgvSelectedEmployee;
        private System.Windows.Forms.Panel PanelEmployee;
        internal System.Windows.Forms.DataGridView DgvEmployee;
        private System.Windows.Forms.Button Okey;
        private System.Windows.Forms.Button CancelEmployee;
        private System.Windows.Forms.Button DeselectAll;
        private System.Windows.Forms.Button SelectAll;
        private MaterialSkin.Controls.MaterialTextBox TxtSearchEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn empname;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DateTimePicker DtArrTime;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DateTimePicker DtArrDate;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.DateTimePicker DtDepDate;
        private System.Windows.Forms.DateTimePicker DtDepTime;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.DataGridView GridTravelView;
        private MaterialSkin.Controls.MaterialButton BtnDelete;
        private MaterialSkin.Controls.MaterialTextBox TxtWarrant;
        private MaterialSkin.Controls.MaterialTextBox TxtDays2;
        private MaterialSkin.Controls.MaterialTextBox TxtDays;
        private MaterialSkin.Controls.MaterialTextBox TxtAdvace;
    }
}