using System;
using System.Collections.Generic;
using System.Text;

namespace Bethany.Data.Models.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> PiesOfTheWeek { get; set; }
    }
}
