using CorePoint.Domain.Enums.DateTime;

namespace CorePoint.Domain.Entities;

public record DateTimeColumn : Column
{
    public DateTime DefaultValue { get; set; }

    public DateTimeColumnFormat Format { get; set; } = DateTimeColumnFormat.DateTime;

    public DateTimeDisplayFormat DisplayFormat { get; set; } = DateTimeDisplayFormat.Standard;

    public DateTimeColumn(DateTimeColumnSettings settings)
        : base(settings)
    {
        DefaultValue = settings.DefaultValue;
        Format = settings.Format;
        DisplayFormat = settings.DisplayFormat;
    }
}
