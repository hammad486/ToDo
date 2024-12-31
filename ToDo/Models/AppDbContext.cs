using Microsoft.EntityFrameworkCore;

namespace ToDo.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
       
        {
            
        }
        public DbSet<TodoTask> Tasks { get; set; }
    }
}
