using System.Collections.Generic;
using APIEstudos.Domain;

namespace APIEstudo.Data.Repositorio.Interface
{
    public interface IClienteRepositorio
    {
        List<Cliente> GetAll();

        public void Insert(Cliente cliente);

        Cliente Update(Cliente cliente);

        public void Delete(Cliente cliente);

        Cliente GetByID(int id);

        
    }
}
