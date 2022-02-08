using System.ComponentModel.DataAnnotations;

namespace Todo.Dtos
{
    public record CreateTodoDto
    {
        [Required]
        public string Description {get; init;}
    }
}