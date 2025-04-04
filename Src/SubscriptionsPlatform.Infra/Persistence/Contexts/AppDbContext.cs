using Microsoft.EntityFrameworkCore;
using SubscriptionsPlatform.Domain.Entities;
using SubscriptionsPlatform.Infra.Persistence.Mappings;

namespace SubscriptionsPlatform.Infra.Persistence.Contexts;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        
        modelBuilder.ApplyConfiguration(new UserMap());
    }
}