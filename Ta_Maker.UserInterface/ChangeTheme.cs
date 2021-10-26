using MaterialSkin.Controls;
using System;

namespace Ta_Maker.UserInterface
{
    public partial class ChangeTheme : MaterialForm
    {
        public ChangeTheme()
        {
            InitializeComponent();
            MaterialDesign.Materialize(this);
        }

        private void DarkSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (DarkSwitch.Checked)
            {
                UserInterface.Properties.Settings.Default["themeMe"] = "DARK";
                UserInterface.Properties.Settings.Default.Save();
                MaterialDesign.Materialize(this);
            }
            else
            {
                UserInterface.Properties.Settings.Default["themeMe"] = "LIGHT";
                UserInterface.Properties.Settings.Default.Save();
                MaterialDesign.Materialize(this);
            }

        }

        private void ChangeTheme_Load(object sender, EventArgs e)
        {
            string themeMe = UserInterface.Properties.Settings.Default["ThemeMe"].ToString();
            if (themeMe == "DARK")
            {
                DarkSwitch.Checked = true;
            }
            else
            {
                DarkSwitch.Checked = false;
            }
        }
    }
}
