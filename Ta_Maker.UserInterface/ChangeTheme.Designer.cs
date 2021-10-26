
namespace Ta_Maker.UserInterface
{
    partial class ChangeTheme
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
            this.DarkSwitch = new MaterialSkin.Controls.MaterialSwitch();
            this.SuspendLayout();
            // 
            // DarkSwitch
            // 
            this.DarkSwitch.AutoSize = true;
            this.DarkSwitch.Depth = 0;
            this.DarkSwitch.Location = new System.Drawing.Point(106, 132);
            this.DarkSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.DarkSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.DarkSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.DarkSwitch.Name = "DarkSwitch";
            this.DarkSwitch.Ripple = true;
            this.DarkSwitch.Size = new System.Drawing.Size(148, 37);
            this.DarkSwitch.TabIndex = 0;
            this.DarkSwitch.Text = "DARK MODE";
            this.DarkSwitch.UseVisualStyleBackColor = true;
            this.DarkSwitch.CheckedChanged += new System.EventHandler(this.DarkSwitch_CheckedChanged);
            // 
            // ChangeTheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 255);
            this.Controls.Add(this.DarkSwitch);
            this.Name = "ChangeTheme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Theme";
            this.Load += new System.EventHandler(this.ChangeTheme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSwitch DarkSwitch;
    }
}