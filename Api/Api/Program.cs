using Api.Configuaration;

var builder = WebApplication.CreateBuilder(args);
builder.Services.Install();
builder.Build().SetupApplication().Run();
