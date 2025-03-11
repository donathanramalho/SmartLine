using Microsoft.EntityFrameworkCore;

namespace SmartLine.Shared.Model;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options) : base(options) { }

    public DbSet<Todo> TodoItems { get; set; }
    
}