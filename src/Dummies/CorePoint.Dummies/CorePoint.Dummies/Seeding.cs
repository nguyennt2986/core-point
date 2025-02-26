
using System.Text.Json;
using CorePoint.Application.Services;
using CorePoint.Domain.Entities;
using CorePoint.Domain.Enums;
using CorePoint.Domain.Enums.DateTime;
using CorePoint.Infrastructure;

namespace CorePoint.Dummies
{
    public class Seeding : IHostedService
    {
        private readonly ICommandRepository<Category> _cateRepo;
        private readonly ICommandRepository<CategoryItem> _itemRepo;
        private readonly ICategoryService _categoryService;

        public Seeding(ICommandRepository<Category> cateRepo, ICommandRepository<CategoryItem> itemRepo, ICategoryService categoryService)
        {
            _cateRepo = cateRepo;
            _itemRepo = itemRepo;
            _categoryService = categoryService;
        }
        public async Task StartAsync(CancellationToken cancellationToken)
        {
            //var departmentId = await CreateDepartment();

        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        private async ValueTask<Guid> CreateCategoryAsync(string name, string jsonCols)
        {
            Guid id = Guid.NewGuid();

            var category = new Category
            {
                CretedOn = DateTimeOffset.Now,
                Id = id,
                IsActive = true,
                IsHidden = false,
                Name = name,
                ColumnsJson = jsonCols
            };
            if (await _categoryService.CreateAsync(category))
                return id;
            return Guid.Empty;
        }

        private async ValueTask<Guid> CreateDeptCategory()
        {
            var cols = new List<Column>();
            var col = new TextColumn
            {
                Name = "Title",
                Title = "Tên phòng ban",
                Id = Guid.Parse("b74e9415-a643-4086-96e5-661ceca73e38"),
                IsHidden = false,
                Required = true
            };
            cols.Add(col);
            var jsonCols = JsonSerializer.Serialize(cols);
            return await CreateCategoryAsync("Department", jsonCols);
        }

        private async ValueTask<Guid> CreateEmpCategory(Guid lookupSourceId)
        {
            var cols = new List<Column>
            {
                new TextColumn
                {
                    Id = Guid.NewGuid(),
                    Type = ColumnType.Text,
                    Name = "Name",
                    Title = "Tên nhân viên",
                    IsHidden = false,
                    Required = true,
                    Order = 1
                },
                new TextColumn
                {
                    Id = Guid.NewGuid(),
                    Type = ColumnType.Text,
                    Name = "Address",
                    Title = "Địa chỉ",
                    IsHidden = false,
                    Required = true,
                    Order = 2
                },
                new ChoiceColumn
                {
                    Id = Guid.NewGuid(),
                    Type = ColumnType.Choice,
                    Name = "Position",
                    Title = "Chức vụ",
                    IsHidden = false,
                    Required = true,
                    Order = 3,
                    Choices = ["Nhân viên", "Trưởng nhóm", "Giám đốc"],
                    DefaultValue = "Nhân viên",

                },
                new CurrencyColumn
                {
                    Id = Guid.NewGuid(),
                    Type = ColumnType.Currency,
                    Name = "Currency",
                    Title = "Lương",
                    IsHidden = false,
                    Required = true,
                    Order = 4,
                    Decimals =2,
                    Region = 1033
                },
                new DateTimeColumn
                {
                    Id = Guid.NewGuid(),
                    Type = ColumnType.Currency,
                    Name = "WorkingDate",
                    Title = "Ngày vào làm",
                    IsHidden = false,
                    Required = true,
                    Order = 5,
                    DisplayFormat = DateTimeDisplayFormat.Standard,
                    Format = DateTimeColumnFormat.DateOnly

                },
                new BooleanColumn
                {
                    Id = Guid.NewGuid(),
                    Type = ColumnType.Currency,
                    Name = "Active",
                    Title = "Còn làm việc",
                    IsHidden = false,
                    Required = true,
                    Order = 6,
                    DefaultValue = true
                },
                new ReferenceColumn
                {
                    Id = Guid.NewGuid(),
                    Type = ColumnType.Currency,
                    Name = "Department",
                    Title = "Phòng ban",
                    IsHidden = false,
                    Required = true,
                    Order = 7,
                    CategoryId = lookupSourceId,
                    ShowColumnId = Guid.Parse("b74e9415-a643-4086-96e5-661ceca73e38")// Title column of department category                    
                }

            };
            var jsonCols = JsonSerializer.Serialize(cols);
            return await CreateCategoryAsync("Department", jsonCols);
        }
    }
}
