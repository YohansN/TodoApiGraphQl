﻿using ToDoApiGraphQl.Data;
using ToDoApiGraphQl.Models;

namespace ToDoApiGraphQl.GraphQL
{
    public class Query
    {
        [UseDbContext(typeof(Context))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<TaskToDo> GetTask([ScopedService] Context context)
        {
            return context.TaskToDo;
        }

        [UseDbContext(typeof(Context))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<User> GetUser([ScopedService] Context context)
        {
            return context.User;
        }
    }
}
