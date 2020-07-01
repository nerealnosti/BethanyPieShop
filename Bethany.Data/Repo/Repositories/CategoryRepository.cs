using Bethany.Data.DatabaseContext;
using Bethany.Data.Models;
using Bethany.Data.Repo.IRepositories;
using FoodGood.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bethany.Data.Repo.Repositories
{
    public class CategoryRepository : RepositoryAsync<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<Category> AllCategories { get; }
    }
}
