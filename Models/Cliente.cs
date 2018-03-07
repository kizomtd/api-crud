using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace estudo.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(80)]
        public string Nome { get; set; }

        [MaxLength(150)]
        public string Endereco { get; set; }

        [MaxLength(80)]
        public string Cidade { get; set; }

        [MaxLength(250)]
        public string Email { get; set; }
    }
}
