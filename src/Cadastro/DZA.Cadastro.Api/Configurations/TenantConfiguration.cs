using DZA.Cadastro.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace DZA.Cadastro.Api.Configurations;

public static class TenantConfiguration
{
    public static void RegisterTenant(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddHttpContextAccessor();

        services.AddScoped<CadastroContext>(provider =>
        {
            var builderOptions = new DbContextOptionsBuilder<CadastroContext>();
            var httpContext = provider.GetService<IHttpContextAccessor>()?.HttpContext;
            var tenant = httpContext?.Request.Path.Value.Split("/", StringSplitOptions.RemoveEmptyEntries)[0];
            var connectionString = configuration?.GetConnectionString("TenantDataBase")?.Replace("_DATABASE_", tenant);

            builderOptions.UseSqlServer(connectionString)
            .LogTo(Console.WriteLine)
            .EnableSensitiveDataLogging();

            return new CadastroContext(builderOptions.Options);
        });
    }
}
