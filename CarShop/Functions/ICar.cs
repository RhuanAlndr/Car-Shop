using CarShop.Models;

namespace CarShop.Functions
{
    public interface ICar
    {
        Car AddCar(Car car);
        Car EditCar(Car car);
        Car DeleteCar(int id);
    }
}
