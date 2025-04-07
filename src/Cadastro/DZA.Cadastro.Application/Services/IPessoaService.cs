using DZA.Cadastro.Application.DTO;

namespace DZA.Cadastro.Application.Services;
public interface IPessoaService
{
    Task<IEnumerable<PessoaDTO>> ObterPessoas();
    Task<IEnumerable<PessoaDTO>> ObterPessoasPorDepartamento(Guid idDepartamento);
    Task<PessoaDTO> ObterPessoaPorId(Guid id);
    Task AdicionarPessoa(PessoaDTO pessoa);
    void AtualizaPessoa(PessoaDTO pessoa);
}