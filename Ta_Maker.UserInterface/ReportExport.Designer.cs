
namespace Ta_Maker
{
    partial class ReportExport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportExport));
            this.ExportReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CmbYear = new MaterialSkin.Controls.MaterialComboBox();
            this.CmbMonth = new MaterialSkin.Controls.MaterialComboBox();
            this.BtnGenarateReport = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // ExportReport
            // 
            this.ExportReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportReport.Location = new System.Drawing.Point(0, 65);
            this.ExportReport.Name = "ExportReport";
            this.ExportReport.ServerReport.BearerToken = null;
            this.ExportReport.Size = new System.Drawing.Size(400, 28);
            this.ExportReport.TabIndex = 3;
            // 
            // CmbYear
            // 
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
            this.CmbYear.Location = new System.Drawing.Point(55, 133);
            this.CmbYear.MaxDropDownItems = 4;
            this.CmbYear.MouseState = MaterialSkin.MouseState.OUT;
            this.CmbYear.Name = "CmbYear";
            this.CmbYear.Size = new System.Drawing.Size(281, 49);
            this.CmbYear.StartIndex = 0;
            this.CmbYear.TabIndex = 0;
            this.CmbYear.SelectedIndexChanged += new System.EventHandler(this.CmbYear_SelectedIndexChanged);
            // 
            // CmbMonth
            // 
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
            this.CmbMonth.Location = new System.Drawing.Point(55, 198);
            this.CmbMonth.MaxDropDownItems = 4;
            this.CmbMonth.MouseState = MaterialSkin.MouseState.OUT;
            this.CmbMonth.Name = "CmbMonth";
            this.CmbMonth.Size = new System.Drawing.Size(281, 49);
            this.CmbMonth.StartIndex = 0;
            this.CmbMonth.TabIndex = 1;
            // 
            // BtnGenarateReport
            // 
            this.BtnGenarateReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnGenarateReport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnGenarateReport.Depth = 0;
            this.BtnGenarateReport.HighEmphasis = true;
            this.BtnGenarateReport.Icon = null;
            this.BtnGenarateReport.Location = new System.Drawing.Point(114, 269);
            this.BtnGenarateReport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnGenarateReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnGenarateReport.Name = "BtnGenarateReport";
            this.BtnGenarateReport.Size = new System.Drawing.Size(154, 36);
            this.BtnGenarateReport.TabIndex = 2;
            this.BtnGenarateReport.Text = "Generate Report";
            this.BtnGenarateReport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnGenarateReport.UseAccentColor = false;
            this.BtnGenarateReport.UseVisualStyleBackColor = true;
            this.BtnGenarateReport.Click += new System.EventHandler(this.BtnGenarateReport_Click);
            // 
            // ReportExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 325);
            this.Controls.Add(this.BtnGenarateReport);
            this.Controls.Add(this.CmbMonth);
            this.Controls.Add(this.CmbYear);
            this.Controls.Add(this.ExportReport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportExport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Export";
            this.Load += new System.EventHandler(this.ReportExport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ExportReport;
        private MaterialSkin.Controls.MaterialComboBox CmbYear;
        private MaterialSkin.Controls.MaterialComboBox CmbMonth;
        private MaterialSkin.Controls.MaterialButton BtnGenarateReport;
    }
}