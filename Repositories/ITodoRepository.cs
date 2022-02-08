using Todo.Entities;

namespace Todo.Repositories
{
    public interface ITodoRepositories
    {
        Task<TodoList>  GetTodoAsync(Guid id);
        Task<IEnumerable<TodoList>> GetTodoAsync();

        Task CreateTodoAsync(TodoList todoList);
        Task UpdateTodoAsync(TodoList todoList);
        Task DeleteTodoAsync(Guid id);
    }
}