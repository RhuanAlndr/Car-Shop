using CarShop.Models;
using CarShop.Data;

namespace CarShop.Functions
{
    public class ICarFunction : ICar
    {
        readonly DataContext _dataContext;

        public ICarFunction(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Car AddCar(Car car)
        {
            _dataContext.Cars.Add(car);
            _dataContext.SaveChanges();

            return car;
        }

        public Car EditCar(Car car)
        {
            var c = _dataContext.Cars.Find(car.Id);
            if(c == null)
            {
                throw new Exception("Deu ruim!");
            }
            c.Name = car.Name;
            c.Year = car.Year;
            c.BrandId = car.BrandId;
            _dataContext.Update(c);
            _dataContext.SaveChanges();

            return c;
        }

        public Car DeleteCar(int id)
        {
            var car = _dataContext.Cars.Find(id);
            if(car == null)
            {
                throw new Exception("Deu ruim!");
            }
            _dataContext.Cars.Remove(car);
            _dataContext.SaveChanges();

            return car;
        }
    }
}
