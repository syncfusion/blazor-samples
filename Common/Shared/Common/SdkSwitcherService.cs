using System;
using System.Collections.Generic;
using System.Linq;
using BlazorDemos.Shared;

namespace BlazorDemos.Service
{
    public enum SDKType
    {
        UIEdition,
        Grid,
        Chart,
        FileManager,
        Gantt,
        RTE,
        Scheduler,
        Diagram
    }

    public static class SDKSwitcherService
    {
        public const string UiEditionSdkId = "uiedition";
        public const string GridSdkId = "grid";
        public const string ChartSdkId = "chart";
        public const string FileManagerSdkId = "filemanager";
        public const string GanttSdkId = "gantt";
        public const string RteSdkId = "richtexteditor";
        public const string SchedulerSdkId = "scheduler";
        public const string DiagramSdkId = "diagram";
        public static bool IsInitializingFromUrl { get; set; }

        public static SDKType CurrentSDK { get; set; } = SDKType.UIEdition;
        public static string CurrentSdkId => GetSdkId(CurrentSDK);
        public static event Action? OnSDKChanged;

        public static void SetSDK(SDKType sdk)
        {
            CurrentSDK = sdk;
            ApplyVisibilityRules();
            OnSDKChanged?.Invoke();
        }


        public static void InitializeFromUrl(string? sdkId)
        {
            IsInitializingFromUrl = true;

            try
            {
                var resolvedSdk = ResolveSdk(sdkId);

                var sdkType = Enum.GetValues<SDKType>()
                    .First(x => string.Equals(
                        GetSdkId(x),
                        resolvedSdk,
                        StringComparison.OrdinalIgnoreCase));

                CurrentSDK = sdkType;
                ApplyVisibilityRules();
            }
            finally
            {
                IsInitializingFromUrl = false;
            }
        }

        public static void ApplyVisibilityRules()
        {
            ApplyVisibility(CurrentSdkId);
        }

        public static void ApplyVisibility(string? sdkId, IList<SampleList>? sampleList = null)
        {
            var resolvedSdk = ResolveSdk(sdkId);
            var items = sampleList ?? SampleBrowser.SampleList;
            foreach (var component in items)
            {
                component.IsHide = !IsVisible(component, resolvedSdk);
            }
        }

        public static string ResolveSdk(string? sdkId)
        {
            if (string.IsNullOrWhiteSpace(sdkId))
            {
                return UiEditionSdkId;
            }

            return sdkId.Trim() switch
            {
                "uiedition" or "ui-edition" or "" => UiEditionSdkId,
                "grid" or "grid-sdk" or "gridsdk" => GridSdkId,
                "chart" or "chart-sdk" or "chartsdk" => ChartSdkId,
                "filemanager" or "file-manager-sdk" or "filemanagersdk" => FileManagerSdkId,
                "gantt" or "gantt-sdk" or "ganttsdk" => GanttSdkId,
                "rte" or "rte-sdk" or "rtesdk" or "richtexteditor" => RteSdkId,
                "scheduler" or "scheduler-sdk" or "schedulersdk" => SchedulerSdkId,
                "diagram" or "diagram-sdk" or "diagramsdk" => DiagramSdkId,
                _ => UiEditionSdkId
            };
        }

        public static string GetSdkId(SDKType sdk)
        {
            return sdk switch
            {
                SDKType.UIEdition => UiEditionSdkId,
                SDKType.Grid => GridSdkId,
                SDKType.Chart => ChartSdkId,
                SDKType.FileManager => FileManagerSdkId,
                SDKType.Gantt => GanttSdkId,
                SDKType.RTE => RteSdkId,
                SDKType.Scheduler => SchedulerSdkId,
                SDKType.Diagram => DiagramSdkId,
                _ => UiEditionSdkId
            };
        }

