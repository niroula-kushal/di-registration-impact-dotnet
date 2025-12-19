using Microsoft.EntityFrameworkCore;
using stream_response_ef_core.Models;

namespace stream_response_ef_core.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Item> Items { get; set; } = null!;
}
