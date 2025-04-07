using DZA.Cadastro.Application.AutoMapper;
using DZA.Cadastro.Application.Services;
using DZA.Cadastro.Domain.Repositories;
using DZA.Cadastro.Infra.Data.Repositories;

namespace DZA.Cadastro.Api.Configurations;

public static class DependenciesInjectionsConfig
{
    public static void RegistesServices(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(DomainDTOMappingProfile));
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IPessoaService, PessoaService>();
        services.AddScoped<IDepartementoService, DepartementoService>();
    }
}
