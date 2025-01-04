namespace CorePoint.Domain.DTOs
{
    public class CategoryArgs
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTimeOffset CretedOn { get; set; } = DateTimeOffset.UtcNow;
        public DateTimeOffset ModifiedOn { get; set; } = DateTimeOffset.UtcNow;
        public bool IsActive { get; set; }
        public bool IsHidden { get; set; }
        public string ColumnsJson { get; set; } = string.Empty;

        public CategoryArgs(string name, bool active, bool isHidden, string columnsJson)
        {
            Id = Guid.NewGuid();
            Name = name;
            IsActive = active;
            IsHidden = isHidden;
            ColumnsJson = columnsJson;
        }
    }
}
