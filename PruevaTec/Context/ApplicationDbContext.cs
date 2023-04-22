using Microsoft.EntityFrameworkCore;
using PruevaTec.Models;

namespace PruevaTec.Context
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Rol> roles { get; set; }
        public DbSet<Usuario> usuarios { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) { }
    }
}
