
namespace Ta_Maker
{
    partial class UnitSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitSetting));
            this.CmbUnitName = new MaterialSkin.Controls.MaterialComboBox();
            this.BtnDefaltUnit = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.btnAddUnits = new MaterialSkin.Controls.MaterialButton();
            this.TxtSourceName = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmbUnitName
            // 
            this.CmbUnitName.AutoResize = false;
            this.CmbUnitName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CmbUnitName.Depth = 0;
            this.CmbUnitName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CmbUnitName.DropDownHeight = 174;
            this.CmbUnitName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbUnitName.DropDownWidth = 121;
            this.CmbUnitName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CmbUnitName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CmbUnitName.FormattingEnabled = true;
            this.CmbUnitName.Hint = "Select Unit Name";
            this.CmbUnitName.IntegralHeight = false;
            this.CmbUnitName.ItemHeight = 43;
            this.CmbUnitName.Location = new System.Drawing.Point(19, 17);
            this.CmbUnitName.MaxDropDownItems = 4;
            this.CmbUnitName.MouseState = MaterialSkin.MouseState.OUT;
            this.CmbUnitName.Name = "CmbUnitName";
            this.CmbUnitName.Size = new System.Drawing.Size(306, 49);
            this.CmbUnitName.StartIndex = 0;
            this.CmbUnitName.TabIndex = 5;
            // 
            // BtnDefaltUnit
            // 
            this.BtnDefaltUnit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnDefaltUnit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnDefaltUnit.Depth = 0;
            this.BtnDefaltUnit.HighEmphasis = true;
            this.BtnDefaltUnit.Icon = null;
            this.BtnDefaltUnit.Location = new System.Drawing.Point(80, 84);
            this.BtnDefaltUnit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnDefaltUnit.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnDefaltUnit.Name = "BtnDefaltUnit";
            this.BtnDefaltUnit.Size = new System.Drawing.Size(173, 36);
            this.BtnDefaltUnit.TabIndex = 6;
            this.BtnDefaltUnit.Text = "SET AS DEFAULT UNIT";
            this.BtnDefaltUnit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnDefaltUnit.UseAccentColor = false;
            this.BtnDefaltUnit.UseVisualStyleBackColor = true;
            this.BtnDefaltUnit.Click += new System.EventHandler(this.BtnDefaltUnit_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.CmbUnitName);
            this.materialCard1.Controls.Add(this.BtnDefaltUnit);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 163);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(342, 131);
            this.materialCard1.TabIndex = 7;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.btnAddUnits);
            this.materialCard2.Controls.Add(this.TxtSourceName);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(17, 78);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(342, 67);
            this.materialCard2.TabIndex = 8;
            // 
            // btnAddUnits
            // 
            this.btnAddUnits.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddUnits.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddUnits.Depth = 0;
            this.btnAddUnits.HighEmphasis = true;
            this.btnAddUnits.Icon = null;
            this.btnAddUnits.Location = new System.Drawing.Point(237, 16);
            this.btnAddUnits.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddUnits.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddUnits.Name = "btnAddUnits";
            this.btnAddUnits.Size = new System.Drawing.Size(87, 36);
            this.btnAddUnits.TabIndex = 21;
            this.btnAddUnits.Text = "ADD UNIT";
            this.btnAddUnits.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddUnits.UseAccentColor = false;
            this.btnAddUnits.UseVisualStyleBackColor = true;
            this.btnAddUnits.Click += new System.EventHandler(this.btnAddUnits_Click);
            // 
            // TxtSourceName
            // 
            this.TxtSourceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSourceName.Depth = 0;
            this.TxtSourceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtSourceName.Hint = "Enter Unit Name";
            this.TxtSourceName.LeadingIcon = null;
            this.TxtSourceName.Location = new System.Drawing.Point(19, 8);
            this.TxtSourceName.MaxLength = 50;
            this.TxtSourceName.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtSourceName.Multiline = false;
            this.TxtSourceName.Name = "TxtSourceName";
            this.TxtSourceName.Size = new System.Drawing.Size(197, 50);
            this.TxtSourceName.TabIndex = 20;
            this.TxtSourceName.Text = "";
            this.TxtSourceName.TrailingIcon = null;
            // 
            // UnitSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 309);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UnitSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unit Setting";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UnitSetting_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialComboBox CmbUnitName;
        private MaterialSkin.Controls.MaterialButton BtnDefaltUnit;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialButton btnAddUnits;
        private MaterialSkin.Controls.MaterialTextBox TxtSourceName;
    }
}