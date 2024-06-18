using Microsoft.EntityFrameworkCore;

namespace ApiMissing.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        { 
        
        }
        public DbSet<ApiMissing.Models.Usuario> Usuario { get; set; } = default!; 
        public DbSet<ApiMissing.Models.Observacoes> Observacoes { get; set; } = default!;
        public DbSet<ApiMissing.Models.Pessoa> Pessoa { get; set; } = default!;
    }
}
