using Microsoft.EntityFrameworkCore;

namespace test.Data
{
    public class DbContextPropiedad  : DbContext
    {
        public DbSet<Propetario> Propetario { get; set; }

        public DbContextPropiedad(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Propetario>().HasData(
                new Propetario() { Id = 1, Name = "Fulano", LastName = "Perez" },
                new Propetario() { Id = 2, Name = "Fulano", LastName = "Perez" },
                new Propetario() { Id = 3, Name = "Fulano", LastName = "Perez" },
                new Propetario() { Id = 4, Name = "Fulano", LastName = "Perez" }

                );
        }
    }
}
