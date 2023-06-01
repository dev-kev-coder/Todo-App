using Microsoft.EntityFrameworkCore;

// Models
using todo_app.Models;

namespace todo_app.Data
{
    public class TodoDbContext : DbContext
    {

        public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options) { }

        public DbSet<Category>? Categories { get; set; }
        public DbSet<TaskItem>? TaskItems { get; set; }
        public DbSet<ApplicationUser>? ApplicationUsers { get; set; }

    }
}
