using System.ComponentModel.DataAnnotations;

namespace ToDoApiGraphQl.Models
{
    [GraphQLDescription("Represents an user of the sistem.")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public ICollection<TaskToDo>? TaskToDo { get; set; } = new List<TaskToDo>();
    }
}
