using System;
using Syncfusion.Blazor;

namespace BlazorDemos
{
    internal static class SunburstThemeColors
    {
        internal static string[] GetDefaultPalette(Theme theme)
        {
            return theme switch
            {
                Theme.Material3 => new[]
                {
                    "#B3261E", "#6750A4", "#386A20", "#0061A4",
                    "#825500", "#7A5800", "#006874", "#9A4521"
                },
                Theme.Material3Dark => new[]
                {
                    "#EFB8C8", "#D0BCFF", "#A6F0C6", "#9CCAFF",
                    "#FFD8A8", "#F2D58F", "#80D4E5", "#FFCBA4"
                },
                Theme.Fluent2 => new[]
                {
                    "#A4262C", "#5C2D91", "#107C10", "#0078D4",
                    "#C19C00", "#881798", "#008272", "#005E50"
                },
                Theme.Fluent2Dark => new[]
                {
                    "#FF8C42", "#B59CFF", "#7CE0A8", "#5BA8FF",
                    "#FFE07A", "#F4729D", "#5BE0D2", "#9D5DFF"
                },
                Theme.HighContrast => new[]
                {
                    "#FF0000", "#FFFF00", "#00FF00", "#00FFFF",
                    "#FF00FF", "#FF7A00", "#7CFC00", "#FFFFFF"
                },
                Theme.Bootstrap5 => new[]
                {
                    "#DC3545", "#6610F2", "#198754", "#0D6EFD",
                    "#FD7E14", "#FFC107", "#0DCAF0", "#D63384"
                },
                Theme.Bootstrap5Dark => new[]
                {
                    "#DC3545", "#6610F2", "#198754", "#0D6EFD",
                    "#FD7E14", "#FFC107", "#0DCAF0", "#D63384"
                },
                Theme.Tailwind => new[]
                {
                    "#EF4444", "#8B5CF6", "#10B981", "#3B82F6",
                    "#F97316", "#EAB308", "#06B6D4", "#EC4899"
                },
                Theme.TailwindDark => new[]
                {
                    "#EF4444", "#8B5CF6", "#10B981", "#3B82F6",
                    "#F97316", "#EAB308", "#06B6D4", "#EC4899"
                },
                _ => new[]
                {
                    "#E53935", "#8E24AA", "#43A047", "#1E88E5",
                    "#FB8C00", "#FDD835", "#00ACC1", "#F4511E"
                }
            };
        }

        internal static string[] GetLegendPalette(Theme theme)
        {
            return theme switch
            {
                Theme.Material3 => new[]
                {
                    "#0F7B6C", "#E58A3A", "#1F6FB2", "#C24A6A",
                    "#6750A4", "#006874", "#7A5800", "#9A4521"
                },
                Theme.Material3Dark => new[]
                {
                    "#5DD9C1", "#F2B27A", "#7CB6E8", "#E89AB4",
                    "#D0BCFF", "#80D4E5", "#F2D58F", "#FFCBA4"
                },
                Theme.Fluent2 => new[]
                {
                    "#107C10", "#D83B01", "#0078D4", "#A4262C",
                    "#5C2D91", "#008272", "#C19C00", "#881798"
                },
                Theme.Fluent2Dark => new[]
                {
                    "#7CE0A8", "#FFB070", "#5BA8FF", "#FF8C42",
                    "#B59CFF", "#5BE0D2", "#FFE07A", "#F4729D"
                },
                Theme.HighContrast => new[]
                {
                    "#00FF00", "#FF8A00", "#00C8FF", "#FF1493",
                    "#FF7A00", "#7CFC00", "#FFFF00", "#FFFFFF"
                },
                Theme.Bootstrap5 => new[]
                {
                    "#0D9488", "#FD7E14", "#0D6EFD", "#D63384",
                    "#6610F2", "#0DCAF0", "#FFC107", "#198754"
                },
                Theme.Bootstrap5Dark => new[]
                {
                    "#20C997", "#FF922B", "#3D8BFD", "#F06595",
                    "#845EF7", "#39D8F4", "#FFD43B", "#51CF66"
                },
                Theme.Tailwind => new[]
                {
                    "#14B8A6", "#F97316", "#3B82F6", "#EC4899",
                    "#8B5CF6", "#06B6D4", "#F59E0B", "#10B981"
                },
                Theme.TailwindDark => new[]
                {
                    "#2DD4BF", "#FB923C", "#60A5FA", "#F472B6",
                    "#A78BFA", "#22D3EE", "#FBBF24", "#34D399"
                },
                _ => new[]
                {
                    "#0F7B6C", "#E58A3A", "#1F6FB2", "#C24A6A",
                    "#27AE60", "#117A65", "#D68910", "#A04000"
                }
            };
        }

