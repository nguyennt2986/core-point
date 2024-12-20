namespace CorePoint.Domain.Entities;

public record TextColumnSettings : ColumnSettings
{
    public int MaxLength { get; set; } = 255;
    public string DefaultVale { get; set; } = string.Empty;
}
