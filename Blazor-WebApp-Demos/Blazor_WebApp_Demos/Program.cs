#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using BlazorDemos.Pages;
using BlazorDemos.Components;
using Syncfusion.Blazor;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BlazorDemos.Shared;
using Syncfusion.Blazor.Popups;
using Syncfusion.Licensing;
using System;
using System.Net.Http;
using Microsoft.AspNetCore.Components;

var licenseKey = "";
var builder = WebApplication.CreateBuilder(args);

SyncfusionLicenseProvider.RegisterLicense(licenseKey);
builder.Services.AddControllers();
builder.Services.AddHttpClient();
builder.Services.AddScoped<SfDialogService>();
builder.Services.AddScoped<SampleService>();
builder.Services.AddSingleton<DeviceMode>();
builder.Services.AddMemoryCache();
builder.Services.AddSignalR(e => e.MaximumReceiveMessageSize = 102400000);
builder.Services.AddScoped(sp => new HttpClient {
    BaseAddress = new Uri(sp.GetRequiredService<NavigationManager>().BaseUri)
});
builder.Services.Configure<CookiePolicyOptions>(options =>
    {
        options.MinimumSameSitePolicy = SameSiteMode.Strict;
    });
builder.Services.AddSyncfusionBlazor();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

// Set HSTS value is 1 year. see https://aka.ms/aspnetcore-hsts.
builder.Services.AddHsts(options =>
{
    options.IncludeSubDomains = true;
    options.MaxAge = TimeSpan.FromDays(730);
});

#region Localization
// Set the resx file folder path to access
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

// Register the Syncfusion locale service to customize the  SyncfusionBlazor component locale culture
builder.Services.AddSingleton(typeof(ISyncfusionStringLocalizer), typeof(SyncfusionLocalizer));

var supportedCultures = new[] { "en-US", "de-DE", "fr-CH", "zh-CN" };
var localizationOptions = new RequestLocalizationOptions()
            .SetDefaultCulture("en-US")
            .AddSupportedCultures(supportedCultures)
            .AddSupportedUICultures(supportedCultures);
#endregion

var app = builder.Build();
#region Localization
app.UseRequestLocalization(localizationOptions);
#endregion
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseCookiePolicy(
    new CookiePolicyOptions
    {
        Secure = CookieSecurePolicy.Always
    });
#if NET9_0
app.MapStaticAssets();
#else
app.UseStaticFiles();
#endif
app.UseAntiforgery();
app.UseStatusCodePagesWithRedirects("/Error");

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(BlazorDemos.Pages.Index).Assembly);
app.MapControllers();
app.Run();
