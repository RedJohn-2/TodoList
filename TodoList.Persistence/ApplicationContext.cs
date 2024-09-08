using Microsoft.EntityFrameworkCore;
using TodoList.Model;

namespace TodoList.Persistence
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Note> Notes { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
    }
}
