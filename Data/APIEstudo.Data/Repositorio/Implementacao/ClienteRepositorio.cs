using System.Collections.Generic;
using System.Linq;
using APIEstudo.Data.Repositorio.Interface;
using APIEstudos.Domain;
using Microsoft.EntityFrameworkCore;

namespace APIEstudo.Data.Repositorio.Implementacao
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private readonly MainContext _mainContext;

        public ClienteRepositorio(MainContext mainContext)
        {
            _mainContext = mainContext;
        }

        public List<Cliente> GetAll()
        {
            return _mainContext.Cliente.Include(x => x.TipoCliente).ToList();
        }

        public void Insert(Cliente cliente)
        {
            _mainContext.Add(cliente);
            _mainContext.SaveChanges();
        }

        public Cliente Update(Cliente cliente)
        {
            var result = _mainContext.Cliente.Where(c => c.ID == cliente.ID).FirstOrDefault();
            if (result != null)
            {
                result.Nome = cliente.Nome;
                _mainContext.Update(result);
                _mainContext.SaveChanges();
                return result;
            }
            return cliente;
        }

        public void Delete(Cliente cliente)
        {
            _mainContext.Remove(cliente);
            _mainContext.SaveChanges();
        }

        public Cliente GetByID(int id)
        {
            var result = _mainContext.Cliente.Find(id);
            return result;
        }

    }
}
