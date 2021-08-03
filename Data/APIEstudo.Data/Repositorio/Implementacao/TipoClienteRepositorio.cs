
using System.Collections.Generic;
using System.Linq;
using APIEstudo.Data.Repositorio.Interface;
using APIEstudos.Domain;

namespace APIEstudo.Data.Repositorio.Implementacao
{
    public class TipoClienteRepositorio : ITipoClienteRepositorio
    {
        private readonly MainContext _context;

        public TipoClienteRepositorio(MainContext context)
        {
            _context = context;
        }

        public void Delete(TipoCliente tipoCliente)
        {
            _context.Remove(tipoCliente);
            _context.SaveChanges();
        }

        public List<TipoCliente> GetAll()
        {
            return _context.TipoCliente.ToList();
        }

        public TipoCliente GetByID(int ID)
        {
            var tipoCliente = _context.TipoCliente.Find(ID);
            return tipoCliente;
        }

        //public TipoCliente DeleteByName(TipoCliente tipoCliente)
        //{
        //    var tipoClienteResult = _context.TipoCliente.Find(tipoCliente);
        //    return tipoClienteResult;
        //}

        public void Insert(TipoCliente tipoCliente)
        {
            _context.Add(tipoCliente);
            _context.SaveChanges();
        }

        public TipoCliente Update(TipoCliente tipoCliente)
        {
            var result = _context.TipoCliente.Where(t => t.ID == tipoCliente.ID).FirstOrDefault();
            if (result != null)
            {
                result.Nome = tipoCliente.Nome;
                _context.Update(result);
                _context.SaveChanges();
                return result;
            }
            return tipoCliente;
        }
    }
}
