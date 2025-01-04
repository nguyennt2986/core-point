namespace CorePoint.Domain.Entities;

public record EmailColumn : Column
{
    public int MaxLength { get; init; } = 255;
    public string Error { get; init; } = string.Empty;
}
