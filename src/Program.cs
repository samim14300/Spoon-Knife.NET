using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using System.IO;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseStaticFiles();
app.UseDefaultFiles();

app.MapGet("/", () =>
{
    return File.ReadAllText("wwwroot/index.html"); 
});

app.Run();
