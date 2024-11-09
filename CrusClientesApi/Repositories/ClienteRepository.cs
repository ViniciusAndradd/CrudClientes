using CrudClientesApi.Context;
using CrudClientesApi.Entities;
using Microsoft.EntityFrameworkCore;


namespace CrudClientesApi.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly AppDbContext _context;

        public ClienteRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Cliente> GetClienteById(int id)
        {
            var cliente = await _context.Clientes
                .SingleOrDefaultAsync(c => c.Id == id);

            return cliente;
        }

        public async Task<IEnumerable<Cliente>> GetClientes()
        {
            var clientes = await _context.Clientes
                .ToListAsync();

            return clientes;
        }
    }
}
