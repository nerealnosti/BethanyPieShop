using Bethany.Data.Models.ViewModels;
using Bethany.Data.Repo.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace EmptyMVCCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepositoryAsync _pieRepository;

        public HomeController(IPieRepositoryAsync pieRepository)
        {
            _pieRepository = pieRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PiesOfTheWeek = _pieRepository.PiesOfWeek()
            };

            return View(homeViewModel);
        }
    }
}
