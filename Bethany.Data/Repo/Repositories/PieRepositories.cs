using Bethany.Data.DatabaseContext;
using Bethany.Data.Models;
using Bethany.Data.Repo.IRepositories;
using FoodGood.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bethany.Data.Repo.Repositories
{
    public class PieRepositories : RepositoryAsync<Pie>, IPieRepositoryAsync
    {
        public PieRepositories(AppDbContext dbContext) : base(dbContext)
        { }


        public IEnumerable<Pie> PiesOfWeek()
        {
            return _dbentities.Include(c => c.Category).Where(p => p.IsPieOfTheWeek);

        }




    }
}
