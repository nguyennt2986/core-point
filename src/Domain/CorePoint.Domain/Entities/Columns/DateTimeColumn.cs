using CorePoint.Domain.Enums.DateTime;

namespace CorePoint.Domain.Entities;

public record DateTimeColumn : Column
{
    public DateTime DefaultValue { get; init; }
    public DateTimeColumnFormat Format { get; init; } = DateTimeColumnFormat.DateTime;
    public DateTimeDisplayFormat DisplayFormat { get; init; } = DateTimeDisplayFormat.Standard;
}
