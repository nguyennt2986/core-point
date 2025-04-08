using CorePoint.Domain.Extension;

namespace CorePoint.Domain.Entities;

public record Category
{
    //viet 1 attribute để build dynamicparameters ứng với param trong store procedure

    public long Id { get; set; }

    [DbParameterName("@CategoryName")]
    public string Name { get; set; } = string.Empty;
    public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset ModifiedOn { get; set; } = DateTimeOffset.UtcNow;
    public bool IsActive { get; set; }
    public bool IsHidden { get; set; }
    public string ColumnsJson { get; set; } = string.Empty;
}
