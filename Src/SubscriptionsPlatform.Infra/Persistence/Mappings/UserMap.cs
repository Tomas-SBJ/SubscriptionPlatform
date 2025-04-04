using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage;
using SubscriptionsPlatform.Domain.Entities;

namespace SubscriptionsPlatform.Infra.Persistence.Mappings;

internal class UserMap : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("user");
        
        builder.HasKey(x => x.Id);
        
        builder.HasIndex(x => new
        {
            x.Username,
            x.Password
        }).IsUnique();
        
        builder.Property(x => x.Id)
            .HasColumnName("id");
        
        builder.Property(x => x.Username)
            .HasColumnName("username");
        
        builder.Property(x => x.Password)
            .HasColumnName("password");
    }
}