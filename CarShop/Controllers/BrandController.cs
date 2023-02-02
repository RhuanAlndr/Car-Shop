using Microsoft.AspNetCore.Mvc;
using CarShop.Data;
using CarShop.Models;
using CarShop.Functions;

namespace CarShop.Controllers
{
    public class BrandController : Controller
    {
        readonly DataContext _dataContext;
        readonly IBrand _iBrand;

        public BrandController(DataContext dataContext, IBrand iBrand)
        {
            _dataContext = dataContext;
            _iBrand = iBrand;
        }

        public IActionResult Index()
        {
            List<Brand> brands = new List<Brand>(_dataContext.Brands);
            return View(brands);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Brand brand)
        {
            if (ModelState.IsValid)
            {
                _iBrand.AddBrand(brand);
                return RedirectToAction("Index");
            }

            return View(brand);
        }

        public IActionResult Edit(int Id)
        {
            if (_dataContext.Brands != null)
            {
                var b = _dataContext.Brands.Find(Id);
                if (b == null)
                {
                    return NotFound();
                }
                return View(b);
            }
            
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(Brand brand)
        {
            if(ModelState.IsValid)
            {
                _iBrand.EditBrand(brand);
                return RedirectToAction("Index");
            }
            return View(brand);
        }

        public IActionResult Delete(int id)
        {
            var brand = _dataContext.Brands.Find(id);
            if(brand == null)
            {
                NotFound();
            }
            return View(brand);
        }

        public IActionResult DeleteConfirmed(int id)
        {
            _iBrand.DeleteBrand(id);

            return RedirectToAction("Index");
        }
        
    }
}
