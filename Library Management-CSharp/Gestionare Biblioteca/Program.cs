using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Gestionare_Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();

            services.AddDbContext<BibliotecaDbContext>(options =>
                options.UseSqlite("Data Source=biblioteca.db"));

            services.AddScoped<Biblioteca>(); // Biblioteca ca serviciu scoped

            using (var serviceProvider = services.BuildServiceProvider())
            {
                var dbContext = serviceProvider.GetRequiredService<BibliotecaDbContext>();
                dbContext.Database.Migrate();  // Aplică migrațiile
                Console.WriteLine("Baza de date este gata!");

                var biblioteca = serviceProvider.GetRequiredService<Biblioteca>();

                // Adăugăm cărți
                Carte carte1 = new Carte("Clean Code", "Robert C. Martin", "123456");
                Carte carte2 = new Carte("The Pragmatic Programmer", "Andrew Hunt", "789012");
                biblioteca.AdaugaCarte(carte1);
                biblioteca.AdaugaCarte(carte2);

                // Adăugăm un membru
                Membru membru1 = new Membru("George Popescu", "george@email.com");
                biblioteca.AdaugaMembru(membru1);

                biblioteca.AfisareCartiDisponibile();

                biblioteca.InregistrareImprumut(carte1, membru1);

                biblioteca.AfisareCartiDisponibile();

                biblioteca.ReturnareCarte(carte1);

                biblioteca.AfisareCartiDisponibile();

                Console.ReadLine();
            }
        }
    }
}
