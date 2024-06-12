#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Blazor;

namespace ThemeHelper
{
    internal class ThemeHelper
    {
        internal static Theme GetCurrentTheme(string navURL)
        {
            if (navURL.IndexOf("material3") > -1)
            {
                if (navURL.IndexOf("dark") > -1)
                {
                    return Theme.Material3Dark;
                }
                else
                {
                    return Theme.Material3;
                }
            }
            else if (navURL.IndexOf("material") > -1)
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
            else if (navURL.IndexOf("fluent2") > -1)
            {
                //if(navURL.IndexOf("highcontrast") > -1)
                //{
                //    return Theme.Fluent2HighContrast;
                //}
                if (navURL.IndexOf("dark") > -1)
                {
                    return Theme.Fluent2Dark;
                }
                else
                {
                    return Theme.Fluent2;
                }
            }
            else if (navURL.IndexOf("fluent") > -1)
            {
                if (navURL.IndexOf("dark") > -1)
                {
                    return Theme.FluentDark;
                }
                else
                {
                    return Theme.Fluent;
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

        internal static string GetFontFamily(string currentUri)
        {
            return (currentUri.IndexOf("fabric") > -1 || currentUri.IndexOf("fluent") > -1 || currentUri.IndexOf("highcontrast") > -1) ? "Segoe UI" : currentUri.IndexOf("bootstrap") > -1 ? "Helvetica" : currentUri.IndexOf("material") > -1 ? "Roboto" : "Inter";
        }
    }
}
