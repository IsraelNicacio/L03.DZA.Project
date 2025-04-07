using AutoMapper;
using DZA.Cadastro.Application.DTO;
using DZA.Cadastro.Domain.Entities;
using DZA.Cadastro.Domain.Repositories;

namespace DZA.Cadastro.Application.Services;

public class DepartementoService : IDepartementoService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public DepartementoService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IEnumerable<DepartamentoDTO>> ObterDepartamentos()
        => _mapper.Map<IEnumerable<DepartamentoDTO>>(await _unitOfWork.Pessoa.ObterDepartamentos());

    public async Task<DepartamentoDTO> ObterDepartamentoPorId(Guid id)
        => _mapper.Map<DepartamentoDTO>(await _unitOfWork.Pessoa.ObterPessoasPorDepartamento(id));

    public async Task AdicionarDepartamento(DepartamentoDTO departamento)
    {
        var departEntity = _mapper.Map<Departamento>(departamento);
        if(departEntity is not null)
        {
            await _unitOfWork.Pessoa.AdicionarDepartamento(departEntity);
            await _unitOfWork.Commit();
        }
    }

    public async void AtualizarDepartamento(DepartamentoDTO departamento)
    {
        var departEntity = _mapper.Map<Departamento>(departamento);
        if (departEntity is not null)
        {
            _unitOfWork.Pessoa.AtualizarDepartamento(departEntity);
            await _unitOfWork.Commit();
        }
    }
}
