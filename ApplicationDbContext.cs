using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using test_two.Models;

namespace test_two
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
    }
}
