using CorePoint.Domain.Enums.DateTime;

namespace CorePoint.Domain.Entities;

public record DateTimeColumnSettings : ColumnSettings
{
    public DateTime DefaultValue { get; set; }

    public DateTimeColumnFormat Format { get; set; } = DateTimeColumnFormat.DateTime;

    public DateTimeDisplayFormat DisplayFormat { get; set; } = DateTimeDisplayFormat.Standard;
}
