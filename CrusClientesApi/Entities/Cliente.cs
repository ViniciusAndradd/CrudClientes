using System.ComponentModel.DataAnnotations;

namespace CrudClientesApi.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Nome { get; set; }
        [MaxLength(11)]
        public string Telefone { get; set; }
    }
}
