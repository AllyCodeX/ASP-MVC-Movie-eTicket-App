using eTicket.Models;
using Microsoft.EntityFrameworkCore;

namespace eTicket.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options): base(options )    
        {
                
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movies>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });
            modelBuilder.Entity<Actor_Movies>().HasOne(m=>m.Movie).WithMany(am=>am.Actor_Movies).HasForeignKey(am=>am.MovieId);
            modelBuilder.Entity<Actor_Movies>().HasOne(m => m.Actor).WithMany(am => am.Actor_Movies).HasForeignKey(am => am.ActorId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Cinema> Cinema { get; set; }    
        public DbSet<Actor_Movies> Actor_Movies { get; set; }

    }
}
