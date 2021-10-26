using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace Ta_Maker
{
    class MaterialDesign
    {
        public static void Materialize(Form form)
        {
            string themeMe = UserInterface.Properties.Settings.Default["ThemeMe"].ToString();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            if (themeMe == "DARK")
            {
                materialSkinManager.AddFormToManage((MaterialForm)form);
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

                materialSkinManager.ColorScheme = new ColorScheme(
                    Primary.BlueGrey800, Primary.BlueGrey900,
                    Primary.BlueGrey500, Accent.LightBlue200,
                    TextShade.WHITE);
            }
            else
            {
                materialSkinManager.AddFormToManage((MaterialForm)form);
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

                materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE);
            }
        }
    }
}
