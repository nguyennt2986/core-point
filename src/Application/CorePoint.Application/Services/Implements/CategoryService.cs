using CorePoint.Domain.Entities;
using CorePoint.Infrastructure;

namespace CorePoint.Application.Services;

internal class CategoryService : ICategoryService
{
    private readonly IQueryRepository<Category> _queryRepo;
    private readonly ICommandRepository<Category> _commandRepo;

    public CategoryService(IQueryRepository<Category> queryRepository, ICommandRepository<Category> commandRepository)
    {
        _queryRepo = queryRepository;
        _commandRepo = commandRepository;
    }

    public IEnumerable<Category> Get()
    {
        //_queryRepo.GetAll();
        throw new NotImplementedException();
    }

    public ValueTask<IEnumerable<Category>> GetAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async ValueTask<bool> CreateAsync(Category category, CancellationToken cancellationToken = default)
    {
        if (cancellationToken.IsCancellationRequested)
            return false;
        var param = Helper.BuildParameters(category);
        return await _commandRepo.CreateAsync(param, "", cancellationToken);
    }
}
