using CorePoint.Domain.Enums;

namespace CorePoint.Domain.Entities;

public record Column
{
    //snowlfake id
    public long Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public string Title { get; init; } = string.Empty;
    public ColumnType Type { get; init; }
    public int Order { get; init; }
    public bool Required { get; init; }
    public bool Sortable { get; init; }
    public bool Groupable { get; init; }
    public bool IsHidden { get; init; } = false;
    public ColumnStatus Status { get; init; } = ColumnStatus.Active;
}
