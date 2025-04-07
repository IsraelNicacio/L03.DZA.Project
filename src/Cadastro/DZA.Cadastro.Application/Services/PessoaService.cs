using AutoMapper;
using DZA.Cadastro.Application.DTO;
using DZA.Cadastro.Domain.Entities;
using DZA.Cadastro.Domain.Repositories;

namespace DZA.Cadastro.Application.Services;

public class PessoaService : IPessoaService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public PessoaService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IEnumerable<PessoaDTO>> ObterPessoas()
        => _mapper.Map<IEnumerable<PessoaDTO>>(await _unitOfWork.Pessoa.ObterPessoas());

    public async Task<IEnumerable<PessoaDTO>> ObterPessoasPorDepartamento(Guid idDepartamento)
        => _mapper.Map<IEnumerable<PessoaDTO>>(await _unitOfWork.Pessoa.ObterPessoasPorDepartamento(idDepartamento));

    public async Task<PessoaDTO> ObterPessoaPorId(Guid id)
        => _mapper.Map<PessoaDTO>(await _unitOfWork.Pessoa.ObterPessoaPorId(id));

    public async Task AdicionarPessoa(PessoaDTO pessoa)
    {
        var pessoaEntity = _mapper.Map<Pessoa>(pessoa);
        if (pessoaEntity is not null)
        {
            await _unitOfWork.Pessoa.AdicionarPessoa(pessoaEntity);
            await _unitOfWork.Commit();
        }
    }
    public async void AtualizaPessoa(PessoaDTO pessoa)
    {
        var pessoaEntity = _mapper.Map<Pessoa>(pessoa);
        if (pessoaEntity is not null)
        {
            _unitOfWork.Pessoa.AtualizaPessoa(pessoaEntity);
            await _unitOfWork.Commit();
        }
    }
}
