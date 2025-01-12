using Microsoft.EntityFrameworkCore;

namespace Projekt_bazy.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Dodaj DbSety reprezentujące tabele w bazie danych
        public DbSet<Sprzet> Sprzety { get; set; }
        public DbSet<Personel> Personel { get; set; }
        public DbSet<Zamowienie> Zamowienia { get; set; }
    }
}
