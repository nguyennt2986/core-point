namespace CorePoint.Domain.Entities;

public record CurrencyColumn : Column
{
    //If it is true, formating currency by user region, otherwise use site region
    //public bool IsPersonalRegion { get; init; } = false;
    public int Region { get; init; } = 1033;//English
    public int? Maximum { get; init; }
    public int? Minimum { get; init; }
    public decimal? DefaultValue { get; init; }
    public int Decimals { get; init; }
}
