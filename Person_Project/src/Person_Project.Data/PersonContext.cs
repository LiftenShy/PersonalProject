
using Microsoft.EntityFrameworkCore;
using Person_Project.Models.EntityModels;

namespace Person_Project.Data
{
    public class PersonContext : DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> options)
            : base(options)
        { }

        public DbSet<Person> Persons { get; set; }
    }
}
