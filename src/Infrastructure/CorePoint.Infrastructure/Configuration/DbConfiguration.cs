namespace CorePoint.Infrastructure;

public class DbConfiguration
{
    public string ConnectionString { get; set; } = string.Empty;
    public int Timeout { get; set; } = 10;

    /// <summary>
    /// true if use dapper to work with Database
    /// </summary>
    public bool IsDapper { get; set; } = true;
}
