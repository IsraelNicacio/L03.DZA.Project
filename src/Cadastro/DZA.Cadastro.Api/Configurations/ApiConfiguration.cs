namespace DZA.Cadastro.Api.Configurations;

public static class ApiConfiguration
{
    const string AllowAllPolicy = "AllowAll";

    public static void AddApiConfiguration(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        services.AddCors(options =>
        {
            options.AddPolicy(AllowAllPolicy
                , builder => 
                builder.AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod());
        });
    }

    public static void UseApiConfiguration(this WebApplication app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment() || env.IsEnvironment("Stage") || env.IsEnvironment("Docker"))
            app.UseDeveloperExceptionPage();

        if (app.Configuration["USE_HTTPS_REDIRECTION"] == "true")
            app.UseHttpsRedirection();

        app.UseCors(AllowAllPolicy);
        app.UseAuthorization();
        app.MapControllers();
    }
}
