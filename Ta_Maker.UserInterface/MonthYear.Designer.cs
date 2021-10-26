
namespace Ta_Maker
{
    partial class MonthYear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonthYear));
            this.CmbYear = new MaterialSkin.Controls.MaterialComboBox();
            this.CmbMonth = new MaterialSkin.Controls.MaterialComboBox();
            this.BtnSetMonthYear = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
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
            this.CmbYear.Location = new System.Drawing.Point(41, 133);
            this.CmbYear.MaxDropDownItems = 4;
            this.CmbYear.MouseState = MaterialSkin.MouseState.OUT;
            this.CmbYear.Name = "CmbYear";
            this.CmbYear.Size = new System.Drawing.Size(298, 49);
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
            this.CmbMonth.Location = new System.Drawing.Point(41, 201);
            this.CmbMonth.MaxDropDownItems = 4;
            this.CmbMonth.MouseState = MaterialSkin.MouseState.OUT;
            this.CmbMonth.Name = "CmbMonth";
            this.CmbMonth.Size = new System.Drawing.Size(298, 49);
            this.CmbMonth.StartIndex = 0;
            this.CmbMonth.TabIndex = 1;
            // 
            // BtnSetMonthYear
            // 
            this.BtnSetMonthYear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSetMonthYear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnSetMonthYear.Depth = 0;
            this.BtnSetMonthYear.HighEmphasis = true;
            this.BtnSetMonthYear.Icon = null;
            this.BtnSetMonthYear.Location = new System.Drawing.Point(57, 282);
            this.BtnSetMonthYear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnSetMonthYear.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSetMonthYear.Name = "BtnSetMonthYear";
            this.BtnSetMonthYear.Size = new System.Drawing.Size(256, 36);
            this.BtnSetMonthYear.TabIndex = 2;
            this.BtnSetMonthYear.Text = "SET AS DEFALT MONTH AND YEAR";
            this.BtnSetMonthYear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnSetMonthYear.UseAccentColor = false;
            this.BtnSetMonthYear.UseVisualStyleBackColor = true;
            this.BtnSetMonthYear.Click += new System.EventHandler(this.BtnSetMonthYear_Click);
            // 
            // MonthYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 354);
            this.Controls.Add(this.BtnSetMonthYear);
            this.Controls.Add(this.CmbMonth);
            this.Controls.Add(this.CmbYear);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MonthYear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set Month Year";
            this.Load += new System.EventHandler(this.MonthYear_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox CmbYear;
        private MaterialSkin.Controls.MaterialComboBox CmbMonth;
        private MaterialSkin.Controls.MaterialButton BtnSetMonthYear;
    }
}