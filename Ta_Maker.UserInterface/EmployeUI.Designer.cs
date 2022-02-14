
namespace Ta_Maker
{
    partial class EmployeUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeUI));
            this.EmployeeTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.TabAddEmployee = new System.Windows.Forms.TabPage();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.TxtEmpNo = new MaterialSkin.Controls.MaterialTextBox();
            this.CmbDesignation = new MaterialSkin.Controls.MaterialComboBox();
            this.CmbEmpGroup = new MaterialSkin.Controls.MaterialComboBox();
            this.CmbStatus = new MaterialSkin.Controls.MaterialComboBox();
            this.TxtDesig = new MaterialSkin.Controls.MaterialTextBox();
            this.CmbStation = new MaterialSkin.Controls.MaterialComboBox();
            this.TxtName = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtSalary = new MaterialSkin.Controls.MaterialTextBox();
            this.BtnDelete = new MaterialSkin.Controls.MaterialButton();
            this.BtnClear = new MaterialSkin.Controls.MaterialButton();
            this.BtnInsert = new MaterialSkin.Controls.MaterialButton();
            this.TabViewEmployee = new System.Windows.Forms.TabPage();
            this.CkInclude = new MaterialSkin.Controls.MaterialCheckbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RbByDesignation = new MaterialSkin.Controls.MaterialRadioButton();
            this.RbByName = new MaterialSkin.Controls.MaterialRadioButton();
            this.TxtSearchEmployee = new MaterialSkin.Controls.MaterialTextBox();
            this.BtnLoadEmployee = new MaterialSkin.Controls.MaterialButton();
            this.EmployeListView = new MaterialSkin.Controls.MaterialListView();
            this.EMPNO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DESIGNATION = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EMPNAME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SALARY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WORKINGUNIT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.STATUS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GROUP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmployeTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.LblMsg = new MaterialSkin.Controls.MaterialLabel();
            this.EmployeeTabControl.SuspendLayout();
            this.TabAddEmployee.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.TabViewEmployee.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeTabControl
            // 
            this.EmployeeTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeTabControl.Controls.Add(this.TabAddEmployee);
            this.EmployeeTabControl.Controls.Add(this.TabViewEmployee);
            this.EmployeeTabControl.Depth = 0;
            this.EmployeeTabControl.Location = new System.Drawing.Point(30, 149);
            this.EmployeeTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.EmployeeTabControl.Multiline = true;
            this.EmployeeTabControl.Name = "EmployeeTabControl";
            this.EmployeeTabControl.SelectedIndex = 0;
            this.EmployeeTabControl.Size = new System.Drawing.Size(768, 407);
            this.EmployeeTabControl.TabIndex = 0;
            // 
            // TabAddEmployee
            // 
            this.TabAddEmployee.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TabAddEmployee.Controls.Add(this.materialCard1);
            this.TabAddEmployee.Controls.Add(this.BtnDelete);
            this.TabAddEmployee.Controls.Add(this.BtnClear);
            this.TabAddEmployee.Controls.Add(this.BtnInsert);
            this.TabAddEmployee.Location = new System.Drawing.Point(4, 22);
            this.TabAddEmployee.Name = "TabAddEmployee";
            this.TabAddEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.TabAddEmployee.Size = new System.Drawing.Size(760, 381);
            this.TabAddEmployee.TabIndex = 0;
            this.TabAddEmployee.Text = "ADD EMPLOYEE";
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.TxtEmpNo);
            this.materialCard1.Controls.Add(this.CmbDesignation);
            this.materialCard1.Controls.Add(this.CmbEmpGroup);
            this.materialCard1.Controls.Add(this.CmbStatus);
            this.materialCard1.Controls.Add(this.TxtDesig);
            this.materialCard1.Controls.Add(this.CmbStation);
            this.materialCard1.Controls.Add(this.TxtName);
            this.materialCard1.Controls.Add(this.TxtSalary);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(29, 14);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(702, 295);
            this.materialCard1.TabIndex = 0;
            // 
            // TxtEmpNo
            // 
            this.TxtEmpNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtEmpNo.Depth = 0;
            this.TxtEmpNo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtEmpNo.Hint = "Employee Number";
            this.TxtEmpNo.LeadingIcon = null;
            this.TxtEmpNo.Location = new System.Drawing.Point(30, 25);
            this.TxtEmpNo.MaxLength = 50;
            this.TxtEmpNo.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtEmpNo.Multiline = false;
            this.TxtEmpNo.Name = "TxtEmpNo";
            this.TxtEmpNo.Size = new System.Drawing.Size(272, 50);
            this.TxtEmpNo.TabIndex = 1;
            this.TxtEmpNo.Text = "";
            this.TxtEmpNo.TrailingIcon = null;
            // 
            // CmbDesignation
            // 
            this.CmbDesignation.AutoResize = false;
            this.CmbDesignation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CmbDesignation.Depth = 0;
            this.CmbDesignation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CmbDesignation.DropDownHeight = 174;
            this.CmbDesignation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDesignation.DropDownWidth = 121;
            this.CmbDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CmbDesignation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CmbDesignation.FormattingEnabled = true;
            this.CmbDesignation.Hint = "Designation";
            this.CmbDesignation.IntegralHeight = false;
            this.CmbDesignation.ItemHeight = 43;
            this.CmbDesignation.Location = new System.Drawing.Point(30, 93);
            this.CmbDesignation.MaxDropDownItems = 4;
            this.CmbDesignation.MouseState = MaterialSkin.MouseState.OUT;
            this.CmbDesignation.Name = "CmbDesignation";
            this.CmbDesignation.Size = new System.Drawing.Size(272, 49);
            this.CmbDesignation.StartIndex = 0;
            this.CmbDesignation.TabIndex = 3;
            // 
            // CmbEmpGroup
            // 
            this.CmbEmpGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbEmpGroup.AutoResize = false;
            this.CmbEmpGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CmbEmpGroup.Depth = 0;
            this.CmbEmpGroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CmbEmpGroup.DropDownHeight = 174;
            this.CmbEmpGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEmpGroup.DropDownWidth = 121;
            this.CmbEmpGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CmbEmpGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CmbEmpGroup.FormattingEnabled = true;
            this.CmbEmpGroup.Hint = "Group";
            this.CmbEmpGroup.IntegralHeight = false;
            this.CmbEmpGroup.ItemHeight = 43;
            this.CmbEmpGroup.Location = new System.Drawing.Point(344, 227);
            this.CmbEmpGroup.MaxDropDownItems = 4;
            this.CmbEmpGroup.MouseState = MaterialSkin.MouseState.OUT;
            this.CmbEmpGroup.Name = "CmbEmpGroup";
            this.CmbEmpGroup.Size = new System.Drawing.Size(324, 49);
            this.CmbEmpGroup.StartIndex = 0;
            this.CmbEmpGroup.TabIndex = 7;
            // 
            // CmbStatus
            // 
            this.CmbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbStatus.AutoResize = false;
            this.CmbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CmbStatus.Depth = 0;
            this.CmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CmbStatus.DropDownHeight = 174;
            this.CmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbStatus.DropDownWidth = 121;
            this.CmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CmbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CmbStatus.FormattingEnabled = true;
            this.CmbStatus.Hint = "Employee Status";
            this.CmbStatus.IntegralHeight = false;
            this.CmbStatus.ItemHeight = 43;
            this.CmbStatus.Location = new System.Drawing.Point(344, 26);
            this.CmbStatus.MaxDropDownItems = 4;
            this.CmbStatus.MouseState = MaterialSkin.MouseState.OUT;
            this.CmbStatus.Name = "CmbStatus";
            this.CmbStatus.Size = new System.Drawing.Size(324, 49);
            this.CmbStatus.StartIndex = 0;
            this.CmbStatus.TabIndex = 2;
            this.CmbStatus.Visible = false;
            // 
            // TxtDesig
            // 
            this.TxtDesig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDesig.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDesig.Depth = 0;
            this.TxtDesig.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtDesig.Hint = "Buckle Number";
            this.TxtDesig.LeadingIcon = null;
            this.TxtDesig.Location = new System.Drawing.Point(344, 92);
            this.TxtDesig.MaxLength = 50;
            this.TxtDesig.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtDesig.Multiline = false;
            this.TxtDesig.Name = "TxtDesig";
            this.TxtDesig.Size = new System.Drawing.Size(324, 50);
            this.TxtDesig.TabIndex = 4;
            this.TxtDesig.Text = "";
            this.TxtDesig.TrailingIcon = null;
            // 
            // CmbStation
            // 
            this.CmbStation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbStation.AutoResize = false;
            this.CmbStation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CmbStation.Depth = 0;
            this.CmbStation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CmbStation.DropDownHeight = 174;
            this.CmbStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbStation.DropDownWidth = 121;
            this.CmbStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CmbStation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CmbStation.FormattingEnabled = true;
            this.CmbStation.Hint = "Working Unit";
            this.CmbStation.IntegralHeight = false;
            this.CmbStation.ItemHeight = 43;
            this.CmbStation.Location = new System.Drawing.Point(308, 226);
            this.CmbStation.MaxDropDownItems = 4;
            this.CmbStation.MouseState = MaterialSkin.MouseState.OUT;
            this.CmbStation.Name = "CmbStation";
            this.CmbStation.Size = new System.Drawing.Size(86, 49);
            this.CmbStation.StartIndex = 0;
            this.CmbStation.TabIndex = 8;
            this.CmbStation.Visible = false;
            // 
            // TxtName
            // 
            this.TxtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtName.Depth = 0;
            this.TxtName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtName.Hint = "Full Name";
            this.TxtName.LeadingIcon = null;
            this.TxtName.Location = new System.Drawing.Point(30, 158);
            this.TxtName.MaxLength = 50;
            this.TxtName.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtName.Multiline = false;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(638, 50);
            this.TxtName.TabIndex = 5;
            this.TxtName.Text = "";
            this.TxtName.TrailingIcon = null;
            // 
            // TxtSalary
            // 
            this.TxtSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSalary.Depth = 0;
            this.TxtSalary.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtSalary.Hint = "Basic Salary";
            this.TxtSalary.LeadingIcon = null;
            this.TxtSalary.Location = new System.Drawing.Point(30, 226);
            this.TxtSalary.MaxLength = 50;
            this.TxtSalary.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtSalary.Multiline = false;
            this.TxtSalary.Name = "TxtSalary";
            this.TxtSalary.Size = new System.Drawing.Size(272, 50);
            this.TxtSalary.TabIndex = 6;
            this.TxtSalary.Text = "";
            this.TxtSalary.TrailingIcon = null;
            // 
            // BtnDelete
            // 
            this.BtnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnDelete.Depth = 0;
            this.BtnDelete.Enabled = false;
            this.BtnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDelete.HighEmphasis = true;
            this.BtnDelete.Icon = null;
            this.BtnDelete.Location = new System.Drawing.Point(37, 329);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(152, 36);
            this.BtnDelete.TabIndex = 12;
            this.BtnDelete.Text = "DELETE EMPLOYEE";
            this.BtnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnDelete.UseAccentColor = false;
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            this.BtnDelete.Enter += new System.EventHandler(this.BtnDelete_Enter);
            this.BtnDelete.Leave += new System.EventHandler(this.BtnDelete_Leave);
            // 
            // BtnClear
            // 
            this.BtnClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnClear.Depth = 0;
            this.BtnClear.HighEmphasis = true;
            this.BtnClear.Icon = null;
            this.BtnClear.Location = new System.Drawing.Point(299, 329);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(147, 36);
            this.BtnClear.TabIndex = 11;
            this.BtnClear.Text = "CLEAR ALL FIELDS";
            this.BtnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnClear.UseAccentColor = false;
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            this.BtnClear.Enter += new System.EventHandler(this.BtnClear_Enter);
            this.BtnClear.Leave += new System.EventHandler(this.BtnClear_Leave);
            // 
            // BtnInsert
            // 
            this.BtnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnInsert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnInsert.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnInsert.Depth = 0;
            this.BtnInsert.HighEmphasis = true;
            this.BtnInsert.Icon = null;
            this.BtnInsert.Location = new System.Drawing.Point(556, 329);
            this.BtnInsert.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnInsert.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(165, 36);
            this.BtnInsert.TabIndex = 9;
            this.BtnInsert.Text = "ADD NEW EMPLOYEE";
            this.BtnInsert.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnInsert.UseAccentColor = false;
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            this.BtnInsert.Enter += new System.EventHandler(this.BtnInsert_Enter);
            this.BtnInsert.Leave += new System.EventHandler(this.BtnInsert_Leave);
            // 
            // TabViewEmployee
            // 
            this.TabViewEmployee.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TabViewEmployee.Controls.Add(this.CkInclude);
            this.TabViewEmployee.Controls.Add(this.panel1);
            this.TabViewEmployee.Controls.Add(this.TxtSearchEmployee);
            this.TabViewEmployee.Controls.Add(this.BtnLoadEmployee);
            this.TabViewEmployee.Controls.Add(this.EmployeListView);
            this.TabViewEmployee.Location = new System.Drawing.Point(4, 22);
            this.TabViewEmployee.Name = "TabViewEmployee";
            this.TabViewEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.TabViewEmployee.Size = new System.Drawing.Size(760, 381);
            this.TabViewEmployee.TabIndex = 1;
            this.TabViewEmployee.Text = "VIEW EMPLOYEE";
            // 
            // CkInclude
            // 
            this.CkInclude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CkInclude.AutoSize = true;
            this.CkInclude.Depth = 0;
            this.CkInclude.Location = new System.Drawing.Point(509, 332);
            this.CkInclude.Margin = new System.Windows.Forms.Padding(0);
            this.CkInclude.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CkInclude.MouseState = MaterialSkin.MouseState.HOVER;
            this.CkInclude.Name = "CkInclude";
            this.CkInclude.Ripple = true;
            this.CkInclude.Size = new System.Drawing.Size(86, 37);
            this.CkInclude.TabIndex = 29;
            this.CkInclude.Text = "Include";
            this.CkInclude.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RbByDesignation);
            this.panel1.Controls.Add(this.RbByName);
            this.panel1.Location = new System.Drawing.Point(3, 332);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 32);
            this.panel1.TabIndex = 28;
            // 
            // RbByDesignation
            // 
            this.RbByDesignation.AutoSize = true;
            this.RbByDesignation.Depth = 0;
            this.RbByDesignation.Location = new System.Drawing.Point(2, -3);
            this.RbByDesignation.Margin = new System.Windows.Forms.Padding(0);
            this.RbByDesignation.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RbByDesignation.MouseState = MaterialSkin.MouseState.HOVER;
            this.RbByDesignation.Name = "RbByDesignation";
            this.RbByDesignation.Ripple = true;
            this.RbByDesignation.Size = new System.Drawing.Size(120, 37);
            this.RbByDesignation.TabIndex = 0;
            this.RbByDesignation.TabStop = true;
            this.RbByDesignation.Text = "Designation";
            this.RbByDesignation.UseVisualStyleBackColor = true;
            // 
            // RbByName
            // 
            this.RbByName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RbByName.AutoSize = true;
            this.RbByName.Depth = 0;
            this.RbByName.Location = new System.Drawing.Point(129, -3);
            this.RbByName.Margin = new System.Windows.Forms.Padding(0);
            this.RbByName.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RbByName.MouseState = MaterialSkin.MouseState.HOVER;
            this.RbByName.Name = "RbByName";
            this.RbByName.Ripple = true;
            this.RbByName.Size = new System.Drawing.Size(99, 37);
            this.RbByName.TabIndex = 0;
            this.RbByName.TabStop = true;
            this.RbByName.Text = "By Name";
            this.RbByName.UseVisualStyleBackColor = true;
            // 
            // TxtSearchEmployee
            // 
            this.TxtSearchEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSearchEmployee.Depth = 0;
            this.TxtSearchEmployee.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtSearchEmployee.Hint = "Search Employee";
            this.TxtSearchEmployee.LeadingIcon = null;
            this.TxtSearchEmployee.Location = new System.Drawing.Point(239, 331);
            this.TxtSearchEmployee.MaxLength = 50;
            this.TxtSearchEmployee.MinimumSize = new System.Drawing.Size(0, 30);
            this.TxtSearchEmployee.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtSearchEmployee.Multiline = false;
            this.TxtSearchEmployee.Name = "TxtSearchEmployee";
            this.TxtSearchEmployee.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.TxtSearchEmployee.ShortcutsEnabled = false;
            this.TxtSearchEmployee.ShowSelectionMargin = true;
            this.TxtSearchEmployee.Size = new System.Drawing.Size(206, 36);
            this.TxtSearchEmployee.TabIndex = 4;
            this.TxtSearchEmployee.Text = "";
            this.TxtSearchEmployee.TrailingIcon = null;
            this.TxtSearchEmployee.UseTallSize = false;
            this.TxtSearchEmployee.TextChanged += new System.EventHandler(this.TxtSearchEmployee_TextChanged);
            // 
            // BtnLoadEmployee
            // 
            this.BtnLoadEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLoadEmployee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnLoadEmployee.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnLoadEmployee.Depth = 0;
            this.BtnLoadEmployee.HighEmphasis = true;
            this.BtnLoadEmployee.Icon = null;
            this.BtnLoadEmployee.Location = new System.Drawing.Point(608, 331);
            this.BtnLoadEmployee.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnLoadEmployee.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnLoadEmployee.Name = "BtnLoadEmployee";
            this.BtnLoadEmployee.Size = new System.Drawing.Size(146, 36);
            this.BtnLoadEmployee.TabIndex = 3;
            this.BtnLoadEmployee.Text = "LOAD EMPLOYEES";
            this.BtnLoadEmployee.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnLoadEmployee.UseAccentColor = false;
            this.BtnLoadEmployee.UseVisualStyleBackColor = true;
            this.BtnLoadEmployee.Click += new System.EventHandler(this.BtnLoadEmployee_Click);
            // 
            // EmployeListView
            // 
            this.EmployeListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeListView.AutoSizeTable = false;
            this.EmployeListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.EmployeListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmployeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EMPNO,
            this.DESIGNATION,
            this.EMPNAME,
            this.SALARY,
            this.WORKINGUNIT,
            this.STATUS,
            this.GROUP});
            this.EmployeListView.Depth = 0;
            this.EmployeListView.FullRowSelect = true;
            this.EmployeListView.HideSelection = false;
            this.EmployeListView.Location = new System.Drawing.Point(3, 16);
            this.EmployeListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.EmployeListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.EmployeListView.MouseState = MaterialSkin.MouseState.OUT;
            this.EmployeListView.Name = "EmployeListView";
            this.EmployeListView.OwnerDraw = true;
            this.EmployeListView.Size = new System.Drawing.Size(751, 306);
            this.EmployeListView.TabIndex = 2;
            this.EmployeListView.UseCompatibleStateImageBehavior = false;
            this.EmployeListView.View = System.Windows.Forms.View.Details;
            this.EmployeListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EmployeListView_MouseClick);
            // 
            // EMPNO
            // 
            this.EMPNO.Text = "EMPLOYEE NO";
            this.EMPNO.Width = 130;
            // 
            // DESIGNATION
            // 
            this.DESIGNATION.Text = "DESIGNATION";
            this.DESIGNATION.Width = 130;
            // 
            // EMPNAME
            // 
            this.EMPNAME.Text = "EMPLYEE NAME";
            this.EMPNAME.Width = 245;
            // 
            // SALARY
            // 
            this.SALARY.Text = "BASIC SALARY";
            this.SALARY.Width = 130;
            // 
            // WORKINGUNIT
            // 
            this.WORKINGUNIT.Text = "WORKING UNIT";
            this.WORKINGUNIT.Width = 130;
            // 
            // STATUS
            // 
            this.STATUS.Text = "STATUS";
            this.STATUS.Width = 5;
            // 
            // GROUP
            // 
            this.GROUP.Text = "GROUP";
            // 
            // EmployeTabSelector
            // 
            this.EmployeTabSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeTabSelector.BaseTabControl = this.EmployeeTabControl;
            this.EmployeTabSelector.Depth = 0;
            this.EmployeTabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.EmployeTabSelector.Location = new System.Drawing.Point(30, 107);
            this.EmployeTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.EmployeTabSelector.Name = "EmployeTabSelector";
            this.EmployeTabSelector.Size = new System.Drawing.Size(768, 42);
            this.EmployeTabSelector.TabIndex = 1;
            this.EmployeTabSelector.Text = "materialTabSelector1";
            // 
            // LblMsg
            // 
            this.LblMsg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblMsg.AutoSize = true;
            this.LblMsg.Depth = 0;
            this.LblMsg.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblMsg.ForeColor = System.Drawing.Color.Red;
            this.LblMsg.Location = new System.Drawing.Point(173, 74);
            this.LblMsg.MinimumSize = new System.Drawing.Size(500, 0);
            this.LblMsg.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(1, 0);
            this.LblMsg.TabIndex = 3;
            this.LblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmployeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 566);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.EmployeTabSelector);
            this.Controls.Add(this.EmployeeTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employes Details";
            this.Load += new System.EventHandler(this.EmployeUI_Load);
            this.EmployeeTabControl.ResumeLayout(false);
            this.TabAddEmployee.ResumeLayout(false);
            this.TabAddEmployee.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.TabViewEmployee.ResumeLayout(false);
            this.TabViewEmployee.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl EmployeeTabControl;
        private System.Windows.Forms.TabPage TabAddEmployee;
        private System.Windows.Forms.TabPage TabViewEmployee;
        private MaterialSkin.Controls.MaterialTabSelector EmployeTabSelector;
        private MaterialSkin.Controls.MaterialButton BtnDelete;
        private MaterialSkin.Controls.MaterialButton BtnClear;
        private MaterialSkin.Controls.MaterialButton BtnInsert;
        private MaterialSkin.Controls.MaterialComboBox CmbStation;
        private MaterialSkin.Controls.MaterialTextBox TxtSalary;
        private MaterialSkin.Controls.MaterialTextBox TxtName;
        private MaterialSkin.Controls.MaterialTextBox TxtDesig;
        private MaterialSkin.Controls.MaterialComboBox CmbDesignation;
        private MaterialSkin.Controls.MaterialTextBox TxtEmpNo;
        private MaterialSkin.Controls.MaterialButton BtnLoadEmployee;
        private MaterialSkin.Controls.MaterialListView EmployeListView;
        private System.Windows.Forms.ColumnHeader EMPNO;
        private System.Windows.Forms.ColumnHeader DESIGNATION;
        private System.Windows.Forms.ColumnHeader EMPNAME;
        private System.Windows.Forms.ColumnHeader SALARY;
        private System.Windows.Forms.ColumnHeader WORKINGUNIT;
        private MaterialSkin.Controls.MaterialTextBox TxtSearchEmployee;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRadioButton RbByDesignation;
        private MaterialSkin.Controls.MaterialRadioButton RbByName;
        private MaterialSkin.Controls.MaterialComboBox CmbStatus;
        private System.Windows.Forms.ColumnHeader STATUS;
        private MaterialSkin.Controls.MaterialCheckbox CkInclude;
        private MaterialSkin.Controls.MaterialLabel LblMsg;
        private MaterialSkin.Controls.MaterialComboBox CmbEmpGroup;
        private System.Windows.Forms.ColumnHeader GROUP;
        private MaterialSkin.Controls.MaterialCard materialCard1;
    }
}