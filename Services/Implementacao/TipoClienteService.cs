using System.Collections.Generic;
using APIEstudo.Data.Repositorio.Interface;
using APIEstudos.Domain;
using APIEstudos.Domain.DTO;
using APIEstudos.Services.Interface;

namespace APIEstudos.Services.Implementacao
{
    public class TipoClienteService : ITipoClienteService
    {
        private readonly ITipoClienteRepositorio _tipoClienteRepositorio;

        public TipoClienteService(ITipoClienteRepositorio tipoClienteRepositorio)
        {
            _tipoClienteRepositorio = tipoClienteRepositorio;
        }

        public List<TipoCliente> GetAllTipoCliente()
        {
            return _tipoClienteRepositorio.GetAll();
        }

        public void InsertTipoCliente(TipoClienteDTO tipoClienteDTO)
        {
            var tipoCliente = new TipoCliente();
            tipoCliente.Nome = tipoClienteDTO.Nome;
            _tipoClienteRepositorio.Insert(tipoCliente);
        }

        public void UpdateTipoCliente(TipoCliente tipoCliente)
        {
            _tipoClienteRepositorio.Update(tipoCliente);
        }
        public void DeleteTipoCliente(int id)
        {
            var tipoClienteResult = _tipoClienteRepositorio.GetByID(id);
            if (tipoClienteResult != null)
            {
                _tipoClienteRepositorio.Delete(tipoClienteResult);
            }

        }

    }
}
