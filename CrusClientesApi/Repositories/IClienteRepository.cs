using CrudClientesApi.Entities;

namespace CrudClientesApi.Repositories
{
    public interface IClienteRepository
    {
        Task<IEnumerable<Entities.Cliente>> GetClientes();
        Task<Entities.Cliente> GetClienteById(int Id);
    }
}
