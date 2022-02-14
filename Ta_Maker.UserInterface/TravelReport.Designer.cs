
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
            this.BtnShowReport = new MaterialSkin.Controls.MaterialButton();
            this.CmbYear = new System.Windows.Forms.ComboBox();
            this.CmbMonth = new System.Windows.Forms.ComboBox();
            this.BtnFinalMark = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TravelReportViewer
            // 
            this.TravelReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TravelReportViewer.Location = new System.Drawing.Point(3, 64);
            this.TravelReportViewer.Name = "TravelReportViewer";
            this.TravelReportViewer.ServerReport.BearerToken = null;
            this.TravelReportViewer.Size = new System.Drawing.Size(1283, 559);
            this.TravelReportViewer.TabIndex = 0;
            // 
            // BtnShowReport
            // 
            this.BtnShowReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnShowReport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnShowReport.Depth = 0;
            this.BtnShowReport.HighEmphasis = true;
            this.BtnShowReport.Icon = null;
            this.BtnShowReport.Location = new System.Drawing.Point(1103, 25);
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
            // CmbYear
            // 
            this.CmbYear.FormattingEnabled = true;
            this.CmbYear.Location = new System.Drawing.Point(755, 33);
            this.CmbYear.Name = "CmbYear";
            this.CmbYear.Size = new System.Drawing.Size(121, 21);
            this.CmbYear.TabIndex = 5;
            this.CmbYear.SelectedIndexChanged += new System.EventHandler(this.CmbYear_SelectedIndexChanged);
            // 
            // CmbMonth
            // 
            this.CmbMonth.FormattingEnabled = true;
            this.CmbMonth.Location = new System.Drawing.Point(902, 33);
            this.CmbMonth.Name = "CmbMonth";
            this.CmbMonth.Size = new System.Drawing.Size(164, 21);
            this.CmbMonth.TabIndex = 6;
            this.CmbMonth.SelectedIndexChanged += new System.EventHandler(this.CmbMonth_SelectedIndexChanged);
            // 
            // BtnFinalMark
            // 
            this.BtnFinalMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFinalMark.Location = new System.Drawing.Point(565, 31);
            this.BtnFinalMark.Name = "BtnFinalMark";
            this.BtnFinalMark.Size = new System.Drawing.Size(171, 28);
            this.BtnFinalMark.TabIndex = 7;
            this.BtnFinalMark.Text = "Mark as Final Print";
            this.BtnFinalMark.UseVisualStyleBackColor = true;
            this.BtnFinalMark.Click += new System.EventHandler(this.BtnFinalMark_Click);
            // 
            // TravelReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 626);
            this.Controls.Add(this.BtnFinalMark);
            this.Controls.Add(this.CmbMonth);
            this.Controls.Add(this.CmbYear);
            this.Controls.Add(this.BtnShowReport);
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
        private MaterialSkin.Controls.MaterialButton BtnShowReport;
        private System.Windows.Forms.ComboBox CmbYear;
        private System.Windows.Forms.ComboBox CmbMonth;
        private System.Windows.Forms.Button BtnFinalMark;
    }
}