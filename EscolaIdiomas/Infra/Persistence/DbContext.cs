using Microsoft.EntityFrameworkCore;

namespace Infra.Persistence
{
    public class DbContext(DbContextOptions options) : DbContext(options)
    {

    }
}
