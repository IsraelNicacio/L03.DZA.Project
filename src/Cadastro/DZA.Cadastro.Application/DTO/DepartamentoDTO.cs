using System.ComponentModel.DataAnnotations;

namespace DZA.Cadastro.Application.DTO;

public class DepartamentoDTO
{
    const string stringLength = "O campo {0} deve ter no maximo {1} caracteres";
    const string required = "O campo {0} deve ser informado";

    public Guid? Id { get; private set; }

    [Required(ErrorMessage = required)]
    [StringLength(60, ErrorMessage = stringLength)]
    public string Nome { get; private set; }
}