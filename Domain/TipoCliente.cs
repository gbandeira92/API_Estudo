
using System.ComponentModel.DataAnnotations;

namespace APIEstudos.Domain
{
    public class TipoCliente
    {
        [Key]
        public int ID { get; set; }
        public string Nome { get; set; }

    }
}
