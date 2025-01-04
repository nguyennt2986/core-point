namespace CorePoint.Domain.Entities;

public record CategoryItem
{
    public long Id { get; init; }
    public Guid CategoryId { get; init; }
    public string JsonColumnsValue { get; init; } = string.Empty;
}
