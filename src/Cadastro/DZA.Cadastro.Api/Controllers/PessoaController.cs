using Microsoft.AspNetCore.Mvc;

namespace DZA.Cadastro.Api.Controllers;
[ApiController]
[Route("{tenant}/[controller]")]
public class PessoaController : ControllerBase
{
    [HttpGet("ObterPessoas")]
    public IEnumerable<object> Get()
    {
        return default;
    }
}
