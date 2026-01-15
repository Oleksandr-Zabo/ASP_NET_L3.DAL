using ASP_NET_L3.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASP_NET_L3.DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure Book entity
            modelBuilder.Entity<Book>(entity =>
            {
                // Configure decimal precision for Price
                entity.Property(b => b.Price)
                    .HasPrecision(18, 2); // 18 digits total, 2 after decimal point

                // Configure ISBN as unique
                entity.HasIndex(b => b.ISBN)
                    .IsUnique();

                // Configure relationship with Author
                entity.HasOne(b => b.Author)
                    .WithMany()
                    .HasForeignKey(b => b.AuthorId)
                    .OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}
