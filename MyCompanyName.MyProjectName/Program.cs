using MyCompanyName.MyProjectName;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseAutofac();

builder.Services.ReplaceConfiguration(builder.Configuration);
builder.Services.AddApplication<MyProjectNameModule>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/todo", () => new List<string>
{
    "Todo 1",
    "Todo 2"
});

app.InitializeApplication();
app.Run();
