using Api.Configuaration;

var builder = WebApplication.CreateBuilder(args);
builder.Services.Install();

var app = builder.Build();
app.Install();
app.Run();
