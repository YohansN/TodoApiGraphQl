using Microsoft.EntityFrameworkCore;

namespace ToDoApiGraphQl.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options){}
        DbSet<Task> Tasks { get; set; }
    }
}
