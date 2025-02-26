namespace CorePoint.Domain.Entities;

public record BooleanItem
{
    public Guid ColumnId { get; init; }
    public string Name { get; init; } = string.Empty;
    public bool Value { get; init; }
}
