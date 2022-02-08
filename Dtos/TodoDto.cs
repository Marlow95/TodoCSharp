namespace Todo.Dtos
{
    public record TodoDto
    {
        public Guid Id { get; init; }
        public string Description { get; init; }
        public DateTimeOffset CreatedAtDate { get; init; }
    }
}