        internal static string[] GetDrilldownPalette(Theme theme)
        {
            return theme switch
            {
                Theme.Material3 => new[]
                {
                    "#0061A4", "#386A20", "#B3261E", "#825500",
                    "#6750A4", "#006874", "#7A5800", "#9A4521"
                },
                Theme.Material3Dark => new[]
                {
                    "#9CCAFF", "#A6F0C6", "#EFB8C8", "#FFD8A8",
                    "#D0BCFF", "#80D4E5", "#F2D58F", "#FFCBA4"
                },
                Theme.Fluent2 => new[]
                {
                    "#0078D4", "#107C10", "#A4262C", "#C19C00",
                    "#5C2D91", "#008272", "#881798", "#005E50"
                },
                Theme.Fluent2Dark => new[]
                {
                    "#5BA8FF", "#7CE0A8", "#FF8C42", "#FFE07A",
                    "#B59CFF", "#5BE0D2", "#F4729D", "#9D5DFF"
                },
                Theme.HighContrast => new[]
                {
                    "#00A2ED", "#00FF00", "#FF0000", "#FFB900",
                    "#FF00FF", "#00FFFF", "#E81123", "#7A28C0"
                },
                Theme.Bootstrap5 => new[]
                {
                    "#0D6EFD", "#198754", "#DC3545", "#FFC107",
                    "#6F42C1", "#0DCAF0", "#6610F2", "#D63384"
                },
                Theme.Bootstrap5Dark => new[]
                {
                    "#0D6EFD", "#198754", "#DC3545", "#FFC107",
                    "#6F42C1", "#0DCAF0", "#6610F2", "#D63384"
                },
                Theme.Tailwind => new[]
                {
                    "#3B82F6", "#10B981", "#EF4444", "#F59E0B",
                    "#8B5CF6", "#06B6D4", "#EC4899", "#EAB308"
                },
                Theme.TailwindDark => new[]
                {
                    "#3B82F6", "#10B981", "#EF4444", "#F59E0B",
                    "#8B5CF6", "#06B6D4", "#EC4899", "#EAB308"
                },
                _ => new[]
                {
                    "#2980B9", "#27AE60", "#C0392B", "#D68910",
                    "#7D3C98", "#117A65", "#B7950B", "#A04000"
                }
            };
        }

