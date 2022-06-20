using Microsoft.EntityFrameworkCore;

namespace MenagerZadan.Models
{
    public class TaskManagerContext : DbContext
    {
        public TaskManagerContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<TaskModel> Tasks { get; set; }
    }
}
