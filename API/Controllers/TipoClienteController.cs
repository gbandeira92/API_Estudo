using APIEstudos.Domain;
using APIEstudos.Domain.DTO;
using APIEstudos.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace APIEstudos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoClienteController : ControllerBase
    {
        private readonly ITipoClienteService _tipoClienteService;

        public TipoClienteController(ITipoClienteService tipoClienteService)
        {
            _tipoClienteService = tipoClienteService;
        }

        [HttpGet]
        [SwaggerOperation(
            Summary = "endpoint que retorna a lista dos clientes",
            Description = "endpoint que retorno a lista dos clientes",
            OperationId = "Get"
            )]

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(TipoClienteDTO))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Get()
        {
            var result = _tipoClienteService.GetAll();
            return StatusCode(200, result);
        }

        [HttpPost]
        [SwaggerOperation(
            Summary = "endpoint que insere na lista dos clientes",
            Description = "endpoint que insere na lista dos clientes",
            OperationId = "Post"
            )]

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Post([FromBody] TipoClienteDTO tipoClienteDTO)
        {

            _tipoClienteService.InsertTipoCliente(tipoClienteDTO);
            return StatusCode(201, "Tipo de cliente inserido com sucesso");
        }

        [HttpDelete("{id}")]
        [SwaggerOperation(
            Summary = "endpoint que deleta da lista dos clientes",
            Description = "endpoint que deleta da lista dos clientes",
            OperationId = "Delete"
            )]

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Delete(int id)
        {
            _tipoClienteService.Delete(id);
            return StatusCode(200, "Tipo de cliente deletado com sucesso");
        }

        [HttpPut]
        [SwaggerOperation(
            Summary = "endpoint que altera a lista dos clientes",
            Description = "endpoint que altera a lista dos clientes",
            OperationId = "Put"
            )]

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(TipoCliente))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Put([FromBody] TipoCliente tipoCliente)
        {
            _tipoClienteService.Update(tipoCliente);
            return StatusCode(200, "Tipo de cliente alterado com sucesso");
            //return StatusCode(200, _tipoClienteService.Update(tipoCliente));
        }
    }
}
