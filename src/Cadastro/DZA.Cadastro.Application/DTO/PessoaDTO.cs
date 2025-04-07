using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DZA.Cadastro.Application.DTO;

public class PessoaDTO
{
    const string stringLength = "O campo {0} deve ter no maximo {1} caracteres";
    const string required = "O campo {0} deve ser informado";
    const string range = "O campo deve ter entre {1} e {2} de {0}";

    [Key]
    public Guid? Id { get; private set; }

    public Guid? DepartamentoId { get; private set; }

    [Required(ErrorMessage = required)]
    [StringLength(60, ErrorMessage = stringLength)]
    public string Nome { get; private set; }

    [Required(ErrorMessage = required)]
    [StringLength(60, ErrorMessage = stringLength)]
    public string SobreNome { get; private set; }

    [Required(ErrorMessage = required)]
    [Range(0,120, ErrorMessage = range)]
    public int Idade { get; private set; }
}
