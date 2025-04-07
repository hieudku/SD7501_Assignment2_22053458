using Microsoft.AspNetCore.Mvc;
using SD7501_Assignment2_22053458.Data;
using SD7501_Assignment2_22053458.Models;

namespace SD7501_Assignment2_22053458.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.Category.ToList();
            return View(objCategoryList);
        }
    }
}
