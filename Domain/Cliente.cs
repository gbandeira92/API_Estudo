
using System.ComponentModel.DataAnnotations;

namespace APIEstudos.Domain
{
    public class Cliente
    {
        [Key]
        public int ID { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public bool Ativo { get; set; }
        public int TipoClienteID { get; set; }
        public TipoCliente TipoCliente { get; set; }

    }

}
