
using Microsoft.EntityFrameworkCore;
using SocialMusic.Models.EntityModels;
using SocialMusic.Models.EntityModels.AuthModels;

namespace SocialMusic.Data
{
    public class PersonContext : DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> options)
            : base(options)
        { }

        public DbSet<Person> Persons { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }

        public DbSet<UserProfile> UserProfiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasMany(ur => ur.UserProfiles)
                       .WithOne(ur => ur.UserRole);
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasMany(ur => ur.Roles)
                       .WithOne(ur => ur.UserRole);
            });
        }
    }
}
