using DZA.Cadastro.Api.Configurations;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddApiConfiguration();
builder.Services.RegistesServices();
builder.Services.RegisterTenant(builder.Configuration);

var app = builder.Build();
app.UseSwaggerConfig();
app.UseApiConfiguration(app.Environment);
app.Run();
