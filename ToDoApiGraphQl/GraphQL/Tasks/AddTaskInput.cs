namespace ToDoApiGraphQl.GraphQL.Tasks
{
    public record AddTaskInput(string Title, string Description, bool IsDone, int UserId);
}
