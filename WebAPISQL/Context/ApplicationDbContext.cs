using Microsoft.EntityFrameworkCore;
using WebAPISQL.Models;

namespace WebAPISQL.Context
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; } = null!;
        public DbSet<Vendedor> Vendedor { get; set; } = null!;
        public DbSet<Mastcli> Mastcli { get; set; } = null!;
    }
}
