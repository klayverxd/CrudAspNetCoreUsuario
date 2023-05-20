using System.ComponentModel.DataAnnotations;

namespace CrudUsuarios.Models
{
    public class UsuarioModel
    {
        [Key]
        public long Id { get; set; }

        [MaxLength(255)]
        public string Nome { get; set; }

        [MaxLength(45)]
        public string Email { get; set; }
        public int Idade { get; set; }
    }
}
