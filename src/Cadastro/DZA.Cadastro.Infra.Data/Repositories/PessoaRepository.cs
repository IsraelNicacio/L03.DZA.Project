using DZA.Cadastro.Domain.Entities;
using DZA.Cadastro.Domain.Repositories;
using DZA.Cadastro.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace DZA.Cadastro.Infra.Data.Repositories;

public class PessoaRepository : IPessoaRepository
{
    private readonly CadastroContext _context;

    public PessoaRepository(CadastroContext context) 
        => _context = context;

    public async Task<IEnumerable<Pessoa>> ObterPessoas()
        => await _context.Pessoas.ToListAsync();

    public async Task<IEnumerable<Pessoa>?> ObterPessoasPorDepartamento(Guid idDepartamento)
    {
        var departamento = await _context.Departamentos
                                         .Include(d => d.Pessoas)
                                         .FirstOrDefaultAsync(d => d.Id == idDepartamento);
        return departamento?.Pessoas ?? Enumerable.Empty<Pessoa>();
    }

    public async Task<Pessoa?> ObterPessoaPorId(Guid id) 
        => await _context.Pessoas.FindAsync(id);

    public async Task AdicionarPessoa(Pessoa pessoa) 
        => await _context.Pessoas.AddAsync(pessoa);

    public void AtualizaPessoa(Pessoa pessoa) 
        => _context.Pessoas.Update(pessoa);

    public async Task<IEnumerable<Departamento>> ObterDepartamentos()
        => await _context.Departamentos.ToListAsync();

    public async Task<Departamento?> ObterDepartamentoPorId(Guid id)
        => await _context.Departamentos.FindAsync(id);

    public async Task AdicionarDepartamento(Departamento departamento)
        => await _context.Departamentos.AddAsync(departamento);

    public void AtualizarDepartamento(Departamento departamento)
        => _context.Departamentos.Update(departamento);
}
