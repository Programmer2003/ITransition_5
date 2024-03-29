using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Task5.Data;
using Task5.Generators;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddTransient<Manager>();
builder.Services.AddTransient<Export>();
builder.Services.AddSingleton<Config>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
