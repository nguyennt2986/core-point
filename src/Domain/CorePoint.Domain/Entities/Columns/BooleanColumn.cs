namespace CorePoint.Domain.Entities;

public record BooleanColumn : Column
{
    public bool DefaultValue { get; init; }
}
