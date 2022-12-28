using ToDoApiGraphQl.Data;
using ToDoApiGraphQl.GraphQL.Tasks;
using ToDoApiGraphQl.GraphQL.Users;
using ToDoApiGraphQl.Models;

namespace ToDoApiGraphQl.GraphQL
{
    public class Mutation
    {
        [UseDbContext(typeof(Context))]
        public async Task<AddUserPayload> AddUserAsync(AddUserInput userInput, [ScopedService] Context context)
        {
            var user = new User
            {
                Name = userInput.Name
            };
            context.User.Add(user);
            await context.SaveChangesAsync();
            return new AddUserPayload(user);
        }

        [UseDbContext(typeof(Context))]
        public async Task<bool> DeleteUserAsync(int id, [ScopedService] Context context)
        {
            var user = await context.User.FindAsync(id);
            if (user == null)
                return false;

            context.User.Remove(user);
            await context.SaveChangesAsync();
            return true;
        }

        [UseDbContext(typeof(Context))]
        public async Task<AddTaskPayload> AddTaskAsync(AddTaskInput taskInput, [ScopedService] Context context)
        {
            var task = new TaskToDo
            {
                Title = taskInput.Title,
                Description = taskInput.Description,
                IsDone = taskInput.IsDone,
                UserId = taskInput.UserId
            };
            context.TaskToDo.Add(task);
            await context.SaveChangesAsync();
            return new AddTaskPayload(task);
        }
    }
}
