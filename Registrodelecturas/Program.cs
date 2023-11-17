var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseMvc();
app.MapGet("/", () => "Hello World!");

app.Run();
