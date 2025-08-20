namespace Gestionare_Biblioteca
{
    using Microsoft.EntityFrameworkCore;

    public class BibliotecaDbContext : DbContext
    {
        public BibliotecaDbContext(DbContextOptions<BibliotecaDbContext> options) 
            : base(options) 
        { }

        public DbSet<Carte> Carti { get; set; }
        public DbSet<Membru> Membri { get; set; }
        public DbSet<Imprumut> Imprumuturi { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlite("Data Source=biblioteca.db");
            }
        }
    }
}