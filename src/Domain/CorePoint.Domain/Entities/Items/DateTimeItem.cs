namespace CorePoint.Domain.Entities;

public record DateTimeItem
{
    public Guid ColumnId { get; init; }
    public string Name { get; init; } = string.Empty;
    public DateTimeOffset Value { get; init; }
}
