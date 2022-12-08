using ToDoApiGraphQl.Models;

namespace ToDoApiGraphQl.Repositories.Interfaces
{
    public interface ITaskRepository
    {
        IQueryable<Todo> GetAll();
        Todo GetById(int id);
        void Create(Todo task);
        Todo Update(Todo task);
        void Delete(Todo task);
    }
}
