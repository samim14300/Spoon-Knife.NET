using Microsoft.AspNetCore.Builder;

public class Startup
{
    public void Configure(IApplicationBuilder app)
    {
        app.UseDefaultFiles();  // Set up default files first
        app.UseStaticFiles();

        app.MapGet("/", () =>
        {
            return File.ReadAllText("wwwroot/index.html");
        });
    }
}
