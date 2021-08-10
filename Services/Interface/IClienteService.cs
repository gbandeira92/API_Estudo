using System.Collections.Generic;
using APIEstudos.Domain;
using APIEstudos.Domain.DTO;

namespace APIEstudos.Services.Interface
{
    public interface IClienteService
    {
        List<Cliente> GetAllCliente();

        void InsertCliente(ClienteDTO clienteDTO);

        void UpdateCliente(Cliente cliente);

        void DeleteCliente(int id);

    }
}
