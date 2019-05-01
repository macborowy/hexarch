using Microsoft.EntityFrameworkCore;

namespace HexArch.Infrastructure.EntityFrameworkDataAccess
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Entities.Student> Students { get; set; }
    }
}
