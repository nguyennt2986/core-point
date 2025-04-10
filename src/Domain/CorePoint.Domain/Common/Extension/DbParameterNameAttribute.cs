namespace CorePoint.Domain.Common.Extension;

[AttributeUsage(AttributeTargets.Property)]
public class DbParameterNameAttribute : Attribute
{
    public string Name { get; }
    public DbParameterNameAttribute(string name) => Name = name;
}
