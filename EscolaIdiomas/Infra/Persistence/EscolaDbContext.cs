using Domain.Entity.Colaborador;
using Microsoft.EntityFrameworkCore;

namespace Infra.Persistence
{
    public class EscolaDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Colaborador> Colaborador { get; set; }
    }
}
