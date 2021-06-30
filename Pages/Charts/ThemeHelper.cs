using Syncfusion.Blazor;

namespace ThemeHelper
{
    internal class ThemeHelper
    {
        internal static Theme GetCurrentTheme(string navURL)
        {
            if (navURL.IndexOf("material") > -1)
            {
                return Theme.Material;
            }
            else if (navURL.IndexOf("fabric") > -1)
            {
                return Theme.Fabric;
            }
            else if (navURL.IndexOf("bootstrap") > -1)
            {
                return Theme.Bootstrap;
            }
            else if (navURL.IndexOf("highcontrast") > -1)
            {
                return Theme.HighContrast;
            }
            else if (navURL.IndexOf("tailwind") > -1)
            {
                return Theme.Tailwind;
            }
            else
            {
                return Theme.Bootstrap4;
            }
        }
    }
}
