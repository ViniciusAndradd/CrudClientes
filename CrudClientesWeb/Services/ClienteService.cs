using CrudClientesModels.DTOs;
using System.Net.Http.Json;

namespace CrudClientesWeb.Services
{
    public class ClienteService : IClienteService
    {
        public HttpClient _httpClient { get; set; }
        public ILogger<ClienteService> _logger { get; set; }
        public ClienteService(HttpClient httpClient, ILogger<ClienteService> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }


        public async Task<IEnumerable<ClienteDto>> GetClientes()
        {
            try
            {
                var clientesDto = await _httpClient.GetFromJsonAsync<IEnumerable<ClienteDto>>("api/clientes");
                return clientesDto;
            }
            catch (Exception ex)
            {
                _logger.LogError("Erro ao acessar clientes");
                throw;
            }

        }
    }
}
