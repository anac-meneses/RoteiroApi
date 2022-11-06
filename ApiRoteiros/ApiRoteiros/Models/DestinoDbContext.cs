using Microsoft.EntityFrameworkCore;

namespace ApiRoteiros.Models
{
    public class DestinoDbContext : DbContext
    {
        public DestinoDbContext(DbContextOptions<DestinoDbContext> options)
            : base(options) { }
        public DbSet<Destino> Destino { get; set; }    
    }
}
