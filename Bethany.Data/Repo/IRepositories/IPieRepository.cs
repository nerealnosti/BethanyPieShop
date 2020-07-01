using Bethany.Data.Models;
using System.Collections.Generic;

namespace Bethany.Data.Repo.IRepositories
{
    public interface IPieRepositoryAsync : IRepositoryAsync<Pie>
    {
        IEnumerable<Pie> PiesOfWeek();
    }
}
