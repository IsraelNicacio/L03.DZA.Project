using DZA.Cadastro.Domain.Entities;
using DZA.Core.Data;

namespace DZA.Cadastro.Domain.Repositories;

public interface IPessoaRepository : IRepository<Pessoa>
{
    Task<IEnumerable<Pessoa>> ObterPessoas();
    Task<IEnumerable<Pessoa>> ObterPessoasPorDepartamento(Guid idDepartamento);
    Task<Pessoa> ObterPessoaPorId(Guid id);
    Task AdicionarPessoa(Pessoa pessoa);
    void AtualizaPessoa(Pessoa pessoa);

    Task<IEnumerable<Departamento>> ObterDepartamentos();
    Task<Departamento> ObterDepartamentoPorId(Guid id);
    Task AdicionarDepartamento(Departamento departamento);
    void AtualizarDepartamento(Departamento departamento);
}
