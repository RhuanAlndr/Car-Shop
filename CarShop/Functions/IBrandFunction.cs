using CarShop.Models;
using CarShop.Data;

namespace CarShop.Functions
{
    public class IBrandFunction : IBrand
    {
        readonly DataContext _dataContext;
        public IBrandFunction(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public Brand AddBrand(Brand brand)
        {
            _dataContext.Brands.Add(brand);
            _dataContext.SaveChanges();

            return brand;
        }

        public Brand DeleteBrand(int id)
        {
            var b = _dataContext.Brands.Find(id);
            if (b == null)
            {
                throw new Exception("Deu ruim!");
            }
            _dataContext.Brands.Remove(b);
            _dataContext.SaveChanges();

            return b;
        }

        public Brand EditBrand(Brand brand)
        {
            var b = _dataContext.Brands.Find(brand.Id);
            if (b == null)
            {
                throw new Exception("Deu ruim!");
            }
            b.Name = brand.Name;
            _dataContext.Brands.Update(b);
            _dataContext.SaveChanges();

            return brand;
        }
    }
}
