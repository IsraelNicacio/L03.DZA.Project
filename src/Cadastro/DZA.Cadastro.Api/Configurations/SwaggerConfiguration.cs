namespace DZA.Cadastro.Api.Configurations;

public static class SwaggerConfiguration
{
    public static void UseSwaggerConfig(this WebApplication app)
    {
        if (app.Environment.IsDevelopment() || app.Environment.IsEnvironment("Stage") || app.Environment.IsEnvironment("Docker"))
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
    }
}
