using Microsoft.EntityFrameworkCore;
using WebUygulama1.Models;

namespace WebUygulama1.Utility
{
    public class UygulamaDbContext : DbContext
    {
        public UygulamaDbContext(DbContextOptions<UygulamaDbContext> options): base(options) { }

        public DbSet<KitapTuru> KitapTurleri { get; set; }
    }
}
