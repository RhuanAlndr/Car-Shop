using CarShop.Data;
using CarShop.Models;
using Microsoft.AspNetCore.Mvc;
using CarShop.Functions;
using Microsoft.EntityFrameworkCore;

namespace CarShop.Controllers
{
    public class CarController : Controller
    {
        private readonly DataContext _dataContext;
        private readonly ICar _iCar;

        public CarController(DataContext dataContext, ICar iCar)
        {
            _dataContext = dataContext;
            _iCar = iCar;
        }

        public IActionResult Index()
        {
            ViewBag.Cars = _dataContext.Cars.Include(b => b.Brand).ToList();

            return View();
        }

        public IActionResult Create()
        {
            ViewBag.Brands = _dataContext.Brands.ToList();

            return View();
        }
        
        [HttpPost]
        public IActionResult Create(Car car)
        {
            if (ModelState.IsValid)
            {
                _iCar.AddCar(car);
                return RedirectToAction("Index");
            }
            ViewBag.Brands = _dataContext.Brands.ToList();
            return View(car);
        }
        
        public IActionResult Edit(int id)
        {
            if (ModelState.IsValid)
            {
                var c = _dataContext.Cars.Find(id);
                if(c == null)
                {
                    return NotFound();
                }

                ViewBag.Brands = _dataContext.Brands.ToList();
                return View(c);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Edit(Car car)
        {
            if(ModelState.IsValid)
            {
                _iCar.EditCar(car);

                return RedirectToAction("Index");
            }
            return NotFound();
        }

        public IActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                var car = _dataContext.Cars.Find(id);
                if (car == null)
                {
                    return NotFound();
                }
                return View(car);
            }
            return NotFound();
        }

        public IActionResult DeleteConfirmed(int id)
        {
            _iCar.DeleteCar(id);

            return RedirectToAction("Index");
        }

    }
}