        public static string GetDisplayName(string? sdkId)
        {
            return ResolveSdk(sdkId) switch
            {
                UiEditionSdkId => "UI Edition",
                GridSdkId => "Grid SDK",
                ChartSdkId => "Charts SDK",
                FileManagerSdkId => "FileManager SDK",
                GanttSdkId => "Gantt SDK",
                RteSdkId => "RichTextEditor SDK",
                SchedulerSdkId => "Scheduler SDK",
                DiagramSdkId => "Diagram SDK",
                _ => "UI Edition"
            };
        }

        public static string GetSDKDisplayName(SDKType sdk)
        {
            return GetDisplayName(GetSdkId(sdk));
        }

        public static bool IsVisible(SampleList component, string? sdkId)
        {
            var resolvedSdk = ResolveSdk(sdkId);
            if (component == null)
            {
                return false;
            }

            if (string.Equals(resolvedSdk, UiEditionSdkId, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            var visibleKeys = GetVisibleKeys(resolvedSdk);
            var componentKeysForSdk = GetComponentKeys(component);
            return componentKeysForSdk.Any(key => visibleKeys.Contains(key));
        }

        public static IReadOnlyList<(SDKType sdk, string displayName)> GetAvailableSDKs()
        {
            return new List<(SDKType, string)>
            {
                (SDKType.UIEdition, GetSDKDisplayName(SDKType.UIEdition)),
                (SDKType.Grid, GetSDKDisplayName(SDKType.Grid)),
                (SDKType.Chart, GetSDKDisplayName(SDKType.Chart)),
                (SDKType.FileManager, GetSDKDisplayName(SDKType.FileManager)),
                (SDKType.Gantt, GetSDKDisplayName(SDKType.Gantt)),
                (SDKType.RTE, GetSDKDisplayName(SDKType.RTE)),
                (SDKType.Scheduler, GetSDKDisplayName(SDKType.Scheduler)),
                (SDKType.Diagram, GetSDKDisplayName(SDKType.Diagram))
            };
        }

        private static HashSet<string> GetVisibleKeys(string sdkId)
        {
            return sdkId switch
            {
                GridSdkId => new HashSet<string>(StringComparer.OrdinalIgnoreCase)
                {
                    "datagrid",
                    "treegrid",
                    "pivottable"
                },
                ChartSdkId => new HashSet<string>(StringComparer.OrdinalIgnoreCase)
                {
                    "chart",
                    "chart3d",
                    "stockchart",
                    "circulargauge",
                    "lineargauge",
                    "heatmapchart",
                    "maps",
                    "rangeselector",
                    "smithchart",
                    "sparkline",
                    "barcodes",
                    "sankey",
                    "treemap",
                    "bulletchart",
                    "dashboardlayout"
                },
                FileManagerSdkId => new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "filemanager" },
                GanttSdkId => new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "ganttchart", "kanban" },
                RteSdkId => new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "richtexteditor", "blockeditor" },
                SchedulerSdkId => new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "scheduler", "calendar", "datepicker", "daterangepicker", "datetimepicker" },
                DiagramSdkId => new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "diagram" },
                _ => new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            };
        }

        private static HashSet<string> GetComponentKeys(SampleList component)
        {
            var keys = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (var value in new[] { component.ControllerName, component.Name, component.Category, component.DemoPath })
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    continue;
                }

                var normalized = NormalizeKey(value);
                if (!string.IsNullOrWhiteSpace(normalized))
                {
                    keys.Add(normalized);
                }
            }

            return keys;
        }

        private static string NormalizeKey(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return string.Empty;
            }

            return new string(value.Where(ch => char.IsLetterOrDigit(ch)).ToArray());
        }

        private const string BlazorDocsUrl = "https://blazor.syncfusion.com/documentation/";
        private const string SdkDocsUrl = "https://help.syncfusion.com/";

        private static readonly Dictionary<string, (string Sdk, string? Path)> ComponentMap =
            new(StringComparer.OrdinalIgnoreCase)
            {
                // Grid SDK
                ["datagrid"] = ("grid-sdk", "data-grid"),
                ["treegrid"] = ("grid-sdk", "tree-grid"),
                ["pivottable"] = ("grid-sdk", "pivot-table"),

                // Chart SDK
                ["chart"] = ("chart-sdk", "charts"),
                ["chart3d"] = ("chart-sdk", "3d-charts"),
                ["stockchart"] = ("chart-sdk", "stock-chart"),
                ["circulargauge"] = ("chart-sdk", "circular-gauge"),
                ["lineargauge"] = ("chart-sdk", "linear-gauge"),
                ["heatmapchart"] = ("chart-sdk", "heatmap-chart"),
                ["maps"] = ("chart-sdk", "maps"),
                ["rangeselector"] = ("chart-sdk", "range-selector"),
                ["smithchart"] = ("chart-sdk", "smith-chart"),
                ["sparkline"] = ("chart-sdk", "sparkline-charts"),
                ["barcodes"] = ("chart-sdk", "barcode-generator"),
                ["sankey"] = ("chart-sdk", "sankey-diagram"),
                ["treemap"] = ("chart-sdk", "treemap"),
                ["bulletchart"] = ("chart-sdk", "bullet-chart"),
                ["dashboardlayout"] = ("chart-sdk", "dashboard-layout"),

                // File Manager SDK
                ["filemanager"] = ("file-manager-sdk", "getting-started-with-web-app"),

                // Gantt SDK
                ["ganttchart"] = ("gantt-sdk", "gantt-chart"),
                ["kanban"] = ("gantt-sdk", "kanban"),

                // RTE SDK
                ["richtexteditor"] = ("rich-text-editor-sdk", "rich-text-editor"),
                ["blockeditor"] = ("rich-text-editor-sdk", "block-editor"),
                ["markdowneditor"] = ("rich-text-editor-sdk", "markdown-editor"),
                ["aismartrichtexteditor"] = ("rich-text-editor-sdk", "smart-rich-text-editor"),

                // Scheduler SDK
                ["scheduler"] = ("scheduler-sdk", "schedule"),
                ["calendar"] = ("scheduler-sdk", "calendar"),
                ["datepicker"] = ("scheduler-sdk", "date-picker"),
                ["daterangepicker"] = ("scheduler-sdk", "daterange-picker"),
                ["datetimepicker"] = ("scheduler-sdk", "datetime-picker"),
                ["timepicker"] = ("scheduler-sdk", "time-picker"),

                // Diagram SDK
                ["diagram"] = ("diagram-sdk", null),
            };

        private static readonly Dictionary<string, Uri> ComponentDocumentationLinkMap =
            new(StringComparer.OrdinalIgnoreCase)
            {
                ["speech-to-text"] = new Uri($"{BlazorDocsUrl}speech-to-text/getting-started-web-app", UriKind.Absolute),
                ["buttons"] = new Uri($"{BlazorDocsUrl}button/getting-started", UriKind.Absolute),
                ["fab"] = new Uri($"{BlazorDocsUrl}floating-action-button/getting-started", UriKind.Absolute),
                ["ai-smartpaste"] = new Uri($"{BlazorDocsUrl}smart-paste/getting-started", UriKind.Absolute),
                ["ai-smarttextarea"] = new Uri($"{BlazorDocsUrl}smart-textarea/getting-started", UriKind.Absolute),
            };

        public static Uri GetGettingStartedUrl(string componentName)
        {
            var originalComponentName = componentName ?? string.Empty;
            var normalizedComponentName = NormalizeKey(originalComponentName);

            if (ComponentDocumentationLinkMap.TryGetValue(originalComponentName, out var documentationLink))
            {
                return documentationLink;
            }

            if (!ComponentMap.TryGetValue(normalizedComponentName, out var mapping))
            {
                return new Uri($"{BlazorDocsUrl}{originalComponentName}/getting-started", UriKind.Absolute);
            }

            var (sdk, path) = mapping;

            var documentationUrl = path is null
                ? $"{SdkDocsUrl}{sdk}/blazor/getting-started"
                : $"{SdkDocsUrl}{sdk}/blazor/{path}" +
                  (normalizedComponentName == "filemanager" ? string.Empty : "/getting-started");

            return new Uri(documentationUrl, UriKind.Absolute);
        }
    }
}
