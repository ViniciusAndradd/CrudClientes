using CrudClientesApi.Mappings;
using CrudClientesApi.Repositories;
using CrudClientesModels.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudClientesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteRepository _clienteRepository;

        public ClientesController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClienteDto>>> GetClientes()
        {
            try
            {
                var clientes = await _clienteRepository.GetClientes();
                if (clientes is null)
                {
                    return NotFound();
                }
                else
                {
                    var clienteDtos = clientes.ConverterClientesParaDto();
                    return Ok(clienteDtos);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao acessar a base de dados {ex.Message}");
            }
        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult<ClienteDto>> GetClienteById(int id)
        {
            try
            {
                var cliente = await _clienteRepository.GetClienteById(id);
                if (cliente is null)
                {
                    return NotFound("Cliente não encontrado");
                }
                else
                {
                    var clienteDto = cliente.ConverterClienteParaDto();
                    return Ok(clienteDto);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar a base de dados");
            }
        }
    }
}
