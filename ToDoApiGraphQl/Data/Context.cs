using Microsoft.EntityFrameworkCore;
using ToDoApiGraphQl.Models;

namespace ToDoApiGraphQl.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options){}
        public DbSet<Todo> Tasks { get; set; }
    }
}
