using Examen.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Examen.Infra.Data.Context
{
    public class ExamenDbContext : DbContext
    {
        public DbSet<Person>? Person { get; set; }

        public ExamenDbContext(DbContextOptions<ExamenDbContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ExamenDbContext).Assembly);
        }
    }
}
