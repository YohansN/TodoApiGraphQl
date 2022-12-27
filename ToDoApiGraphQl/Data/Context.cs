using Microsoft.EntityFrameworkCore;
using ToDoApiGraphQl.Models;

namespace ToDoApiGraphQl.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options){}
        public DbSet<TaskToDo> TaskToDo { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<User>()
                .HasMany(u => u.TaskToDo)
                .WithOne(u => u.User!)
                .HasPrincipalKey(u => u.Id)
                .HasForeignKey(u => u.UserId);

            modelBuilder
                .Entity<TaskToDo>()
                .HasOne(t => t.User!)
                .WithMany(t => t.TaskToDo)
                .HasPrincipalKey(t => t.Id)
                .HasForeignKey(t => t.UserId);
        }
    }
}
