using Microsoft.EntityFrameworkCore.Diagnostics;
using ToDoApiGraphQl.Data;
using ToDoApiGraphQl.Models;
using ToDoApiGraphQl.Repositories.Interfaces;

namespace ToDoApiGraphQl.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly Context _context;
        public TaskRepository(Context context)
        {
            _context = context;
        }

        public IQueryable<Todo> GetAll() => _context.Tasks.AsQueryable();

        public Todo GetById(int id) => _context.Tasks.SingleOrDefault(t => t.Id == id);

        public void Create(Todo task)
        {
            _context.Tasks.Add(task);
            _context.SaveChanges();
        }

        public Todo Update(Todo task)
        {
            _context.Tasks.Update(task);
            _context.SaveChanges();
            return task;
        }

        public void Delete(Todo task)
        {
            _context.Tasks.Remove(task);
            _context.SaveChanges();
        } 
    }
}
