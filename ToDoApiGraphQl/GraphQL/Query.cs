using ToDoApiGraphQl.Data;
using ToDoApiGraphQl.Models;

namespace ToDoApiGraphQl.GraphQL
{
    public class Query
    {
        public IQueryable<TaskToDo> GetTask([Service] Context context)
        {
            return context.taskToDo;
        }
    }
}
