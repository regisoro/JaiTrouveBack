

using JaitrouveBack.Entities;
using Microsoft.EntityFrameworkCore;

namespace JaitrouveBack
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Objt> Objets { get; set; }
    }
   

}
