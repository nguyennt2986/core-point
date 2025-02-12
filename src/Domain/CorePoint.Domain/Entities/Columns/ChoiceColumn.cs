using CorePoint.Domain.Enums;

namespace CorePoint.Domain.Entities;

public record ChoiceColumn : Column
{
    public string DefaultValue { get; init; } = string.Empty;
    public IEnumerable<string> Choices { get; init; } = [];

    public ChoiceFormat Format { get; init; }
}
