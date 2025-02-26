﻿using CorePoint.Domain.Entities;

namespace CorePoint.Application.Services
{
    public interface ICategoryService
    {
        IEnumerable<Category> Get();
        ValueTask<IEnumerable<Category>> GetAsync(CancellationToken cancellationToken = default);

        ValueTask<bool> CreateAsync(Category category, CancellationToken cancellationToken = default);

    }
}
