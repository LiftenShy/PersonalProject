
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
    }
    
    /*protected override OnModelCreating(ModelBuilder modelBuilder)
    {
       
    }*/
}
