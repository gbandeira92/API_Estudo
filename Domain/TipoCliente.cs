
using System.Collections.Generic;

namespace APIEstudos.Domain
{
    public class TipoCliente
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public ICollection<Cliente> Clientes { get; set; }
    }
}
