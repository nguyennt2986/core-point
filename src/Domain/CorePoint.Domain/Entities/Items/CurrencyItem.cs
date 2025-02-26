namespace CorePoint.Domain.Entities;

public record CurrencyItem
{
    public Guid ColumnId { get; init; }
    public string Name { get; init; } = string.Empty;
    public decimal Value { get; init; }
}
