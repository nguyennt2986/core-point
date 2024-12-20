namespace CorePoint.Domain.Entities;

public record Category
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTimeOffset CretedOn { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset ModifiedOn { get; set; } = DateTimeOffset.UtcNow;
    public bool IsActive { get; set; }
    public bool IsHidden { get; set; }
    public string ColumnsJson { get; set; } = string.Empty;
}
