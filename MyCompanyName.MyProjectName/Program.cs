using MyCompanyName.MyProjectName;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseAutofac();

builder.Services.ReplaceConfiguration(builder.Configuration);
builder.Services.AddApplication<MyProjectNameModule>();

var app = builder.Build();

app.InitializeApplication();
app.Run();
