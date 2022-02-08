using System.ComponentModel.DataAnnotations;

namespace Todo.Dtos
{
    public record UpdateTodoDto
    {
        [Required]
        public string Description { get; init; }
    }
}