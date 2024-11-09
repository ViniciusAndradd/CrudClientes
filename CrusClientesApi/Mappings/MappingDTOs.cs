using CrudClientesModels.DTOs;
using CrudClientesApi.Entities;

namespace CrudClientesApi.Mappings
{
    public static class MappingDTOs
    {
        public static IEnumerable<ClienteDto> ConverterClientesParaDto(
                                              this IEnumerable<Cliente> clientes)
        {
            return (from cliente in clientes
                    select new ClienteDto
                    {
                        Id = cliente.Id,
                        Nome = cliente.Nome,
                        Telefone = cliente.Telefone,
                    }).ToList();
        }

        public static ClienteDto ConverterClienteParaDto(this Cliente cliente)
        {
            return new ClienteDto
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Telefone = cliente.Telefone
            };
        }
    }
}
