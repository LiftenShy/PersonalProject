
using Microsoft.EntityFrameworkCore;
using Person_Project.Models.EntityModels;
using Person_Project.Models.EntityModels.AuthModels;

namespace Person_Project.Data
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
}
