namespace CorePoint.Domain.Entities;

public record ChoiceColumn : Column
{
    public bool Multi { get; init; }
    public string DefaultValue { get; init; } = string.Empty;
    public IEnumerable<string> Choices { get; init; } = [];
}
