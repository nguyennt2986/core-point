namespace CorePoint.Domain.Entities;

public record ChoiceItem
{
    public Guid ColumnId { get; init; }
    public string Name { get; init; } = string.Empty;
    public string Value { get; init; } = string.Empty;
}
