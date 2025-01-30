#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Blazor_MAUI_Demos.Shared;
using Microsoft.AspNetCore.Components.WebView.Maui;
using Syncfusion.Blazor.Popups;
using Syncfusion.Blazor;
using System.Globalization;

namespace Blazor_MAUI_Demos;

public static class MauiProgram
{
   public static MauiApp CreateMauiApp()
   {
      var builder = MauiApp.CreateBuilder();
      builder
          .UseMauiApp<App>()
          .ConfigureFonts(fonts =>
          {
	      fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
	   });

      builder.Services.AddMauiBlazorWebView();
      builder.Services.AddMemoryCache();

#if DEBUG
      builder.Services.AddBlazorWebViewDeveloperTools();
#endif

      builder.Services.AddSyncfusionBlazor();
      builder.Services.AddScoped<SampleService>();
      builder.Services.AddSingleton<DeviceMode>();
      builder.Services.AddScoped<SfDialogService>();

      // Register the locale service to localize the  SyncfusionBlazor components.
      builder.Services.AddSingleton(typeof(ISyncfusionStringLocalizer), typeof(SyncfusionLocalizer)); 

      // Set the resx file folder path to access
      builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");
      // Set the default culture
      var culture = new CultureInfo("en-US");
      CultureInfo.DefaultThreadCurrentCulture = culture;
      CultureInfo.DefaultThreadCurrentUICulture = culture;

      return builder.Build();
   }
}
