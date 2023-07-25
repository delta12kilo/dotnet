using BullkyBookWeb.Data;
using BullkyBookWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BullkyBookWeb.Controllers
{
    public class CategoryController : Controller
    {
        public readonly ApplicationDbContext _ad;
       
        public CategoryController(ApplicationDbContext ad)
        {
            _ad = ad;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> getCategorydata = _ad.Categories;

            return View(getCategorydata);
        }
    }
}
