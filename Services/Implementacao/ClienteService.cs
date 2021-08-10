using System.Collections.Generic;
using APIEstudo.Data.Repositorio.Interface;
using APIEstudos.Domain;
using APIEstudos.Domain.DTO;
using APIEstudos.Services.Interface;

namespace APIEstudos.Services.Implementacao
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public ClienteService(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public List<Cliente> GetAllCliente()
        {
            return _clienteRepositorio.GetAll();
        }

        public void InsertCliente(ClienteDTO clienteDTO)
        {
            var cliente = new Cliente();
            cliente.Nome = clienteDTO.Nome;
            _clienteRepositorio.Insert(cliente);
        }

        public void UpdateCliente(Cliente cliente)
        {
            _clienteRepositorio.Update(cliente);
        }

        public void DeleteCliente(int id)
        {
            var resultCliente = _clienteRepositorio.GetByID(id);
            if (resultCliente != null)
            {
                _clienteRepositorio.Delete(resultCliente);
            }
        }

    }
}
