using Microsoft.AspNetCore.Mvc;
using SD7501_Assignment2_22053458.Data;
using SD7501_Assignment2_22053458.Models;

namespace SD7501_Assignment2_22053458.Controllers
{
    public class ParkingSlotsController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ParkingSlotsController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<ParkingSlots> objParkingSlotsList = _db.ParkingSlots.ToList();
            return View(objParkingSlotsList);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
