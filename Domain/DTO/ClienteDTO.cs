using System.ComponentModel.DataAnnotations;

namespace APIEstudos.Domain.DTO
{
    public class ClienteDTO
    {
        [Required(ErrorMessage = "Nome Obrigatório")]
        [MaxLength(255)]
        [MinLength(3)]
        public string Nome { get; set; }
    }
}
