using DZA.Cadastro.Application.DTO;
using DZA.Cadastro.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace DZA.Cadastro.Api.Controllers;
[ApiController]
[Route("{tenant}/[controller]")]
public class PessoaController : ControllerBase{
    private readonly IPessoaService _pessooaService;

    public PessoaController(IPessoaService pessooaService) 
        => _pessooaService = pessooaService;

    [HttpGet("ObterPessoas")]
    public async Task<IEnumerable<PessoaDTO>> Get()
        => await _pessooaService.ObterPessoas();}
