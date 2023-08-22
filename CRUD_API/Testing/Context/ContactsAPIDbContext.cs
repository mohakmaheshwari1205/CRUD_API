using Microsoft.EntityFrameworkCore;
using Testing.Models;

namespace Testing.Context
{
    public class ContactsAPIDbContext : DbContext
    {
        public ContactsAPIDbContext(DbContextOptions<ContactsAPIDbContext> options) : base(options)
        {

        }

        public DbSet<Contacts> contacts { get; set; } 
    }
}
