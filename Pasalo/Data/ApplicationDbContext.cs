using Microsoft.EntityFrameworkCore;
using Pasalo.Models;

namespace Pasalo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Articulo> Articulos { get; set; }
    }
}