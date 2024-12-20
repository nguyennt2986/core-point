using CorePoint.Domain.Enums;

namespace CorePoint.Domain.Entities;

public record Column
{
    public Guid Id { get; init; }
    public string StaticName { get; init; } = string.Empty;
    public string DisplayName { get; init; } = string.Empty;
    public ColumnType Type { get; init; }
    public int Order { get; init; }
    public bool Required { get; init; }

    public Column(ColumnSettings settings)
    {
        Id = settings.Id;
        StaticName = settings.StaticName;
        DisplayName = settings.DisplayName;
        Type = settings.Type;
        Order = settings.Order;
        Required = settings.Required;
    }
}
