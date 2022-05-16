var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.Use(async (context, next) => {

    context.Response.ContentType = "Text/Plain";
    await context.Response.WriteAsync("Aoa pakistan");
    await next();
});
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("this is first line");
    await next();
});
app.MapGet("/", () => "Hello World!\n");

app.Run();
