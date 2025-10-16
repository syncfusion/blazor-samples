#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using BlazorDemos.Shared;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;
using Syncfusion.Blazor;
using Syncfusion.Blazor.Popups;
using System;
using System.Globalization;
using System.Net.Http;
using Syncfusion.Licensing;

var licenseKey = "";
SyncfusionLicenseProvider.RegisterLicense(licenseKey);
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<SfDialogService>();
builder.Services.AddScoped<SampleService>();
builder.Services.AddSingleton<DeviceMode>();
builder.Services.AddSyncfusionBlazor();
#region Localization
// Register the Syncfusion locale service to customize the  SyncfusionBlazor component locale culture
builder.Services.AddSingleton(typeof(ISyncfusionStringLocalizer), typeof(SyncfusionLocalizer));

// Set the default culture of the application
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en-US");

// Get the modified culture from culture switcher
var host = builder.Build();
var jsInterop = host.Services.GetRequiredService<IJSRuntime>();
var result = await jsInterop.InvokeAsync<string>("cultureInfo.get");
if (result != null)
{
    // Set the culture from culture switcher
    var culture = new CultureInfo(result);
    CultureInfo.DefaultThreadCurrentCulture = culture;
    CultureInfo.DefaultThreadCurrentUICulture = culture;
}
#endregion

await builder.Build().RunAsync();
