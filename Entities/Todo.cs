namespace Todo.Entities
{
    public record TodoList
    {
        public Guid Id { get; init; }
        public string Description { get; init; }

        public DateTimeOffset CreatedAtDate { get; init; }
    }
}