using Syncfusion.Blazor;

namespace ThemeHelper
{
    internal class ThemeHelper
    {
        internal static Theme GetCurrentTheme(string navURL)
        {
            if (navURL.IndexOf("material") > -1)
            {
                if (navURL.IndexOf("dark") > -1)
                {
                    return Theme.MaterialDark;
                }
                else
                {
                    return Theme.Material;
                }
            }
            else if (navURL.IndexOf("fabric") > -1)
            {
                if (navURL.IndexOf("dark") > -1)
                {
                    return Theme.FabricDark;
                }
                else
                {
                    return Theme.Fabric;
                }
            }
            else if (navURL.IndexOf("bootstrap5") > -1)
            {
                if (navURL.IndexOf("dark") > -1)
                {
                    return Theme.Bootstrap5Dark;
                }
                else
                {
                    return Theme.Bootstrap5;
                }
            }
            else if (navURL.IndexOf("bootstrap4") > -1)
            {
                return Theme.Bootstrap4;
            }
            else if (navURL.IndexOf("bootstrap") > -1)
            {
                if (navURL.IndexOf("dark") > -1)
                {
                    return Theme.BootstrapDark;
                }
                else
                {
                    return Theme.Bootstrap;
                }
            }
            else if (navURL.IndexOf("tailwind") > -1)
            {
                if (navURL.IndexOf("dark") > -1)
                {
                    return Theme.TailwindDark;
                }
                else
                {
                    return Theme.Tailwind;
                }
            }
            else if (navURL.IndexOf("highcontrast") > -1)
            {
                return Theme.HighContrast;
            }
            else
            {
                return Theme.Bootstrap4;
            }
        }
    }
}
