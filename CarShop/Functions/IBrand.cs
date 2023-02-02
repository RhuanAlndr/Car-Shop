using CarShop.Migrations;
using CarShop.Models;

namespace CarShop.Functions
{
    public interface IBrand
    {
        Brand AddBrand(Brand brand);
        Brand EditBrand(Brand brand);
        Brand DeleteBrand(int id);
    }
}
