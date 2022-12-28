using ToDoApiGraphQl.Data;
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
    }
}
