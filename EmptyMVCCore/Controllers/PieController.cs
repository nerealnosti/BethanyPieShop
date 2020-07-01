using Bethany.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Bethany.Data.Repo.IRepositories;
using System.Threading.Tasks;
using System.Linq;
using System;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmptyMVCCore.Controllers
{
    public class PieController : Controller
    {

        private readonly IPieRepositoryAsync _pieRepository;
        private readonly ICategoryRepository _categoryRepository;
        // GET: /<controller>/




        public PieController(IPieRepositoryAsync pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }



        public async Task<ViewResult> ListAsync()
        {

            PieListViewModel pieListViewModel = new PieListViewModel
            {
                
                Pies = await _pieRepository.GetAllAsync(),
                CurrentCategory = "Pies"
            };
            return View(pieListViewModel);
        }


        public async Task<IActionResult> Details(int id)
        {

            var pie = await _pieRepository.GetIncludesSingleWithID(x => x.PieId == id, s => s.Category);
            if(pie is null) return NotFound();
            
            return View(pie);
        }
    }
}
