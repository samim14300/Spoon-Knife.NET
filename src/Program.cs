var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    return File.ReadAllText("wwwroot/index.html"); 
});

app.Run();
