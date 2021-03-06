
using System.ComponentModel.DataAnnotations;

namespace APIEstudos.Domain.DTO
{
    public class TipoClienteDTO
    {
        [Required(ErrorMessage = "Nome Obrigatório")]
        [MinLength(3)]
        [MaxLength(255)]
        public string Nome { get; set; }
    }
}
