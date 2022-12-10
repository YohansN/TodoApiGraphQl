﻿namespace ToDoApiGraphQl.BusinessRules.Requests
{
    public class UpsertTaskRequest
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public bool IsDone { get; set; } = false;
    }
}
