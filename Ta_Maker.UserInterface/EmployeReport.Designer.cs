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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeReport));
            this.EmployereportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Ta_DataSet = new Ta_Maker.Ta_DataSet();
            this.EmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Ta_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployereportViewer
            // 
            this.EmployereportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.EmployeeBindingSource;
            this.EmployereportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.EmployereportViewer.LocalReport.ReportEmbeddedResource = "Ta_Maker.UserInterface.Employee.rdlc";
            this.EmployereportViewer.Location = new System.Drawing.Point(3, 64);
            this.EmployereportViewer.Name = "EmployereportViewer";
            this.EmployereportViewer.ServerReport.BearerToken = null;
            this.EmployereportViewer.Size = new System.Drawing.Size(955, 503);
            this.EmployereportViewer.TabIndex = 0;
            // 
            // Ta_DataSet
            // 
            this.Ta_DataSet.DataSetName = "Ta_DataSet";
            this.Ta_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EmployeeBindingSource
            // 
            this.EmployeeBindingSource.DataMember = "Employee";
            this.EmployeeBindingSource.DataSource = this.Ta_DataSet;
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
            ((System.ComponentModel.ISupportInitialize)(this.Ta_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer EmployereportViewer;
        private System.Windows.Forms.BindingSource EmployeeBindingSource;
        private Ta_DataSet Ta_DataSet;
    }
}

