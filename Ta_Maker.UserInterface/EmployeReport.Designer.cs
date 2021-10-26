namespace Ta_Maker
{
    partial class EmployeReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeReport));
            this.EmployereportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // EmployereportViewer
            // 
            this.EmployereportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployereportViewer.LocalReport.ReportEmbeddedResource = "Ta_Maker.UserInterface.Employee.rdlc";
            this.EmployereportViewer.Location = new System.Drawing.Point(3, 64);
            this.EmployereportViewer.Name = "EmployereportViewer";
            this.EmployereportViewer.ServerReport.BearerToken = null;
            this.EmployereportViewer.Size = new System.Drawing.Size(955, 503);
            this.EmployereportViewer.TabIndex = 0;
            // 
            // EmployeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 570);
            this.Controls.Add(this.EmployereportViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List of Employees";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer EmployereportViewer;
    }
}

