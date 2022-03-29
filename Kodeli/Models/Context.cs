using Kodeli.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace Kodeli.Models
{
    public class Context: DbContext 
       
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=NAZLI\\NAZLI; database=Kodeli; integrated security=true;");

        }
        public DbSet<TanimlarTur> TanimlarTur { get; set; }
        public DbSet<Tanimlar> Tanimlar { get; set; }
        public DbSet<Basvuru> Basvuru { get; set; }
        public DbSet<Il> Il { get; set; }
        public DbSet<Ilce> Ilce { get; set; }
        public DbSet<Okul> Okul { get; set; }
        public DbSet<Ulke> Ulke { get; set; }
        public DbSet<YarismaTanim> YarismaTanim { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            foreach (var relationship in modelbuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(modelbuilder);
        }
    }


}
