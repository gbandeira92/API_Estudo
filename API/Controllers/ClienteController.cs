using System.Collections.Generic;
using APIEstudos.Domain;
using APIEstudos.Domain.DTO;
using APIEstudos.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace APIEstudos.API.Controllers
{
    [Route("v1/[Controller]")]
    [ApiController]

    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        [SwaggerOperation(
            Summary = "Endpoint que retorna a lista de Cliente",
            Description = "Endpont que retorna a lista de Clientes",
            OperationId = "Get")]

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<ClienteDTO>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]


        public IActionResult Get()
        {
            var result = _clienteService.GetAllCliente();
            return StatusCode(200, result);
        }

        [HttpPost]
        [SwaggerOperation(
            Summary = "Endpoint que insere na lista de Cliente",
            Description = "Endpoint que insere a lista de Cliente",
            OperationId = "Post")]

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public IActionResult Post([FromBody] ClienteDTO clienteDTO)
        {
            _clienteService.InsertCliente(clienteDTO);
            return StatusCode(201, "Cliente inserido com sucesso");
        }

        [HttpPut]
        [SwaggerOperation(
            Summary = "Endpoint que altera um cliente",
            Description = "Endpoint que altera um cliente",
            OperationId = "Put")]

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Cliente))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public IActionResult Put([FromBody] Cliente cliente)
        {
            _clienteService.UpdateCliente(cliente);
            return StatusCode(200, $"ID {cliente.ID} alterado para o nome {cliente.Nome}");
        }

        [HttpDelete("{id}")]
        [SwaggerOperation(
            Summary = "Endpoint que deleta um cliente",
            Description = "Endpoint que delete um cliente",
            OperationId = "Delete")]

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Delete(int id)
        {
            _clienteService.DeleteCliente(id);
            return StatusCode(200, "Cliente Deletado com sucesso");
        }

    }
}
