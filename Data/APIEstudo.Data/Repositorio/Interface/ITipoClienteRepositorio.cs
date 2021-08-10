
using System.Collections.Generic;
using APIEstudos.Domain;

namespace APIEstudo.Data.Repositorio.Interface
{
    public interface ITipoClienteRepositorio
    {
        List<TipoCliente> GetAll();

        void Insert(TipoCliente tipoCliente);

        TipoCliente Update(TipoCliente tipoCliente);

        void Delete(TipoCliente tipoCliente);

        TipoCliente GetByID(int ID);
    }
}
