
namespace Ta_Maker.UserInterface
{
    partial class AddUnits
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
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnAddUnits = new MaterialSkin.Controls.MaterialButton();
            this.TxtPlaceName2 = new MaterialSkin.Controls.MaterialTextBox();
            this.CmbOfficeType2 = new MaterialSkin.Controls.MaterialComboBox();
            this.CmbDistrict = new MaterialSkin.Controls.MaterialComboBox();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.BtnSaveDist = new MaterialSkin.Controls.MaterialButton();
            this.TxtPlaceName = new MaterialSkin.Controls.MaterialTextBox();
            this.CmbOfficeType = new MaterialSkin.Controls.MaterialComboBox();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.LblMsg = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(363, 113);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(72, 19);
            this.materialLabel2.TabIndex = 21;
            this.materialLabel2.Text = "ADD UNIT";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(89, 116);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(106, 19);
            this.materialLabel1.TabIndex = 20;
            this.materialLabel1.Text = "ADD DISTRICT";
            // 
            // btnAddUnits
            // 
            this.btnAddUnits.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddUnits.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddUnits.Depth = 0;
            this.btnAddUnits.HighEmphasis = true;
            this.btnAddUnits.Icon = null;
            this.btnAddUnits.Location = new System.Drawing.Point(352, 359);
            this.btnAddUnits.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddUnits.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddUnits.Name = "btnAddUnits";
            this.btnAddUnits.Size = new System.Drawing.Size(87, 36);
            this.btnAddUnits.TabIndex = 19;
            this.btnAddUnits.Text = "ADD UNIT";
            this.btnAddUnits.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddUnits.UseAccentColor = false;
            this.btnAddUnits.UseVisualStyleBackColor = true;
            this.btnAddUnits.Click += new System.EventHandler(this.btnAddUnits_Click);
            // 
            // TxtPlaceName2
            // 
            this.TxtPlaceName2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPlaceName2.Depth = 0;
            this.TxtPlaceName2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtPlaceName2.Hint = "Enter Unit Name";
            this.TxtPlaceName2.LeadingIcon = null;
            this.TxtPlaceName2.Location = new System.Drawing.Point(305, 289);
            this.TxtPlaceName2.MaxLength = 50;
            this.TxtPlaceName2.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtPlaceName2.Multiline = false;
            this.TxtPlaceName2.Name = "TxtPlaceName2";
            this.TxtPlaceName2.Size = new System.Drawing.Size(197, 50);
            this.TxtPlaceName2.TabIndex = 18;
            this.TxtPlaceName2.Text = "";
            this.TxtPlaceName2.TrailingIcon = null;
            // 
            // CmbOfficeType2
            // 
            this.CmbOfficeType2.AutoResize = false;
            this.CmbOfficeType2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CmbOfficeType2.Depth = 0;
            this.CmbOfficeType2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CmbOfficeType2.DropDownHeight = 174;
            this.CmbOfficeType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbOfficeType2.DropDownWidth = 121;
            this.CmbOfficeType2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CmbOfficeType2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CmbOfficeType2.FormattingEnabled = true;
            this.CmbOfficeType2.Hint = "Select Office Type";
            this.CmbOfficeType2.IntegralHeight = false;
            this.CmbOfficeType2.ItemHeight = 43;
            this.CmbOfficeType2.Location = new System.Drawing.Point(304, 220);
            this.CmbOfficeType2.MaxDropDownItems = 4;
            this.CmbOfficeType2.MouseState = MaterialSkin.MouseState.OUT;
            this.CmbOfficeType2.Name = "CmbOfficeType2";
            this.CmbOfficeType2.Size = new System.Drawing.Size(198, 49);
            this.CmbOfficeType2.StartIndex = 0;
            this.CmbOfficeType2.TabIndex = 17;
            // 
            // CmbDistrict
            // 
            this.CmbDistrict.AutoResize = false;
            this.CmbDistrict.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CmbDistrict.Depth = 0;
            this.CmbDistrict.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CmbDistrict.DropDownHeight = 174;
            this.CmbDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDistrict.DropDownWidth = 121;
            this.CmbDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CmbDistrict.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CmbDistrict.FormattingEnabled = true;
            this.CmbDistrict.Hint = "Select District";
            this.CmbDistrict.IntegralHeight = false;
            this.CmbDistrict.ItemHeight = 43;
            this.CmbDistrict.Location = new System.Drawing.Point(303, 150);
            this.CmbDistrict.MaxDropDownItems = 4;
            this.CmbDistrict.MouseState = MaterialSkin.MouseState.OUT;
            this.CmbDistrict.Name = "CmbDistrict";
            this.CmbDistrict.Size = new System.Drawing.Size(199, 49);
            this.CmbDistrict.StartIndex = 0;
            this.CmbDistrict.TabIndex = 16;
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(286, 124);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(237, 283);
            this.materialDivider2.TabIndex = 15;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // BtnSaveDist
            // 
            this.BtnSaveDist.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSaveDist.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnSaveDist.Depth = 0;
            this.BtnSaveDist.HighEmphasis = true;
            this.BtnSaveDist.Icon = null;
            this.BtnSaveDist.Location = new System.Drawing.Point(77, 359);
            this.BtnSaveDist.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnSaveDist.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSaveDist.Name = "BtnSaveDist";
            this.BtnSaveDist.Size = new System.Drawing.Size(118, 36);
            this.BtnSaveDist.TabIndex = 14;
            this.BtnSaveDist.Text = "ADD DISTRICT";
            this.BtnSaveDist.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnSaveDist.UseAccentColor = false;
            this.BtnSaveDist.UseVisualStyleBackColor = true;
            this.BtnSaveDist.Click += new System.EventHandler(this.BtnSaveDist_Click);
            // 
            // TxtPlaceName
            // 
            this.TxtPlaceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPlaceName.Depth = 0;
            this.TxtPlaceName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtPlaceName.Hint = "Enter District Name";
            this.TxtPlaceName.LeadingIcon = null;
            this.TxtPlaceName.Location = new System.Drawing.Point(42, 219);
            this.TxtPlaceName.MaxLength = 50;
            this.TxtPlaceName.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtPlaceName.Multiline = false;
            this.TxtPlaceName.Name = "TxtPlaceName";
            this.TxtPlaceName.Size = new System.Drawing.Size(208, 50);
            this.TxtPlaceName.TabIndex = 13;
            this.TxtPlaceName.Text = "";
            this.TxtPlaceName.TrailingIcon = null;
            // 
            // CmbOfficeType
            // 
            this.CmbOfficeType.AutoResize = false;
            this.CmbOfficeType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CmbOfficeType.Depth = 0;
            this.CmbOfficeType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CmbOfficeType.DropDownHeight = 174;
            this.CmbOfficeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbOfficeType.DropDownWidth = 121;
            this.CmbOfficeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CmbOfficeType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CmbOfficeType.FormattingEnabled = true;
            this.CmbOfficeType.Hint = "Select Office Type";
            this.CmbOfficeType.IntegralHeight = false;
            this.CmbOfficeType.ItemHeight = 43;
            this.CmbOfficeType.Location = new System.Drawing.Point(42, 150);
            this.CmbOfficeType.MaxDropDownItems = 4;
            this.CmbOfficeType.MouseState = MaterialSkin.MouseState.OUT;
            this.CmbOfficeType.Name = "CmbOfficeType";
            this.CmbOfficeType.Size = new System.Drawing.Size(208, 49);
            this.CmbOfficeType.StartIndex = 0;
            this.CmbOfficeType.TabIndex = 12;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(19, 125);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(253, 282);
            this.materialDivider1.TabIndex = 11;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // LblMsg
            // 
            this.LblMsg.AutoSize = true;
            this.LblMsg.Depth = 0;
            this.LblMsg.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblMsg.Location = new System.Drawing.Point(220, 74);
            this.LblMsg.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(1, 0);
            this.LblMsg.TabIndex = 22;
            // 
            // AddUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 427);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnAddUnits);
            this.Controls.Add(this.TxtPlaceName2);
            this.Controls.Add(this.CmbOfficeType2);
            this.Controls.Add(this.CmbDistrict);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.BtnSaveDist);
            this.Controls.Add(this.TxtPlaceName);
            this.Controls.Add(this.CmbOfficeType);
            this.Controls.Add(this.materialDivider1);
            this.Name = "AddUnits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Units";
            this.Load += new System.EventHandler(this.AddUnits_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnAddUnits;
        private MaterialSkin.Controls.MaterialTextBox TxtPlaceName2;
        private MaterialSkin.Controls.MaterialComboBox CmbOfficeType2;
        private MaterialSkin.Controls.MaterialComboBox CmbDistrict;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialButton BtnSaveDist;
        private MaterialSkin.Controls.MaterialTextBox TxtPlaceName;
        private MaterialSkin.Controls.MaterialComboBox CmbOfficeType;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel LblMsg;
    }
}