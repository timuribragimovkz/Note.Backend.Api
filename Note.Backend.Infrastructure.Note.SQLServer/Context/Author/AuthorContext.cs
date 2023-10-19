using Microsoft.EntityFrameworkCore;
using Note.Backend.Infrastructure.SQLServer.Models;

namespace Note.Backend.Infrastructure.SQLServer.Context.Author;

public class AuthorContext : DbContext
{
    public AuthorContext(DbContextOptions<AuthorContext> options) : base(options)
    {

    }
    public DbSet<AuthorDto> AuthorDtos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AuthorDto>()
            .ToTable("AuthorData");

        modelBuilder.Entity<AuthorDto>()
            .Property(r => r.Name)
            .HasColumnType("nvarchar(255)");
    }
}
