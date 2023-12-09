using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using System.IO;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

/*
app.MapGet("/", () =>
{
    return File.ReadAllText("wwwroot/index.html"); 
});
*/

app.MapFallback(context =>
{
    return context.Response.SendFileAsync(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "index.html"));
});

app.Run();
