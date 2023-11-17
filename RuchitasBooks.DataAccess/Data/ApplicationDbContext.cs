using RuchitasBooks.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace RuchitasBookStore.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        /*adding CoverType to the DB*/

        public DbSet<CoverType> Covertypes { get; set; }

        /*adding Products to the DB*/

        public DbSet<Product> Products { get; set; }

    }
}