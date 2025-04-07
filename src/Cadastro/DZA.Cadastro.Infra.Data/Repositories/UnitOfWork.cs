using DZA.Cadastro.Domain.Repositories;
using DZA.Cadastro.Infra.Data.Context;

namespace DZA.Cadastro.Infra.Data.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly CadastroContext _context;

    public UnitOfWork(CadastroContext context) 
        => _context = context;

    private IPessoaRepository _pessoa;
    public IPessoaRepository Pessoa
    { 
        get => _pessoa ?? (_pessoa ?? (new PessoaRepository(_context))); 
    }

    public async Task<bool> Commit()
        => await _context.SaveChangesAsync() > 0;
    public void Dispose()
        => _context?.DisposeAsync();
}
