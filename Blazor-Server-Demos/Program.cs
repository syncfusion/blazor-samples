#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
#if NET8_0
    using BlazorDemos.Components;
#endif
using BlazorDemos.Shared;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Syncfusion.Blazor.Popups;
using Syncfusion.Blazor;
using Syncfusion.Licensing;
using System.Diagnostics.Metrics;
using System.Globalization;
using Microsoft.AspNetCore.Localization;
using System.Collections.Generic;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Localization;


    var licenseKey = "";
    var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
#if NET8_0
    builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
#else
    builder.Services.AddRazorPages();
#endif
    SyncfusionLicenseProvider.RegisterLicense(licenseKey);
    builder.Services.AddControllers();
    builder.Services.AddServerSideBlazor();
    builder.Services.AddScoped<SfDialogService>();
    builder.Services.AddScoped<SampleService>();
    builder.Services.AddSingleton<DeviceMode>();
    builder.Services.AddMemoryCache();
#region Localization
// Set the resx file folder path to access
            builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");
            builder.Services.AddSyncfusionBlazor();
            // Register the Syncfusion locale service to customize the  SyncfusionBlazor component locale culture
            builder.Services.AddSingleton(typeof(ISyncfusionStringLocalizer), typeof(SyncfusionLocalizer));

            var supportedCultures = new[] { "en-US", "de-DE", "fr-CH", "zh-CN" };
            var localizationOptions = new RequestLocalizationOptions()
                        .SetDefaultCulture("en-US")
                        .AddSupportedCultures(supportedCultures)
                        .AddSupportedUICultures(supportedCultures);
    #endregion
        builder.Services.AddServerSideBlazor().AddCircuitOptions(option => { option.DetailedErrors = true; });
        builder.Services.AddServerSideBlazor().AddHubOptions(o => { o.MaximumReceiveMessageSize = 102400000; });
        var app = builder.Build();
    #region Localization
        app.UseRequestLocalization(localizationOptions);
    #endregion

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Error");
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
    }
    app.UseStatusCodePagesWithRedirects("/Error");
    app.UseHttpsRedirection();
    app.UseDefaultFiles();
    app.UseStaticFiles();
    app.UseRouting();
#if NET8_0
    app.UseAntiforgery();
    app.MapRazorComponents<App>()
    .AddAdditionalAssemblies(typeof(BlazorDemos.Pages.Index).Assembly)
    .AddInteractiveServerRenderMode();
#else
    app.MapBlazorHub();
    app.MapFallbackToPage("/_Host");
#endif
app.MapControllers();
app.Run();
