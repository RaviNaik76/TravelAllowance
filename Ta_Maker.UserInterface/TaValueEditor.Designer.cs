
namespace Ta_Maker.UserInterface
{
    partial class TaValueEditor
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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.BtnModify = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.BtnUpdate = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.CmbEmpClass = new MaterialSkin.Controls.MaterialComboBox();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.TxtBangloreTa = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtMetroTa = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtNormalTa = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.TxtOutMetroTa = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtOutNormalTa = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.BtnModify);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.BtnUpdate);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.CmbEmpClass);
            this.materialCard1.Controls.Add(this.materialCard2);
            this.materialCard1.Controls.Add(this.materialCard3);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 118);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(602, 325);
            this.materialCard1.TabIndex = 0;
            // 
            // BtnModify
            // 
            this.BtnModify.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnModify.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnModify.Depth = 0;
            this.BtnModify.HighEmphasis = true;
            this.BtnModify.Icon = null;
            this.BtnModify.Location = new System.Drawing.Point(314, 267);
            this.BtnModify.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnModify.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(75, 36);
            this.BtnModify.TabIndex = 9;
            this.BtnModify.Text = "Modify";
            this.BtnModify.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnModify.UseAccentColor = false;
            this.BtnModify.UseVisualStyleBackColor = true;
            this.BtnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(79, 97);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(147, 19);
            this.materialLabel3.TabIndex = 15;
            this.materialLabel3.Text = "Out of State Journey";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnUpdate.Depth = 0;
            this.BtnUpdate.Enabled = false;
            this.BtnUpdate.HighEmphasis = true;
            this.BtnUpdate.Icon = null;
            this.BtnUpdate.Location = new System.Drawing.Point(212, 267);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(77, 36);
            this.BtnUpdate.TabIndex = 10;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnUpdate.UseAccentColor = false;
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(363, 15);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(179, 19);
            this.materialLabel2.TabIndex = 14;
            this.materialLabel2.Text = "Journey Within The State";
            // 
            // CmbEmpClass
            // 
            this.CmbEmpClass.AutoResize = false;
            this.CmbEmpClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CmbEmpClass.Depth = 0;
            this.CmbEmpClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CmbEmpClass.DropDownHeight = 174;
            this.CmbEmpClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEmpClass.DropDownWidth = 121;
            this.CmbEmpClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CmbEmpClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CmbEmpClass.FormattingEnabled = true;
            this.CmbEmpClass.Hint = "Select Employee Group";
            this.CmbEmpClass.IntegralHeight = false;
            this.CmbEmpClass.ItemHeight = 43;
            this.CmbEmpClass.Location = new System.Drawing.Point(21, 27);
            this.CmbEmpClass.MaxDropDownItems = 4;
            this.CmbEmpClass.MouseState = MaterialSkin.MouseState.OUT;
            this.CmbEmpClass.Name = "CmbEmpClass";
            this.CmbEmpClass.Size = new System.Drawing.Size(268, 49);
            this.CmbEmpClass.StartIndex = 0;
            this.CmbEmpClass.TabIndex = 1;
            this.CmbEmpClass.SelectedIndexChanged += new System.EventHandler(this.CmbEmpClass_SelectedIndexChanged);
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.TxtBangloreTa);
            this.materialCard2.Controls.Add(this.TxtMetroTa);
            this.materialCard2.Controls.Add(this.TxtNormalTa);
            this.materialCard2.Depth = 0;
            this.materialCard2.Enabled = false;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(314, 28);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(272, 219);
            this.materialCard2.TabIndex = 5;
            // 
            // TxtBangloreTa
            // 
            this.TxtBangloreTa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBangloreTa.Depth = 0;
            this.TxtBangloreTa.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBangloreTa.Hint = "Banglore T.A";
            this.TxtBangloreTa.LeadingIcon = null;
            this.TxtBangloreTa.Location = new System.Drawing.Point(22, 13);
            this.TxtBangloreTa.MaxLength = 50;
            this.TxtBangloreTa.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtBangloreTa.Multiline = false;
            this.TxtBangloreTa.Name = "TxtBangloreTa";
            this.TxtBangloreTa.Size = new System.Drawing.Size(228, 50);
            this.TxtBangloreTa.TabIndex = 6;
            this.TxtBangloreTa.Text = "";
            this.TxtBangloreTa.TrailingIcon = null;
            // 
            // TxtMetroTa
            // 
            this.TxtMetroTa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMetroTa.Depth = 0;
            this.TxtMetroTa.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtMetroTa.Hint = "Metro T.A";
            this.TxtMetroTa.LeadingIcon = null;
            this.TxtMetroTa.Location = new System.Drawing.Point(22, 156);
            this.TxtMetroTa.MaxLength = 50;
            this.TxtMetroTa.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtMetroTa.Multiline = false;
            this.TxtMetroTa.Name = "TxtMetroTa";
            this.TxtMetroTa.Size = new System.Drawing.Size(228, 50);
            this.TxtMetroTa.TabIndex = 8;
            this.TxtMetroTa.Text = "";
            this.TxtMetroTa.TrailingIcon = null;
            // 
            // TxtNormalTa
            // 
            this.TxtNormalTa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNormalTa.Depth = 0;
            this.TxtNormalTa.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtNormalTa.Hint = "Normal T.A";
            this.TxtNormalTa.LeadingIcon = null;
            this.TxtNormalTa.Location = new System.Drawing.Point(22, 98);
            this.TxtNormalTa.MaxLength = 50;
            this.TxtNormalTa.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtNormalTa.Multiline = false;
            this.TxtNormalTa.Name = "TxtNormalTa";
            this.TxtNormalTa.Size = new System.Drawing.Size(228, 50);
            this.TxtNormalTa.TabIndex = 7;
            this.TxtNormalTa.Text = "";
            this.TxtNormalTa.TrailingIcon = null;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.TxtOutMetroTa);
            this.materialCard3.Controls.Add(this.TxtOutNormalTa);
            this.materialCard3.Depth = 0;
            this.materialCard3.Enabled = false;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(17, 111);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(272, 136);
            this.materialCard3.TabIndex = 2;
            // 
            // TxtOutMetroTa
            // 
            this.TxtOutMetroTa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtOutMetroTa.Depth = 0;
            this.TxtOutMetroTa.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtOutMetroTa.Hint = "Out of State Metro T.A";
            this.TxtOutMetroTa.LeadingIcon = null;
            this.TxtOutMetroTa.Location = new System.Drawing.Point(22, 73);
            this.TxtOutMetroTa.MaxLength = 50;
            this.TxtOutMetroTa.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtOutMetroTa.Multiline = false;
            this.TxtOutMetroTa.Name = "TxtOutMetroTa";
            this.TxtOutMetroTa.Size = new System.Drawing.Size(228, 50);
            this.TxtOutMetroTa.TabIndex = 4;
            this.TxtOutMetroTa.Text = "";
            this.TxtOutMetroTa.TrailingIcon = null;
            // 
            // TxtOutNormalTa
            // 
            this.TxtOutNormalTa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtOutNormalTa.Depth = 0;
            this.TxtOutNormalTa.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtOutNormalTa.Hint = "Out of State Normal T.A";
            this.TxtOutNormalTa.LeadingIcon = null;
            this.TxtOutNormalTa.Location = new System.Drawing.Point(22, 15);
            this.TxtOutNormalTa.MaxLength = 50;
            this.TxtOutNormalTa.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtOutNormalTa.Multiline = false;
            this.TxtOutNormalTa.Name = "TxtOutNormalTa";
            this.TxtOutNormalTa.Size = new System.Drawing.Size(228, 50);
            this.TxtOutNormalTa.TabIndex = 3;
            this.TxtOutNormalTa.Text = "";
            this.TxtOutNormalTa.TrailingIcon = null;
            // 
            // TaValueEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 462);
            this.Controls.Add(this.materialCard1);
            this.Name = "TaValueEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ta Value Editor";
            this.Load += new System.EventHandler(this.TaValueEditor_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton BtnModify;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton BtnUpdate;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialComboBox CmbEmpClass;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialTextBox TxtBangloreTa;
        private MaterialSkin.Controls.MaterialTextBox TxtMetroTa;
        private MaterialSkin.Controls.MaterialTextBox TxtNormalTa;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialTextBox TxtOutMetroTa;
        private MaterialSkin.Controls.MaterialTextBox TxtOutNormalTa;
    }
}