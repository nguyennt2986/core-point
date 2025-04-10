using CorePoint.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CorePoint.Infrastructure.Ef;

public class ApplicationDbContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<CategoryItem> CategoryItems { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
