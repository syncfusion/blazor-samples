#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using BlazorDemos.Pages;
using BlazorDemos.Components;
using Syncfusion.Blazor;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BlazorDemos.Shared;
using Syncfusion.Blazor.Popups;
using Syncfusion.Licensing;
using System;

var licenseKey = "";
var builder = WebApplication.CreateBuilder(args);

SyncfusionLicenseProvider.RegisterLicense(licenseKey);
builder.Services.AddControllers();
builder.Services.AddScoped<SfDialogService>();
builder.Services.AddScoped<SampleService>();
builder.Services.AddSingleton<DeviceMode>();
builder.Services.AddMemoryCache();

builder.Services.AddSyncfusionBlazor();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

// Set HSTS value is 1 year. see https://aka.ms/aspnetcore-hsts.
builder.Services.AddHsts(options =>
{
    options.IncludeSubDomains = true;
    options.MaxAge = TimeSpan.FromDays(365);
});


var app = builder.Build();

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

app.UseStaticFiles();
app.UseAntiforgery();
app.UseStatusCodePagesWithRedirects("/Error");

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(BlazorDemos.Pages.Index).Assembly);
app.MapControllers();
app.Run();
