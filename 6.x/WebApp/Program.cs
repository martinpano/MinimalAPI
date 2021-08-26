var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapGet("/", (HttpContext ctx) => Results.Ok("Successfull!"));

app.MapGet("/hello", (HttpContext ctx) => $"Hello there {ctx.Request.Query["name"].ToString()}");

app.MapGet("/current-time", () => $"Time right now: { DateTime.Now.ToLongTimeString() }");

app.Run();
