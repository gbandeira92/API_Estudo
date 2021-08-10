using System.Collections.Generic;
using APIEstudos.Domain;
using APIEstudos.Domain.DTO;

namespace APIEstudos.Services.Interface
{
    public interface ITipoClienteService
    {
        List<TipoCliente> GetAllTipoCliente();

        void InsertTipoCliente(TipoClienteDTO tipoClienteDTO);

        void UpdateTipoCliente(TipoCliente tipoCliente);

        void DeleteTipoCliente(int id);
        
    }
}
