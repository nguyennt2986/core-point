# Dự án Web Application giống SharePoint

## 🧱 Cấu trúc thư mục dự án

```text
src/
├── Core/
│   ├── Domain/
│   │   ├── Entities/
│   │   │   ├── Category.cs
│   │   │   └── CategoryItem.cs
│   │   ├── Interfaces/
│   │   │   └── Repositories/
│   │   │       ├── ICategoryRepository.cs
│   │   │       └── ICategoryItemRepository.cs
│   │   └── Common/
│   │       ├── ValueObjects/         // Enum, struct, logic thuần Domain
│   │       ├── Extensions/           // Nếu có logic mở rộng cho domain
│   │       └── ISnowflakeIdGenerator.cs
│
├── Application/
│   ├── Features/
│   │   ├── Category/
│   │   │   ├── Commands/
│   │   │   ├── Queries/
│   │   │   └── Dtos/
│   │   └── CategoryItem/
│   ├── Services/
│   │   ├── ICategoryService.cs
│   │   ├── ICategoryItemService.cs
│   │   └── Implementations/
│   │       ├── CategoryService.cs
│   │       └── CategoryItemService.cs
│   └── Common/
│       ├── Mapping/
│       │   └── MappingProfiles.cs
│       └── Validation/ (nếu dùng FluentValidation)
│
├── Infrastructure/
│   ├── Persistence/
│   │   ├── EF/
│   │   │   ├── ApplicationDbContext.cs
│   │   │   └── Configurations/
│   │   │       ├── CategoryConfiguration.cs
│   │   │       └── CategoryItemConfiguration.cs
│   │   ├── Dapper/
│   │   │   ├── DapperDbContext.cs
│   │   │   └── Queries/
│   │   │       ├── CategoryDapperRepository.cs
│   │   │       └── CategoryItemDapperRepository.cs
│   │   └── Repositories/
│   │       ├── CategoryRepository.cs
│   │       └── CategoryItemRepository.cs
│   ├── Identity/                     // Nếu có auth
│   └── Snowflake/
│       ├── SnowflakeOptions.cs
│       ├── SnowflakeIdGenerator.cs
│       └── DependencyInjection.cs
│
├── WebApi/
│   ├── Controllers/
│   │   ├── CategoryController.cs
│   │   └── CategoryItemController.cs
│   ├── DependencyInjection/
│   │   ├── ServiceCollectionExtensions.cs
│   │   └── SnowflakeSetup.cs
│   └── Program.cs
```


## 💡 Ghi chú

- **Core**: chứa các logic nghiệp vụ, interface, value object, entity.
- **Application**: xử lý các luồng use case chính, mapping, validation, dto.
- **Infrastructure**: nơi triển khai persistence (EF + Dapper), auth, snowflake ID, caching...
- **WebApi**: entry point vào hệ thống, controller và cấu hình dependency injection.

---

Bạn muốn mình bổ sung thêm gì không? Ví dụ: hướng dẫn setup, build, run, hoặc diagram kiến trúc?
