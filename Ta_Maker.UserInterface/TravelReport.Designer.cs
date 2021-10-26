
namespace Ta_Maker
{
    partial class TravelReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TravelReport));
            this.TravelReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CmbMonth = new MaterialSkin.Controls.MaterialComboBox();
            this.CmbYear = new MaterialSkin.Controls.MaterialComboBox();
            this.BtnShowReport = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // TravelReportViewer
            // 
            this.TravelReportViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TravelReportViewer.Location = new System.Drawing.Point(6, 122);
            this.TravelReportViewer.Name = "TravelReportViewer";
            this.TravelReportViewer.ServerReport.BearerToken = null;
            this.TravelReportViewer.Size = new System.Drawing.Size(1323, 498);
            this.TravelReportViewer.TabIndex = 0;
            // 
            // CmbMonth
            // 
            this.CmbMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbMonth.AutoResize = false;
            this.CmbMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CmbMonth.Depth = 0;
            this.CmbMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CmbMonth.DropDownHeight = 174;
            this.CmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMonth.DropDownWidth = 121;
            this.CmbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CmbMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CmbMonth.FormattingEnabled = true;
            this.CmbMonth.Hint = "Select Month";
            this.CmbMonth.IntegralHeight = false;
            this.CmbMonth.ItemHeight = 43;
            this.CmbMonth.Location = new System.Drawing.Point(924, 67);
            this.CmbMonth.MaxDropDownItems = 4;
            this.CmbMonth.MouseState = MaterialSkin.MouseState.OUT;
            this.CmbMonth.Name = "CmbMonth";
            this.CmbMonth.Size = new System.Drawing.Size(201, 49);
            this.CmbMonth.StartIndex = 0;
            this.CmbMonth.TabIndex = 3;
            // 
            // CmbYear
            // 
            this.CmbYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbYear.AutoResize = false;
            this.CmbYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CmbYear.Depth = 0;
            this.CmbYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CmbYear.DropDownHeight = 174;
            this.CmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbYear.DropDownWidth = 121;
            this.CmbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CmbYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CmbYear.FormattingEnabled = true;
            this.CmbYear.Hint = "Select Year";
            this.CmbYear.IntegralHeight = false;
            this.CmbYear.ItemHeight = 43;
            this.CmbYear.Location = new System.Drawing.Point(753, 67);
            this.CmbYear.MaxDropDownItems = 4;
            this.CmbYear.MouseState = MaterialSkin.MouseState.OUT;
            this.CmbYear.Name = "CmbYear";
            this.CmbYear.Size = new System.Drawing.Size(150, 49);
            this.CmbYear.StartIndex = 0;
            this.CmbYear.TabIndex = 2;
            this.CmbYear.SelectedIndexChanged += new System.EventHandler(this.CmbYear_SelectedIndexChanged);
            // 
            // BtnShowReport
            // 
            this.BtnShowReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnShowReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnShowReport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnShowReport.Depth = 0;
            this.BtnShowReport.HighEmphasis = true;
            this.BtnShowReport.Icon = null;
            this.BtnShowReport.Location = new System.Drawing.Point(1205, 77);
            this.BtnShowReport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnShowReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnShowReport.Name = "BtnShowReport";
            this.BtnShowReport.Size = new System.Drawing.Size(123, 36);
            this.BtnShowReport.TabIndex = 4;
            this.BtnShowReport.Text = "Show Reoprt";
            this.BtnShowReport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnShowReport.UseAccentColor = false;
            this.BtnShowReport.UseVisualStyleBackColor = true;
            this.BtnShowReport.Click += new System.EventHandler(this.BtnShowReport_Click);
            // 
            // TravelReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 626);
            this.Controls.Add(this.BtnShowReport);
            this.Controls.Add(this.CmbMonth);
            this.Controls.Add(this.CmbYear);
            this.Controls.Add(this.TravelReportViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TravelReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Travel Report";
            this.Load += new System.EventHandler(this.TravelReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer TravelReportViewer;
        private MaterialSkin.Controls.MaterialComboBox CmbMonth;
        private MaterialSkin.Controls.MaterialComboBox CmbYear;
        private MaterialSkin.Controls.MaterialButton BtnShowReport;
    }
}