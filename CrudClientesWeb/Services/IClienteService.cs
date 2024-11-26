using CrudClientesModels.DTOs;

namespace CrudClientesWeb.Services
{
    public interface IClienteService
    {
        Task<IEnumerable<ClienteDto>> GetClientes();

    }
}
