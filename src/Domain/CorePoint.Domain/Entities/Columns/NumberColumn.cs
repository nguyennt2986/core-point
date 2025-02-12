namespace CorePoint.Domain.Entities;

public record NumberColumn : Column
{
    public int Decimals { get; init; } = 0;

    /// <summary>
    /// When it is true then the user input value will divide 100 and store Db.
    /// </summary>
    public bool IsPercentage { get; init; }
    public int? Minimum { get; init; }
    public int? Maximum { get; init; }
    public decimal? DefaultValue { get; init; }
}
