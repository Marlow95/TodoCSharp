using Todo.Entities;
using Todo.Dtos;

namespace Todo
{
    public static class Extentions
    {
        public static TodoDto AsDto(this TodoList todo)
        {
            return new TodoDto {
                Id = todo.Id,
                Description = todo.Description,
                CreatedAtDate = todo.CreatedAtDate
            };
        }
    }
}