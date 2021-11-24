
namespace Ta_Maker.UserInterface
{
    partial class DesignationEditor
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
            this.TxtDesignation = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtSortOrder = new MaterialSkin.Controls.MaterialTextBox();
            this.BtnAdd = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.GridDesignation = new System.Windows.Forms.DataGridView();
            this.BtnModify = new MaterialSkin.Controls.MaterialButton();
            this.BtnUpdate = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDesignation)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtDesignation
            // 
            this.TxtDesignation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDesignation.Depth = 0;
            this.TxtDesignation.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtDesignation.Hint = "Designation";
            this.TxtDesignation.LeadingIcon = null;
            this.TxtDesignation.Location = new System.Drawing.Point(17, 6);
            this.TxtDesignation.MaxLength = 50;
            this.TxtDesignation.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtDesignation.Multiline = false;
            this.TxtDesignation.Name = "TxtDesignation";
            this.TxtDesignation.Size = new System.Drawing.Size(274, 50);
            this.TxtDesignation.TabIndex = 1;
            this.TxtDesignation.Text = "";
            this.TxtDesignation.TrailingIcon = null;
            // 
            // TxtSortOrder
            // 
            this.TxtSortOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSortOrder.Depth = 0;
            this.TxtSortOrder.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtSortOrder.Hint = "Sort Order No.";
            this.TxtSortOrder.LeadingIcon = null;
            this.TxtSortOrder.Location = new System.Drawing.Point(312, 6);
            this.TxtSortOrder.MaxLength = 50;
            this.TxtSortOrder.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtSortOrder.Multiline = false;
            this.TxtSortOrder.Name = "TxtSortOrder";
            this.TxtSortOrder.Size = new System.Drawing.Size(139, 50);
            this.TxtSortOrder.TabIndex = 2;
            this.TxtSortOrder.Text = "";
            this.TxtSortOrder.TrailingIcon = null;
            // 
            // BtnAdd
            // 
            this.BtnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnAdd.Depth = 0;
            this.BtnAdd.HighEmphasis = true;
            this.BtnAdd.Icon = null;
            this.BtnAdd.Location = new System.Drawing.Point(476, 13);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(64, 36);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnAdd.UseAccentColor = false;
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.BtnAdd);
            this.materialCard1.Controls.Add(this.TxtSortOrder);
            this.materialCard1.Controls.Add(this.TxtDesignation);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(19, 74);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(558, 68);
            this.materialCard1.TabIndex = 0;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.GridDesignation);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(19, 150);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(558, 248);
            this.materialCard2.TabIndex = 4;
            // 
            // GridDesignation
            // 
            this.GridDesignation.AllowUserToAddRows = false;
            this.GridDesignation.AllowUserToDeleteRows = false;
            this.GridDesignation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDesignation.Location = new System.Drawing.Point(17, 7);
            this.GridDesignation.Name = "GridDesignation";
            this.GridDesignation.Size = new System.Drawing.Size(523, 236);
            this.GridDesignation.TabIndex = 5;
            // 
            // BtnModify
            // 
            this.BtnModify.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnModify.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnModify.Depth = 0;
            this.BtnModify.HighEmphasis = true;
            this.BtnModify.Icon = null;
            this.BtnModify.Location = new System.Drawing.Point(36, 402);
            this.BtnModify.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnModify.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(75, 36);
            this.BtnModify.TabIndex = 6;
            this.BtnModify.Text = "Modify";
            this.BtnModify.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnModify.UseAccentColor = false;
            this.BtnModify.UseVisualStyleBackColor = true;
            this.BtnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnUpdate.Depth = 0;
            this.BtnUpdate.HighEmphasis = true;
            this.BtnUpdate.Icon = null;
            this.BtnUpdate.Location = new System.Drawing.Point(482, 402);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(77, 36);
            this.BtnUpdate.TabIndex = 7;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnUpdate.UseAccentColor = false;
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // DesignationEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 449);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnModify);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.Name = "DesignationEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Designation Editor";
            this.Load += new System.EventHandler(this.DesignationEditor_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridDesignation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox TxtDesignation;
        private MaterialSkin.Controls.MaterialTextBox TxtSortOrder;
        private MaterialSkin.Controls.MaterialButton BtnAdd;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.DataGridView GridDesignation;
        private MaterialSkin.Controls.MaterialButton BtnModify;
        private MaterialSkin.Controls.MaterialButton BtnUpdate;
    }
}