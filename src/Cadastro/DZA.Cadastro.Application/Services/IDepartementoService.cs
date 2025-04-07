using DZA.Cadastro.Application.DTO;

namespace DZA.Cadastro.Application.Services;

public interface IDepartementoService
{
    Task<IEnumerable<DepartamentoDTO>> ObterDepartamentos();
    Task<DepartamentoDTO> ObterDepartamentoPorId(Guid id);
    Task AdicionarDepartamento(DepartamentoDTO departamento);
    void AtualizarDepartamento(DepartamentoDTO departamento);
}
