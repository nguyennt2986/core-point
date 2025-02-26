namespace CorePoint.Domain.Entities;

public record CategoryItem
{
    public long Id { get; init; }
    public Guid CategoryId { get; init; }
    public DateTimeOffset CretedOn { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset ModifiedOn { get; set; } = DateTimeOffset.UtcNow;
    public string JsonData { get; init; } = string.Empty;
}
