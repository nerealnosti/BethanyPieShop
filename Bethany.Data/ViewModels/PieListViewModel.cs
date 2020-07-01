using Bethany.Data.Models;
using System.Collections.Generic;

namespace Bethany.Data.ViewModels
{
    public class PieListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }
        public string CurrentCategory { get; set; }
    }
}
