namespace CorePoint.Domain.Entities;

public record ReferenceColumn : Column
{
    public Guid CategoryId { get; init; }
    public Guid ShowColumnId { get; init; }
    public bool IsMult { get; init; }
}
