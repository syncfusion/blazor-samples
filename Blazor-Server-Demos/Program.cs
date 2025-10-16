#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
#if NET8_0_OR_GREATER
using BlazorDemos.Components;
#endif
using BlazorDemos.Shared;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Syncfusion.Blazor.Popups;
using Syncfusion.Blazor;
using SmartComponents.LocalEmbeddings;
using Syncfusion.Blazor.SmartComponents;
using BlazorDemos.Service;
using FileManagerAI.Services;
using Microsoft.AspNetCore.Http;
using Syncfusion.Licensing;
using System;
using System.Net.Http;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.AI;
using Microsoft.Extensions.AI;
using OpenAI;
using Microsoft.Extensions.FileProviders;
using System.IO;


var licenseKey = "";
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped(sp =>
{
    NavigationManager UriHelper = sp.GetRequiredService<NavigationManager>();
    return new HttpClient { BaseAddress = new Uri(UriHelper.BaseUri) };
});
// Add services to the container.
#if NET8_0_OR_GREATER
builder.Services.AddRazorComponents()
.AddInteractiveServerComponents();
#else
    builder.Services.AddRazorPages();
#endif
SyncfusionLicenseProvider.RegisterLicense(licenseKey);
#region AI Integration
builder.Services.AddScoped<FileManagerService>();
// Local Embeddings
builder.Services.AddSingleton<LocalEmbedder>();
// Smart Components
/* OpenAI Service */
string apiKey = "your api key";
string deploymentName = "your deployment name";

OpenAIClient openAIClient = new OpenAIClient(apiKey);
IChatClient openAiChatClient = openAIClient.GetChatClient(deploymentName).AsIChatClient();
builder.Services.AddChatClient(openAiChatClient);
builder.Services.AddSyncfusionSmartComponents()
    .InjectOpenAIInference();
builder.Services.AddSingleton<SyncfusionAIService>();
builder.Services.AddScoped<UserTokenService>();
builder.Services.AddScoped<AzureAIService>(sp =>
{
    var userTokenService = sp.GetRequiredService<UserTokenService>();
    return new AzureAIService(userTokenService, openAiChatClient);
});

#endregion
builder.Services.AddControllers();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<SfDialogService>();
builder.Services.AddScoped<SampleService>();
builder.Services.AddSingleton<DeviceMode>();
builder.Services.AddMemoryCache();
builder.Services.Configure<CookiePolicyOptions>(options =>
{
    options.MinimumSameSitePolicy = SameSiteMode.Strict;
});

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
        builder.Services.AddSignalR(o => { o.MaximumReceiveMessageSize = 102400000; });

    // Set HSTS value is 1 year. see https://aka.ms/aspnetcore-hsts.
    builder.Services.AddHsts(options =>
    {
        options.IncludeSubDomains = true;
        options.MaxAge = TimeSpan.FromDays(730);
    });

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
    app.UseCookiePolicy(
    new CookiePolicyOptions
    {
        Secure = CookieSecurePolicy.Always
    });
    app.UseDefaultFiles();
#if NET9_0
    app.MapStaticAssets();
    app.UseStaticFiles(new StaticFileOptions
    {
        FileProvider = new PhysicalFileProvider(
        Path.Combine(app.Environment.ContentRootPath, "wwwroot", "DemoBaseDirectory")),
        RequestPath = "/DemoBaseDirectory"
    });
#else
    app.UseStaticFiles();
#endif
    app.UseRouting();
#if NET8_0_OR_GREATER
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
