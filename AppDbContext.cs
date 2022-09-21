using Labb_1_MVC_o_Razor_v2.Models;
using Microsoft.EntityFrameworkCore;

namespace Labb_1_MVC_o_Razor_v2
{
    public class AppDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Loan> Loans { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().HasData(new Book { ID = 1, Title = "Hazing Week: Destroy your liver in 4 days", Author = "Lamb O. Paul Yewkas" });
            modelBuilder.Entity<Book>().HasData(new Book { ID = 2, Title = "The Moonshining", Author = "Stephen Dringk" });
            modelBuilder.Entity<Book>().HasData(new Book { ID = 3, Title = "The Bro-Code", Author = "Dan Bro" });
        }
    }
}