        internal static string[] GetSelectionPalette(Theme theme)
        {
            return theme switch
            {
                Theme.Material3 => new[]
                {
                    "#6750A4", "#0061A4", "#386A20", "#B3261E",
                    "#825500", "#006874", "#7A5800", "#9A4521"
                },
                Theme.Material3Dark => new[]
                {
                    "#D0BCFF", "#9CCAFF", "#A6F0C6", "#EFB8C8",
                    "#FFD8A8", "#80D4E5", "#F2D58F", "#FFCBA4"
                },
                Theme.Fluent2 => new[]
                {
                    "#5C2D91", "#0078D4", "#107C10", "#A4262C",
                    "#C19C00", "#008272", "#881798", "#005E50"
                },
                Theme.Fluent2Dark => new[]
                {
                    "#B59CFF", "#5BA8FF", "#7CE0A8", "#FF8C42",
                    "#FFE07A", "#5BE0D2", "#F4729D", "#9D5DFF"
                },
                Theme.HighContrast => new[]
                {
                    "#FFFF00", "#00FFFF", "#7CFC00", "#FF7A00",
                    "#FF00FF", "#FFFFFF", "#00FFAA", "#FFD700"
                },
                Theme.Bootstrap5 => new[]
                {
                    "#6610F2", "#0D6EFD", "#198754", "#DC3545",
                    "#FD7E14", "#0DCAF0", "#D63384", "#FFC107"
                },
                Theme.Bootstrap5Dark => new[]
                {
                    "#6610F2", "#0D6EFD", "#198754", "#DC3545",
                    "#FD7E14", "#0DCAF0", "#D63384", "#FFC107"
                },
                Theme.Tailwind => new[]
                {
                    "#8B5CF6", "#3B82F6", "#10B981", "#EF4444",
                    "#F97316", "#06B6D4", "#EC4899", "#F59E0B"
                },
                Theme.TailwindDark => new[]
                {
                    "#8B5CF6", "#3B82F6", "#10B981", "#EF4444",
                    "#F97316", "#06B6D4", "#EC4899", "#F59E0B"
                },
                _ => new[]
                {
                    "#8E24AA", "#1E88E5", "#43A047", "#E53935",
                    "#FB8C00", "#00ACC1", "#FDD835", "#F4511E"
                }
            };
        }

        internal static string[] GetPrintExportPalette(Theme theme)
        {
            return theme switch
            {
                Theme.Material3 => new[]
                {
                    "#0061A4", "#386A20", "#B3261E", "#825500",
                    "#6750A4", "#006874", "#7A5800", "#9A4521"
                },
                Theme.Material3Dark => new[]
                {
                    "#9CCAFF", "#A6F0C6", "#EFB8C8", "#FFD8A8",
                    "#D0BCFF", "#80D4E5", "#F2D58F", "#FFCBA4"
                },
                Theme.Fluent2 => new[]
                {
                    "#0078D4", "#107C10", "#A4262C", "#C19C00",
                    "#5C2D91", "#008272", "#881798", "#005E50"
                },
                Theme.Fluent2Dark => new[]
                {
                    "#5BA8FF", "#7CE0A8", "#FF8C42", "#FFE07A",
                    "#B59CFF", "#5BE0D2", "#F4729D", "#9D5DFF"
                },
                Theme.HighContrast => new[]
                {
                    "#00A2ED", "#00FF00", "#FF0000", "#FFB900",
                    "#FF00FF", "#00FFFF", "#E81123", "#7A28C0"
                },
                Theme.Bootstrap5 => new[]
                {
                    "#0D6EFD", "#198754", "#DC3545", "#FFC107",
                    "#6F42C1", "#0DCAF0", "#6610F2", "#D63384"
                },
                Theme.Bootstrap5Dark => new[]
                {
                    "#0D6EFD", "#198754", "#DC3545", "#FFC107",
                    "#6F42C1", "#0DCAF0", "#6610F2", "#D63384"
                },
                Theme.Tailwind => new[]
                {
                    "#3B82F6", "#10B981", "#EF4444", "#F59E0B",
                    "#8B5CF6", "#06B6D4", "#EC4899", "#EAB308"
                },
                Theme.TailwindDark => new[]
                {
                    "#3B82F6", "#10B981", "#EF4444", "#F59E0B",
                    "#8B5CF6", "#06B6D4", "#EC4899", "#EAB308"
                },
                _ => new[]
                {
                    "#2980B9", "#27AE60", "#C0392B", "#D68910",
                    "#7D3C98", "#117A65", "#B7950B", "#A04000"
                }
            };
        }
    }
}
