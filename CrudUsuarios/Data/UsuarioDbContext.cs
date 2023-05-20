using CrudUsuarios.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudUsuarios.Data
{
    public class UsuarioDbContext : DbContext 
    {
        public UsuarioDbContext(DbContextOptions<UsuarioDbContext> options) : base(options)
        {
            
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}
