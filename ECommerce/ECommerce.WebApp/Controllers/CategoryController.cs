using ECommerce.WebApp.Models.Data;
using ECommerce.WebApp.Models.View;
using ECommerce.WebApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebApp.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryRepository<CategoryView, Category> _repo;
        public CategoryController(ICategoryRepository<CategoryView, Category> repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            List<CategoryView> categories = _repo.GetAll()
                .Select(o => new CategoryView()
                {
                    Id = o.Id,
                    ShortName = o.ShortName,
                    LongName = o.LongName,
                    Description = o.Description,
                    Active = o.Active
                }).ToList();
            return View(categories);
        }
    }
}
