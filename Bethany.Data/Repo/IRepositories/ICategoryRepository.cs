using Bethany.Data.Models;
using System.Collections.Generic;

namespace Bethany.Data.Repo.IRepositories

{
    public interface ICategoryRepository : IRepositoryAsync<Category>
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
