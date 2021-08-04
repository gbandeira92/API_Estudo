
using System.Collections.Generic;
using APIEstudos.Domain;
using APIEstudos.Domain.DTO;

namespace APIEstudos.Services.Interface
{
    public interface ITipoClienteService
    {
        void InsertTipoCliente(TipoClienteDTO tipoClienteDTO);

        List<TipoCliente> GetAll();

        void Delete(int id);

        void Update(TipoCliente tipoCliente);
    }
}
