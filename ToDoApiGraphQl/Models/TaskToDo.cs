using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoApiGraphQl.Models
{
    [GraphQLDescription("Represents tasks of an user.")]
    public class TaskToDo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string? Description { get; set; }
        public bool IsDone { get; set; } = false;

        [Required]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
