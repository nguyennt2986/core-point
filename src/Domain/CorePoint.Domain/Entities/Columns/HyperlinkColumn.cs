using CorePoint.Domain.Enums;

namespace CorePoint.Domain.Entities;

public record HyperlinkColumn : Column
{
    public HyperlinkFormat Format { get; set; }
}
