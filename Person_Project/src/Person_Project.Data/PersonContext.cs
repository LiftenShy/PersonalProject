
using Microsoft.EntityFrameworkCore;
using Person_Project.Data.Model;

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
