using ToDoApiGraphQl.Data;
using ToDoApiGraphQl.Models;

namespace ToDoApiGraphQl.GraphQL
{
    public class Query
    {
        [UseDbContext(typeof(Context))]
        public IQueryable<TaskToDo> GetTask([ScopedService] Context context)
        {
            return context.TaskToDo;
        }
    }
}
