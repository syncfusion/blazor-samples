using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using BlazorDemos.Service;

namespace BlazorDemos.Shared;

public partial class SdkSwitcher
{
    private void InitializeMenu()
    {
        MenuItems = new Collection<SdkMenuItem>
        {
            CreateItem("all-demos", "All Demos", SDKType.UIEdition),
            AddChildren(new SdkMenuItem
            {
                Id = "standalone-ui-sdk",
                Text = "Standalone UI SDK",
                IconClass = CreateIconClass("standalone-ui-sdk")
            },
                BuildChild(SDKType.Grid),
                BuildChild(SDKType.Chart),
                BuildChild(SDKType.Scheduler),
                BuildChild(SDKType.Gantt),
                BuildChild(SDKType.RTE),
                BuildChild(SDKType.Diagram),
                BuildChild(SDKType.FileManager)),
            AddChildren(new SdkMenuItem
            {
                Id = "document-solutions",
                Text = "Document Solutions",
                IconClass = CreateIconClass("document-solutions")
            },
                BuildNavigation("document-sdk", "Document SDK", "https://document.syncfusion.com/#/document-sdk"),
                BuildNavigation("pdf-viewer-sdk", "PDF Viewer SDK", "https://document.syncfusion.com/demos/pdf-viewer/blazor-server/default"),
                BuildNavigation("docx-editor-sdk", "DOCX Editor SDK", "https://liveviewereditorblazorapp.azurewebsites.net/demos/docx-editor/blazor-server/document-editor/default-functionalities"),
                BuildNavigation("spreadsheet-editor-sdk", "Spreadsheet Editor SDK", "https://liveviewereditorblazorapp.azurewebsites.net/demos/spreadsheet-editor/blazor-server/spreadsheet/overview"))
        };

        CurrentSDKDisplay = ResolveDisplayText();
    }

    private static SdkMenuItem CreateItem(string id, string text, SDKType sdkType)
    {
        return new SdkMenuItem
        {
            Id = id,
            Text = text,
            IconClass = CreateIconClass(id),
            SdkType = sdkType,
            NavigateTo = "/"
        };
    }

    private static SdkMenuItem AddChildren(SdkMenuItem parent, params SdkMenuItem[] children)
    {
        foreach (var child in children)
        {
            parent.Children.Add(child);
        }
        return parent;
    }

    private static SdkMenuItem BuildNavigation(string id, string text, string url)
    {
        return new SdkMenuItem
        {
            Id = id,
            Text = text,
            IconClass = CreateIconClass(id),
            NavigateTo = url,
            OpenInNewTab = true
        };
    }

    private static SdkMenuItem BuildChild(SDKType sdk)
    {
        var id = SDKSwitcherService.GetSdkId(sdk);
        return new SdkMenuItem
        {
            Id = id,
            Text = ResolveChildLabel(sdk),
            IconClass = CreateIconClass(id),
            SdkType = sdk,
            NavigateTo = "sdk"
        };
    }

    private static string CreateIconClass(string id)
    {
        var iconBaseClass = id switch
        {
            "all-demos" or
            "grid" or
            "chart" or
            "richtexteditor" or
            "gantt" or
            "filemanager" or
            "scheduler" or
            "diagram" => "sdk-icon",
            _ => SampleUtils.SdkSwitcherIcon
        };

        return $"{iconBaseClass} sdk-switcher-icon-{id}";
    }

    private static string ResolveChildLabel(SDKType sdk)
    {
        return sdk switch
        {
            SDKType.Chart => "Charts SDK",
            SDKType.FileManager => "FileManager SDK",
            _ => SDKSwitcherService.GetSDKDisplayName(sdk)
        };
    }
}